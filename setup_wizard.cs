using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace MultiWiiWinGUI
{
    public partial class setup_wizard : Form
    {

        private int iActualPage = 0;            //Start from here
        private const int iLastPage = 5;        //Finish Page
        private GUI_settings Settings;
        const string sGuiSettingsFilename = "gui_settings.xml";

        public setup_wizard()
        {
            InitializeComponent();
        }

        private void setup_scan_Ports()
        {
            cb_SerialPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cb_SerialPort.Items.Add(port);
            }
            // select 1st item if any - avoid error when no com ports found
            if (cb_SerialPort.Items.Count > 0)
                cb_SerialPort.SelectedIndex = 0;
        }

        private void setup_wizard_Load(object sender, EventArgs e)
        {
            if (iActualPage == 0) { b_prev.Enabled = false; }
            Settings = new GUI_settings();

            //Set default values and fill out gui controls
            Settings.bEnableLogging = false;
            Settings.iSoftwareVersion = 23;
            Settings.sCaptureFolder = Directory.GetCurrentDirectory() + "\\Captures";
            Settings.sLogFolder = Directory.GetCurrentDirectory() + "\\Logs";
            Settings.sSettingsFolder = Directory.GetCurrentDirectory() + "\\Settings";
            Settings.sPreferedSerialSpeed = "115200";
            Settings.max_wp_number = 100; //until first connect
            Settings.wp_radius = 200; //2 meters (until first connect);
            Settings.speech_enabled = true;

            // scan for serial ports on startup - maybe not needed as better scan on entering page 3
            //setup_scan_Ports();
            // add serial speeds
            string[] sSerialSpeeds = { "115200", "57600", "38400", "19200", "9600" };
            foreach (string speed in sSerialSpeeds)
            {
                cb_SerialSpeed.Items.Add(speed);
            }
            cb_SerialSpeed.SelectedItem = Settings.sPreferedSerialSpeed;

            l_Log_folder.Text = Settings.sLogFolder;
            l_Captures_folder.Text = Settings.sCaptureFolder;
            l_Settings_folder.Text = Settings.sSettingsFolder;
            //Set log enties checkboxes
            cb_Log1.Checked = Settings.logGraw;
            cb_Log2.Checked = Settings.logGatt;
            cb_Log3.Checked = Settings.logGmag;
            cb_Log4.Checked = Settings.logGrcc;
            cb_Log5.Checked = Settings.logGrcx;
            cb_Log6.Checked = Settings.logGmot;
            cb_Log7.Checked = Settings.logGsrv;
            cb_Log8.Checked = Settings.logGnav;
            cb_Log9.Checked = Settings.logGpar;
            cb_Log10.Checked = Settings.logGdbg;

            cbSpeechEnabled.Checked = Settings.speech_enabled;



        }


        private void b_finish_cancel_Click(object sender, EventArgs e)
        {

                //We reached the last page, so all parameters should be valid
                if (panelWizard.SelectedIndex == iLastPage)
                {

                    //Fill out the Settings class with control contents.
                    Settings.sLogFolder = l_Log_folder.Text;
                    Settings.sSettingsFolder = l_Settings_folder.Text;
                    Settings.sCaptureFolder = l_Captures_folder.Text;
                    Settings.sPreferedSerialSpeed = cb_SerialSpeed.SelectedItem.ToString();
                    Settings.sPreferedComPort = cb_SerialPort.Text;
                    Settings.iSoftwareVersion = 23; 
                    Settings.bEnableLogging = cb_LogEnabled.Checked;
                    Settings.logGraw = cb_Log1.Checked;
                    Settings.logGatt = cb_Log2.Checked;
                    Settings.logGmag = cb_Log3.Checked;
                    Settings.logGrcc = cb_Log4.Checked;
                    Settings.logGrcx = cb_Log5.Checked;
                    Settings.logGmot = cb_Log6.Checked;
                    Settings.logGsrv = cb_Log7.Checked;
                    Settings.logGnav = cb_Log8.Checked;
                    Settings.logGpar = cb_Log9.Checked;
                    Settings.logGdbg = cb_Log10.Checked;

                    Settings.speech_enabled = cbSpeechEnabled.Checked;

                    Settings.max_wp_number = 100; //until first connect
                    Settings.wp_radius = 200; //2 meters (until first connect);


                }

                //Write out the Settings struct
                //if not at the Finish page, don't copy control values, so default values will remain valid
                //No check for successfull writing... :) If it's not successfull the gui will exit at the next step anyway
                Settings.save_to_xml(sGuiSettingsFilename);
            
            this.Close();
        }

        private void b_prev_Click(object sender, EventArgs e)
        {
            if (iActualPage > 0)
            {
                iActualPage--;
                panelWizard.SelectedIndex = iActualPage;
                b_next.Enabled = true;
                b_finish_cancel.Text = "Cancel";
                if (iActualPage == 0) { b_prev.Enabled = false; }
            }

        }

        private void b_next_Click(object sender, EventArgs e)
        {
            if (iActualPage < iLastPage)
            {
                iActualPage++;
                if (String.Compare(panelWizard.TabPages[iActualPage].Name,"tabSerial") == 0 )
                {
                    // Rewritten to use tab.name to identify serial port tab
                    // re-scan for serial ports
                    setup_scan_Ports();
                }
                panelWizard.SelectedIndex = iActualPage;
                b_prev.Enabled = true;
                if (iActualPage == iLastPage) { b_next.Enabled = false; b_finish_cancel.Text = "Finish"; }
            }
        }

        private void b_select_settings_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.SelectedPath = l_Settings_folder.Text;
            if (fb.ShowDialog() == DialogResult.OK)
            {
                l_Settings_folder.Text = fb.SelectedPath;
            }
            fb.Dispose();
        }

        private void b_select_log_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.SelectedPath = l_Log_folder.Text;
            if (fb.ShowDialog() == DialogResult.OK)
            {
                l_Log_folder.Text = fb.SelectedPath;
            }
            fb.Dispose();
        }

        private void b_select_captures_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.SelectedPath = l_Captures_folder.Text;
            if (fb.ShowDialog() == DialogResult.OK)
            {
                l_Captures_folder.Text = fb.SelectedPath;
            }
            fb.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        


  

    }
}
