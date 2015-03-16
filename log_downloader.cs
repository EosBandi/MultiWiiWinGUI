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
using System.Text.RegularExpressions;

namespace MultiWiiWinGUI
{
    public partial class log_downloader : Form
    {






        public string sSerialPortName;
        public int iSerialPortBaudrate;
        public string sLogDirectory;


        enum serialstatus {
            Unknown,
            Connecting,
            Connected,
            Erasing,
            GetLogs,
            Downloading,
            Testing,
            Fucking,
            Exiting
        }



        private bool isConnected;

        private serialstatus status = serialstatus.Unknown;
        private string line = "";
        private int cross = 0;
        private int logcount = 0;
        private int receivedbytes = 0;
        private int currentlog;
        private StreamWriter file;
        private string logfilename;

        public log_downloader()
        {
            InitializeComponent();
        }


        private void UpdateDisplay()
        {
            if (status != serialstatus.Downloading)
            {
                textBox1.AppendText(line);
            }
            label1.Text = Convert.ToString(cross);
            if (isConnected) lStatus.Text = status.ToString() + " " + receivedbytes + " " + serialPort1.BytesToRead;
            else lStatus.Text = status.ToString() + " " + receivedbytes + " 0";
            this.Refresh();
        }



        private void DisplayText(object sender, EventArgs e)
        {
            UpdateDisplay();
        }


        private void bConnect_Click(object sender, EventArgs e)
        {


            if (!isConnected)
            {


                if (sSerialPortName == "") { return; }  //if no port selected then do nothin' at connect
                //Assume that the selection in the combobox for port is still valid
                serialPort1.PortName = sSerialPortName;
                serialPort1.BaudRate = iSerialPortBaudrate;

                try
                {
                    serialPort1.Open();
                }
                catch
                {
                    //WRONG, it seems that the combobox selection pointed to a port which is no longer available
                    MessageBoxEx.Show(this, "Please check that your USB cable is still connected.\r\n", "Error opening COM port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Exit without connecting;
                }
                //Set button text and status
                isConnected = true;

                System.Threading.Thread.Sleep(3000);

                status = serialstatus.Connecting;
                serialPort1.Write("+++");               //Try to enter command line mode
                bConnect.Text = "Disconnect";
                UpdateDisplay();
            }
            else
            {

                serialPort1.Write("exit\r");
                bConnect.Text = "Connect";
                //System.Threading.Thread.Sleep(500);
                serialPort1.Close();
                isConnected = false;
                UpdateDisplay();
            }


        }
        
        void genchkcombo(int logcount)
        {
            MethodInvoker m = delegate()
            {
                if (!chkList.Items.Contains(logcount))
                {
                    chkList.Items.Add(logcount);
                }
            };
            try
            {
                BeginInvoke(m);
            }
            catch
            {
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            serialPort1.ReadTimeout = 500;

            while (serialPort1.BytesToRead > 0 && isConnected)
            {
                //updatedisplay
                line = "";
                try
                {
                    line = serialPort1.ReadLine(); //readline(comPort);
                    if (!line.Contains("\n"))
                        line = line + "\n";
                }
                catch
                {
                    line = serialPort1.ReadExisting();
                    //byte[] data = readline(comPort);
                    //line = Encoding.ASCII.GetString(data, 0, data.Length);
                }
                
                receivedbytes += line.Length;

                if (line.Contains(">>>"))
                {
//                    if (status == serialstatus.GetLogs)
//                    {
//                        if (logcount >= 1) genchkcombo(-1);
//                    }

                    status = serialstatus.Connected;
                    
                }

                switch (status)
                {
                    case serialstatus.Connecting:
                        if (line.Contains(">>>"))
                        {
                            status = serialstatus.Connected;
                        }
                        break;
                    case serialstatus.Erasing:
                        cross++;
                        break;
                    case serialstatus.GetLogs:
                        if (line.Contains("start") && line.Contains("end"))
                        {
                            Regex regex2 = new Regex(@"^Log ([0-9]+),", RegexOptions.IgnoreCase);
                            if (regex2.IsMatch(line))
                            {
                                MatchCollection matchs = regex2.Matches(line);
                                logcount = int.Parse(matchs[0].Groups[1].Value);
                                genchkcombo(logcount);
                                //status = serialstatus.Done;
                            }
                        }
                        break;
                    case serialstatus.Downloading:
                        file.Write(line);
                        break;


                }
                this.Invoke(new EventHandler(DisplayText));
            }

        }

        private void bEraseLogs_Click(object sender, EventArgs e)
        {
            if (status == serialstatus.Connected)
            {
                cross = 0;
                serialPort1.Write("erase\r");
                status = serialstatus.Erasing;
            }
        }

        private void bListLogs_Click(object sender, EventArgs e)
        {
            if (status == serialstatus.Connected)
            {
                serialPort1.Write("logs\r");
                status = serialstatus.GetLogs;
            }

        }


        private void downloadsinglethread()
        {
            for (int i = 0; i < chkList.CheckedItems.Count; i++)
            {
                int a = (int)chkList.CheckedItems[i];
                {
                    currentlog = a;
                    //open file
                    logfilename = sLogDirectory + Path.DirectorySeparatorChar + DateTime.Now.ToString("yyyy-MM-dd HH-mm") + " " + currentlog + ".log";
                    file = new StreamWriter(logfilename);
                    System.Threading.Thread.Sleep(500);
                    serialPort1.Write("dump " + a.ToString() + "\r");
                    status = serialstatus.Downloading;
                    System.Threading.Thread.Sleep(100);

                    while (status != serialstatus.Connected)
                    {
                      System.Threading.Thread.Sleep(100);
                    }
                    file.Close();
                    file.Dispose();
                }
            }
        }


        private void bDownload_Click(object sender, EventArgs e)
        {
            if (status == serialstatus.Connected)
            {
                System.Threading.Thread t11 = new System.Threading.Thread(delegate() { downloadsinglethread(); });
                t11.Name = "Log download single thread";
                t11.Start();
            }
        }


        private void processLine(string line)
        {

            line = line.Replace(", ", ",");
            line = line.Replace(": ", ":");

            string[] items = line.Split(',', ':');


            if (items[0].Contains("GPS"))
            {

            }






        }
















    }
}
