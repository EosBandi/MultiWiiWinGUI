using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;
using MultiWiiGUIControls;
using ZedGraph;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
//using GMap.NET.MapProviders;
using System.Globalization;
using System.Reflection;

namespace MultiWiiWinGUI
{

    public partial class mainGUI : Form
    {


        //Do a syncronous msp_query - return false is no answer received within timeout (timeout is in millisec)
        private bool MSPquery_sync(int command, int timeout)
        {

            DateTime startTime = DateTime.Now;
            bool no_answer = false;

            last_response = 0;
            MSPquery(command);

            while (last_response != command && !no_answer)
            {
                if (DateTime.Now.Subtract(startTime).TotalMilliseconds > timeout) { no_answer = true; }
            }

            if (no_answer) return (false);
            return (true);
        }


        private void failed_connect_cleanup(byte reason)
        {
            
            switch(reason) {
                case 1:
                    MessageBoxEx.Show(this, "Please check if you have selected the right com port", "Error device not responding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBoxEx.Show(this, "Flight control sw version missmatch. Expected:"+Convert.ToString(byteVersion)+" Got:"+Convert.ToString(mw_gui.version), "Invalid FC version number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
            b_connect.Text = "Connect";
            b_connect.Image = Properties.Resources.connect;
            isConnected = false;
            timer_realtime.Stop();                       //Stop timer(s), whatever it takes
            bkgWorker.CancelAsync();
            System.Threading.Thread.Sleep(500);         //Wait bkworker to finish
            serialPort.Close();
            if (bLogRunning)
            {
                closeLog();
            }
        }


        private void b_connect_Click(object sender, EventArgs e)
        {

            //Check if we at GUI Settings, go to first screen when connect
            if (tabMain.SelectedIndex == 4) { tabMain.SelectedIndex = 0; }

            if (serialPort.IsOpen)              //Disconnect
            {
                delete_RC_Checkboxes();
                b_connect.Text = "Connect";
                b_connect.Image = Properties.Resources.connect;
                isConnected = false;
                timer_realtime.Stop();                       //Stop timer(s), whatever it takes
                bkgWorker.CancelAsync();
                System.Threading.Thread.Sleep(500);         //Wait bkworker to finish
                serialPort.Close();
                if (bLogRunning)
                {
                    closeLog();
                }

                //Disable buttons that are not working here
                b_reset.Enabled = false;
                b_cal_acc.Enabled = false;
                b_cal_mag.Enabled = false;
                b_read_settings.Enabled = false;
                b_write_settings.Enabled = false;
                b_write_to_file.Enabled = false;
                b_load_from_file.Enabled = false;
                btnDownLoadMission.Enabled = false;
                btnUploadMission.Enabled = false;




            }
            else                               //Connect
            {

                if (cb_serial_port.Text == "") { return; }  //if no port selected then do nothin' at connect
                //Assume that the selection in the combobox for port is still valid
                serialPort.PortName = cb_serial_port.Text;
                serialPort.BaudRate = int.Parse(cb_serial_speed.Text);
                try
                {
                    serialPort.Open();
                }
                catch
                {
                    //WRONG, it seems that the combobox selection pointed to a port which is no longer available
                    MessageBoxEx.Show(this, "Please check that your USB cable is still connected.\r\nAfter you press OK, Serial ports will be re-enumerated", "Error opening COM port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    serial_ports_enumerate();
                    return; //Exit without connecting;
                }
                //Set button text and status
                b_connect.Text = "Disconnect";
                b_connect.Image = Properties.Resources.disconnect;
                isConnected = true;

                //Open Log file if it is enabled
                if (gui_settings.bEnableLogging)
                {
                    openLog();
                }


                //Run BackgroundWorker
                if (!bkgWorker.IsBusy) { bkgWorker.RunWorkerAsync(); }


                serial_packet_rx_count = 0;
                serial_packet_tx_count = 0;
                serial_error_count = 0;

                telemetry_status_received = 0;
                telemetry_status_sent = 0;





                //first send MSP_IDENT messaages and wait at least one successfull packet to arrive
                byte tries = 0;
                while (!MSPquery_sync(MSP.MSP_IDENT, 5000) && tries < 5) { tries++; }
                if (tries == 10) { failed_connect_cleanup(1); return; }

                tries = 0;
                while (!MSPquery_sync(MSP.MSP_PID, 200) && tries < 10) { tries++; }
                if (tries == 10) { failed_connect_cleanup(1); return; }

                tries = 0;
                while (!MSPquery_sync(MSP.MSP_RC_TUNING, 200) && tries < 10) { tries++; }
                if (tries == 10) { failed_connect_cleanup(1); return; }

                tries = 0;
                while (!MSPquery_sync(MSP.MSP_BOX, 200) && tries < 10) { tries++; }
                if (tries == 10) { failed_connect_cleanup(1); return; }

                tries = 0;
                while (!MSPquery_sync(MSP.MSP_BOXNAMES, 200) && tries < 10) { tries++; }
                if (tries == 10) { failed_connect_cleanup(1); return; }

                tries = 0;
                while (!MSPquery_sync(MSP.MSP_MISC, 200) && tries < 10) { tries++; }
                if (tries == 10) { failed_connect_cleanup(1); return; }

                tries = 0;
                while (!MSPquery_sync(MSP.MSP_SERVO_CONF, 200) && tries < 10) { tries++; }
                if (tries == 10) { failed_connect_cleanup(1); return; }

                if (check_capability(CAP.NAV_CAPABLE) )
                {
                    tries = 0;
                    while (!MSPquery_sync(MSP.MSP_NAV_CONFIG, 200) && tries < 10) { tries++; }
                    if (tries == 10) { failed_connect_cleanup(1); return; }
                }
                
                serial_packet_rx_count = 0;
                serial_packet_tx_count = 0;

                if (mw_gui.version != byteVersion)
                {
                    failed_connect_cleanup(2);
                    return;
                }

                //All set we are ready to go.
                if (check_capability(CAP.NAV_CAPABLE))
                {
                    if (get_navi_version() != iNaviVersion)
                    {
                        MessageBoxEx.Show(this, "Navigation code version missmatch!\r\nGUI version: v" + Convert.ToString(iNaviVersion) +
                                          " Controller version: v" + Convert.ToString(get_navi_version()) + "\r\n Navigation functions disabled!", "Code version missmatch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        naviGroup.Enabled = false;
                    }
                    else
                    {
                        btnDownLoadMission.Enabled = true;
                        btnUploadMission.Enabled = true;
                        naviGroup.Enabled = true;
                    }

                }
                else
                {
                    naviGroup.Enabled = false;
                }

                //Enable buttons that are not working here
                b_reset.Enabled = true;
                b_cal_acc.Enabled = true;
                b_cal_mag.Enabled = true;
                b_read_settings.Enabled = true;
                b_write_settings.Enabled = true;
                b_write_to_file.Enabled = true;
                b_load_from_file.Enabled = true;

                timer_realtime.Start();
                bOptions_needs_refresh = true;
                create_RC_Checkboxes(mw_gui.sBoxNames);
                update_gui();
            }
        }

        private void MSPquery(int command)
        {
            byte c = 0;
            byte[] o;
            o = new byte[10];
            // with checksum 
            o[0] = (byte)'$';
            o[1] = (byte)'M';
            o[2] = (byte)'<';
            o[3] = (byte)0; c ^= o[3];       //no payload 
            o[4] = (byte)command; c ^= o[4];
            o[5] = (byte)c;
            serialPort.Write(o, 0, 6);

            if (telemetry_started==1) serial_packet_tx_count++;
        }

        private void MSPqueryWP(int wp)
        {
            byte c = 0;
            byte[] o;
            o = new byte[10];
            // with checksum 
            o[0] = (byte)'$';
            o[1] = (byte)'M';
            o[2] = (byte)'<';
            o[3] = (byte)1; c ^= o[3];       //one byte payload
            o[4] = (byte)MSP.MSP_WP; c ^= o[4];
            o[5] = (byte)wp; c ^= o[5];
            o[6] = (byte)c;
            serialPort.Write(o, 0, 7) ;
            if (telemetry_started == 1)serial_packet_tx_count++;
        }

        private void write_parameters()
        {
            byte[] buffer = new byte[250];          //this must be long enough
            int bptr = 0;                           //buffer pointer
            byte[] bInt16 = new byte[2];            //two byte buffer for converting int to two separated bytes
            byte checksum = 0;

            //Stop all timers
            timer_realtime.Stop();

            update_params();                            //update parameters object from GUI controls.
            mw_params.write_settings(serialPort,iCheckBoxItems, check_capability(CAP.EXTENDED_AUX));


            //TODO: rewrite to msp_query_sync if it is neccessary.... 
            response_counter = 0;

            MSPquery_sync(MSP.MSP_PID,200);
            MSPquery_sync(MSP.MSP_RC_TUNING,200);
            MSPquery_sync(MSP.MSP_IDENT,200);
            MSPquery_sync(MSP.MSP_BOX,200);
            MSPquery_sync(MSP.MSP_MISC,200);
            MSPquery_sync(MSP.MSP_SERVO_CONF,200);

            if (naviGroup.Enabled)
            {
                MSPquery_sync(MSP.MSP_NAV_CONFIG,200);
            }
            DateTime startTime = DateTime.Now;
            bool missing_packets = false;
            //Wait for all the responses from the setting reload. Add 2sec timeout for remote situtations
            while (response_counter < 6)
            {
                if (DateTime.Now.Subtract(startTime).TotalMilliseconds > 2000) { response_counter = 8; missing_packets = true; }

            }

            if (missing_packets) MessageBoxEx.Show("Not all response packets were arrived,\rplease reread parameters and check that save really happened.","Response Packets Lost",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            bOptions_needs_refresh = true;
            update_gui();
            timer_realtime.Start();


        }


    }


}

