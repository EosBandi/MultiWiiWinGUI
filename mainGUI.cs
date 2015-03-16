/*
 * MultiWii Windows GUI by Andras Schaffer (EOSBandi)
 * February  2014     V2.3 Beta

 * 
 * LogBrowser is based on ArduPlanner Mega code written by Michael Oborne http://www.diydrones.com 
 * Instrument controls are based on AvionicsInstrument Controls written by Guillaume CHOUTEAU http://www.codeproject.com/Articles/27411/C-Avionic-Instrument-Controls
 * Video capture code is using Aforge.Net Framework http://www.aforgenet.com
 * Graph parts are using ZedGraph control http://sourceforge.net/projects/zedgraph/
 * 
*/

using System;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;
using MultiWiiGUIControls;
using ZedGraph;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Globalization;
using System.Reflection;
using System.Media;
using System.Speech;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace MultiWiiWinGUI
{

    public partial class mainGUI : Form
    {

        #region Common variables (properties)

        const string sVersion = "2.4";
        byte byteVersion = 230;
        uint iNaviVersion = 7;                //Navigation code version
        const string sVersionUrl = "http://mw-wingui.googlecode.com/svn/trunk/WinGui2/version.xml";
        private string sVersionFromSVN;
        private XDocument doc;

        static string sOptionsConfigFilename = "optionsconfig";
        const string sGuiSettingsFilename = "gui_settings.xml";
        enum CopterType { Tri = 1, QuadP, QuadX, BI, Gimbal, Y6, Hex6, FlyWing, Y4,
            Hex6X, OctoX8, OctoFlatX, OctoFlatP, Airplane, Heli_120_CCPM, Heli_90_DEG, Vtail4, 
            Hex6H, PPM_to_Servo, DualCopter, Singlecopter };
        

        string[] sGpsMode = { "None", "PosHold", "RTH", "Mission" };
        string[] sNavState = { "None", "RTH Start", "RTH Enroute", "PosHold infinit", "PosHold timed", "WP Enroute", "Process next","Jump","Start Land","Land in Progress","Landed","Settling before land","Start descent" };

        string[] sNavError = { "Navigation system is working.",
                               "Next waypoint distance is more than the safety limit, aborting mission",
                               "GPS reception is compromised - pausing mission, COPTER IS ADRIFT!",
                               "Error while reading next waypoint from memory, aborting mission.",
                               "Mission Finished." ,
                               "Waiting for timed position hold.",
                               "Invalid Jump target detected, aborting mission.",
                               "Invalid Mission Step Action code detected, aborting mission.",
                               "Waiting to reach return to home altitude.",
                               "GPS fix lost, mission aborted - COPTER IS ADRIFT!",
                               "Copter is disarmed, navigation engine disabled.",
                               "Landing is in progress, check attitude if possible."};

        string[] sSerialSpeeds = { "115200", "57600", "38400", "19200", "9600" };
        string[] sRefreshSpeeds = { "10 Hz", "5 Hz", "2 Hz", "1 Hz" };
        int[] iRefreshIntervals = { 10, 20, 50, 100 };
        const int rcLow = 1300;
        const int rcMid = 1700;

        const int rcLevel1 = 1230;
        const int rcLevel2 = 1360;
        const int rcLevel3 = 1490;
        const int rcLevel4 = 1620;
        const int rcLevel5 = 1749;

        const string sRelName = "2.4";

        Boolean isCLI = false;
        string inCLIBuffer;

        //PID values
        static PID[] Pid;


        static SerialPort serialPort;
        static bool isConnected = false;                        //is port connected or not ?
        static bool bSerialError = false;
        static bool isPaused = false;

        static double xTimeStamp = 0;
        static byte[] bSerialBuffer;

        static int iCheckBoxItems = 0;                          //number of checkboxItems (readed from optionsconfig.xml
        static int iPidItems = 0;                               //number if Pid items (const definition)
        static mw_data_gui mw_gui;                              //Data structures in that contains the data in the gui
        static mw_settings mw_params;
        static GUI_settings gui_settings;
        static bool bOptions_needs_refresh = true;
        static bool bRestartNeeded = false;                     //FC software version changed, must restart

        static string[] option_names;
        static string[] option_indicators;
        static string[] option_desc;

        static LineItem curve_acc_roll, curve_acc_pitch, curve_acc_z;
        static LineItem curve_gyro_roll, curve_gyro_pitch, curve_gyro_yaw;
        static LineItem curve_mag_roll, curve_mag_pitch, curve_mag_yaw;
        static LineItem curve_alt, curve_head;
        static LineItem curve_dbg1, curve_dbg2, curve_dbg3, curve_dbg4;


        static RollingPointPairList list_acc_roll, list_acc_pitch, list_acc_z;
        static RollingPointPairList list_gyro_roll, list_gyro_pitch, list_gyro_yaw;
        static RollingPointPairList list_mag_roll, list_mag_pitch, list_mag_yaw;
        static RollingPointPairList list_alt, list_head;
        static RollingPointPairList list_dbg1, list_dbg2, list_dbg3, list_dbg4;

        static Scale xScale;

        CheckBoxEx[, ,] aux;
        indicator_lamp[] indicators;
        indicator_lamp[] indicators_mission;

        System.Windows.Forms.Label[] cb_labels;
        System.Windows.Forms.Label[] aux_labels;
        System.Windows.Forms.Label[,] lmh_labels;

        CultureInfo culture = new CultureInfo("en-US");


        XmlTextReader reader;
        int z;

        //For video capture 
        static bool bVideoRecording = false;
        static bool bVideoConnected = false;
        static VideoFileWriter vfwWriter;
        static FilterInfoCollection videoDevices;
        static VideoCaptureDevice videoSource;
        static TimeSpan tsFrameTimeStamp;
        static TimeSpan tsFrameRate;


        static Pen drawPen;
        static System.Drawing.SolidBrush drawBrush;
        static System.Drawing.Font drawFont;

        //For logging
        StreamWriter wLogStream;
        StreamWriter wKMLLogStream;
        static bool bLogRunning = false;
        static bool bKMLLogRunning = false;
        static UInt32 last_mode_flags;          //Contains the mode flags from the pervious log write tick

        static int GPS_lat_old, GPS_lon_old;

        //Routes on Map
        static GMapRoute GMRouteFlightPath;
        static GMapRoute GMRouteMission;

        //Map Overlays
        static GMapOverlay GMOverlayFlightPath;// static so can update from gcs
        static GMapOverlay GMOverlayWaypoints;
        static GMapOverlay GMOverlayMission;
        static GMapOverlay GMOverlayLiveData;
        static GMapOverlay GMOverlayPOI;

        static GMapProvider[] mapProviders;
        static PointLatLng copterPos = new PointLatLng(47.402489, 19.071558);       //Just the corrds of my flying place

        static bool isMouseDown = false;
        static bool isMouseDraging = false;

        static bool bPosholdRecorded = false;
        static bool bHomeRecorded = false;

        // markers
        GMarkerGoogle currentMarker;
        GMapMarkerRect CurentRectMarker = null;
        GMapMarker center; 
        GMapMarker markerGoToClick = new GMarkerGoogle(new PointLatLng(0.0, 0.0),GMarkerGoogleType.lightblue);

        List<PointLatLng> points = new List<PointLatLng>();

        PointLatLng GPS_pos;
        PointLatLng end;
        PointLatLng start;

        DebugWindow frmDebug;
        string strDebug = "";

        //Navigaton constants

        static mission_step_structure mission_step;

        const int MISSION_FLAG_END = 0xA5;		    //Flags that this is the last step

        const byte IDLE = 0;
        const byte HEADER_START = 1;
        const byte HEADER_M = 2;
        const byte HEADER_ARROW = 3;
        const byte HEADER_SIZE = 4;
        const byte HEADER_CMD = 5;
        const byte HEADER_ERR = 6;

        static byte[] inBuf;

        static int AUX_CHANNELS = 4;

        static byte c_state = IDLE;
        static Boolean err_rcvd = false;
        static byte offset = 0;
        static byte dataSize = 0;
        static byte checksum = 0;
        static byte cmd;
        static int serial_error_count = 0;
        static int serial_packet_rx_count = 0;
        static int serial_packet_tx_count = 0;
        static int telemetry_link_quality = 0;
        static int telemetry_started = 0;


        static int telemetry_status_sent = 0;
        static int telemetry_status_received = 0;
        static byte previous_nav_error;

        static int selectedrow;
        static bool bGoToClikEnabled = false;
        static int iDefAlt = 25;        //Default altitude 25meters
        static int iGTCAlt = 25;


        //Servo settings
        System.Windows.Forms.Label[] servo_text;
        CheckBoxEx[] servo_reverse;
        System.Windows.Forms.NumericUpDown[] servo_rate;
        System.Windows.Forms.NumericUpDown[] servo_min;
        System.Windows.Forms.NumericUpDown[] servo_mid;
        System.Windows.Forms.NumericUpDown[] servo_max;

        static int response_counter = 0;
        static byte last_response = 0;
        static byte update_cycle_count = 0;             //Counts the update cycles (10 cycles all)


        static bool bShowGauges = false;
        static int prev_wp = 0;
        static int prev_state = 0;
        SpeechSynthesizer speech;


        #endregion

        public mainGUI()
        {
            InitializeComponent();
            #region map_setup
            // config map             
            MainMap.MinZoom = 1;
            MainMap.MaxZoom = 20;
            MainMap.CacheLocation = Path.GetDirectoryName(Application.ExecutablePath) + "/mapcache/";

            mapProviders = new GMapProvider[7];
            mapProviders[0] = GMapProviders.BingHybridMap;
            mapProviders[1] = GMapProviders.BingSatelliteMap;
            mapProviders[2] = GMapProviders.GoogleSatelliteMap;
            mapProviders[3] = GMapProviders.GoogleHybridMap;
            mapProviders[4] = GMapProviders.OviSatelliteMap;
            mapProviders[5] = GMapProviders.OviHybridMap;

            for (int i = 0; i < 6; i++)
            {
                cbMapProviders.Items.Add(mapProviders[i]);
            }

            // map events

            MainMap.OnPositionChanged += new PositionChanged(MainMap_OnCurrentPositionChanged);
            //MainMap.OnMarkerClick += new MarkerClick(MainMap_OnMarkerClick);
            MainMap.OnMapZoomChanged += new MapZoomChanged(MainMap_OnMapZoomChanged);
            MainMap.MouseMove += new MouseEventHandler(MainMap_MouseMove);
            MainMap.MouseDown += new MouseEventHandler(MainMap_MouseDown);
            MainMap.MouseUp += new MouseEventHandler(MainMap_MouseUp);
            MainMap.OnMarkerEnter += new MarkerEnter(MainMap_OnMarkerEnter);
            MainMap.OnMarkerLeave += new MarkerLeave(MainMap_OnMarkerLeave);

            currentMarker = new GMarkerGoogle(MainMap.Position,GMarkerGoogleType.red);
            //MainMap.MapScaleInfoEnabled = true;

            MainMap.ForceDoubleBuffer = true;
            MainMap.Manager.Mode = AccessMode.ServerAndCache;

            MainMap.Position = copterPos;

            Pen penRoute = new Pen(Color.Yellow, 3);
            Pen penScale = new Pen(Color.Blue, 3);

            MainMap.ScalePen = penScale;

            GMOverlayFlightPath = new GMapOverlay("flightpath");
            MainMap.Overlays.Add(GMOverlayFlightPath);

            GMOverlayMission = new GMapOverlay("missionroute");
            MainMap.Overlays.Add(GMOverlayMission);

            GMOverlayWaypoints = new GMapOverlay("waypoints");
            MainMap.Overlays.Add(GMOverlayWaypoints);


            GMOverlayLiveData = new GMapOverlay("livedata");
            MainMap.Overlays.Add(GMOverlayLiveData);


            GMOverlayPOI = new GMapOverlay("poi");
            MainMap.Overlays.Add(GMOverlayPOI);


            GMOverlayLiveData.Markers.Clear();
            GMOverlayLiveData.Markers.Add(new GMapMarkerCopter(copterPos, 0, 0, 0, 3));

            GMRouteFlightPath = new GMapRoute(points, "flightpath");
            GMRouteFlightPath.Stroke = penRoute;
            GMOverlayFlightPath.Routes.Add(GMRouteFlightPath);

            center = new GMarkerGoogle(MainMap.Position,GMarkerGoogleType.blue_dot);
            //center = new GMapMarkerCross(MainMap.Position);

            MainMap.Invalidate(false);
            //MainMap.Refresh();
            #endregion

        }

        
        private void mainGUI_Load(object sender, EventArgs e)
        {

      
            //First step, check it gui_settings file is exists or not, if not then start settings wizard
            if (!File.Exists(sGuiSettingsFilename))
            {
                setup_wizard panelSetupWizard = new setup_wizard();
                panelSetupWizard.ShowDialog();

            }

            //Now there must be a valid settings file, so we can continue with normal execution

            splash_screen splash = new splash_screen();
            splash.sVersionLabel = sVersion;
            splash.Show();
            splash.Refresh();
            //Start with Settings file read, and parse exit if unsuccessfull
            gui_settings = new GUI_settings();
            if (!gui_settings.read_from_xml(sGuiSettingsFilename))
            {
                Environment.Exit(-1);
            }

            //fill out relevant variables
            cbGUISpeechEnabled.Checked = gui_settings.speech_enabled;
            sOptionsConfigFilename = sOptionsConfigFilename + ".xml";
            read_options_config();                  //read and parse optionsconfig.xml file. sets iCheckBoxItems
            iCheckBoxItems = 24;                    //Theoretical maximum

            splash.sStatus = "Building internal data structures...";
            splash.Refresh();

            mw_gui = new mw_data_gui(iPidItems, iCheckBoxItems, gui_settings.iSoftwareVersion);
            mw_params = new mw_settings(iPidItems, iCheckBoxItems, gui_settings.iSoftwareVersion);
            mission_step = new mission_step_structure();

            //Quick hack to get pid names to mw_params untill redo the structures
            for (int i = 0; i < iPidItems; i++)
            {
                mw_params.pidnames[i] = Pid[i].name;
            }

            splash.sFcVersionLabel = "MultiWii version " + sRelName;
            splash.sStatus = "Connecting to MAP server...";
            splash.Refresh();

            MainMap.Manager.Mode = AccessMode.ServerAndCache;
            if (!Stuff.PingNetwork("pingtest.com"))
            {
                MainMap.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No internet connection available, going to CacheOnly mode.", "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            cbMapProviders.SelectedIndex = gui_settings.iMapProviderSelectedIndex;
            MainMap.MapProvider = mapProviders[gui_settings.iMapProviderSelectedIndex];
            MainMap.Zoom = 18;

            splash.sStatus = "Building up GUI elements...";
            splash.Refresh();

            bSerialBuffer = new byte[65];
            inBuf = new byte[300];   //init input buffer

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            //rcOptions1 = new byte[iCheckBoxItems];
            //rcOptions2 = new byte[iCheckBoxItems];

            //Fill out settings tab
            l_Capture_folder.Text = gui_settings.sCaptureFolder;
            l_LogFolder.Text = gui_settings.sLogFolder;
            l_Settings_folder.Text = gui_settings.sSettingsFolder;

            cb_Logging_enabled.Checked = gui_settings.bEnableLogging;

            //Set log enties checkboxes
            cb_Log1.Checked = gui_settings.logGraw;
            cb_Log2.Checked = gui_settings.logGatt;
            cb_Log3.Checked = gui_settings.logGmag;
            cb_Log4.Checked = gui_settings.logGrcc;
            cb_Log5.Checked = gui_settings.logGrcx;
            cb_Log6.Checked = gui_settings.logGmot;
            cb_Log7.Checked = gui_settings.logGsrv;
            cb_Log8.Checked = gui_settings.logGnav;
            cb_Log9.Checked = gui_settings.logGpar;
            cb_Log10.Checked = gui_settings.logGdbg;

            cbCellcount.SelectedIndex = gui_settings.cellcount - 1;
            cbGUISpeechEnabled.Checked = gui_settings.speech_enabled;
            cbSpeakAlt.Checked = gui_settings.announce_alt_enabled;
            cbSpeakBattery.Checked = gui_settings.announce_vbat_enabled;
            cbSpeakDist.Checked = gui_settings.announce_dist_enabled;
            comboSpeakInterval.SelectedIndex = gui_settings.announce_interval;

            b_save_gui_settings.BackColor = Color.Transparent;

            splash.sStatus = "Build PID structures...";
            splash.Refresh();


            //Build servo control arrays
            // It is a mess and not an elegant solution BUT WORKS
            servo_text = new System.Windows.Forms.Label[8];
            servo_text[0] = lSrvName1;
            servo_text[1] = lSrvName2;
            servo_text[2] = lSrvName3;
            servo_text[3] = lSrvName4;
            servo_text[4] = lSrvName5;
            servo_text[5] = lSrvName6;
            servo_text[6] = lSrvName7;
            servo_text[7] = lSrvName8;

            servo_reverse = new CheckBoxEx[8];
            servo_reverse[0] = cbSrvRev1;
            servo_reverse[1] = cbSrvRev2;
            servo_reverse[2] = cbSrvRev3;
            servo_reverse[3] = cbSrvRev4;
            servo_reverse[4] = cbSrvRev5;
            servo_reverse[5] = cbSrvRev6;
            servo_reverse[6] = cbSrvRev7;
            servo_reverse[7] = cbSrvRev8;

            servo_rate = new System.Windows.Forms.NumericUpDown[8];
            servo_rate[0] = nSrvRate1;
            servo_rate[1] = nSrvRate2;
            servo_rate[2] = nSrvRate3;
            servo_rate[3] = nSrvRate4;
            servo_rate[4] = nSrvRate5;
            servo_rate[5] = nSrvRate6;
            servo_rate[6] = nSrvRate7;
            servo_rate[7] = nSrvRate8;

            servo_min = new System.Windows.Forms.NumericUpDown[8];
            servo_min[0] = nSrvMin1;
            servo_min[1] = nSrvMin2;
            servo_min[2] = nSrvMin3;
            servo_min[3] = nSrvMin4;
            servo_min[4] = nSrvMin5;
            servo_min[5] = nSrvMin6;
            servo_min[6] = nSrvMin7;
            servo_min[7] = nSrvMin8;

            servo_mid = new System.Windows.Forms.NumericUpDown[8];
            servo_mid[0] = nSrvMid1;
            servo_mid[1] = nSrvMid2;
            servo_mid[2] = nSrvMid3;
            servo_mid[3] = nSrvMid4;
            servo_mid[4] = nSrvMid5;
            servo_mid[5] = nSrvMid6;
            servo_mid[6] = nSrvMid7;
            servo_mid[7] = nSrvMid8;

            servo_max = new System.Windows.Forms.NumericUpDown[8];
            servo_max[0] = nSrvMax1;
            servo_max[1] = nSrvMax2;
            servo_max[2] = nSrvMax3;
            servo_max[3] = nSrvMax4;
            servo_max[4] = nSrvMax5;
            servo_max[5] = nSrvMax6;
            servo_max[6] = nSrvMax7;
            servo_max[7] = nSrvMax8;


            //Build PID control structure based on the Pid structure.

            const int iLineSpace = 36;
            const int iRow1 = 30;
            const int iRow2 = 130;
            const int iRow3 = 230;
            const int iTopY = 25;
            Font fontField = new Font("Tahoma", 9, FontStyle.Bold);
            Size fieldSize = new Size(70, 25);

            for (int i = 0; i < iPidItems; i++)
            {
                Pid[i].pidLabel = new System.Windows.Forms.Label();
                Pid[i].pidLabel.Text = Pid[i].name;
                Pid[i].pidLabel.Location = new Point(iRow1, 10 + i * iLineSpace);
                Pid[i].pidLabel.Visible = true;
                Pid[i].pidLabel.AutoSize = true;
                Pid[i].pidLabel.ForeColor = Color.White;
                Pid[i].pidLabel.TextAlign = ContentAlignment.MiddleRight;
                toolTip1.SetToolTip(Pid[i].pidLabel, Pid[i].description);
                this.tabPagePID.Controls.Add(Pid[i].pidLabel);

                if (Pid[i].Pshown)
                {
                    Pid[i].Pfield = new System.Windows.Forms.NumericUpDown();
                    Pid[i].Pfield.ValueChanged += new EventHandler(pfield_valuechange);
                    Pid[i].Pfield.Location = new Point(iRow1, iTopY + i * iLineSpace);
                    Pid[i].Pfield.Size = fieldSize;
                    Pid[i].Pfield.Font = fontField;
                    Pid[i].Pfield.BorderStyle = BorderStyle.None;
                    Pid[i].Pfield.Maximum = Pid[i].Pmax;
                    Pid[i].Pfield.Minimum = Pid[i].Pmin;
                    Pid[i].Pfield.DecimalPlaces = decimals(Pid[i].Pprec);
                    Pid[i].Pfield.Increment = 1 / (decimal)Pid[i].Pprec;
                    this.tabPagePID.Controls.Add(Pid[i].Pfield);

                    Pid[i].Plabel = new System.Windows.Forms.Label();
                    Pid[i].Plabel.Text = "P";
                    Pid[i].Plabel.Font = fontField;
                    Pid[i].Plabel.ForeColor = Color.White;
                    Pid[i].Plabel.Location = new Point(iRow1 - 20, iTopY + i * iLineSpace);
                    this.tabPagePID.Controls.Add(Pid[i].Plabel);

                }
                if (Pid[i].Ishown)
                {
                    Pid[i].Ifield = new System.Windows.Forms.NumericUpDown();
                    Pid[i].Ifield.ValueChanged += new EventHandler(ifield_valuechange);
                    Pid[i].Ifield.Location = new Point(iRow2, iTopY + i * iLineSpace);
                    Pid[i].Ifield.Size = fieldSize;
                    Pid[i].Ifield.Font = fontField;
                    Pid[i].Ifield.BorderStyle = BorderStyle.None;
                    Pid[i].Ifield.Maximum = Pid[i].Imax;
                    Pid[i].Ifield.Minimum = Pid[i].Imin;
                    Pid[i].Ifield.DecimalPlaces = decimals(Pid[i].Iprec);
                    Pid[i].Ifield.Increment = 1 / (decimal)Pid[i].Iprec;
                    this.tabPagePID.Controls.Add(Pid[i].Ifield);

                    Pid[i].Ilabel = new System.Windows.Forms.Label();
                    Pid[i].Ilabel.Text = "I";
                    Pid[i].Ilabel.Font = fontField;
                    Pid[i].Ilabel.ForeColor = Color.White;
                    Pid[i].Ilabel.Location = new Point(iRow2 - 20, iTopY + i * iLineSpace);
                    this.tabPagePID.Controls.Add(Pid[i].Ilabel);



                }
                if (Pid[i].Dshown)
                {
                    Pid[i].Dfield = new System.Windows.Forms.NumericUpDown();
                    Pid[i].Dfield.ValueChanged += new EventHandler(dfield_valuechange);
                    Pid[i].Dfield.Location = new Point(iRow3, iTopY + i * iLineSpace);
                    Pid[i].Dfield.Size = fieldSize;
                    Pid[i].Dfield.Font = fontField;
                    Pid[i].Dfield.BorderStyle = BorderStyle.None;
                    Pid[i].Dfield.Maximum = Pid[i].Dmax;
                    Pid[i].Dfield.Minimum = Pid[i].Dmin;
                    Pid[i].Dfield.DecimalPlaces = decimals(Pid[i].Dprec);
                    Pid[i].Dfield.Increment = 1 / (decimal)Pid[i].Dprec;
                    this.tabPagePID.Controls.Add(Pid[i].Dfield);

                    Pid[i].Dlabel = new System.Windows.Forms.Label();
                    Pid[i].Dlabel.Text = "D";
                    Pid[i].Dlabel.Font = fontField;
                    Pid[i].Dlabel.ForeColor = Color.White;
                    Pid[i].Dlabel.Location = new Point(iRow3 - 20, iTopY + i * iLineSpace);
                    this.tabPagePID.Controls.Add(Pid[i].Dlabel);

                }


                //Set up stuff at the mission palane
                txtDefAlt.Text = iDefAlt.ToString();        //Set up default altitude
                txtGTCAlt.Text = iGTCAlt.ToString();        //Set up default Go to Click altitude


            }


            //Tooltips (needs improvement)

            toolTip1.SetToolTip(b_check_all_ACC, "Select all ACC values");
            toolTip1.SetToolTip(b_uncheck_all_ACC, "Deselect all ACC values");
            toolTip1.SetToolTip(lDefAlt, "Default waypoint altitude (in Above Ground Level where Home position Ground level is zero)");
            toolTip1.SetToolTip(txtDefAlt, "Default waypoint altitude (in Above Ground Level where Home position Ground level is zero)");






            this.Refresh();

            splash.sStatus = "Check serial ports...";
            splash.Refresh();



            serial_ports_enumerate();
            foreach (string speed in sSerialSpeeds)
            {
                cb_serial_speed.Items.Add(speed);
            }
            cb_serial_speed.SelectedItem = gui_settings.sPreferedSerialSpeed;

            if (cb_serial_port.Items.Count == 0)
            {
                b_connect.Enabled = false;          //Nos serial port, disable connect
            }

            //Init serial port object
            serialPort = new SerialPort();
            //Set up serial port parameters (at least the ones what we know upfront
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Handshake = Handshake.None;
            serialPort.DtrEnable = false;               //??

            serialPort.ReadBufferSize = 4096;            //4K byte of read buffer
            serialPort.ReadTimeout = 500;               // 500msec timeout;




            //Init Realtime Monitor panel controls
            foreach (string rate in sRefreshSpeeds)
            {
                cb_monitor_rate.Items.Add(rate);
            }
            cb_monitor_rate.SelectedIndex = 1;              //10Hz is the default

            splash.sStatus = "Setup Timers...";
            splash.Refresh();



            //Setup timers
            timer_realtime.Tick += new EventHandler(timer_realtime_Tick);
            timer_realtime.Interval = iRefreshIntervals[cb_monitor_rate.SelectedIndex];
            timer_realtime.Enabled = true;
            timer_realtime.Stop();


            splash.sStatus = "Setup zgMonitor control...";
            splash.Refresh();


            //Set up zgMonitor control for real time monitoring
            GraphPane myPane = zgMonitor.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = "";
            myPane.XAxis.Title.Text = "";
            myPane.YAxis.Title.Text = "";

            //Set up pointlists and curves
            list_acc_roll = new RollingPointPairList(300);
            curve_acc_roll = myPane.AddCurve("acc_roll", list_acc_roll, Color.Red, SymbolType.None);

            list_acc_pitch = new RollingPointPairList(300);
            curve_acc_pitch = myPane.AddCurve("acc_pitch", list_acc_pitch, Color.Green, SymbolType.None);

            list_acc_z = new RollingPointPairList(300);
            curve_acc_z = myPane.AddCurve("acc_z", list_acc_z, Color.Blue, SymbolType.None);

            list_gyro_roll = new RollingPointPairList(300);
            curve_gyro_roll = myPane.AddCurve("gyro_roll", list_gyro_roll, Color.Khaki, SymbolType.None);

            list_gyro_pitch = new RollingPointPairList(300);
            curve_gyro_pitch = myPane.AddCurve("gyro_pitch", list_gyro_pitch, Color.Cyan, SymbolType.None);

            list_gyro_yaw = new RollingPointPairList(300);
            curve_gyro_yaw = myPane.AddCurve("gyro_yaw", list_gyro_yaw, Color.Magenta, SymbolType.None);

            list_mag_roll = new RollingPointPairList(300);
            curve_mag_roll = myPane.AddCurve("mag_roll", list_mag_roll, Color.CadetBlue, SymbolType.None);

            list_mag_pitch = new RollingPointPairList(300);
            curve_mag_pitch = myPane.AddCurve("mag_pitch", list_mag_pitch, Color.MediumPurple, SymbolType.None);

            list_mag_yaw = new RollingPointPairList(300);
            curve_mag_yaw = myPane.AddCurve("mag_yaw", list_mag_yaw, Color.DarkGoldenrod, SymbolType.None);

            list_alt = new RollingPointPairList(300);
            curve_alt = myPane.AddCurve("alt", list_alt, Color.White, SymbolType.None);

            list_head = new RollingPointPairList(300);
            curve_head = myPane.AddCurve("head", list_head, Color.Orange, SymbolType.None);

            list_dbg1 = new RollingPointPairList(300);
            curve_dbg1 = myPane.AddCurve("dbg1", list_dbg1, Color.PaleTurquoise, SymbolType.None);

            list_dbg2 = new RollingPointPairList(300);
            curve_dbg2 = myPane.AddCurve("dbg2", list_dbg2, Color.PaleTurquoise, SymbolType.None);

            list_dbg3 = new RollingPointPairList(300);
            curve_dbg3 = myPane.AddCurve("dbg3", list_dbg3, Color.PaleTurquoise, SymbolType.None);

            list_dbg4 = new RollingPointPairList(300);
            curve_dbg4 = myPane.AddCurve("dbg4", list_dbg4, Color.PaleTurquoise, SymbolType.None);

            // Show the x axis grid
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.Color = Color.DarkGray;
            myPane.YAxis.MajorGrid.Color = Color.DarkGray;


            myPane.XAxis.Scale.IsVisible = false;

            // Make the Y axis scale red
            myPane.YAxis.Scale.FontSpec.FontColor = Color.DarkGray;
            myPane.YAxis.Title.FontSpec.FontColor = Color.DarkGray;
            // turn off the opposite tics so the Y tics don't show up on the Y2 axis
            myPane.YAxis.MajorTic.IsOpposite = false;
            myPane.YAxis.MinorTic.IsOpposite = false;
            // Don't display the Y zero line
            myPane.YAxis.MajorGrid.IsZeroLine = true;
            // Align the Y axis labels so they are flush to the axis
            myPane.YAxis.Scale.Align = AlignP.Inside;
            myPane.YAxis.Color = Color.DarkGray;
            myPane.YAxis.Scale.IsVisible = false;
            // Manually set the axis range
            myPane.YAxis.Scale.Min = -300;
            myPane.YAxis.Scale.Max = 300;
            myPane.XAxis.Color = Color.DarkGray;

            myPane.Border.Color = Color.FromArgb(64, 64, 64);

            myPane.Chart.Fill = new Fill(Color.Black, Color.Black, 45.0f);
            myPane.Fill = new Fill(Color.FromArgb(64, 64, 64), Color.FromArgb(64, 64, 64), 45.0f);
            myPane.Legend.IsVisible = false;
            myPane.XAxis.Scale.IsVisible = false;
            myPane.YAxis.Scale.IsVisible = true;

            myPane.XAxis.Scale.MagAuto = true;
            myPane.YAxis.Scale.MagAuto = false;

            zgMonitor.IsEnableHPan = true;
            zgMonitor.IsEnableHZoom = true;

            foreach (ZedGraph.LineItem li in myPane.CurveList)
            {
                li.Line.Width = 1;
            }


            myPane.YAxis.Title.FontSpec.FontColor = Color.DarkGray;
            myPane.XAxis.Title.FontSpec.FontColor = Color.DarkGray;

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 300;
            myPane.XAxis.Type = AxisType.Linear;



            zgMonitor.ScrollGrace = 0;
            xScale = zgMonitor.GraphPane.XAxis.Scale;
            zgMonitor.AxisChange();


            splash.sStatus = "Init video capture structures...";
            splash.Refresh();



            //Init video capture dev
            try
            {
                // enumerate video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    dropdown_devices.Items.Add(device.Name);
                }
            }
            catch (ApplicationException)
            {
                dropdown_devices.Items.Add("No local capture devices");
                dropdown_devices.Enabled = false;
                b_video_connect.Enabled = false;
            }

            dropdown_devices.SelectedIndex = 0;
            cb_codec.SelectedIndex = 0;

            //Drawing stuff for OSD
            drawPen = new Pen(Color.White, 1);
            drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 16.0F);
            drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);


            //Disable buttons that are not working till connected
            b_reset.Enabled = false;
            b_cal_acc.Enabled = false;
            b_cal_mag.Enabled = false;
            b_read_settings.Enabled = false;
            b_write_settings.Enabled = false;
            b_write_to_file.Enabled = false;
            b_load_from_file.Enabled = false;
            btnDownLoadMission.Enabled = false;
            btnUploadMission.Enabled = false;



            //init instrument panels
            altitude_meter1.SetAlimeterParameters(0);
            vertical_speed_indicator1.SetVerticalSpeedIndicatorParameters(0);


            System.Threading.Thread.Sleep(2000);
            splash.Close();
            MainMap.Invalidate(false);

            int w = MainMap.Size.Width;
            MainMap.Width = w +1 ;
            MainMap.Width = w;
            MainMap.ShowCenter = false;


            mw_gui.max_wp_number = gui_settings.max_wp_number;
            mw_gui.wp_radius = gui_settings.wp_radius;

            //Welcome message from Anna
            if (gui_settings.speech_enabled)
            {
                speech = new SpeechSynthesizer();
                speech.Rate = -2;
                speech.SpeakAsync("Initialisation completed. Have a good flight!");
            }

        }

        bool check_capability(int captocheck)
        {
            if ((mw_gui.capability & captocheck) > 0)
            {
                return true;
            }
            else
                return false;
        }


        uint get_navi_version()
        {
            return (mw_gui.capability >> 28);
        }

        private void create_RC_Checkboxes(string[] names)
        {

            //Build indicator lamps array
            indicators = new indicator_lamp[iCheckBoxItems];
            int row = 0; int col = 0;
            int startx = 459; int starty = 7;
            for (int i = 0; i < iCheckBoxItems; i++)
            {
                indicators[i] = new indicator_lamp();
                indicators[i].Location = new Point(startx + col * 67, starty + row * 19);
                indicators[i].Visible = true;
                indicators[i].Text = names[i];
                indicators[i].indicator_color = 1;
                this.splitContainer3.Panel1.Controls.Add(indicators[i]);
                col++;
                if (col == 2) { col = 0; row++; }
            }

            //Build a second indicator lamps array on Mission plane
            indicators_mission = new indicator_lamp[iCheckBoxItems];
            startx = this.splitContainer9.Panel1.Location.X + this.splitContainer9.Panel1.Width - 67;
            starty = this.splitContainer9.Panel1.Location.Y + 20;
            for (int i = 0; i < iCheckBoxItems; i++)
            {
                indicators_mission[i] = new indicator_lamp();
                indicators_mission[i].Location = new Point(startx , starty + i * 19);
                indicators_mission[i].Text = names[i];
                indicators_mission[i].indicator_color = 1;
                indicators_mission[i].Anchor = ( AnchorStyles.Right | AnchorStyles.Top );
                indicators_mission[i].Visible = bShowGauges;
                this.splitContainer9.Panel1.Controls.Add(indicators_mission[i]);
                this.splitContainer9.Panel1.Controls.SetChildIndex(indicators_mission[i], 0);

            }

            //Build the RC control checkboxes structure

            if (!check_capability(CAP.EXTENDED_AUX))
            {
#region normal_aux_states 
            aux = new CheckBoxEx[4, 4, iCheckBoxItems];

            startx = 200;
            starty = 60;

            int a, b, c;
            for (c = 0; c < 4; c++)
            {
                for (a = 0; a < 3; a++)
                {
                    for (b = 0; b < iCheckBoxItems; b++)
                    {
                        aux[c, a, b] = new CheckBoxEx();
                        aux[c, a, b].Location = new Point(startx + a * 18 + c * 70, starty + b * 25);
                        aux[c, a, b].Visible = true;
                        aux[c, a, b].Text = "";
                        aux[c, a, b].AutoSize = true;
                        aux[c, a, b].Size = new Size(16, 16);
                        aux[c, a, b].UseVisualStyleBackColor = true;
                        aux[c, a, b].CheckedChanged += new System.EventHandler(this.aux_checked_changed_event);
                        //Set info on the given checkbox position
                        aux[c, a, b].aux = c;           //Which aux channel
                        aux[c, a, b].rclevel = a;       //which rc level
                        aux[c, a, b].item = b;          //Which item
                        this.tabPageRC.Controls.Add(aux[c, a, b]);

                    }
                }
            }

            aux_labels = new System.Windows.Forms.Label[4];
            lmh_labels = new System.Windows.Forms.Label[4, 3];          // aux1-4, L,M,H
            string strlmh = "LMH";
            for (a = 0; a < 4; a++)
            {
                aux_labels[a] = new System.Windows.Forms.Label();
                aux_labels[a].Text = "AUX" + String.Format("{0:0}", a + 1);
                aux_labels[a].Location = new Point(startx + a * 70 + 8, starty - 35);
                aux_labels[a].AutoSize = true;
                aux_labels[a].ForeColor = Color.White;
                this.tabPageRC.Controls.Add(aux_labels[a]);
                for (b = 0; b < 3; b++)
                {
                    lmh_labels[a, b] = new System.Windows.Forms.Label();
                    lmh_labels[a, b].Text = strlmh.Substring(b, 1); ;
                    lmh_labels[a, b].Location = new Point(startx + a * 70 + b * 18, starty - 20);
                    lmh_labels[a, b].AutoSize = true;
                    lmh_labels[a, b].ForeColor = Color.White;
                    this.tabPageRC.Controls.Add(lmh_labels[a, b]);
                }

            }

            cb_labels = new System.Windows.Forms.Label[20];

            for (z = 0; z < iCheckBoxItems; z++)
            {
                cb_labels[z] = new System.Windows.Forms.Label();
                cb_labels[z].Text = names[z];
                cb_labels[z].Location = new Point(10, starty + z * 25);
                cb_labels[z].Visible = true;
                cb_labels[z].AutoSize = true;
                cb_labels[z].ForeColor = Color.White;
                cb_labels[z].TextAlign = ContentAlignment.MiddleRight;
                this.tabPageRC.Controls.Add(cb_labels[z]);


            }
#endregion
            } // EXTNEDED AUX CAPABILITY
            else 
            {
#region extended_aux_states
            aux = new CheckBoxEx[4, 6, iCheckBoxItems];

            startx = 150;
            starty = 60;

            int a, b, c;
            for (c = 0; c < 4; c++)
            {
                for (a = 0; a < 6; a++)
                {
                    for (b = 0; b < iCheckBoxItems; b++)
                    {
                        aux[c, a, b] = new CheckBoxEx();
                        aux[c, a, b].Location = new Point(startx + a * 18 + c * 130, starty + b * 25);
                        aux[c, a, b].Visible = true;
                        aux[c, a, b].Text = "";
                        aux[c, a, b].AutoSize = true;
                        aux[c, a, b].Size = new Size(16, 16);
                        aux[c, a, b].UseVisualStyleBackColor = true;
                        aux[c, a, b].CheckedChanged += new System.EventHandler(this.aux_checked_changed_event);
                        //Set info on the given checkbox position
                        aux[c, a, b].aux = c;           //Which aux channel
                        aux[c, a, b].rclevel = a;       //which rc level
                        aux[c, a, b].item = b;          //Which item
                        this.tabPageRC.Controls.Add(aux[c, a, b]);

                    }
                }
            }

            aux_labels = new System.Windows.Forms.Label[4];
            lmh_labels = new System.Windows.Forms.Label[4, 6];          // aux1-4, L,M,H
            string strlmh = "123456";
            for (a = 0; a < 4; a++)
            {
                aux_labels[a] = new System.Windows.Forms.Label();
                aux_labels[a].Text = "AUX" + String.Format("{0:0}", a + 1);
                aux_labels[a].Location = new Point(startx + a * 130 + 32, starty - 35);
                aux_labels[a].AutoSize = true;
                aux_labels[a].ForeColor = Color.White;
                this.tabPageRC.Controls.Add(aux_labels[a]);
                for (b = 0; b < 6; b++)
                {
                    lmh_labels[a, b] = new System.Windows.Forms.Label();
                    lmh_labels[a, b].Text = strlmh.Substring(b, 1); ;
                    lmh_labels[a, b].Location = new Point(startx + a * 130 + b * 18, starty - 20);
                    lmh_labels[a, b].AutoSize = true;
                    lmh_labels[a, b].ForeColor = Color.White;
                    this.tabPageRC.Controls.Add(lmh_labels[a, b]);
                }

            }

            cb_labels = new System.Windows.Forms.Label[20];

            for (z = 0; z < iCheckBoxItems; z++)
            {
                cb_labels[z] = new System.Windows.Forms.Label();
                cb_labels[z].Text = names[z];
                cb_labels[z].Location = new Point(10, starty + z * 25);
                cb_labels[z].Visible = true;
                cb_labels[z].AutoSize = true;
                cb_labels[z].ForeColor = Color.White;
                cb_labels[z].TextAlign = ContentAlignment.MiddleRight;
                this.tabPageRC.Controls.Add(cb_labels[z]);


            }
#endregion
            }


        }

        private void delete_RC_Checkboxes()
        {
            int a, b, c;

            if (aux != null)
            {

                if (!check_capability(CAP.EXTENDED_AUX))
                {
                    for (c = 0; c < 4; c++)
                        for (a = 0; a < 3; a++)
                            for (b = 0; b < iCheckBoxItems; b++)
                            {
                                this.tabPageRC.Controls.Remove(aux[c, a, b]);
                                aux[c, a, b].CheckedChanged -= new System.EventHandler(this.aux_checked_changed_event);
                                aux[c, a, b].Dispose();
                            }

                    for (a = 0; a < 4; a++)
                    {
                        this.tabPageRC.Controls.Remove(aux_labels[a]);
                        aux_labels[a].Dispose();
                        for (b = 0; b < 3; b++)
                        {
                            this.tabPageRC.Controls.Remove(lmh_labels[a, b]);
                            lmh_labels[a, b].Dispose();
                        }
                    }


                }
                else           //Extended AUX
                {
                    for (c = 0; c < 4; c++)
                        for (a = 0; a < 6; a++)
                            for (b = 0; b < iCheckBoxItems; b++)
                            {
                                this.tabPageRC.Controls.Remove(aux[c, a, b]);
                                aux[c, a, b].CheckedChanged -= new System.EventHandler(this.aux_checked_changed_event);
                                aux[c, a, b].Dispose();
                            }

                    for (a = 0; a < 4; a++)
                    {
                        this.tabPageRC.Controls.Remove(aux_labels[a]);
                        aux_labels[a].Dispose();
                        for (b = 0; b < 6; b++)
                        {
                            this.tabPageRC.Controls.Remove(lmh_labels[a, b]);
                            lmh_labels[a, b].Dispose();
                        }
                    }

                }
                for (int i = 0; i < iCheckBoxItems; i++)
                {
                    this.tabPageRC.Controls.Remove(cb_labels[i]);
                    cb_labels[i].Dispose();
                    this.splitContainer3.Panel1.Controls.Remove(indicators[i]);
                    indicators[i].Dispose();
                    this.splitContainer9.Panel1.Controls.Remove(indicators_mission[i]);
                    indicators_mission[i].Dispose();
                }
            }
        }

        private void timer_realtime_Tick(object sender, EventArgs e)
        {
            telemetry_started = 1;

            update_cycle_count++;
            if (update_cycle_count == 11) update_cycle_count = 1;

            try
            {
                //timer intervall is set update rate/10. 
                //It means that one cycle has the following time
                //10Hz - 10ms
                //5hz  - 20ms
                //2hz  - 50ms
                //1hz  - 100ms
                // At 57600bps 1byte is transfered at .15ms

                if (serialPort.BytesToRead == 0)
                {

                    switch (update_cycle_count)
                    {

                        case 1:
                            MSPquery(MSP.MSP_STATUS); telemetry_status_sent++;
                            break;
                        case 2:
                            MSPquery(MSP.MSP_SERVO);
                            break;
                        case 3:
                            MSPquery(MSP.MSP_RAW_GPS);
                            break;
                        case 4:
                            MSPquery(MSP.MSP_COMP_GPS);
                            break;
                        case 5:
                            MSPquery(MSP.MSP_ANALOG);
                            break;
                        case 6:
                            MSPquery(MSP.MSP_ATTITUDE);
                            break;
                        case 7:
                            MSPquery(MSP.MSP_ALTITUDE);
                            break;
                        case 8:
                            MSPquery(MSP.MSP_RC);
                            break;
                        case 9:
                            MSPquery(MSP.MSP_NAV_STATUS);
                            break;
                        case 10:
                            MSPquery(MSP.MSP_MOTOR);
                            break;
                        default:
                            break;
                    }


                    if (tabMain.SelectedIndex == GUIPages.SensorGraph && update_cycle_count == 6)
                    {
                        MSPquery(MSP.MSP_DEBUG);
                        MSPquery(MSP.MSP_RAW_IMU);
                    }

                    if (frmDebug != null && update_cycle_count == 1) MSPquery(MSP.MSP_DEBUGMSG);

                    if (isBoxActive("ARM"))
                    {                                                           //armed
                        if (!bHomeRecorded) MSPqueryWP(0);         //get home position
                    }
                    else
                    {
                        mw_gui.GPS_home_lon = 0;
                        mw_gui.GPS_home_lat = 0;
                        bHomeRecorded = false;
                    }

                    /*

                                        if (isBoxActive("GPS HOLD"))
                                        {                                                            //poshold
                                            MSPqueryWP(255);         //get hold position
                                        }
                                        else
                                        {
                                            mw_gui.GPS_poshold_lon = 0;
                                            mw_gui.GPS_poshold_lat = 0;
                                            bPosholdRecorded = false;
                                        }
                     */



                }
            }
            catch
            {
                bSerialError = true;
            }

            if (update_cycle_count == 1) update_gui();

        }

        private void cb_monitor_rate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change refresh rate
            timer_realtime.Interval = iRefreshIntervals[cb_monitor_rate.SelectedIndex];
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Some additional housekeeping if we are connected


            if (isConnected == true)
            {

                //Common things
                isCLI = false;

                switch (tabMain.SelectedIndex)
                {

                    case GUIPages.Mission:
                        timer_realtime.Start();
                        break;
                    case GUIPages.PID:
                        timer_realtime.Stop();
                        break;
                    case GUIPages.SensorGraph:
                        timer_realtime.Start();
                        break;
                    case GUIPages.CLI:
                        timer_realtime.Stop();              //Stop refresh to free up serial channel
                        isCLI = true;
                        //serialPort.Write("#");            //CLI init string (could be +++ )
                        break;
                    case GUIPages.RC:
                        timer_realtime.Start();
                        break;
                    case GUIPages.FlighTune:
                        timer_realtime.Stop();
                        break;
                    case GUIPages.FlightDeck:
                        timer_realtime.Start();             //need to check about logging .....
                        break;
                    case GUIPages.Video:
                        timer_realtime.Stop();
                        break;
                    case GUIPages.GUISettings:
                        timer_realtime.Stop();
                        break;
                }

            }

        }

        private void b_log_browser_Click(object sender, EventArgs e)
        {
            LogBrowser logbrowser = new LogBrowser();
            logbrowser.sInitialDirectory = gui_settings.sLogFolder;
            logbrowser.ShowDialog();
            logbrowser.Dispose();
        }

        private void serial_ports_enumerate()
        {
            //Enumerate all serial ports
            b_connect.Enabled = true;           //Enable the connect button

            string[] ports = SerialPort.GetPortNames();
            cb_serial_port.Items.Clear();
            foreach (string port in ports)
            {
                cb_serial_port.Items.Add(port);
            }
            cb_serial_port.SelectedIndex = cb_serial_port.FindStringExact(gui_settings.sPreferedComPort);

            //if prefered port is not available then select the first one 
            if (cb_serial_port.Text == "")
            {
                if (cb_serial_port.Items.Count > 0) { cb_serial_port.SelectedIndex = 0; }
            }

            //Thisable connect button if there is no selected com port
            if (cb_serial_port.Items.Count == 0) { b_connect.Enabled = false; }
        }

        private void read_options_config()
        {

            option_names = new string[20];
            option_indicators = new string[20];
            option_desc = new string[100];


            int iPidID = 0;

            Pid = new PID[20];          //Max 20 PID values if we have more then we will ignore it

            iCheckBoxItems = 0;
            iPidItems = 0;

            if (File.Exists(sOptionsConfigFilename))
            {
                reader = new XmlTextReader(sOptionsConfigFilename);
            }
            else
            {
                MessageBoxEx.Show(this, "Options file " + sOptionsConfigFilename + " does not found", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(-1);
            }
            try
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:

                            if (String.Compare(reader.Name, "aux_option", true) == 0 && reader.HasAttributes)
                            {
                                for (int i = 0; i < reader.AttributeCount; i++)
                                {
                                    reader.MoveToAttribute(i);
                                    if (String.Compare(reader.Name, "name", true) == 0)
                                    {
                                        option_names[iCheckBoxItems] = reader.Value;
                                    }
                                    if (String.Compare(reader.Name, "desc", true) == 0)
                                    {
                                        option_desc[iCheckBoxItems] = reader.Value;
                                    }
                                    if (String.Compare(reader.Name, "ind", true) == 0)
                                    {
                                        option_indicators[iCheckBoxItems] = reader.Value;
                                    }

                                }
                                iCheckBoxItems++;
                            }


                            if (String.Compare(reader.Name, "version", true) == 0 && reader.HasAttributes)
                            {
                                reader.MoveToAttribute("id");
                                byteVersion = Convert.ToByte(reader.GetAttribute("id"));
                            }
                            if (String.Compare(reader.Name, "naviversion", true) == 0 && reader.HasAttributes)
                            {
                                reader.MoveToAttribute("id");
                                iNaviVersion = Convert.ToUInt16(reader.GetAttribute("id"));
                            }

                            if (String.Compare(reader.Name, "pid", true) == 0 && reader.HasAttributes)
                            {
                                reader.MoveToAttribute("id");
                                iPidID = Convert.ToInt16(reader.GetAttribute("id"));
                                Pid[iPidID] = new PID();
                                reader.MoveToAttribute("name");
                                Pid[iPidID].name = reader.GetAttribute("name");
                                reader.MoveToAttribute("desc");
                                Pid[iPidID].description = reader.GetAttribute("desc");
                                iPidItems++;
                            }
                            if (String.Compare(reader.Name, "p", true) == 0 && reader.HasAttributes)
                            {
                                reader.MoveToAttribute("id");
                                iPidID = Convert.ToInt16(reader.GetAttribute("id"));
                                reader.MoveToAttribute("shown");
                                Pid[iPidID].Pshown = Convert.ToBoolean(reader.GetAttribute("shown"));
                                reader.MoveToAttribute("min");
                                Pid[iPidID].Pmin = Convert.ToDecimal(reader.GetAttribute("min"), culture);
                                reader.MoveToAttribute("max");
                                Pid[iPidID].Pmax = Convert.ToDecimal(reader.GetAttribute("max"), culture);
                                reader.MoveToAttribute("prec");
                                Pid[iPidID].Pprec = Convert.ToInt16(reader.GetAttribute("prec"));
                            }
                            if (String.Compare(reader.Name, "i", true) == 0 && reader.HasAttributes)
                            {
                                reader.MoveToAttribute("id");
                                iPidID = Convert.ToInt16(reader.GetAttribute("id"));
                                reader.MoveToAttribute("shown");
                                Pid[iPidID].Ishown = Convert.ToBoolean(reader.GetAttribute("shown"));
                                reader.MoveToAttribute("min");
                                Pid[iPidID].Imin = Convert.ToDecimal(reader.GetAttribute("min"), culture);
                                reader.MoveToAttribute("max");
                                Pid[iPidID].Imax = Convert.ToDecimal(reader.GetAttribute("max"), culture);
                                reader.MoveToAttribute("prec");
                                Pid[iPidID].Iprec = Convert.ToInt16(reader.GetAttribute("prec"));
                            }
                            if (String.Compare(reader.Name, "d", true) == 0 && reader.HasAttributes)
                            {
                                reader.MoveToAttribute("id");
                                iPidID = Convert.ToInt16(reader.GetAttribute("id"));
                                reader.MoveToAttribute("shown");
                                Pid[iPidID].Dshown = Convert.ToBoolean(reader.GetAttribute("shown"));
                                reader.MoveToAttribute("min");
                                Pid[iPidID].Dmin = Convert.ToDecimal(reader.GetAttribute("min"), culture);
                                reader.MoveToAttribute("max");
                                Pid[iPidID].Dmax = Convert.ToDecimal(reader.GetAttribute("max"), culture);
                                reader.MoveToAttribute("prec");
                                Pid[iPidID].Dprec = Convert.ToInt16(reader.GetAttribute("prec"));
                            }




                            break;

                    }
                }
            }
            catch
            {
                MessageBoxEx.Show(this, "Options file contains invalid data around Line : " + reader.LineNumber, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(-1);
            }

            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void b_pause_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                b_pause.ForeColor = Color.Red;
                b_pause.Text = "Paused";
                timer_realtime.Stop();
            }
            else
            {
                b_pause.ForeColor = Color.Black;
                b_pause.Text = "Pause";
                if (isConnected) { timer_realtime.Start(); }
            }

        }

        private void evaluate_command(byte cmd)
        {

            byte ptr;

            switch (cmd)
            {
                case MSP.MSP_IDENT:
                    ptr = 0;
                    mw_gui.version = (byte)inBuf[ptr++];
                    mw_gui.multiType = (byte)inBuf[ptr++];
                    mw_gui.protocol_version = (byte)inBuf[ptr++];
                    mw_gui.capability = BitConverter.ToUInt32(inBuf, ptr); ptr += 4;
                    response_counter++;
                    break;
                case MSP.MSP_STATUS:
                    ptr = 0;
                    mw_gui.cycleTime = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.i2cErrors = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.present = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.mode = BitConverter.ToUInt32(inBuf, ptr); ptr += 4;
                    telemetry_status_received++;
                    break;
                case MSP.MSP_RAW_IMU:
                    ptr = 0;
                    mw_gui.ax = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.ay = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.az = BitConverter.ToInt16(inBuf, ptr); ptr += 2;

                    mw_gui.gx = BitConverter.ToInt16(inBuf, ptr) / 8; ptr += 2;
                    mw_gui.gy = BitConverter.ToInt16(inBuf, ptr) / 8; ptr += 2;
                    mw_gui.gz = BitConverter.ToInt16(inBuf, ptr) / 8; ptr += 2;

                    mw_gui.magx = BitConverter.ToInt16(inBuf, ptr) / 3; ptr += 2;
                    mw_gui.magy = BitConverter.ToInt16(inBuf, ptr) / 3; ptr += 2;
                    mw_gui.magz = BitConverter.ToInt16(inBuf, ptr) / 3; ptr += 2;
                    break;
                case MSP.MSP_SERVO:
                    ptr = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        mw_gui.servos[i] = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    }
                    break;
                case MSP.MSP_MOTOR:
                    ptr = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        mw_gui.motors[i] = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    }
                    break;
                case MSP.MSP_RC:
                    ptr = 0;
                    mw_gui.rcRoll = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.rcPitch = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.rcYaw = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.rcThrottle = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    if (AUX_CHANNELS != ((dataSize / 2) - 4))
                    {
                        AUX_CHANNELS = (dataSize / 2) - 4;
                    };
                    if (AUX_CHANNELS > 8) AUX_CHANNELS = 8;   //DO not process channels above 12 (SBUS issue)
                    for (int i = 0; i < AUX_CHANNELS; i++)
                    {
                        mw_gui.rcAUX[i] = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    }
                    break;
                case MSP.MSP_RAW_GPS:
                    ptr = 0;
                    mw_gui.GPS_fix = (byte)inBuf[ptr++];
                    mw_gui.GPS_numSat = (byte)inBuf[ptr++];
                    mw_gui.GPS_latitude = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                    mw_gui.GPS_longitude = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                    mw_gui.GPS_altitude = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.GPS_speed = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    break;
                case MSP.MSP_COMP_GPS:
                    ptr = 0;
                    mw_gui.GPS_distanceToHome = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.GPS_directionToHome = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.GPS_update = (byte)inBuf[ptr++];
                    break;
                case MSP.MSP_ATTITUDE:
                    ptr = 0;
                    mw_gui.angx = BitConverter.ToInt16(inBuf, ptr) / 10; ptr += 2;
                    mw_gui.angy = BitConverter.ToInt16(inBuf, ptr) / 10; ptr += 2;
                    mw_gui.heading = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    break;
                case MSP.MSP_ALTITUDE:
                    ptr = 0;
                    mw_gui.EstAlt = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                    mw_gui.vario = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    break;
                case MSP.MSP_ANALOG:
                    ptr = 0;
                    mw_gui.vBat = (byte)inBuf[ptr++];
                    mw_gui.pMeterSum = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.rssi = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    break;
                case MSP.MSP_RC_TUNING:
                    ptr = 0;
                    mw_gui.rcRate = (byte)inBuf[ptr++];
                    mw_gui.rcExpo = (byte)inBuf[ptr++];
                    mw_gui.RollPitchRate = (byte)inBuf[ptr++];
                    mw_gui.YawRate = (byte)inBuf[ptr++];
                    mw_gui.DynThrPID = (byte)inBuf[ptr++];
                    mw_gui.ThrottleMID = (byte)inBuf[ptr++];
                    mw_gui.ThrottleEXPO = (byte)inBuf[ptr++];
                    response_counter++;
                    break;
                case MSP.MSP_PID:
                    ptr = 0;
                    for (int i = 0; i < iPidItems; i++)
                    {
                        mw_gui.pidP[i] = (byte)inBuf[ptr++];
                        mw_gui.pidI[i] = (byte)inBuf[ptr++];
                        mw_gui.pidD[i] = (byte)inBuf[ptr++];
                    }
                    response_counter++;
                    bOptions_needs_refresh = true;
                    break;
                case MSP.MSP_BOX:
                    ptr = 0;
                    if (!check_capability(CAP.EXTENDED_AUX))
                    {
                        if (mw_gui.activation.Length < dataSize / 2)
                            mw_gui.activation = new UInt32[dataSize / 2];
                        for (int i = 0; i < (dataSize / 2); i++)
                        {
                            mw_gui.activation[i] = (UInt32)BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                        }
                    }
                    else
                    {
                        if (mw_gui.activation.Length < dataSize / 4)
                            mw_gui.activation = new UInt32[dataSize / 4];
                        for (int i = 0; i < (dataSize / 4); i++)
                        {
                            mw_gui.activation[i] = BitConverter.ToUInt32(inBuf, ptr); ptr += 4;
                        }
                    }
                    response_counter++;
                    break;
                case MSP.MSP_BOXNAMES:
                    StringBuilder builder = new StringBuilder();
                    ptr = 0;
                    while (ptr < dataSize) builder.Append((char)inBuf[ptr++]);
                    builder.Remove(builder.Length - 1, 1);
                    mw_gui.sBoxNames = new string[builder.ToString().Split(';').Length];
                    mw_gui.sBoxNames = builder.ToString().Split(';');
                    iCheckBoxItems = mw_gui.sBoxNames.Length;
                    mw_gui.bUpdateBoxNames = true;
                    break;
                case MSP.MSP_MISC:
                    ptr = 0;
                    mw_gui.powerTrigger = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;

                    mw_gui.minThrottle = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.maxThrottle = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.minCommand = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.failsafe_throttle = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;

                    mw_gui.plog_arm = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.plog_lifetime = BitConverter.ToUInt32(inBuf, ptr); ptr += 4;

                    mw_gui.mag_declination = BitConverter.ToInt16(inBuf, ptr); ptr += 2;

                    mw_gui.vbatscale = (byte)BitConverter.ToChar(inBuf, ptr); ptr++;
                    mw_gui.vbatlevel_warn1 = (byte)BitConverter.ToChar(inBuf, ptr); ptr++;
                    mw_gui.vbatlevel_warn2 = (byte)BitConverter.ToChar(inBuf, ptr); ptr++;
                    mw_gui.vbatlevel_crit = (byte)BitConverter.ToChar(inBuf, ptr); ptr++;
                    response_counter++;
                    break;


                case MSP.MSP_SERVO_CONF:
                    ptr = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        //DO only the tricopter version...



                        mw_gui.servoMin[i] = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                        mw_gui.servoMax[i] = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                        mw_gui.servoMiddle[i] = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                        mw_gui.servoRate[i] = (SByte)inBuf[ptr]; ptr += 1;

                        //Check the boundaries, if no servos are defined in config.h then the servo variables remain uninitailised in EEPROM so expect gibberis
                        if ((mw_gui.servoMin[i] < 900) || (mw_gui.servoMin[i] > 2100)) mw_gui.servoMin[i] = 1000;
                        if ((mw_gui.servoMax[i] < 900) || (mw_gui.servoMax[i] > 2100)) mw_gui.servoMax[i] = 2000;
                        if ((mw_gui.servoMiddle[i] < 1000) || (mw_gui.servoMiddle[i] > 2000)) mw_gui.servoMiddle[i] = 1500;
                        if (Math.Abs(mw_gui.servoRate[i]) > 100) mw_gui.servoRate[i] = 100;
                    }
                    response_counter++;
                    break;

                case MSP.MSP_DEBUG:
                    ptr = 0;
                    mw_gui.debug1 = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.debug2 = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.debug3 = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    mw_gui.debug4 = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    break;
                case MSP.MSP_DEBUGMSG:
                    StringBuilder dbgmsg = new StringBuilder();
                    ptr = 0;
                    while (ptr < dataSize) dbgmsg.Append((char)inBuf[ptr++]);
                    strDebug = strDebug + dbgmsg.ToString();
                    break;
                case MSP.MSP_WP:

                    ptr = 0;
                    byte wp_no = (byte)inBuf[ptr++];

                    if (wp_no == 0)
                    {
                        ptr++;  //Action is ignored
                        mw_gui.GPS_home_lat = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                        mw_gui.GPS_home_lon = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                        mw_gui.GPS_home_alt = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                        bHomeRecorded = true;
                        //flag comes here but not care
                    }
                    if (wp_no == 255)
                    {
                        ptr++; //action is ignored
                        mw_gui.GPS_poshold_lat = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                        mw_gui.GPS_poshold_lon = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                        mw_gui.GPS_poshold_alt = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                        bPosholdRecorded = true;

                    }
                    if ((wp_no > 0) && (wp_no < 255))     //It is a valid WP response
                    {
                        mission_step.wp_number = wp_no;
                        mission_step.action = inBuf[ptr++];
                        mission_step.lat = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                        mission_step.lon = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                        mission_step.altitude = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                        mission_step.p1 = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                        mission_step.p2 = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                        mission_step.p3 = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                        mission_step.flag = inBuf[ptr++];

                        mission_step.wp_updated = true;
                    }
                    break;
                case MSP.MSP_NAV_STATUS:
                    ptr = 0;
                    mw_gui.gps_mode = inBuf[ptr++];
                    mw_gui.nav_state = inBuf[ptr++];
                    mw_gui.action = inBuf[ptr++];
                    mw_gui.wp_number = inBuf[ptr++];
                    mw_gui.nav_error = inBuf[ptr++];
                    mw_gui.target_bearing = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    break;

                case MSP.MSP_NAV_CONFIG:
                    ptr = 0;
                    mw_gui.flags1 = inBuf[ptr++];
                    mw_gui.flags2 = inBuf[ptr++];
                    mw_gui.wp_radius = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.safe_wp_distance = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.nav_max_altitude = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.nav_speed_max = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.nav_speed_min = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.crosstrack_gain = inBuf[ptr++];
                    mw_gui.nav_bank_max = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.rth_altitude = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.land_speed = inBuf[ptr++];
                    mw_gui.fence        = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.max_wp_number = inBuf[ptr++];
                    break;

                case MSP.MSP_RADIO:         //Special command inserted by the 3dr radio for multiwii
                    ptr = 0;
                    mw_gui.rxerrors = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.fixed_errors = BitConverter.ToUInt16(inBuf, ptr); ptr += 2;
                    mw_gui.localrssi = inBuf[ptr++];
                    mw_gui.remrssi = inBuf[ptr++];
                    mw_gui.txbuf = inBuf[ptr++];
                    mw_gui.noise = inBuf[ptr++];
                    mw_gui.remnoise = inBuf[ptr++];
                    break;


            }
        }

        private void bkgWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            byte c;

            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            try
            {
                bool bIsPortOpen = serialPort.IsOpen;
            }
            catch
            {
                //Hmm, if this throws an exception it should mean that we have an issue here
                bSerialError = true;
                return;
            }

            bSerialError = false;

            try
            {

                while (!bw.CancellationPending)                // backgroundworker runs continously
                {

                    if (serialPort.IsOpen)
                    {
                        //Just process what is received. Get received commands and put them into 
                        while (serialPort.BytesToRead > 0)
                        {
                            if (isCLI == true)
                            {
                                inCLIBuffer = serialPort.ReadExisting();
                                AccessToTB();
                            }
                            else
                            {
                                c = (byte)serialPort.ReadByte();


                                switch (c_state)
                                {
                                    case IDLE:
                                        c_state = (c == '$') ? HEADER_START : IDLE;
                                        break;
                                    case HEADER_START:
                                        c_state = (c == 'M') ? HEADER_M : IDLE;
                                        break;

                                    case HEADER_M:
                                        if (c == '>')
                                        {
                                            c_state = HEADER_ARROW;
                                        }
                                        else if (c == '!')
                                        {
                                            c_state = HEADER_ERR;
                                        }
                                        else
                                        {
                                            c_state = IDLE;
                                        }
                                        break;

                                    case HEADER_ARROW:
                                    case HEADER_ERR:
                                        /* is this an error message? */
                                        err_rcvd = (c_state == HEADER_ERR);        /* now we are expecting the payload size */
                                        dataSize = c;
                                        /* reset index variables */
                                        offset = 0;
                                        checksum = 0;
                                        checksum ^= c;
                                        c_state = HEADER_SIZE;
                                        if (dataSize > 150) { c_state = IDLE; }
                                        break;
                                    case HEADER_SIZE:
                                        cmd = c;
                                        checksum ^= c;
                                        c_state = HEADER_CMD;
                                        break;
                                    case HEADER_CMD:
                                        if (offset < dataSize)
                                        {
                                            checksum ^= c;
                                            inBuf[offset++] = c;
                                        }
                                        else
                                        {

                                            /* compare calculated and transferred checksum */
                                            if (checksum == c)
                                            {
                                                if (err_rcvd)
                                                {
                                                    //Invalid command received... (CRC was OK btw)
                                                    if (telemetry_started == 1) serial_packet_rx_count++;
                                                    last_response = cmd;                        

                                                }
                                                else
                                                {
                                                    /* we got a valid response packet, evaluate it */
                                                    if (telemetry_started == 1) serial_packet_rx_count++;
                                                    last_response = cmd;
                                                    evaluate_command(cmd);
                                                }
                                            }
                                            else
                                            {
                                                //Checksum error
                                                serial_error_count++;
                                            }
                                            c_state = IDLE;
                                        }
                                        break;
                                }
                            }
                        }
                    }
                    else   //port not opened, (it could happen when U disconnect the usb cable while connected
                    {
                        //bSerialError = true; //do nothing
                        //return;
                    }

                }// while
            }

            catch
            {
                bSerialError = true;
                return;
            }

            e.Cancel = true;

        }

        private void set_servo_control(int i, bool status, string function)
        {
            servo_text[i].Enabled = status;
            servo_text[i].Text = function;
            servo_max[i].Enabled = status;
            servo_max[i].Visible = status;
            servo_min[i].Enabled = status;
            servo_min[i].Visible = status;
            servo_mid[i].Enabled = status;
            servo_mid[i].Visible = status;
            servo_rate[i].Enabled = status;
            servo_rate[i].Visible = status;
            servo_reverse[i].Enabled = status;
            servo_reverse[i].Visible = status;
        }

        private void nav_error_notification(byte error_code)
        {

            switch (error_code)
            {
                case 1: speech.SpeakAsync(sNavError[error_code]);
                    break;
                case 2: speech.SpeakAsync(sNavError[error_code]);
                    break;
                case 3: speech.SpeakAsync(sNavError[error_code]);
                    break;
                case 4: speech.SpeakAsync(sNavError[error_code]);
                    break;
                case 6: speech.SpeakAsync(sNavError[error_code]);
                    break;
                case 7: speech.SpeakAsync(sNavError[error_code]);
                    break;
                case 8: speech.SpeakAsync(sNavError[error_code]);
                    break;
                case 9: speech.SpeakAsync(sNavError[error_code]);
                    break;
            }
        }

        private void update_gui()
        {


            //Common stuff

            bool test = isArmed();

            labelCRCErrors.Text = Convert.ToString(serial_error_count);
            labelReceivedPackets.Text = Convert.ToString(serial_packet_rx_count);
            labelSentPackets.Text = Convert.ToString(serial_packet_tx_count);

            barRSSI.Value = mw_gui.remrssi;
            labelRSSI.Text = Convert.ToString(barRSSI.Value);

            barNoise.Value = mw_gui.remnoise;
            labelNoise.Text = Convert.ToString(barNoise.Value);
            
            //VBat on the FC Config panel for helping setup vBatScale
            lVBatConf.Text = String.Format("{0:0.0} volts", (double)mw_gui.vBat / 10);

            if (frmDebug != null && strDebug != "")
            {
                frmDebug.AppendText(strDebug);
                strDebug = "";
            }

            //in case of Serial error, throw an error message and disconnect gracefully
            if (bSerialError)
            {
                //Background worker returned error, disconnect serial port
                b_connect.Text = "Connect";
                isConnected = false;
                timer_realtime.Stop();                       //Stop timer(s), whatever it takes
                System.Threading.Thread.Sleep(iRefreshIntervals[cb_monitor_rate.SelectedIndex]);         //Wait for 1 cycle to let backgroundworker finish it's last job.
                try
                {
                    serialPort.Close();
                }
                catch
                {
                }
                MessageBoxEx.Show(this, "An error condition detected on the Serial port, check that your USB cable is connected", "Comm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bSerialError = false;
                return;
            }

            //if logging is enabled then write the neccessary log entries
            if (bLogRunning && wLogStream.BaseStream != null) updateLog();

            //If GPS logging is running then add the necessary KML log record
            if (bKMLLogRunning)
            {
                if (GPS_lat_old != mw_gui.GPS_latitude || GPS_lon_old != mw_gui.GPS_longitude)
                {
                    wKMLLogStream.WriteLine("{0},{1},{2}", (decimal)mw_gui.GPS_longitude / 10000000, (decimal)mw_gui.GPS_latitude / 10000000, mw_gui.GPS_altitude);
                    GPS_lat_old = mw_gui.GPS_latitude;
                    GPS_lon_old = mw_gui.GPS_longitude;
                }

                if (!bHomeRecorded && (mw_gui.GPS_home_lon != 0))
                {
                    addKMLMarker("Home position", mw_gui.GPS_home_lon, mw_gui.GPS_home_lat, mw_gui.GPS_altitude);
                    bHomeRecorded = true;
                }


                if (!bPosholdRecorded && (mw_gui.GPS_poshold_lon != 0))
                {
                    addKMLMarker("PosHold", mw_gui.GPS_poshold_lon, mw_gui.GPS_poshold_lat, mw_gui.GPS_altitude);
                    bPosholdRecorded = true;
                }
            }

            #region options_need_refresh_if

            if (bOptions_needs_refresh)
            {
                update_pid_panel();
                update_aux_panel();

                throttle_expo_control1.SetRCExpoParameters((double)nTMID.Value, (double)nTEXPO.Value, mw_gui.rcThrottle);

                //update magnetic declination

                label49.Text = "(" + Convert.ToString((decimal)mw_gui.mag_declination / 10) + ")";
                decimal mag_dec = (decimal)mw_gui.mag_declination / 10;
                if (mag_dec < 0) cbMagSign.SelectedIndex = 1;
                else cbMagSign.SelectedIndex = 0;
                mag_dec = Math.Abs(mag_dec);
                nMagDeg.Value = (int)mag_dec;
                nMagMin.Value = (mag_dec - (int)mag_dec) * 60;

                //Update Power parameters
                nVBatScale.Value = (int)mw_gui.vbatscale;
                nVBatWarn1.Value = (int)mw_gui.vbatlevel_warn1;
                nVBatWarn2.Value = (int)mw_gui.vbatlevel_warn2;
                nVBatCritical.Value = (int)mw_gui.vbatlevel_crit;
                nPAlarm.Value = mw_gui.powerTrigger;
                nPAlarm.BackColor = Color.White;

                //Update throttle params
                nMinThr.Value = mw_gui.minThrottle;
                lMaxThr.Text = Convert.ToString(mw_gui.maxThrottle);
                lMinCommand.Text = Convert.ToString(mw_gui.minCommand);
                nFSThr.Value = mw_gui.failsafe_throttle;

                lArms.Text = Convert.ToString(mw_gui.plog_arm);
                lLife.Text = Convert.ToString(mw_gui.plog_lifetime);


                //Update Servo settings panel
                //Disable all
                for (int i = 0; i < 8; i++)
                {
                    set_servo_control(i, false, "Unused");
                }


                switch ((CopterType)mw_gui.multiType)
                {
                    case CopterType.Tri:
                        set_servo_control(5, true, "Yaw servo");
                        servo_rate[5].Enabled = false;
                        servo_rate[5].Visible = false;
                        break;
                    case CopterType.Airplane:
                        set_servo_control(2, true, "Flaps");
                        set_servo_control(3, true, "Wing 1");
                        set_servo_control(4, true, "Wing 2");
                        set_servo_control(5, true, "Rudder");
                        set_servo_control(6, true, "Elevator");
                        break;
                    case CopterType.Gimbal:
                        set_servo_control(0, true, "Pitch");
                        set_servo_control(1, true, "Roll");
                        set_servo_control(2, true, "Trigger");
                        break;
                    case CopterType.FlyWing:
                        set_servo_control(3, true, "Wing 1");
                        set_servo_control(4, true, "Wing 2");
                        break;
                    case CopterType.BI:
                        set_servo_control(4, true, "Left motor servo");
                        set_servo_control(5, true, "Right motor servo");
                        break;
                    case CopterType.DualCopter:
                        set_servo_control(4, true, "PITCH Servo");
                        set_servo_control(5, true, "ROLL Servo");
                        break;
                    case CopterType.Singlecopter:
                        set_servo_control(3, true, "Side Servo");
                        set_servo_control(4, true, "Side Servo");
                        set_servo_control(5, true, "Front Servo");
                        set_servo_control(6, true, "Rear Servo");
                        break;
                    case CopterType.Heli_120_CCPM:
                        set_servo_control(5, true, "Yaw motor");
                        set_servo_control(3, true, "NICK Servo");
                        set_servo_control(4, true, "Left Servo");
                        set_servo_control(6, true, "Right Servo");
                        break;
                    case CopterType.Heli_90_DEG:
                        set_servo_control(5, true, "Yaw motor");
                        set_servo_control(3, true, "NICK Servo");
                        set_servo_control(4, true, "Roll Servo");
                        set_servo_control(6, true, "Collective Servo");
                        break;
                }


                for (int i = 0; i < 8; i++)
                {
                    servo_max[i].Value = mw_gui.servoMax[i];
                    servo_min[i].Value = mw_gui.servoMin[i];
                    servo_mid[i].Value = mw_gui.servoMiddle[i];
                    servo_rate[i].Value = Math.Abs(mw_gui.servoRate[i]);

                    if (mw_gui.servoRate[i] < 0)
                    {
                        servo_reverse[i].Checked = true;
                    }
                    else
                    {
                        servo_reverse[i].Checked = false;
                    }

                    //Servo handler madness 
                    if ((CopterType)mw_gui.multiType == CopterType.Tri)
                    {
                        if (mw_gui.servoRate[i] == 1)
                        {
                            servo_reverse[i].Checked = true;
                        }
                        else
                        {
                            servo_reverse[i].Checked = false;
                        }
                    }

                }

                if (naviGroup.Enabled)
                {
                    //flags
                    cbNavGPS_filtering.Checked = (mw_gui.flags1 & 0x01) > 0;
                    cbNavGPS_Lead.Checked = (mw_gui.flags1 & 0x02) > 0;
                    cbNavResetHome.Checked = (mw_gui.flags1 & 0x04) > 0;
                    cbNavHeadingControl.Checked = (mw_gui.flags1 & 0x08) > 0;
                    cbNavTailFirst.Checked = (mw_gui.flags1 & 0x10) > 0;
                    cbNavRTHHead.Checked = (mw_gui.flags1 & 0x20) > 0;
                    cbNavSlowNav.Checked = (mw_gui.flags1 & 0x40) > 0;
                    cbNavWaitRTHAlt.Checked = (mw_gui.flags1 & 0x80) > 0;
                    //flags2
                    cbNavDisableSticks.Checked = (mw_gui.flags2 & 0x01) > 0;
                    cbNavBaroTakeover.Checked = (mw_gui.flags2 & 0x02) > 0;

                    nWPRadius.Value = mw_gui.wp_radius;
                    nRTHAlt.Value = mw_gui.rth_altitude;
                    nCrosstrack.Value = (decimal)mw_gui.crosstrack_gain / 100;
                    nMaxSpeed.Value = mw_gui.nav_speed_max;
                    nMinSpeed.Value = mw_gui.nav_speed_min;
                    nBanking.Value = mw_gui.nav_bank_max / 100;
                    nSafeWPDist.Value = mw_gui.safe_wp_distance;
                    nMaxAlt.Value = mw_gui.nav_max_altitude;
                    nLandSpeed.Value = mw_gui.land_speed;
                    nFence.Value = mw_gui.fence;


                    //Save default values to gui settings
                    gui_settings.max_wp_number = mw_gui.max_wp_number;
                    gui_settings.wp_radius = mw_gui.wp_radius;
                }


                gui_settings.save_to_xml(sGuiSettingsFilename);
                bOptions_needs_refresh = false;
            }
#endregion

            #region GUIPages.mission

            //Map update should be continous
            if (mw_gui.GPS_latitude != 0)
            {
                GPS_pos.Lat = (double)mw_gui.GPS_latitude / 10000000;
                GPS_pos.Lng = (double)mw_gui.GPS_longitude / 10000000;
                GMRouteFlightPath.Points.Add(GPS_pos);
            }

            //Hack to force map update
            GMOverlayFlightPath.IsVisibile = false;
            GMOverlayFlightPath.IsVisibile = true;
            
            //Speech nav status notification
            if (gui_settings.speech_enabled)
            {
                if ((prev_state != mw_gui.nav_state) || (prev_wp != mw_gui.wp_number))
                {
                    switch (mw_gui.nav_state)
                    {
                        case 1: speech.SpeakAsync("Starting return to home.");
                            break;
                        case 2: speech.SpeakAsync("Goint to home position.");
                            break;
                        case 3: speech.SpeakAsync("Switching to position hold.");
                            break;
                        case 4: speech.SpeakAsync("Timed position hold.");
                            break;
                        case 5: speech.SpeakAsync("Going to waypoint " + mw_gui.wp_number.ToString() + ".");
                            break;
                        case 9: speech.SpeakAsync("Landing is in progress.");
                            break;
                        case 10: speech.SpeakAsync("Copter is landed. Pull throttle to minimum to disarm.");
                            break;

                    }
                    prev_state = mw_gui.nav_state;
                    prev_wp = mw_gui.wp_number;
                }
            }

            if (tabMain.SelectedIndex == GUIPages.Mission)
            {

                //Update nav and GPS mode text
                lGpsMode.Text = sGpsMode[mw_gui.gps_mode];
                lNavState.Text = sNavState[mw_gui.nav_state];

                //Highlight actual mission step
                for (int i = 0; i < missionDataGrid.RowCount; i++) missionDataGrid.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 64, 64, 64);
                if (mw_gui.gps_mode == 3)
                {
                    try
                    {
                        if (missionDataGrid.RowCount >= mw_gui.wp_number) missionDataGrid.Rows[mw_gui.wp_number - 1].DefaultCellStyle.BackColor = Color.Tomato;
                    }
                    catch { }
                }

                //Error notification (perhaps could move to common section
                if (gui_settings.speech_enabled)
                {
                    if (mw_gui.nav_error != previous_nav_error)
                    {
                        previous_nav_error = mw_gui.nav_error;
                        nav_error_notification(mw_gui.nav_error);
                    }
                }

                lNavError.Text = sNavError[mw_gui.nav_error];

                //Show gauges on MAP
                if (bShowGauges)
                {
                    altitude_meter2.SetAlimeterParameters(mw_gui.EstAlt / 100);                     //Control needs input in meter - EstAlt comes in cm
                    vertical_speed_indicator2.SetVerticalSpeedIndicatorParameters(mw_gui.vario);    //Control needs input in cm/sec - so vario
                    gpsIndicator2.SetGPSIndicatorParameters(mw_gui.GPS_directionToHome, mw_gui.GPS_distanceToHome, mw_gui.GPS_numSat, Convert.ToBoolean(mw_gui.GPS_fix), bHomeRecorded, Convert.ToBoolean(mw_gui.GPS_update));
                    battery_indicator2.SetVoltage(mw_gui.vBat, gui_settings.cellcount);
                    barRSSIMission.Value = mw_gui.remrssi;
                    for (int i = 0; i < iCheckBoxItems; i++)
                    {
                        if ((mw_gui.mode & (1 << i)) > 0)
                        {
                            indicators_mission[i].SetStatus(true);
                        }
                        else
                        {
                            indicators_mission[i].SetStatus(false);
                        }
                    }


                }


                //Update markers
                if (mw_gui.GPS_latitude != 0)
                {
                    //Clear markers
                    GMOverlayLiveData.Markers.Clear();

                    //Display GPS position
                    lGPS_lat.Text = Convert.ToString((decimal)mw_gui.GPS_latitude / 10000000);
                    lGPS_lon.Text = Convert.ToString((decimal)mw_gui.GPS_longitude / 10000000);

                    //Go to click marker display
                    if (markerGoToClick != null) GMOverlayLiveData.Markers.Add(markerGoToClick);

                    //Display HOME position marker
                    if (isBoxActive("ARM") && (mw_gui.GPS_home_lon != 0))       //ARMED
                    {
                        PointLatLng GPS_home = new PointLatLng((double)mw_gui.GPS_home_lat / 10000000, (double)mw_gui.GPS_home_lon / 10000000);
                        GMOverlayLiveData.Markers.Add(new GMapMarkerHome(GPS_home));
                    }

                    //Display copter marker
                    GMOverlayLiveData.Markers.Add(new GMapMarkerCopter(GPS_pos, mw_gui.heading, 0, mw_gui.target_bearing, mw_gui.multiType));

                    // Center Map to copter position if AutoPan is checked in
                    if (cbAutoPan.Checked) MainMap.Position = GPS_pos;
                    MainMap.Invalidate(false);

                    l_GPS_alt.Text = Convert.ToString(mw_gui.GPS_altitude) + "m";
                    l_GPS_numsat.Text = Convert.ToString(mw_gui.GPS_numSat);
                }
            }
            #endregion

            #region GUIOPages.RC

            // TAB RCControl
            if (tabMain.SelectedIndex == GUIPages.RC)
            {
                //update RC control values
                rci_Control_settings.SetRCInputParameters(mw_gui.rcThrottle, mw_gui.rcPitch, mw_gui.rcRoll, mw_gui.rcYaw, mw_gui.rcAUX, AUX_CHANNELS + 4);
                if (!check_capability(CAP.EXTENDED_AUX))
                {
                    #region normal_aux
                    //Show LMH postions above switches
                    for (int i = 0; i < 4; i++)
                    {
                        lmh_labels[i, 0].BackColor = (mw_gui.rcAUX[i] < rcLow) ? Color.Green : Color.Transparent;
                        lmh_labels[i, 1].BackColor = (mw_gui.rcAUX[i] > rcLow && mw_gui.rcAUX[i] < rcMid) ? Color.Green : Color.Transparent;
                        lmh_labels[i, 2].BackColor = (mw_gui.rcAUX[i] > rcMid) ? Color.Green : Color.Transparent;
                    }

                    //evaluate rc_options and recolor mode which supposed to be ON at the current rc values
                    byte act1, act2, opt1, opt2;

                    //Construct options switch mask based on rcAux input
                    opt1 = (byte)(Convert.ToByte(mw_gui.rcAUX[0] < 1300) + Convert.ToByte(1300 < mw_gui.rcAUX[0] && mw_gui.rcAUX[0] < 1700) * 2 + Convert.ToByte(mw_gui.rcAUX[0] > 1700) * 4 + Convert.ToByte(mw_gui.rcAUX[1] < 1300) * 8 + Convert.ToByte(1300 < mw_gui.rcAUX[1] && mw_gui.rcAUX[1] < 1700) * 16 + Convert.ToByte(mw_gui.rcAUX[1] > 1700) * 32);
                    opt2 = (byte)(Convert.ToByte(mw_gui.rcAUX[2] < 1300) + Convert.ToByte(1300 < mw_gui.rcAUX[2] && mw_gui.rcAUX[2] < 1700) * 2 + Convert.ToByte(mw_gui.rcAUX[2] > 1700) * 4 + Convert.ToByte(mw_gui.rcAUX[3] < 1300) * 8 + Convert.ToByte(1300 < mw_gui.rcAUX[3] && mw_gui.rcAUX[3] < 1700) * 16 + Convert.ToByte(mw_gui.rcAUX[3] > 1700) * 32);

                    //Compare with switchbox settings
                    for (int b = 0; b < iCheckBoxItems; b++)
                    {
                        act1 = 0; act2 = 0;
                        for (byte a = 0; a < 3; a++)
                        {
                            if (aux[0, a, b].Checked) act1 += (byte)(1 << a);
                            if (aux[1, a, b].Checked) act1 += (byte)(1 << (3 + a));
                            if (aux[2, a, b].Checked) act2 += (byte)(1 << a);
                            if (aux[3, a, b].Checked) act2 += (byte)(1 << (3 + a));
                        }
                        //Highlight active function name
                        if ((opt1 & act1) != 0 || (opt2 & act2) != 0) { cb_labels[b].BackColor = Color.Red; cb_labels[b].ForeColor = Color.Yellow; } else { cb_labels[b].BackColor = Color.Transparent; cb_labels[b].ForeColor = Color.White; }
                    }
                    #endregion
                }
                else
                {
                    #region extended_aux
                    for (int i = 0; i < 4; i++)
                    {
                        lmh_labels[i, 0].BackColor = (mw_gui.rcAUX[i] < rcLevel1) ? Color.Green : Color.Transparent;
                        lmh_labels[i, 1].BackColor = (mw_gui.rcAUX[i] >= rcLevel1 && mw_gui.rcAUX[i] < rcLevel2) ? Color.Green : Color.Transparent;
                        lmh_labels[i, 2].BackColor = (mw_gui.rcAUX[i] >= rcLevel2 && mw_gui.rcAUX[i] < rcLevel3) ? Color.Green : Color.Transparent;
                        lmh_labels[i, 3].BackColor = (mw_gui.rcAUX[i] >= rcLevel3 && mw_gui.rcAUX[i] < rcLevel4) ? Color.Green : Color.Transparent;
                        lmh_labels[i, 4].BackColor = (mw_gui.rcAUX[i] >= rcLevel4 && mw_gui.rcAUX[i] < rcLevel5) ? Color.Green : Color.Transparent;
                        lmh_labels[i, 5].BackColor = (mw_gui.rcAUX[i] >= rcLevel5) ? Color.Green : Color.Transparent;
                    }

                    UInt32 auxState = 0;
                    for (int i = 0; i < 4; i++)
                    {


                        auxState |= (mw_gui.rcAUX[i] < 1230) ? (UInt32)1 << (6 * i) : 0;
                        auxState |= (1231 < mw_gui.rcAUX[i] && mw_gui.rcAUX[i] < 1360) ? (UInt32)1 << (6 * i + 1) : 0;
                        auxState |= (1361 < mw_gui.rcAUX[i] && mw_gui.rcAUX[i] < 1490) ? (UInt32)1 << (6 * i + 2) : 0;
                        auxState |= (1491 < mw_gui.rcAUX[i] && mw_gui.rcAUX[i] < 1620) ? (UInt32)1 << (6 * i + 3) : 0;
                        auxState |= (1621 < mw_gui.rcAUX[i] && mw_gui.rcAUX[i] < 1749) ? (UInt32)1 << (6 * i + 4) : 0;
                        auxState |= (mw_gui.rcAUX[i] > 1750) ? (UInt32)1 << (6 * i + 5) : 0;
                    }
                    UInt32 check_state;
                    for (int b = 0; b < iCheckBoxItems; b++)
                    {
                        check_state  = 0 ;
                        for (byte a = 0; a < 6; a++)
                        {
                            if (aux[0, a, b].Checked) check_state += (UInt32)(1 << a);
                            if (aux[1, a, b].Checked) check_state += (UInt32)(1 << (6 + a));
                            if (aux[2, a, b].Checked) check_state += (UInt32)(1 << (12 +a));
                            if (aux[3, a, b].Checked) check_state += (UInt32)(1 << (18 + a));
                        }
                        //Highlight active function name
                        if ( (check_state & auxState) != 0) { cb_labels[b].BackColor = Color.Red; cb_labels[b].ForeColor = Color.Yellow; } else { cb_labels[b].BackColor = Color.Transparent; cb_labels[b].ForeColor = Color.White; }
                    }

                    #endregion 
                }

            }

            #endregion

            #region GUIPages.Sensorgraph
            if (tabMain.SelectedIndex == GUIPages.SensorGraph)
            {


                curve_acc_roll.IsVisible = cb_acc_roll.Checked;
                curve_acc_pitch.IsVisible = cb_acc_pitch.Checked;
                curve_acc_z.IsVisible = cb_acc_z.Checked;
                curve_gyro_roll.IsVisible = cb_gyro_roll.Checked;
                curve_gyro_pitch.IsVisible = cb_gyro_pitch.Checked;
                curve_gyro_yaw.IsVisible = cb_gyro_yaw.Checked;
                curve_mag_roll.IsVisible = cb_mag_roll.Checked;
                curve_mag_pitch.IsVisible = cb_mag_pitch.Checked;
                curve_mag_yaw.IsVisible = cb_mag_yaw.Checked;
                curve_alt.IsVisible = cb_alt.Checked;
                curve_head.IsVisible = cb_head.Checked;


                if (cb_acc_roll.Checked) { list_acc_roll.Add((double)xTimeStamp, mw_gui.ax); }
                l_acc_roll.Text = "" + mw_gui.ax;

                if (cb_acc_pitch.Checked) { list_acc_pitch.Add((double)xTimeStamp, mw_gui.ay); }
                l_acc_pitch.Text = "" + mw_gui.ay;

                if (cb_acc_z.Checked) { list_acc_z.Add((double)xTimeStamp, mw_gui.az); }
                l_acc_z.Text = "" + mw_gui.az;

                if (cb_gyro_roll.Checked) { list_gyro_roll.Add((double)xTimeStamp, mw_gui.gx); }
                l_gyro_roll.Text = "" + mw_gui.gx;

                if (cb_gyro_pitch.Checked) { list_gyro_pitch.Add((double)xTimeStamp, mw_gui.gy); }
                l_gyro_pitch.Text = "" + mw_gui.gy;

                if (cb_gyro_yaw.Checked) { list_gyro_yaw.Add((double)xTimeStamp, mw_gui.gz); }
                l_gyro_yaw.Text = "" + mw_gui.gz;

                if (cb_mag_roll.Checked) { list_mag_roll.Add((double)xTimeStamp, mw_gui.magx); }
                l_mag_roll.Text = "" + mw_gui.magx;

                if (cb_mag_pitch.Checked) { list_mag_pitch.Add((double)xTimeStamp, mw_gui.magy); }
                l_mag_pitch.Text = "" + mw_gui.magy;

                if (cb_mag_yaw.Checked) { list_mag_yaw.Add((double)xTimeStamp, mw_gui.magz); }
                l_mag_yaw.Text = "" + mw_gui.magz;

                if (cb_alt.Checked) { list_alt.Add((double)xTimeStamp, (double)mw_gui.EstAlt / 100.0f); }
                l_alt.Text = "" + (double)mw_gui.EstAlt / 100;

                if (cb_head.Checked) { list_head.Add((double)xTimeStamp, mw_gui.heading); }
                l_head.Text = "" + mw_gui.heading;

                if (cb_dbg1.Checked) { list_dbg1.Add((double)xTimeStamp, mw_gui.debug1); }
                l_dbg1.Text = "" + mw_gui.debug1;

                if (cb_dbg2.Checked) { list_dbg2.Add((double)xTimeStamp, mw_gui.debug2); }
                l_dbg2.Text = "" + mw_gui.debug2;

                if (cb_dbg3.Checked) { list_dbg3.Add((double)xTimeStamp, mw_gui.debug3); }
                l_dbg3.Text = "" + mw_gui.debug3;

                if (cb_dbg4.Checked) { list_dbg4.Add((double)xTimeStamp, mw_gui.debug4); }
                l_dbg4.Text = "" + mw_gui.debug4;


                xTimeStamp = xTimeStamp + 1;

                if (xTimeStamp > xScale.Max)
                {
                    double range = xScale.Max - xScale.Min;
                    xScale.Max = xScale.Max + 1;
                    xScale.Min = xScale.Max - range;
                }
                zgMonitor.AxisChange();
                zgMonitor.Invalidate();




            }

            #endregion

            #region GUIPages.FlightDeck

            // TAB FlightDeck
            if (tabMain.SelectedIndex == GUIPages.FlightDeck)
            {


                rc_input_control1.SetRCInputParameters(mw_gui.rcThrottle, mw_gui.rcPitch, mw_gui.rcRoll, mw_gui.rcYaw, mw_gui.rcAUX, AUX_CHANNELS + 4);

                headingIndicatorInstrumentControl1.SetHeadingIndicatorParameters(mw_gui.heading);
                attitudeIndicatorInstrumentControl1.SetArtificalHorizon(-mw_gui.angy, -mw_gui.angx);

                motorsIndicator1.SetMotorsIndicatorParameters(mw_gui.motors, mw_gui.servos, mw_gui.multiType);

                altitude_meter1.SetAlimeterParameters(mw_gui.EstAlt / 100);                     //Control needs input in meter - EstAlt comes in cm
                vertical_speed_indicator1.SetVerticalSpeedIndicatorParameters(mw_gui.vario);    //Control needs input in cm/sec - so vario
                gpsIndicator.SetGPSIndicatorParameters(mw_gui.GPS_directionToHome, mw_gui.GPS_distanceToHome, mw_gui.GPS_numSat, Convert.ToBoolean(mw_gui.GPS_fix), bHomeRecorded, Convert.ToBoolean(mw_gui.GPS_update));
                battery_indicator1.SetVoltage(mw_gui.vBat, gui_settings.cellcount);
                //update indicator lamps

                indACC.SetStatus((mw_gui.present & 1) != 0);
                indBARO.SetStatus((mw_gui.present & 2) != 0);
                indMAG.SetStatus((mw_gui.present & 4) != 0);
                indGPS.SetStatus((mw_gui.present & 8) != 0);
                indSONAR.SetStatus((mw_gui.present & 16) != 0);



                for (int i = 0; i < iCheckBoxItems; i++)
                {
                    if ((mw_gui.mode & (1 << i)) > 0)
                    {
                        indicators[i].SetStatus(true);
                    }
                    else
                    {
                        indicators[i].SetStatus(false);
                    }
                }



                l_cycletime.Text = String.Format("{0:0000} µs", mw_gui.cycleTime);
                l_vbatt.Text = String.Format("{0:0.0} volts", (double)mw_gui.vBat / 10);
                l_powersum.Text = String.Format("{0:0}", mw_gui.pMeterSum);
                l_i2cerrors.Text = String.Format("{0:0}", mw_gui.i2cErrors);

            }

            #endregion

        }

        private void b_reread_rc_options_Click(object sender, EventArgs e)
        {
            MSPquery(MSP.MSP_BOX);
            bOptions_needs_refresh = true;
        }

        private void aux_checked_changed_event(object sender, EventArgs e)
        {
            CheckBoxEx cb = ((CheckBoxEx)(sender));
            if (!check_capability(CAP.EXTENDED_AUX))
            {
                cb.IsHighlighted = cb.Checked == ((mw_gui.activation[cb.item] & (1 << cb.aux * 3 + cb.rclevel)) == 0) ? true : false;
            }
            else
            {
                cb.IsHighlighted = cb.Checked == ((mw_gui.activation[cb.item] & (1 << (cb.aux * 6 + cb.rclevel))) == 0) ? true : false;
            }

        }

        private void b_cal_acc_Click(object sender, EventArgs e)
        {


            if (!isConnected)
            {
                MessageBoxEx.Show(this, "You have to connect to the FC first!", "Not connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBoxEx.Show(this, "Make sure that your copter is leveled!\r\nPress OK when ready, then keep copter steady for 5 seconds.", "Calibrating Accelerometer", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MSPquery(MSP.MSP_ACC_CALIBRATION);
            }

        }

        private void b_cal_mag_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBoxEx.Show(this, "You have to connect to the FC first!", "Not connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBoxEx.Show(this, "After pressing OK please rotate your copter around all three axes\r\n at least a full 360° turn for each axes. You will have 1 minute to finish", "Calibrating Magnetometer", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {

                MSPquery(MSP.MSP_MAG_CALIBRATION);

            }
        }

        private void b_read_settings_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                timer_realtime.Stop();

                while (serialPort.BytesToWrite > 0) ;
                while (serialPort.BytesToRead > 0) ;

                response_counter = 0;

                MSPquery_sync(MSP.MSP_PID,200);
                MSPquery_sync(MSP.MSP_RC_TUNING,200);
                MSPquery_sync(MSP.MSP_IDENT,200);
                MSPquery_sync(MSP.MSP_MISC,200);
                MSPquery_sync(MSP.MSP_SERVO_CONF,200);
                MSPquery_sync(MSP.MSP_BOX,200);
                if (naviGroup.Enabled)
                {
                    MSPquery_sync(MSP.MSP_NAV_CONFIG, 200);
                }


                DateTime startTime = DateTime.Now;
                bool missing_packets = false;

                //Wait for all the responses from the setting reload. Add 2sec timeout for remote situtations
                while (response_counter < 5)
                {
                    if (DateTime.Now.Subtract(startTime).TotalMilliseconds > 3000) { response_counter = 8; missing_packets = true; }
                }

                if (missing_packets) MessageBoxEx.Show("Not all response packets were arrived,\rplease reread parameters to make sure that you see valid parameters.", "Response Packets Lost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                bOptions_needs_refresh = true;
                update_gui();
                timer_realtime.Start();
            }
        }

        private bool isArmed()
        {
            if (mw_gui.sBoxNames != null)
            {
                int i = Array.IndexOf(mw_gui.sBoxNames, "ARM");
                if (indicators != null)
                {
                    return indicators[i].GetStatus();
                }
            }

            return false;

        }


        private void update_params()
        {
            //Get parameters from GUI

            for (int i = 0; i < iPidItems; i++)
            {
                if (Pid[i].Pshown) { mw_gui.pidP[i] = (byte)(Pid[i].Pfield.Value * Pid[i].Pprec); }
                if (Pid[i].Ishown) { mw_gui.pidI[i] = (byte)(Pid[i].Ifield.Value * Pid[i].Iprec); }
                if (Pid[i].Dshown) { mw_gui.pidD[i] = (byte)(Pid[i].Dfield.Value * Pid[i].Dprec); }

                mw_params.pidP[i] = mw_gui.pidP[i];
                mw_params.pidI[i] = mw_gui.pidI[i];
                mw_params.pidD[i] = mw_gui.pidD[i];
            }

            mw_params.RollPitchRate = (byte)(nRATE_rp.Value * 100);
            mw_params.YawRate = (byte)(nRATE_yaw.Value * 100);
            mw_params.DynThrPID = (byte)(nRATE_tpid.Value * 100);

            mw_params.rcExpo = (byte)(nRCExpo.Value * 100);
            mw_params.rcRate = (byte)(nRCRate.Value * 100);
            mw_params.ThrottleMID = (byte)(nTMID.Value * 100);
            mw_params.ThrottleEXPO = (byte)(nTEXPO.Value * 100);



            for (int b = 0; b < iCheckBoxItems; b++)
            {
                mw_params.activation[b] = 0;

                if (!check_capability(CAP.EXTENDED_AUX))
                {
                    for (byte a = 0; a < 3; a++)
                    {
                        if (aux[0, a, b].Checked) mw_params.activation[b] += (UInt32)(1 << a);
                        if (aux[1, a, b].Checked) mw_params.activation[b] += (UInt32)(1 << (3 + a));
                        if (aux[2, a, b].Checked) mw_params.activation[b] += (UInt32)(1 << (6 + a));
                        if (aux[3, a, b].Checked) mw_params.activation[b] += (UInt32)(1 << (9 + a));

                    }
                }
                else
                {
                    for (byte a = 0; a < 6; a++)
                    {
                        if (aux[0, a, b].Checked) mw_params.activation[b] += (UInt32)(1 << a);
                        if (aux[1, a, b].Checked) mw_params.activation[b] += (UInt32)(1 << (6 + a));
                        if (aux[2, a, b].Checked) mw_params.activation[b] += (UInt32)(1 << (12 + a));
                        if (aux[3, a, b].Checked) mw_params.activation[b] += (UInt32)(1 << (18 + a));
                    }
                }

            }

            decimal mag_dec = 0;
            mag_dec = nMagDeg.Value;
            mag_dec += (decimal)nMagMin.Value * (decimal)(1.0 / 60.0);
            if (cbMagSign.SelectedIndex == 1) mag_dec *= -1;
            mw_params.mag_declination = (Int16)(mag_dec * 10);

            mw_params.vbatscale = (byte)nVBatScale.Value;
            mw_params.vbatlevel_warn1 = (byte)nVBatWarn1.Value;
            mw_params.vbatlevel_warn2 = (byte)nVBatWarn2.Value;
            mw_params.vbatlevel_crit = (byte)nVBatCritical.Value;
            mw_params.PowerTrigger = (Int16)nPAlarm.Value;

            mw_params.minThrottle = (UInt16)nMinThr.Value;
            mw_params.failsafe_throttle = (UInt16)nFSThr.Value;

            //Update Servo settings
            for (int i = 0; i < 8; i++)
            {
                mw_params.servoMax[i] = (int)servo_max[i].Value;
                mw_params.servoMin[i] = (int)servo_min[i].Value;
                mw_params.servoMiddle[i] = (int)servo_mid[i].Value;
                mw_params.servoRate[i] = (sbyte)servo_rate[i].Value;

                //So fix for braindead servoconf stuff :(
                if ((CopterType)mw_gui.multiType == CopterType.Tri)
                { // if we have tricopter then the bit0 will decide the direction :(
                    if (servo_reverse[i].Checked == true)
                        mw_params.servoRate[i] = 1;
                    else
                        mw_params.servoRate[i] = 0;
                }
                else
                {
                    if (servo_reverse[i].Checked == true)
                    {
                        mw_params.servoRate[i] *= -1;
                    }
                }

            }

        //update nav params.
            int t = (byte)(cbNavGPS_filtering.Checked ? 0x01 : 0x00) +
                 (byte)(cbNavGPS_Lead.Checked ? 0x02 : 0x00) +
                 (byte)(cbNavResetHome.Checked ? 0x04 : 0x00) +
                 (byte)(cbNavHeadingControl.Checked ? 0x08 : 0x00) +
                 (byte)(cbNavTailFirst.Checked ? 0x10 : 0x00) +
                 (byte)(cbNavRTHHead.Checked ? 0x20 : 0x00) +
                 (byte)(cbNavSlowNav.Checked ? 0x40 : 0x00) +
                 (byte)(cbNavWaitRTHAlt.Checked ? 0x80 : 0x00);
            mw_params.flags1 = (byte)t;

            t = (byte)(cbNavDisableSticks.Checked ? 0x01 : 0x00) +
                (byte)(cbNavBaroTakeover.Checked ? 0x02 : 0x00);  
            mw_params.flags2 = (byte)t;


            mw_params.wp_radius = (ushort)nWPRadius.Value;
            mw_params.rth_altitude = (ushort)nRTHAlt.Value;
            mw_params.crosstrack_gain = (byte)((decimal)nCrosstrack.Value * 100);
            mw_params.nav_speed_max = (ushort)nMaxSpeed.Value;
            mw_params.nav_speed_min = (ushort)nMinSpeed.Value;
            mw_params.nav_bank_max = (ushort)(nBanking.Value * 100);
            mw_params.safe_wp_distance = (ushort)nSafeWPDist.Value;
            mw_params.nav_max_altitude = (ushort)nMaxAlt.Value;
            mw_params.fence = (ushort)nFence.Value;
            mw_params.land_speed = (byte)nLandSpeed.Value;
            mw_params.max_wp_number = mw_gui.max_wp_number;

        }

        private void b_write_settings_Click(object sender, EventArgs e)
        {

            write_parameters();

        }

        private void update_aux_panel()
        {

            if (!check_capability(CAP.EXTENDED_AUX))
            {

                for (int i = 0; i < iCheckBoxItems; i++)
                {
                    aux[0, 0, i].Checked = (mw_gui.activation[i] & (1 << 0)) == 0 ? false : true;
                    aux[0, 1, i].Checked = (mw_gui.activation[i] & (1 << 1)) == 0 ? false : true;
                    aux[0, 2, i].Checked = (mw_gui.activation[i] & (1 << 2)) == 0 ? false : true;
                    aux[1, 0, i].Checked = (mw_gui.activation[i] & (1 << 3)) == 0 ? false : true;
                    aux[1, 1, i].Checked = (mw_gui.activation[i] & (1 << 4)) == 0 ? false : true;
                    aux[1, 2, i].Checked = (mw_gui.activation[i] & (1 << 5)) == 0 ? false : true;
                    aux[2, 0, i].Checked = (mw_gui.activation[i] & (1 << 6)) == 0 ? false : true;
                    aux[2, 1, i].Checked = (mw_gui.activation[i] & (1 << 7)) == 0 ? false : true;
                    aux[2, 2, i].Checked = (mw_gui.activation[i] & (1 << 8)) == 0 ? false : true;
                    aux[3, 0, i].Checked = (mw_gui.activation[i] & (1 << 9)) == 0 ? false : true;
                    aux[3, 1, i].Checked = (mw_gui.activation[i] & (1 << 10)) == 0 ? false : true;
                    aux[3, 2, i].Checked = (mw_gui.activation[i] & (1 << 11)) == 0 ? false : true;
                }

                for (int i = 0; i < iCheckBoxItems; i++)
                {

                    aux[0, 0, i].IsHighlighted = (aux[0, 0, i].Checked == ((mw_gui.activation[i] & (1 << 0)) == 0)) ? true : false;
                    aux[0, 1, i].IsHighlighted = (aux[0, 1, i].Checked == ((mw_gui.activation[i] & (1 << 1)) == 0)) ? true : false;
                    aux[0, 2, i].IsHighlighted = (aux[0, 2, i].Checked == ((mw_gui.activation[i] & (1 << 2)) == 0)) ? true : false;
                    aux[1, 0, i].IsHighlighted = (aux[1, 0, i].Checked == ((mw_gui.activation[i] & (1 << 3)) == 0)) ? true : false;
                    aux[1, 1, i].IsHighlighted = (aux[1, 1, i].Checked == ((mw_gui.activation[i] & (1 << 4)) == 0)) ? true : false;
                    aux[1, 2, i].IsHighlighted = (aux[1, 2, i].Checked == ((mw_gui.activation[i] & (1 << 5)) == 0)) ? true : false;
                    aux[2, 0, i].IsHighlighted = (aux[2, 0, i].Checked == ((mw_gui.activation[i] & (1 << 6)) == 0)) ? true : false;
                    aux[2, 1, i].IsHighlighted = (aux[2, 1, i].Checked == ((mw_gui.activation[i] & (1 << 7)) == 0)) ? true : false;
                    aux[2, 2, i].IsHighlighted = (aux[2, 2, i].Checked == ((mw_gui.activation[i] & (1 << 8)) == 0)) ? true : false;
                    aux[3, 0, i].IsHighlighted = (aux[3, 0, i].Checked == ((mw_gui.activation[i] & (1 << 9)) == 0)) ? true : false;
                    aux[3, 1, i].IsHighlighted = (aux[3, 1, i].Checked == ((mw_gui.activation[i] & (1 << 10)) == 0)) ? true : false;
                    aux[3, 2, i].IsHighlighted = (aux[3, 2, i].Checked == ((mw_gui.activation[i] & (1 << 11)) == 0)) ? true : false;
                }
            }
            else
            {
                for (int i = 0; i < iCheckBoxItems; i++)
                {
                    aux[0, 0, i].Checked = (mw_gui.activation[i] & (1 << 0)) == 0 ? false : true;
                    aux[0, 1, i].Checked = (mw_gui.activation[i] & (1 << 1)) == 0 ? false : true;
                    aux[0, 2, i].Checked = (mw_gui.activation[i] & (1 << 2)) == 0 ? false : true;
                    aux[0, 3, i].Checked = (mw_gui.activation[i] & (1 << 3)) == 0 ? false : true;
                    aux[0, 4, i].Checked = (mw_gui.activation[i] & (1 << 4)) == 0 ? false : true;
                    aux[0, 5, i].Checked = (mw_gui.activation[i] & (1 << 5)) == 0 ? false : true;

                    aux[1, 0, i].Checked = (mw_gui.activation[i] & (1 << 6)) == 0 ? false : true;
                    aux[1, 1, i].Checked = (mw_gui.activation[i] & (1 << 7)) == 0 ? false : true;
                    aux[1, 2, i].Checked = (mw_gui.activation[i] & (1 << 8)) == 0 ? false : true;
                    aux[1, 3, i].Checked = (mw_gui.activation[i] & (1 << 9)) == 0 ? false : true;
                    aux[1, 4, i].Checked = (mw_gui.activation[i] & (1 << 10)) == 0 ? false : true;
                    aux[1, 5, i].Checked = (mw_gui.activation[i] & (1 << 11)) == 0 ? false : true;

                    aux[2, 0, i].Checked = (mw_gui.activation[i] & (1 << 12)) == 0 ? false : true;
                    aux[2, 1, i].Checked = (mw_gui.activation[i] & (1 << 13)) == 0 ? false : true;
                    aux[2, 2, i].Checked = (mw_gui.activation[i] & (1 << 14)) == 0 ? false : true;
                    aux[2, 3, i].Checked = (mw_gui.activation[i] & (1 << 15)) == 0 ? false : true;
                    aux[2, 4, i].Checked = (mw_gui.activation[i] & (1 << 16)) == 0 ? false : true;
                    aux[2, 5, i].Checked = (mw_gui.activation[i] & (1 << 17)) == 0 ? false : true;

                    aux[3, 0, i].Checked = (mw_gui.activation[i] & (1 << 18)) == 0 ? false : true;
                    aux[3, 1, i].Checked = (mw_gui.activation[i] & (1 << 19)) == 0 ? false : true;
                    aux[3, 2, i].Checked = (mw_gui.activation[i] & (1 << 20)) == 0 ? false : true;
                    aux[3, 3, i].Checked = (mw_gui.activation[i] & (1 << 21)) == 0 ? false : true;
                    aux[3, 4, i].Checked = (mw_gui.activation[i] & (1 << 22)) == 0 ? false : true;
                    aux[3, 5, i].Checked = (mw_gui.activation[i] & (1 << 23)) == 0 ? false : true;
                }
                for (int i = 0; i < iCheckBoxItems; i++)
                {

                    aux[0, 0, i].IsHighlighted = (aux[0, 0, i].Checked == ((mw_gui.activation[i] & (1 << 0)) == 0)) ? true : false;
                    aux[0, 1, i].IsHighlighted = (aux[0, 1, i].Checked == ((mw_gui.activation[i] & (1 << 1)) == 0)) ? true : false;
                    aux[0, 2, i].IsHighlighted = (aux[0, 2, i].Checked == ((mw_gui.activation[i] & (1 << 2)) == 0)) ? true : false;
                    aux[0, 3, i].IsHighlighted = (aux[0, 3, i].Checked == ((mw_gui.activation[i] & (1 << 3)) == 0)) ? true : false;
                    aux[0, 4, i].IsHighlighted = (aux[0, 4, i].Checked == ((mw_gui.activation[i] & (1 << 4)) == 0)) ? true : false;
                    aux[0, 5, i].IsHighlighted = (aux[0, 5, i].Checked == ((mw_gui.activation[i] & (1 << 5)) == 0)) ? true : false;

                    aux[1, 0, i].IsHighlighted = (aux[1, 0, i].Checked == ((mw_gui.activation[i] & (1 << 6)) == 0)) ? true : false;
                    aux[1, 1, i].IsHighlighted = (aux[1, 1, i].Checked == ((mw_gui.activation[i] & (1 << 7)) == 0)) ? true : false;
                    aux[1, 2, i].IsHighlighted = (aux[1, 2, i].Checked == ((mw_gui.activation[i] & (1 << 8)) == 0)) ? true : false;
                    aux[1, 3, i].IsHighlighted = (aux[1, 3, i].Checked == ((mw_gui.activation[i] & (1 << 9)) == 0)) ? true : false;
                    aux[1, 4, i].IsHighlighted = (aux[1, 4, i].Checked == ((mw_gui.activation[i] & (1 << 10)) == 0)) ? true : false;
                    aux[1, 5, i].IsHighlighted = (aux[1, 5, i].Checked == ((mw_gui.activation[i] & (1 << 11)) == 0)) ? true : false;

                    aux[2, 0, i].IsHighlighted = (aux[2, 0, i].Checked == ((mw_gui.activation[i] & (1 << 12)) == 0)) ? true : false;
                    aux[2, 1, i].IsHighlighted = (aux[2, 1, i].Checked == ((mw_gui.activation[i] & (1 << 13)) == 0)) ? true : false;
                    aux[2, 2, i].IsHighlighted = (aux[2, 2, i].Checked == ((mw_gui.activation[i] & (1 << 14)) == 0)) ? true : false;
                    aux[2, 3, i].IsHighlighted = (aux[2, 3, i].Checked == ((mw_gui.activation[i] & (1 << 15)) == 0)) ? true : false;
                    aux[2, 4, i].IsHighlighted = (aux[2, 4, i].Checked == ((mw_gui.activation[i] & (1 << 16)) == 0)) ? true : false;
                    aux[2, 5, i].IsHighlighted = (aux[2, 5, i].Checked == ((mw_gui.activation[i] & (1 << 17)) == 0)) ? true : false;

                    aux[3, 0, i].IsHighlighted = (aux[3, 0, i].Checked == ((mw_gui.activation[i] & (1 << 18)) == 0)) ? true : false;
                    aux[3, 1, i].IsHighlighted = (aux[3, 1, i].Checked == ((mw_gui.activation[i] & (1 << 19)) == 0)) ? true : false;
                    aux[3, 2, i].IsHighlighted = (aux[3, 2, i].Checked == ((mw_gui.activation[i] & (1 << 20)) == 0)) ? true : false;
                    aux[3, 3, i].IsHighlighted = (aux[3, 3, i].Checked == ((mw_gui.activation[i] & (1 << 21)) == 0)) ? true : false;
                    aux[3, 4, i].IsHighlighted = (aux[3, 4, i].Checked == ((mw_gui.activation[i] & (1 << 22)) == 0)) ? true : false;
                    aux[3, 5, i].IsHighlighted = (aux[3, 5, i].Checked == ((mw_gui.activation[i] & (1 << 23)) == 0)) ? true : false;

                }

            }

        }

        private void update_pid_panel()
        {
            //fill out PID values from mw_gui. structure

            for (int i = 0; i < iPidItems; i++)
            {
                if (Pid[i].Pshown) { Pid[i].Pfield.Value = (decimal)mw_gui.pidP[i] / Pid[i].Pprec; Pid[i].Pfield.BackColor = Color.White; }
                if (Pid[i].Ishown) { Pid[i].Ifield.Value = (decimal)mw_gui.pidI[i] / Pid[i].Iprec; Pid[i].Ifield.BackColor = Color.White; }
                if (Pid[i].Dshown) { Pid[i].Dfield.Value = (decimal)mw_gui.pidD[i] / Pid[i].Dprec; Pid[i].Dfield.BackColor = Color.White; }

            }

            nRATE_rp.Value = (decimal)mw_gui.RollPitchRate / 100;
            nRATE_rp.BackColor = Color.White;
            nRATE_yaw.Value = (decimal)mw_gui.YawRate / 100;
            nRATE_yaw.BackColor = Color.White;
            nRATE_tpid.Value = (decimal)mw_gui.DynThrPID / 100;
            nRATE_tpid.BackColor = Color.White;

            trackbar_RC_Expo.Value = mw_gui.rcExpo;
            nRCExpo.Value = (decimal)mw_gui.rcExpo / 100;
            nRCExpo.BackColor = Color.White;
            trackbar_RC_Rate.Value = mw_gui.rcRate;
            nRCRate.Value = (decimal)mw_gui.rcRate / 100;
            nRCRate.BackColor = Color.White;

            rc_expo_control1.SetRCExpoParameters((double)mw_gui.rcRate / 100, (double)mw_gui.rcExpo / 100);

            nTEXPO.Value = (decimal)mw_gui.ThrottleEXPO / 100;
            nTEXPO.BackColor = Color.White;
            trackBar_T_EXPO.Value = mw_gui.ThrottleEXPO;
            nTMID.Value = (decimal)mw_gui.ThrottleMID / 100;
            nTMID.BackColor = Color.White;
            trackBar_T_MID.Value = mw_gui.ThrottleMID;
            throttle_expo_control1.SetRCExpoParameters((double)mw_gui.ThrottleMID / 100, (double)mw_gui.ThrottleEXPO / 100, mw_gui.rcThrottle);



        }

        private void update_gui_from_params()
        {
            for (int i = 0; i < iCheckBoxItems; i++)
            {
                aux[0, 0, i].Checked = (mw_params.activation[i] & (1 << 0)) == 0 ? false : true;
                aux[0, 1, i].Checked = (mw_params.activation[i] & (1 << 1)) == 0 ? false : true;
                aux[0, 2, i].Checked = (mw_params.activation[i] & (1 << 2)) == 0 ? false : true;
                aux[1, 0, i].Checked = (mw_params.activation[i] & (1 << 3)) == 0 ? false : true;
                aux[1, 1, i].Checked = (mw_params.activation[i] & (1 << 4)) == 0 ? false : true;
                aux[1, 2, i].Checked = (mw_params.activation[i] & (1 << 5)) == 0 ? false : true;
                aux[2, 0, i].Checked = (mw_params.activation[i] & (1 << 6)) == 0 ? false : true;
                aux[2, 1, i].Checked = (mw_params.activation[i] & (1 << 7)) == 0 ? false : true;
                aux[2, 2, i].Checked = (mw_params.activation[i] & (1 << 8)) == 0 ? false : true;
                aux[3, 0, i].Checked = (mw_params.activation[i] & (1 << 9)) == 0 ? false : true;
                aux[3, 1, i].Checked = (mw_params.activation[i] & (1 << 10)) == 0 ? false : true;
                aux[3, 2, i].Checked = (mw_params.activation[i] & (1 << 11)) == 0 ? false : true;
            }
            //fill out PID values from mw_gui. structure

            for (int i = 0; i < iPidItems; i++)
            {
                if (Pid[i].Pshown) { Pid[i].Pfield.Value = (decimal)mw_params.pidP[i] / Pid[i].Pprec; }
                if (Pid[i].Ishown) { Pid[i].Ifield.Value = (decimal)mw_params.pidI[i] / Pid[i].Iprec; }
                if (Pid[i].Dshown) { Pid[i].Dfield.Value = (decimal)mw_params.pidD[i] / Pid[i].Dprec; }

            }

            nRATE_rp.Value = (decimal)mw_params.RollPitchRate / 100;
            nRATE_yaw.Value = (decimal)mw_params.YawRate / 100;
            nRATE_tpid.Value = (decimal)mw_params.DynThrPID / 100;

            trackbar_RC_Expo.Value = mw_params.rcExpo;
            nRCExpo.Value = (decimal)mw_params.rcExpo / 100;
            trackbar_RC_Rate.Value = mw_params.rcRate;
            nRCRate.Value = (decimal)mw_params.rcRate / 100;
            rc_expo_control1.SetRCExpoParameters((double)mw_params.rcRate / 100, (double)mw_params.rcExpo / 100);

            nTEXPO.Value = (decimal)mw_params.ThrottleEXPO / 100;
            trackBar_T_EXPO.Value = mw_params.ThrottleEXPO;
            nTMID.Value = (decimal)mw_params.ThrottleMID / 100;
            trackBar_T_MID.Value = mw_params.ThrottleMID;
            throttle_expo_control1.SetRCExpoParameters((double)mw_params.ThrottleMID / 100, (double)mw_params.ThrottleEXPO / 100, mw_gui.rcThrottle);

            nPAlarm.Value = mw_params.PowerTrigger;

            label49.Text = "(" + Convert.ToString((decimal)mw_params.mag_declination / 10) + ")";
            decimal mag_dec = (decimal)mw_params.mag_declination / 10;
            if (mag_dec < 0) cbMagSign.SelectedIndex = 1;
            else cbMagSign.SelectedIndex = 0;
            mag_dec = Math.Abs(mag_dec);
            nMagDeg.Value = (int)mag_dec;
            nMagMin.Value = (mag_dec - (int)mag_dec) * 60;

            //Update Power parameters
            nVBatScale.Value = (int)mw_params.vbatscale;
            nVBatWarn1.Value = (int)mw_params.vbatlevel_warn1;
            nVBatWarn2.Value = (int)mw_params.vbatlevel_warn2;
            nVBatCritical.Value = (int)mw_params.vbatlevel_crit;

            //Update throttle params
            nMinThr.Value = mw_params.minThrottle;
            nFSThr.Value = mw_params.failsafe_throttle;

            for (int i = 0; i < 8; i++)
            {


                servo_max[i].Value = mw_params.servoMax[i];
                servo_min[i].Value = mw_params.servoMin[i];
                servo_mid[i].Value = mw_params.servoMiddle[i];
                servo_rate[i].Value = Math.Abs(mw_params.servoRate[i]);
                if (mw_params.servoRate[i] < 0)
                {
                    servo_reverse[i].Checked = true;
                }
                else
                {
                    servo_reverse[i].Checked = false;
                }
            }




        }

        private void b_write_to_file_Click(object sender, EventArgs e)
        {
            update_params();                    //Move values from GUI to the settings object
            SaveFileDialog sfdSaveParameters = new SaveFileDialog();
            sfdSaveParameters.Filter = "MultiWii Settings File|*.mws";
            sfdSaveParameters.Title = "Save parameters to file";
            sfdSaveParameters.InitialDirectory = gui_settings.sSettingsFolder;

            string invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
            string invalidReStr = string.Format(@"[{0} ]+", invalidChars);
            string fn = String.Format("{0:yymmdd-hhmm}", DateTime.Now);
            sfdSaveParameters.FileName = fn;


            sfdSaveParameters.ShowDialog();

            if (sfdSaveParameters.FileName != "")
            {
                mw_params.save_to_xml(sfdSaveParameters.FileName);
            }
        }

        private void b_load_from_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdLoadParameters = new OpenFileDialog();
            ofdLoadParameters.Filter = "MultiWii Settings File|*.mws";
            ofdLoadParameters.Title = "Load parameters from file";
            ofdLoadParameters.InitialDirectory = gui_settings.sSettingsFolder;
            if (ofdLoadParameters.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { //we have file to open
                if (mw_params.read_from_xml(ofdLoadParameters.FileName))
                { update_gui_from_params(); }
            }

        }

        private void mainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {

            timer_realtime.Stop();                       //Stop timer(s), whatever it takes
            bkgWorker.CancelAsync();
            System.Threading.Thread.Sleep(500);         //Wait for 1 cycle to let backgroundworker finish it's last job.
            if (isConnected) { serialPort.Close(); }

            if (bVideoRecording)          //If recording stop it.
            {
                vfwWriter.Close();
            }

            videoSourcePlayer.SignalToStop();
            videoSourcePlayer.WaitForStop();

        }

        private void b_select_log_folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = gui_settings.sLogFolder;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                gui_settings.sLogFolder = folderBrowserDialog1.SelectedPath;
                l_LogFolder.Text = gui_settings.sLogFolder;
                b_save_gui_settings.BackColor = Color.LightCoral;
            }

        }

        private void b_select_capture_folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = gui_settings.sCaptureFolder;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                gui_settings.sCaptureFolder = folderBrowserDialog1.SelectedPath;
                l_Capture_folder.Text = gui_settings.sCaptureFolder;
                b_save_gui_settings.BackColor = Color.LightCoral;
            }
        }

        private void b_select_settings_folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = gui_settings.sSettingsFolder;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                gui_settings.sSettingsFolder = folderBrowserDialog1.SelectedPath;
                l_Settings_folder.Text = gui_settings.sSettingsFolder;
                b_save_gui_settings.BackColor = Color.LightCoral;
            }

        }

        private void cbGUISpeechEnabled_CheckedChanged(object sender, EventArgs e)
        {
            gui_settings.speech_enabled = cbGUISpeechEnabled.Checked;
            b_save_gui_settings.BackColor = Color.LightCoral;

        }

        private void b_save_gui_settings_Click(object sender, EventArgs e)
        {

            gui_settings.save_to_xml(sGuiSettingsFilename);
            b_save_gui_settings.BackColor = Color.Transparent;
            //Save settings to the settings file


            //Check if restart needed
            if (bRestartNeeded)
            {
                MessageBoxEx.Show(this, "For changing MultiWii FC SW version, you have to restart MultiWiiWinGUI. Press OK to close this app, then please start it again manually", "MWWGUI Restart needed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Environment.Exit(-1);
            }
        }

        private void cb_Logging_enabled_Click(object sender, EventArgs e)
        {
            gui_settings.bEnableLogging = cb_Logging_enabled.Checked;
            b_save_gui_settings.BackColor = Color.LightCoral;
        }

        private void b_about_Click(object sender, EventArgs e)
        {
            frmAbout aboutform = new frmAbout();
            aboutform.sVersionLabel = sVersion;
            aboutform.sFcVersionLabel = "MultiWii version " + sRelName;
            aboutform.ShowDialog();
        }

        private void log_option_Clicked(object sender, EventArgs e)
        {
            gui_settings.logGraw = cb_Log1.Checked;
            gui_settings.logGatt = cb_Log2.Checked;
            gui_settings.logGmag = cb_Log3.Checked;
            gui_settings.logGrcc = cb_Log4.Checked;
            gui_settings.logGrcx = cb_Log5.Checked;
            gui_settings.logGmot = cb_Log6.Checked;
            gui_settings.logGsrv = cb_Log7.Checked;
            gui_settings.logGnav = cb_Log8.Checked;
            gui_settings.logGpar = cb_Log9.Checked;
            gui_settings.logGdbg = cb_Log10.Checked;
            b_save_gui_settings.BackColor = Color.LightCoral;
        }

        private void b_check_update_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.AppStarting;
                doc = XDocument.Load(sVersionUrl, LoadOptions.None);
                sVersionFromSVN = doc.Element("application").Element("version").Value;
                string sCommentFromSVN = doc.Element("application").Element("comment").Value;
                this.Cursor = Cursors.Default;
                if (String.Compare(sVersionFromSVN, sVersion) == 0)
                {
                    MessageBoxEx.Show(this, "You have the latest version : " + sVersionFromSVN, "No update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBoxEx.Show(this, "A new version : " + sVersionFromSVN + " is available\r\n" + sCommentFromSVN + "\r\nYou can download it from http://code.google.com/p/mw-wingui/downloads/list", "Update available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBoxEx.Show(this, "Not Able to connect to SVN for version info");
            }

        }

        private void attitudeIndicatorInstrumentControl1_Click(object sender, EventArgs e)
        {
            Point c = System.Windows.Forms.Cursor.Position;
            Point p = attitudeIndicatorInstrumentControl1.PointToClient(c);

            attitudeIndicatorInstrumentControl1.ToggleArtificalHorizonType();

        }

        private int decimals(int prec)
        {
            if (prec == 1) return (0);
            if (prec == 10) return (1);
            if (prec == 100) return (2);
            if (prec == 1000) return (3);

            return (0);
        }

        private void trackBar_T_MID_Scroll(object sender, EventArgs e)
        {
            nTMID.Value = (decimal)trackBar_T_MID.Value / 100;
            throttle_expo_control1.SetRCExpoParameters((double)nTMID.Value, (double)nTEXPO.Value, mw_gui.rcThrottle);
        }

        private void trackBar_T_EXPO_Scroll(object sender, EventArgs e)
        {
            nTEXPO.Value = (decimal)trackBar_T_EXPO.Value / 100;
            throttle_expo_control1.SetRCExpoParameters((double)nTMID.Value, (double)nTEXPO.Value, mw_gui.rcThrottle);
        }

        private void nTMID_ValueChanged(object sender, EventArgs e)
        {
            trackBar_T_MID.Value = (int)(nTMID.Value * 100);
            throttle_expo_control1.SetRCExpoParameters((double)nTMID.Value, (double)nTEXPO.Value, mw_gui.rcThrottle);
            if ((int)(nTMID.Value * 100) != mw_gui.ThrottleMID)
            {
                nTMID.BackColor = Color.IndianRed;
            }
            else
            {
                nTMID.BackColor = Color.White;
            }

        }

        private void nTEXPO_ValueChanged(object sender, EventArgs e)
        {
            trackBar_T_EXPO.Value = (int)(nTEXPO.Value * 100);
            throttle_expo_control1.SetRCExpoParameters((double)nTMID.Value, (double)nTEXPO.Value, mw_gui.rcThrottle);
            if ((int)(nTEXPO.Value * 100) != mw_gui.ThrottleEXPO)
            {
                nTEXPO.BackColor = Color.IndianRed;
            }
            else
            {
                nTEXPO.BackColor = Color.White;
            }

        }

        private void b_log_Click(object sender, EventArgs e)
        {
            if (bLogRunning)        //Close
            {

                closeLog();
                b_log.Text = "Start Log";
                b_log.BackColor = Color.Gray;
                b_log.Image = Properties.Resources.start_log;

            }
            else
            {
                openLog();
                if (bLogRunning)
                {
                    b_log.Text = "Stop Log";
                    b_log.BackColor = Color.IndianRed;
                    b_log.Image = Properties.Resources.stop_log;
                }
            }
        }

        void openLog()
        {
            try
            {
                wLogStream = new StreamWriter(gui_settings.sLogFolder + "\\mwguilog" + String.Format("-{0:yyyyMMdd-hhmm}.log", DateTime.Now));
            }
            catch
            {
                MessageBox.Show("Unable to open log file at " + gui_settings.sLogFolder + "\\mwguilog" + String.Format("-{0:yyyyMMdd-hhmm}.log", DateTime.Now), "Error opening log", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (wLogStream != null)
            {
                bLogRunning = true;
                wLogStream.WriteLine("MultiWii telemetry log. Start time:{0}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
            }

        }

        void closeLog()
        {
            wLogStream.Flush();
            wLogStream.Close();
            wLogStream.Dispose();
            bLogRunning = false;
        }

        void openKMLLog()
        {

            try
            {
                wKMLLogStream = new StreamWriter(gui_settings.sLogFolder + "\\mwgpstrack" + String.Format("-{0:yyyyMMdd-hhmm}.kml", DateTime.Now));
            }
            catch
            {
                MessageBox.Show("Unable to open KMLlog file at " + gui_settings.sLogFolder + "\\mwgpstrack" + String.Format("-{0:yyyyMMdd-hhmm}.kml", DateTime.Now), "Error opening KMLlog", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (wKMLLogStream != null)
            {
                wKMLLogStream.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                wKMLLogStream.WriteLine("<kml xmlns=\"http://www.opengis.net/kml/2.2\" xmlns:gx=\"http://www.google.com/kml/ext/2.2\">");
                wKMLLogStream.WriteLine("<Document>");
                wKMLLogStream.WriteLine("<Placemark>");
                wKMLLogStream.WriteLine("<Style><LineStyle><color>#ef00ffff</color><width>5</width></LineStyle></Style>");
                wKMLLogStream.WriteLine("<name>MultiWii flight log</name>");
                wKMLLogStream.WriteLine("<LineString>");
                wKMLLogStream.WriteLine("<altitudeMode>absolute</altitudeMode>");
                wKMLLogStream.WriteLine("<tessellate>1</tessellate>");
                wKMLLogStream.WriteLine("<coordinates>");
                bKMLLogRunning = true;
            }
        }

        void closeKMLLog()
        {

            wKMLLogStream.WriteLine("</coordinates>");
            wKMLLogStream.WriteLine("</LineString>");
            wKMLLogStream.WriteLine("</Placemark>");
            wKMLLogStream.WriteLine("</Document>");
            wKMLLogStream.WriteLine("</kml>");
            wKMLLogStream.Flush();
            wKMLLogStream.Close();
            wKMLLogStream.Dispose();
            bKMLLogRunning = false;
        }

        void updateLog()                //Update log with the neccessary entries, caller must check if log is open and enabled
        {

            //Check mode changes, and add log entry with the new modes if change occured
            if (last_mode_flags != mw_gui.mode)
            {
                wLogStream.Write("GMOD,{0}", DateTime.Now.ToString("HH:mm:ss.fff"));
                for (int i = 0; i < iCheckBoxItems; i++)
                {
                    if (isBoxActive(i)) wLogStream.Write(",{0}", mw_gui.sBoxNames[i]);
                }
                wLogStream.WriteLine("");
                last_mode_flags = mw_gui.mode;
            }

            //RAW Sensor (acc, gyro)
            if (gui_settings.logGraw) { wLogStream.WriteLine("GRAW,{0},{1},{2},{3},{4},{5},{6}", DateTime.Now.ToString("HH:mm:ss.fff"), mw_gui.ax, mw_gui.ay, mw_gui.az, mw_gui.gx, mw_gui.gy, mw_gui.gz); }
            //Attitude
            if (gui_settings.logGatt) { wLogStream.WriteLine("GATT,{0},{1},{2}", DateTime.Now.ToString("HH:mm:ss.fff"), mw_gui.angx, mw_gui.angy); }
            //Mag, head, baro
            if (gui_settings.logGmag) { wLogStream.WriteLine("GMAG,{0},{1},{2},{3},{4},{5}", DateTime.Now.ToString("HH:mm:ss.fff"), mw_gui.magx, mw_gui.magy, mw_gui.magz, mw_gui.heading, mw_gui.EstAlt); }
            //RC controls 
            if (gui_settings.logGrcc) { wLogStream.WriteLine("GRCC,{0},{1},{2},{3},{4}", DateTime.Now.ToString("HH:mm:ss.fff"), mw_gui.rcThrottle, mw_gui.rcPitch, mw_gui.rcRoll, mw_gui.rcYaw); }
            //RC Aux controls
            if (gui_settings.logGrcx) { wLogStream.WriteLine("GRCX,{0},{1},{2},{3},{4}", DateTime.Now.ToString("HH:mm:ss.fff"), mw_gui.rcAUX[0], mw_gui.rcAUX[1], mw_gui.rcAUX[2], mw_gui.rcAUX[3], mw_gui.rcAUX[4], mw_gui.rcAUX[5], mw_gui.rcAUX[6], mw_gui.rcAUX[7]); }
            //Motors
            if (gui_settings.logGmot) { wLogStream.WriteLine("GMOT,{0},{1},{2},{3},{4},{5},{6},{7},{8}", DateTime.Now.ToString("HH:mm:ss.fff"), mw_gui.motors[0], mw_gui.motors[1], mw_gui.motors[2], mw_gui.motors[3], mw_gui.motors[4], mw_gui.motors[5], mw_gui.motors[6], mw_gui.motors[7]); }
            //Servos
            if (gui_settings.logGsrv) { wLogStream.WriteLine("GSRV,{0},{1},{2},{3},{4},{5},{6},{7},{8}", DateTime.Now.ToString("HH:mm:ss.fff"), mw_gui.servos[0], mw_gui.servos[1], mw_gui.servos[2], mw_gui.servos[3], mw_gui.servos[4], mw_gui.servos[5], mw_gui.servos[6], mw_gui.servos[7]); }
            // Nav-GPS
            if (gui_settings.logGnav) { wLogStream.WriteLine("GNAV,{0},{1},{2},{3},{4}", DateTime.Now.ToString("HH:mm:ss.fff"), mw_gui.GPS_fix, mw_gui.GPS_numSat, mw_gui.GPS_directionToHome, mw_gui.GPS_distanceToHome); }
            // Housekeeping
            if (gui_settings.logGpar) { wLogStream.WriteLine("GPAR,{0},{1},{2},{3},{4}", DateTime.Now.ToString("HH:mm:ss.fff"), mw_gui.cycleTime, mw_gui.i2cErrors, mw_gui.vBat, mw_gui.pMeterSum); }
            //Debug
            if (gui_settings.logGdbg) { wLogStream.WriteLine("GDBG,{0},{1},{2},{3},{4}", DateTime.Now.ToString("HH:mm:ss.fff"), mw_gui.debug1, mw_gui.debug2, mw_gui.debug3, mw_gui.debug4); }



        }

        void addKMLMarker(string description, double lon, double lat, double alt)
        {
            //Close open LineStringPlacemark
            wKMLLogStream.WriteLine("</coordinates>");
            wKMLLogStream.WriteLine("</LineString>");
            wKMLLogStream.WriteLine("</Placemark>");

            wKMLLogStream.WriteLine("<Placemark>");
            wKMLLogStream.WriteLine("<name>" + description + "</name>");
            wKMLLogStream.WriteLine("<Point>");
            wKMLLogStream.WriteLine("<altitudeMode>absolute</altitudeMode>");
            wKMLLogStream.WriteLine("<coordinates>");
            wKMLLogStream.WriteLine("{0},{1},{2}", (decimal)lon / 10000000, (decimal)lat / 10000000, alt);
            wKMLLogStream.WriteLine("</coordinates>");
            wKMLLogStream.WriteLine("</Point>");
            wKMLLogStream.WriteLine("</Placemark>");

            //open another LineString
            wKMLLogStream.WriteLine("<Placemark>");
            wKMLLogStream.WriteLine("<Style><LineStyle><color>#ef00ffff</color><width>5</width></LineStyle></Style>");
            wKMLLogStream.WriteLine("<name>MultiWii flight log</name>");
            wKMLLogStream.WriteLine("<LineString>");
            wKMLLogStream.WriteLine("<altitudeMode>absolute</altitudeMode>");
            wKMLLogStream.WriteLine("<tessellate>1</tessellate>");
            wKMLLogStream.WriteLine("<coordinates>");


        }

        private void AddPOIMarker(string tag, double lng, double lat)
        {
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker m = new GMapMarkerMissionStep(point, Convert.ToByte(tag), WP_ACTION.SET_POI);
            m.Tag = tag;

            GMapMarkerRect mBorders = new GMapMarkerRect(point);
            {
                mBorders.InnerMarker = m;
                mBorders.wprad = (int)mw_gui.wp_radius / 100;
                mBorders.MainMap = MainMap;
            }

            GMOverlayPOI.Markers.Add(m);
            GMOverlayPOI.Markers.Add(mBorders);

        }

        private void AddWPMarker(string tag, double lng, double lat, int alt, Color? color, int markertype)
        {
            PointLatLng point = new PointLatLng(lat, lng);

            GMapMarker m = new GMapMarkerMissionStep(point, Convert.ToByte(tag), (byte)markertype);
            m.Tag = tag;

            GMapMarkerRect mBorders = new GMapMarkerRect(point);
            {
                mBorders.InnerMarker = m;
                mBorders.wprad = (int)mw_gui.wp_radius/100;
                mBorders.MainMap = MainMap;
                if (color.HasValue)
                {
                    mBorders.Color = color.Value;
                }
            }

            GMOverlayWaypoints.Markers.Add(m);
            GMOverlayWaypoints.Markers.Add(mBorders);
        }

        void RegenerateMissionRoute()
        {
            List<PointLatLng> polygonPoints = new List<PointLatLng>();

            if (GMOverlayWaypoints == null)
                return;

            foreach (GMapMarker m in GMOverlayWaypoints.Markers)
            {
                if (m is GMapMarkerRect)
                {
                    m.Tag = polygonPoints.Count;
                    polygonPoints.Add(m.Position);
                }
            }
            if (GMRouteMission == null)
            {
                GMRouteMission = new GMapRoute(polygonPoints, "wp route");
                GMRouteMission.Stroke = new Pen(Color.Aquamarine, 3);

                GMOverlayMission.Routes.Add(GMRouteMission);
            }
            else
            {
                GMRouteMission.Points.Clear();
                GMRouteMission.Points.AddRange(polygonPoints);

                if (GMOverlayMission.Routes.Count == 0)
                {
                    GMOverlayMission.Routes.Add(GMRouteMission);
                }
                else
                {
                    MainMap.UpdateRouteLocalPosition(GMRouteMission);
                }
            }
            GMOverlayMission.IsVisibile = false;
            MainMap.Invalidate(false);
            GMOverlayMission.IsVisibile = true;
            MainMap.Invalidate(false);

        }

        void MainMap_OnMapZoomChanged()
        {
            if (MainMap.Zoom > 0)
            {
                center.Position = MainMap.Position;
            }
        }

        void MainMap_OnCurrentPositionChanged(PointLatLng point)
        {
            if (point.Lat > 90) { point.Lat = 90; }
            if (point.Lat < -90) { point.Lat = -90; }
            if (point.Lng > 180) { point.Lng = 180; }
            if (point.Lng < -180) { point.Lng = -180; }
            center.Position = point;
            LMousePos.Text = "Lat:" + String.Format("{0:0.000000}", point.Lat) + " Lon:" + String.Format("{0:0.000000}", point.Lng);

        }

        void MainMap_OnMarkerLeave(GMapMarker item)
        {
            if (!isMouseDown)
            {
                if (item is GMapMarkerRect)
                {
                    CurentRectMarker = null;

                    GMapMarkerRect rc = item as GMapMarkerRect;
                    rc.Pen.Color = Color.Blue;
                    MainMap.Invalidate(false);
                }
            }
        }

        void MainMap_OnMarkerEnter(GMapMarker item)
        {
            if (!isMouseDown)
            {
                if (item is GMapMarkerRect)
                {
                    GMapMarkerRect rc = item as GMapMarkerRect;
                    rc.Pen.Color = Color.Green;
                    MainMap.Invalidate(false);
                    CurentRectMarker = rc;
                    int answer;
                    if (item.Tag != null && rc.InnerMarker != null && int.TryParse(rc.InnerMarker.Tag.ToString(), out answer))
                    {
                        try
                        {
                            missionDataGrid.CurrentCell = missionDataGrid[0, answer - 1];
                            item.ToolTipText = "Altitude: " + missionDataGrid[ALTCOL.Index, answer - 1].Value.ToString()+"m";
                            item.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        }
                        catch { }
                    }





                }
            }
        }

        void MainMap_MouseUp(object sender, MouseEventArgs e)
        {
            end = MainMap.FromLocalToLatLng(e.X, e.Y);

            if (e.Button == MouseButtons.Right && bGoToClikEnabled) // Right Click is the click to is enabled
            {
                PointLatLng pointClickToGo = new PointLatLng(end.Lat, end.Lng);
                GMOverlayLiveData.Markers.Remove(markerGoToClick);
                markerGoToClick = new GMapMarkerFlyHere(pointClickToGo);
                GMOverlayLiveData.Markers.Add(markerGoToClick);

                //Send the WP command, set waypoint 255 (poshold)
                if (cbSendGTCAlt.Checked)
                {
                    sendWPToMultiWii(serialPort, 255, WP_ACTION.HOLD_UNLIM, end.Lat, end.Lng, Convert.ToInt32(txtGTCAlt.Text), 0, 0, 0, 0);
                }
                else
                {
                    sendWPToMultiWii(serialPort, 255, WP_ACTION.HOLD_UNLIM, end.Lat, end.Lng, 0, 0, 0, 0, 0);
                }
                return;
            }

            if (isMouseDown) // mouse down on some other object and dragged to here.
            {
                if (e.Button == MouseButtons.Left)
                {
                    isMouseDown = false;
                }
                if (!isMouseDraging)
                {
                    if (CurentRectMarker != null)
                    {
                        // cant add WP in existing rect
                    }
                    else
                    {
                        if (Control.ModifierKeys == Keys.Control)
                            addWP("WAYPOINT", 0,0,0, currentMarker.Position.Lat, currentMarker.Position.Lng, iDefAlt);
                    }
                }
                else
                {
                    if (CurentRectMarker != null)
                    {
                        dragMarkerCallback(CurentRectMarker.InnerMarker.Tag.ToString(), currentMarker.Position.Lat, currentMarker.Position.Lng, -1);
                        //update existing point in datagrid
                    }
                }
            }

            isMouseDraging = false;
        }

        void MainMap_MouseDown(object sender, MouseEventArgs e)
        {
            start = MainMap.FromLocalToLatLng(e.X, e.Y);

            if (e.Button == MouseButtons.Left && Control.ModifierKeys != Keys.Alt)
            {
                isMouseDown = true;
                isMouseDraging = false;

                if (currentMarker.IsVisible)
                {
                    currentMarker.Position = MainMap.FromLocalToLatLng(e.X, e.Y);
                }
            }
        }

        void MainMap_MouseMove(object sender, MouseEventArgs e)
        {
            PointLatLng point = MainMap.FromLocalToLatLng(e.X, e.Y);

            currentMarker.Position = point;

            if (!isMouseDown)
            {
                LMousePos.Text = "Lat:" + String.Format("{0:0.000000}", point.Lat) + " Lon:" + String.Format("{0:0.000000}", point.Lng);
                if (GMRouteMission != null)
                {
                    if (GMRouteMission.Points.Count >= 1)
                    {
                        double dist_from_last = MainMap.MapProvider.Projection.GetDistance(GMRouteMission.Points[GMRouteMission.Points.Count - 1], point);
                        lDistLastWP.Text = String.Format("Dist. from last WP:{0:N1}m", dist_from_last * 1000);
                    }
                }
            }

            if (Control.ModifierKeys == Keys.Shift)
            {
                return;
            }

            
            //dragging
            if (e.Button == MouseButtons.Left && isMouseDown && Control.ModifierKeys == Keys.None)
            {
                isMouseDraging = true;
                if (CurentRectMarker == null) // left click pan
                {
                    double latdif = start.Lat - point.Lat;
                    double lngdif = start.Lng - point.Lng;
                    MainMap.Position = new PointLatLng(center.Position.Lat + latdif, center.Position.Lng + lngdif);
                }
                else
                {

                    PointLatLng pnew = MainMap.FromLocalToLatLng(e.X, e.Y);

                    int? pIndex = (int?)CurentRectMarker.Tag;
                    if (pIndex.HasValue)
                    {
                        if (pIndex < GMRouteMission.Points.Count)
                        {
                            GMRouteMission.Points[pIndex.Value] = pnew;
                            MainMap.UpdateRouteLocalPosition(GMRouteMission);
                            lDistance.Text = String.Format("Mission total dist.:{0:N1} m", GMRouteMission.Distance * 1000);

                            if (pIndex == 0)            //Dragging the first marker
                            {
                                if (GMRouteMission.Points.Count > 1)  //We have more than 1 WP
                                {
                                    double dist_from_last = MainMap.MapProvider.Projection.GetDistance(GMRouteMission.Points[1], point);
                                    lDistLastWP.Text = String.Format("Dist. from next WP:{0:N1}m", dist_from_last * 1000);
                                }
                            }
                            else                        //Drag some other marker
                            {
                                double dist_from_last = MainMap.MapProvider.Projection.GetDistance(GMRouteMission.Points[Convert.ToInt32(pIndex - 1)], point);
                                lDistLastWP.Text = String.Format("Dist. from prev. WP:{0:N1}m", dist_from_last * 1000);
                            }



                        }
                    }

                    if (currentMarker.IsVisible)
                    {
                        currentMarker.Position = pnew;
                    }
                    CurentRectMarker.Position = pnew;

                    if (CurentRectMarker.InnerMarker != null)
                    {
                        CurentRectMarker.InnerMarker.Position = pnew;
                    }
                }
            }

        }

        private void cbMapProviders_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            //MainMap.MapProvider = GMapProviders.GoogleSatelliteMap;
            MainMap.MapProvider = (GMapProvider)cbMapProviders.SelectedItem;
            MainMap.MinZoom = 5;
            MainMap.MaxZoom = 20;
            MainMap.Zoom = 18;
            MainMap.Invalidate(false);
            gui_settings.iMapProviderSelectedIndex = cbMapProviders.SelectedIndex;
            gui_settings.save_to_xml(sGuiSettingsFilename);


            this.Cursor = Cursors.Default;

        }

        private void b_start_KML_log_Click(object sender, EventArgs e)
        {
            if (bKMLLogRunning)
            {
                b_start_KML_log.Text = "Start GPS Log";
                b_start_KML_log.BackColor = Color.Gray;
                this.Refresh();
                closeKMLLog();
            }
            else
            {
                openKMLLog();
                if (bKMLLogRunning)
                {
                    b_start_KML_log.Text = "Stop STOP Log";
                    b_start_KML_log.BackColor = Color.IndianRed;
                    this.Refresh();
                }
            }
        }

        private void b_Clear_Route_Click(object sender, EventArgs e)
        {
            GMRouteFlightPath.Points.Clear();
            GMOverlayFlightPath.IsVisibile = false;
            GMOverlayFlightPath.IsVisibile = true;
            MainMap.Invalidate(false);
        }



        private void b_fetch_tiles_Click(object sender, EventArgs e)
        {
            fetch_map();
        }
        private void fetchMapTilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fetch_map();
        }

        private void fetch_map()
        {
            RectLatLng area = MainMap.SelectedArea;
            if (area.IsEmpty)
            {
                DialogResult res = MessageBox.Show("No ripp area defined, ripp displayed on screen?", "Rip", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    area = MainMap.ViewArea;
                }
            }

            if (!area.IsEmpty)
            {
                DialogResult res = MessageBox.Show("Ready ripp at Zoom = " + (int)MainMap.Zoom + " ?", "GMap.NET", MessageBoxButtons.YesNo);

                for (int i = 1; i <= MainMap.MaxZoom; i++)
                {
                    if (res == DialogResult.Yes)
                    {
                        TilePrefetcher obj = new TilePrefetcher();
                        obj.ShowCompleteMessage = false;
                        obj.Start(area, i, MainMap.MapProvider, 100,0);
                       
                    }
                    else if (res == DialogResult.No)
                    {
                        continue;
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Select map area holding ALT", "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        #region ValueChangedEvents

        private void pfield_valuechange(object sender, EventArgs e)
        {
            for (int i = 0; i < iPidItems; i++)
            {
                if (Pid[i].Pshown)
                {
                    if (Pid[i].Pfield.Value != (decimal)mw_gui.pidP[i] / Pid[i].Pprec)
                    {
                        Pid[i].Pfield.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        Pid[i].Pfield.BackColor = Color.White;
                    }
                }
            }

        }

        private void ifield_valuechange(object sender, EventArgs e)
        {
            for (int i = 0; i < iPidItems; i++)
            {
                if (Pid[i].Ishown)
                {

                    if (Pid[i].Ifield.Value != (decimal)mw_gui.pidI[i] / Pid[i].Iprec)
                    {
                        Pid[i].Ifield.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        Pid[i].Ifield.BackColor = Color.White;
                    }
                }
            }
        }

        private void dfield_valuechange(object sender, EventArgs e)
        {
            for (int i = 0; i < iPidItems; i++)
            {
                if (Pid[i].Dshown)
                {
                    if (Pid[i].Dfield.Value != (decimal)mw_gui.pidD[i] / Pid[i].Dprec)
                    {
                        Pid[i].Dfield.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        Pid[i].Dfield.BackColor = Color.White;
                    }
                }
            }
        }

        private void nRATE_rp_ValueChanged(object sender, EventArgs e)
        {
            if (nRATE_rp.Value != (decimal)mw_gui.RollPitchRate / 100) { nRATE_rp.BackColor = Color.IndianRed; }
            else { nRATE_rp.BackColor = Color.White; }
        }

        private void nRATE_yaw_ValueChanged(object sender, EventArgs e)
        {
            if (nRATE_yaw.Value != (decimal)mw_gui.YawRate / 100) { nRATE_yaw.BackColor = Color.IndianRed; }
            else { nRATE_yaw.BackColor = Color.White; }
        }

        private void nRATE_tpid_ValueChanged(object sender, EventArgs e)
        {
            if (nRATE_tpid.Value != (decimal)mw_gui.DynThrPID / 100) { nRATE_tpid.BackColor = Color.IndianRed; }
            else { nRATE_tpid.BackColor = Color.White; }
        }

        private void nPAlarm_ValueChanged(object sender, EventArgs e)
        {
            if (nPAlarm.Value != (decimal)mw_gui.powerTrigger) { nPAlarm.BackColor = Color.IndianRed; }
            else { nPAlarm.BackColor = Color.White; }
        }

        private void trackbar_RC_Expo_Scroll(object sender, EventArgs e)
        {
            nRCExpo.Value = (decimal)trackbar_RC_Expo.Value / 100;
            rc_expo_control1.SetRCExpoParameters((double)nRCRate.Value, (double)nRCExpo.Value);
        }

        private void nRCExpo_ValueChanged(object sender, EventArgs e)
        {
            trackbar_RC_Expo.Value = (int)(nRCExpo.Value * 100);
            rc_expo_control1.SetRCExpoParameters((double)nRCRate.Value, (double)nRCExpo.Value);

            if ((int)(nRCExpo.Value * 100) != mw_gui.rcExpo)
            {
                nRCExpo.BackColor = Color.IndianRed;
            }
            else
            {
                nRCExpo.BackColor = Color.White;
            }


        }

        private void trackbar_RC_Rate_Scroll(object sender, EventArgs e)
        {
            nRCRate.Value = (decimal)trackbar_RC_Rate.Value / 100;
            rc_expo_control1.SetRCExpoParameters((double)nRCRate.Value, (double)nRCExpo.Value);

        }

        private void nRCRate_ValueChanged(object sender, EventArgs e)
        {
            trackbar_RC_Rate.Value = (int)(nRCRate.Value * 100);
            rc_expo_control1.SetRCExpoParameters((double)nRCRate.Value, (double)nRCExpo.Value);
            if ((int)(nRCRate.Value * 100) != mw_gui.rcRate)
            {
                nRCRate.BackColor = Color.IndianRed;
            }
            else
            {
                nRCRate.BackColor = Color.White;
            }

        }

        #endregion

        private void b_check_all_ACC_Click(object sender, EventArgs e)
        {
            cb_acc_pitch.Checked = true;
            cb_acc_roll.Checked = true;
            cb_acc_z.Checked = true;
        }

        private void b_uncheck_all_ACC_Click(object sender, EventArgs e)
        {
            cb_acc_pitch.Checked = false;
            cb_acc_roll.Checked = false;
            cb_acc_z.Checked = false;

        }

        private void b_check_all_GYRO_Click(object sender, EventArgs e)
        {
            cb_gyro_pitch.Checked = true;
            cb_gyro_roll.Checked = true;
            cb_gyro_yaw.Checked = true;
        }

        private void b_uncheck_all_GYRO_Click(object sender, EventArgs e)
        {
            cb_gyro_pitch.Checked = false;
            cb_gyro_roll.Checked = false;
            cb_gyro_yaw.Checked = false;
        }

        private void b_check_all_MAG_Click(object sender, EventArgs e)
        {
            cb_mag_pitch.Checked = true;
            cb_mag_roll.Checked = true;
            cb_mag_yaw.Checked = true;
        }

        private void b_uncheck_all_MAG_Click(object sender, EventArgs e)
        {
            cb_mag_pitch.Checked = false;
            cb_mag_roll.Checked = false;
            cb_mag_yaw.Checked = false;
        }


        private void b_reset_Click(object sender, EventArgs e)
        {
            //bool timer_rt_state = timer_realtime.Enabled;

            //Stop all timers
            timer_realtime.Stop();
            MSPquery(MSP.MSP_RESET_CONF);
            System.Threading.Thread.Sleep(2000);

            MSPquery(MSP.MSP_PID);
            MSPquery(MSP.MSP_RC_TUNING);
            MSPquery(MSP.MSP_IDENT);
            MSPquery(MSP.MSP_BOX);
            MSPquery(MSP.MSP_MISC);
            MSPquery(MSP.MSP_SERVO_CONF);
            MSPquery(MSP.MSP_NAV_CONFIG);

            //Invalidate gui parameters and reread those values

            timer_realtime.Start();
            System.Threading.Thread.Sleep(500);
            bOptions_needs_refresh = true;
            update_gui();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {


            if (isConnected)
            {
                MessageBoxEx.Show(this, "Please disconnect from flight controller before entering Log Download mode", "Disconnect First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            log_downloader logDL = new log_downloader();
            logDL.sLogDirectory = gui_settings.sLogFolder;
            logDL.sSerialPortName = cb_serial_port.Text;
            logDL.iSerialPortBaudrate = int.Parse(cb_serial_speed.Text);
            logDL.ShowDialog();
            logDL.Dispose();




        }

        #region CLI

        void AccessToTB()
        {
            if (txtCLIResult.InvokeRequired)
            {
                txtCLIResult.Invoke(new MethodInvoker(AccessToTB));
                return;
            }
            txtCLIResult.AppendText(inCLIBuffer);
        }

        private void cmdCLISend_Click(object sender, EventArgs e)
        {
            serialPort.Write(txtCLICommand.Text + "\r\n");
            txtCLICommand.Text = "";
        }

        #endregion

        #region Mission Planner

        private void missionDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            if (e.ColumnIndex == DEL.Index && (e.RowIndex + 0) < missionDataGrid.RowCount) // delete
            {
                missionDataGrid.Rows.RemoveAt(e.RowIndex);
            }
            if (e.ColumnIndex == UP.Index && e.RowIndex != 0) // up
            {
                DataGridViewRow myrow = missionDataGrid.CurrentRow;
                missionDataGrid.Rows.Remove(myrow);
                missionDataGrid.Rows.Insert(e.RowIndex - 1, myrow);
            }
            if (e.ColumnIndex == Down.Index && e.RowIndex < missionDataGrid.RowCount - 1) // down
            {
                DataGridViewRow myrow = missionDataGrid.CurrentRow;
                missionDataGrid.Rows.Remove(myrow);
                missionDataGrid.Rows.Insert(e.RowIndex + 1, myrow);
            }

            updateMap();
            updateIndex();

        }

        private void addWP(string action, int P1, int P2, int P3, double Lat, double Lon, int Alt)
        {
            if (missionDataGrid.Rows.Count >= mw_gui.max_wp_number)
            {
                MessageBox.Show("Cannot add mission step. Maximum number of mission steps (" + Convert.ToString(mw_gui.max_wp_number) + ") reached", "Max steps reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            selectedrow = missionDataGrid.Rows.Add();

            missionDataGrid.Rows[selectedrow].Cells[No.Index].Value = selectedrow + 1;
            missionDataGrid.Rows[selectedrow].Cells[Action.Index].Value = action;
            missionDataGrid.Rows[selectedrow].Cells[Par1.Index].Value = P1;
            missionDataGrid.Rows[selectedrow].Cells[Par2.Index].Value = P2;
            missionDataGrid.Rows[selectedrow].Cells[Par3.Index].Value = P3;
            missionDataGrid.Rows[selectedrow].Cells[LATCOL.Index].Value = Lat.ToString("0.0000000");
            missionDataGrid.Rows[selectedrow].Cells[LONCOL.Index].Value = Lon.ToString("0.0000000");
            missionDataGrid.Rows[selectedrow].Cells[ALTCOL.Index].Value = Alt;

            missionDataGrid.Rows[selectedrow].DataGridView.EndEdit();

            updateMap();

        }

        public void dragMarkerCallback(string pointno, double lat, double lng, int alt)
        {
            if (pointno == "")
            {
                return;
            }

            selectedrow = int.Parse(pointno) - 1;
            missionDataGrid.CurrentCell = missionDataGrid[1, selectedrow];
            missionDataGrid.Rows[selectedrow].Cells[LATCOL.Index].Value = lat.ToString("0.0000000");
            missionDataGrid.Rows[selectedrow].Cells[LONCOL.Index].Value = lng.ToString("0.0000000");
            missionDataGrid.Rows[selectedrow].DataGridView.EndEdit();

        }

        private void updateIndex()
        {

            for (int a = 0; a < missionDataGrid.Rows.Count - 0; a++)
            {
                missionDataGrid.Rows[a].Cells[No.Index].Value = a + 1;
                if (missionDataGrid.Rows[a].Cells[Action.Index].Value.ToString() == "RTH")
                {
                    missionDataGrid.Rows[a].Cells[LATCOL.Index].Value = 0;
                    missionDataGrid.Rows[a].Cells[LONCOL.Index].Value = 0;
                }
                if (missionDataGrid.Rows[a].Cells[Action.Index].Value.ToString() == "JUMP")
                {
                    missionDataGrid.Rows[a].Cells[LATCOL.Index].Value = 0;
                    missionDataGrid.Rows[a].Cells[LONCOL.Index].Value = 0;
                }
            }
            missionDataGrid.EndEdit();
        }

        private void updateMap()
        {
            int command = 0;

            if (GMOverlayWaypoints != null) // hasnt been created yet
            {
                GMOverlayWaypoints.Markers.Clear();
            }

            if (GMRouteMission != null)
            {
                GMRouteMission.Points.Clear();

            }

            if (GMOverlayPOI != null)
            {
                GMOverlayPOI.Markers.Clear();
            }

            for (int a = 0; a < missionDataGrid.Rows.Count - 0; a++)
            {
                string sAction = missionDataGrid.Rows[a].Cells[Action.Index].Value.ToString();
                string sAlt = missionDataGrid.Rows[a].Cells[ALTCOL.Index].Value.ToString(); // alt
                string sLat = missionDataGrid.Rows[a].Cells[LATCOL.Index].Value.ToString(); // lat
                string sLon = missionDataGrid.Rows[a].Cells[LONCOL.Index].Value.ToString(); // lng

                if (sAction == "WAYPOINT") command = WP_ACTION.WAYPOINT;
                if (sAction == "POSHOLD_UNLIM") command = WP_ACTION.HOLD_UNLIM;
                if (sAction == "POSHOLD_TIME") command = WP_ACTION.HOLD_TIME;
                if (sAction == "RTH") command = WP_ACTION.RTH;
                if (sAction == "SET_HEAD") command = WP_ACTION.SET_HEAD;
                if (sAction == "SET_POI") command = WP_ACTION.SET_POI;
                if (sAction == "LAND") command = WP_ACTION.LAND;

                if (sLon == "0" || sLat == "0")
                    continue;
                if (sLon == "?" || sLat == "?")
                    continue;
                if (sAction == "JUMP")  //Not shown 
                    continue;
                if (sAction == "RTH")   //Not shown
                    break;
                if (sAction == "SET_HEAD") //Not shown
                    continue;
                if (sAction == "SET_POI")
                {
                    //add a special marker
                    AddPOIMarker((a + 1).ToString(), double.Parse(sLon), double.Parse(sLat));
                    continue;
                }

                AddWPMarker((a + 1).ToString(), double.Parse(sLon), double.Parse(sLat), (int)double.Parse(sAlt), null, command);
                //POSHOLD UNLIM marks the end of the mission
                if (sAction == "POSHOLD_UNLIM")
                    break;

                //LAND here also marks the end of the mission
                if (sAction == "LAND")
                    break;                              

            }

            RegenerateMissionRoute();
            lDistance.Text = String.Format("Mission total dist.:{0:N1} m", GMRouteMission.Distance * 1000);
        }



        private void change_datagrid_header(string sAction)
        {
            if (sAction == "WAYPOINT" || sAction == "POSHOLD_UNLIM")
            {
                missionDataGrid.Columns[2].HeaderText = "";
                missionDataGrid.Columns[3].HeaderText = "";
                missionDataGrid.Columns[4].HeaderText = "";

                missionDataGrid.Columns[5].HeaderText = "Lat";
                missionDataGrid.Columns[6].HeaderText = "Lon";
                missionDataGrid.Columns[7].HeaderText = "Alt";
            }
            if (sAction == "POSHOLD_TIME")
            {
                missionDataGrid.Columns[2].HeaderText = "Sec";
                missionDataGrid.Columns[3].HeaderText = "";
                missionDataGrid.Columns[4].HeaderText = "";
                missionDataGrid.Columns[5].HeaderText = "Lat";
                missionDataGrid.Columns[6].HeaderText = "Lon";
                missionDataGrid.Columns[7].HeaderText = "Alt";
            }
            if (sAction == "RTH")
            {
                missionDataGrid.Columns[2].HeaderText = "Land";
                missionDataGrid.Columns[3].HeaderText = "";
                missionDataGrid.Columns[4].HeaderText = "";
                missionDataGrid.Columns[5].HeaderText = "";
                missionDataGrid.Columns[6].HeaderText = "";
                missionDataGrid.Columns[7].HeaderText = "Alt";
            }

            if (sAction == "JUMP")
            {
                missionDataGrid.Columns[2].HeaderText = "WP#";
                missionDataGrid.Columns[3].HeaderText = "Rep";
                missionDataGrid.Columns[4].HeaderText = "";
                missionDataGrid.Columns[5].HeaderText = "";
                missionDataGrid.Columns[6].HeaderText = "";
                missionDataGrid.Columns[7].HeaderText = "";
            }

            if (sAction == "SET_POI")
            {
                missionDataGrid.Columns[2].HeaderText = "";
                missionDataGrid.Columns[3].HeaderText = "";
                missionDataGrid.Columns[4].HeaderText = "";
                missionDataGrid.Columns[5].HeaderText = "Lat";
                missionDataGrid.Columns[6].HeaderText = "Lon";
                missionDataGrid.Columns[7].HeaderText = "";
            }

            if (sAction == "SET_HEAD")
            {
                missionDataGrid.Columns[2].HeaderText = "head";
                missionDataGrid.Columns[3].HeaderText = "";
                missionDataGrid.Columns[4].HeaderText = "";
                missionDataGrid.Columns[5].HeaderText = "";
                missionDataGrid.Columns[6].HeaderText = "";
                missionDataGrid.Columns[7].HeaderText = "";
            }

            if (sAction == "LAND")
            {
                missionDataGrid.Columns[2].HeaderText = "";
                missionDataGrid.Columns[3].HeaderText = "";
                missionDataGrid.Columns[4].HeaderText = "";
                missionDataGrid.Columns[5].HeaderText = "Lat";
                missionDataGrid.Columns[6].HeaderText = "Lon";
                missionDataGrid.Columns[7].HeaderText = "Alt";
            }



        }


        private void missionDataGrid_SelectionChanged(object sender, EventArgs e)

        {
        }

        private void missionDataGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            string sAction = missionDataGrid.CurrentCell.EditedFormattedValue.ToString();
            change_datagrid_header(sAction);
        }

        private void missionDataGrid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            try
            {
                string sAction = missionDataGrid[Action.Index, selectedrow].Value.ToString();
                change_datagrid_header(sAction);

            }
            catch { }

        }

        private void missionDataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            selectedrow = e.RowIndex;
            try
            {
                string sAction = missionDataGrid[Action.Index, selectedrow].Value.ToString();
                change_datagrid_header(sAction);

            }
            catch { }

        }

        private void missionDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            selectedrow = e.RowIndex;
            try
            {
                string sAction = missionDataGrid[Action.Index, selectedrow].Value.ToString();
                change_datagrid_header(sAction);

            }
            catch { }

        }

        private void missionDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updateMap();
            updateIndex();
        }

        private void cbShowMission_CheckedChanged(object sender, EventArgs e)
        {
            GMOverlayMission.IsVisibile = cbShowMission.Checked;
            MainMap.Invalidate(false);
        }

        private void cbShowWP_CheckedChanged(object sender, EventArgs e)
        {
            GMOverlayWaypoints.IsVisibile = cbShowWP.Checked;
            GMOverlayPOI.IsVisibile = cbShowWP.Checked;
            MainMap.Invalidate(false);
        }

        private void cbShowPos_CheckedChanged(object sender, EventArgs e)
        {
            GMOverlayLiveData.IsVisibile = cbShowPos.Checked;
            MainMap.Invalidate(false);

        }

        private void cbShowFlightPath_CheckedChanged(object sender, EventArgs e)
        {
            GMOverlayFlightPath.IsVisibile = cbShowFlightPath.Checked;
        }

        private void bClickToGo_Click(object sender, EventArgs e)
        {
            if (bGoToClikEnabled)
            {
                bClickToGo.BackColor = Color.LightGray;
                bClickToGo.ForeColor = Color.Black;
                bClickToGo.Text = "Go to Click disabled";
                bGoToClikEnabled = false;
                GMOverlayLiveData.Markers.Remove(markerGoToClick);
                markerGoToClick = null;
            }
            else
            {
                bClickToGo.BackColor = Color.Red;
                bClickToGo.ForeColor = Color.White;
                bClickToGo.Text = "Go to Click enabled";
                bGoToClikEnabled = true;
            }
        }

        private void txtDefAlt_TextChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(txtDefAlt.Text);
            if (i < 2 || i > 400)
            {
                MessageBoxEx.Show(this, "Default altitude must be between 2m and 400m", "Altitude error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDefAlt.Text = iDefAlt.ToString();
                return;

            }
            iDefAlt = i;
        }

        private void txtDefAlt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int i = Convert.ToInt16(txtDefAlt.Text);
                if (i < 2 || i > 400)
                {
                    MessageBoxEx.Show(this, "Default altitude must be between 2m and 400m", "Altitude error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDefAlt.Text = iDefAlt.ToString();
                    return;

                }
                iDefAlt = i;
            }

        }

        private void panelMissionList_Paint(object sender, PaintEventArgs e)
        {

        }

        public void save_mission(string filename)
        {
            XmlTextWriter tw = new XmlTextWriter(filename, null);
            tw.Formatting = Formatting.Indented;
            tw.Indentation = 4;
            tw.WriteStartDocument();

            // Get the name and version of the current assembly.
            Assembly assem = Assembly.GetExecutingAssembly();
            AssemblyName assemName = assem.GetName();
            Version ver = assemName.Version;
            tw.WriteComment(String.Format("{0}, Version {1}", assemName.Name, ver.ToString()));
            tw.WriteComment("MultiWii mission");
            tw.WriteComment("MultiWii FC software revision 2.3dev");
            tw.WriteStartElement("MISSION");
            tw.WriteStartElement("VERSION value=\"" + sVersion + "\""); tw.WriteEndElement();


            for (int i = 0; i < missionDataGrid.Rows.Count; i++)
            {
                tw.WriteStartElement("MISSIONITEM no=\"" + (i + 1) + "\" " +
                                     "action=\"" + missionDataGrid.Rows[i].Cells[Action.Index].Value + "\" " +
                                     "parameter1=\"" + Convert.ToString(missionDataGrid.Rows[i].Cells[Par1.Index].Value) + "\" " +
                                     "parameter2=\"" + Convert.ToString(missionDataGrid.Rows[i].Cells[Par2.Index].Value) + "\" " +
                                     "parameter3=\"" + Convert.ToString(missionDataGrid.Rows[i].Cells[Par3.Index].Value) + "\" " +
                                     "lat=\"" + Convert.ToString(missionDataGrid.Rows[i].Cells[LATCOL.Index].Value) + "\" " +
                                     "lon=\"" + Convert.ToString(missionDataGrid.Rows[i].Cells[LONCOL.Index].Value) + "\" " +
                                     "alt=\"" + Convert.ToString(missionDataGrid.Rows[i].Cells[ALTCOL.Index].Value) + "\"");
                tw.WriteEndElement();
            }
            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Close();
        }

        private bool loadMission(string filename)
        {

            XmlTextReader reader = new XmlTextReader(filename);

            //Clean up current mission   
            missionDataGrid.Rows.Clear();
            updateMap();

            try
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:

                            if (String.Compare(reader.Name, "version", true) == 0 && reader.HasAttributes)
                            {
                                if (reader.GetAttribute("value") != sVersion)
                                {
                                    throw new System.InvalidOperationException("Version of mission is not made for this version of WinGUI");
                                }
                            }
                            if (String.Compare(reader.Name, "MISSIONITEM", true) == 0 && reader.HasAttributes)
                            {

                                string action = "";
                                int parameter1,parameter2,parameter3 = 0;
                                double lat = 0;
                                double lon = 0;
                                int alt = 0;


                                action = reader.GetAttribute("action");
                                parameter1 = Convert.ToInt16(reader.GetAttribute("parameter1"));
                                parameter2 = Convert.ToInt16(reader.GetAttribute("parameter2"));
                                parameter3 = Convert.ToInt16(reader.GetAttribute("parameter3"));

                                double.TryParse(reader.GetAttribute("lat").Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out lat);
                                double.TryParse(reader.GetAttribute("lon").Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out lon);
                                //lat = Convert.ToDouble(reader.GetAttribute("lat"));
                                //lon = Convert.ToDouble(reader.GetAttribute("lon"));
                                alt = Convert.ToInt16(reader.GetAttribute("alt"));
                                addWP(action, parameter1,parameter2, parameter3, lat, lon, alt);

                            }
                            break;
                    }
                }
            }
            catch (System.InvalidOperationException e)
            {
                MessageBoxEx.Show(e.Message, "Version mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }
            catch
            {
                MessageBoxEx.Show("Options file contains invalid data around Line : " + reader.LineNumber, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return (false);
            }

            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return (true);
        }

        private void btnSaveMission_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdSaveParameters = new SaveFileDialog();
            sfdSaveParameters.Filter = "MultiWii Mission File|*.mission";
            sfdSaveParameters.Title = "Save Mission to file";
            sfdSaveParameters.InitialDirectory = gui_settings.sSettingsFolder;

            string invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
            string invalidReStr = string.Format(@"[{0} ]+", invalidChars);
            string fn = String.Format("{0:yyMMdd-hhmm}", DateTime.Now);
            sfdSaveParameters.FileName = fn;


            sfdSaveParameters.ShowDialog();

            if (sfdSaveParameters.FileName != "")
            {
                save_mission(sfdSaveParameters.FileName);
            }
        }

        private void btnLoadMission_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdLoadParameters = new OpenFileDialog();
            ofdLoadParameters.Filter = "MultiWii Mission File|*.mission";
            ofdLoadParameters.Title = "Load mission from file";
            ofdLoadParameters.InitialDirectory = gui_settings.sSettingsFolder;
            if (ofdLoadParameters.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                loadMission(ofdLoadParameters.FileName);
        }

        private void cbSendGTCAlt_CheckedChanged(object sender, EventArgs e)
        {

            txtGTCAlt.Enabled = cbSendGTCAlt.Checked;
            if (txtGTCAlt.Enabled) { txtGTCAlt.BackColor = Color.White; } else { txtGTCAlt.BackColor = Color.Gray; }


        }

        //Temporary implementation to 
        private void sendWPToMultiWii(SerialPort serialport, int wp_number, byte action, double lat, double lon, int alt, int p1,int p2, int p3, byte flag)  
        {
            byte[] buffer = new byte[250];          //this must be long enough
            int bptr = 0;                           //buffer pointer
            byte[] bInt16 = new byte[2];            //two byte buffer for converting int to two separated bytes
            byte[] bInt32 = new byte[4];
            byte checksum = 0;


            if (serialport.IsOpen)
            {
                bptr = 0;
                checksum = 0;
                buffer[bptr++] = (byte)'$';
                buffer[bptr++] = (byte)'M';
                buffer[bptr++] = (byte)'<';
                buffer[bptr++] = 21;
                buffer[bptr++] = (byte)MSP.MSP_SET_WP;

                //byte Waypoint number
                buffer[bptr++] = Convert.ToByte(wp_number);

                //Action
                buffer[bptr++] = Convert.ToByte(action);

                //int32 lattitude in lat * 10,000,000
                bInt32 = BitConverter.GetBytes(Convert.ToInt32(lat * 10000000));
                buffer[bptr++] = bInt32[0]; buffer[bptr++] = bInt32[1]; buffer[bptr++] = bInt32[2]; buffer[bptr++] = bInt32[3];

                //int32 longitude in lon * 10,000,000
                bInt32 = BitConverter.GetBytes(Convert.ToInt32(lon * 10000000));
                buffer[bptr++] = bInt32[0]; buffer[bptr++] = bInt32[1]; buffer[bptr++] = bInt32[2]; buffer[bptr++] = bInt32[3];

                //int32 altitude in cm so convert it from meter
                bInt32 = BitConverter.GetBytes(alt * 100);
                buffer[bptr++] = bInt32[0]; buffer[bptr++] = bInt32[1]; buffer[bptr++] = bInt32[2]; buffer[bptr++] = bInt32[3];

                //int16 Parameter 1
                bInt16 = BitConverter.GetBytes(p1);
                buffer[bptr++] = bInt16[0]; buffer[bptr++] = bInt16[1];
                //int16 Parameter 2
                bInt16 = BitConverter.GetBytes(p2);
                buffer[bptr++] = bInt16[0]; buffer[bptr++] = bInt16[1];
                //int16 Parameter 3
                bInt16 = BitConverter.GetBytes(p3);
                buffer[bptr++] = bInt16[0]; buffer[bptr++] = bInt16[1];

                //byte nav flag (this will be the marker of the end)
                buffer[bptr++] = flag;

                for (int i = 3; i < bptr; i++) checksum ^= buffer[i];
                buffer[bptr++] = checksum;
                serialport.Write(buffer, 0, bptr);
            }
        }

        #endregion

        //Returns the status of the given box (by name or by ID)
        private bool isBoxActive(string boxname)
        {
            int index;
            index = Array.IndexOf(mw_gui.sBoxNames, boxname);
            if (index >= 0)
            {
                return isBoxActive(index);
            }
            return false;
        }
        private bool isBoxActive(int boxid)
        {
            return ((mw_gui.mode & (1 << boxid)) > 0);
        }

        #region Video

        private void OpenVideoSource(IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // close previous video source
            videoSourcePlayer.SignalToStop();
            videoSourcePlayer.WaitForStop();

            //add asynch layer
            AsyncVideoSource asyncSource = new AsyncVideoSource(source, true);
            // set NewFrame event handler
            asyncSource.NewFrame += new NewFrameEventHandler(videoSourcePlayer_NewFrame);
            // start the video source
            asyncSource.Start();


            // start new video source
            videoSourcePlayer.VideoSource = asyncSource;
            videoSourcePlayer.Start();

            this.Cursor = Cursors.Default;
        }

        private void videoSourcePlayer_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = eventArgs.Frame;
            //Graphics g = Graphics.FromImage(image);

            //g.DrawString(String.Format("{0:0}", mw_gui.angx), drawFont, drawBrush, 100,100);


            if (bVideoRecording == true)
            {
                tsFrameTimeStamp = tsFrameTimeStamp.Add(tsFrameRate);
                if (vfwWriter != null)
                {
                    vfwWriter.WriteVideoFrame(image, tsFrameTimeStamp);
                }
            }
            //g.Dispose();

        }

        private void b_video_connect_Click(object sender, EventArgs e)
        {

            if (!bVideoConnected)
            {
                // create video source
                videoSource = new VideoCaptureDevice(videoDevices[dropdown_devices.SelectedIndex].MonikerString);
                videoSource.DesiredFrameRate = (int)nFrameRate.Value;
                // open it
                OpenVideoSource(videoSource);
                bVideoConnected = true;
                b_video_connect.Text = "Disconnect video device";
            }
            else
            {
                if (bVideoRecording) { vfwWriter.Close(); }
                videoSourcePlayer.SignalToStop();
                videoSourcePlayer.WaitForStop();
                b_video_connect.Text = "Connect video device";
                bVideoConnected = false;

            }
        }

        private void b_Record_Click(object sender, EventArgs e)
        {
            if (bVideoConnected)
            {
                if (bVideoRecording == false)
                {
                    if (vfwWriter != null) { vfwWriter.Close(); }

                    l_capture_file.Text = "capture" + String.Format("-{0:yymmdd-hhmm}", DateTime.Now);
                    vfwWriter = new VideoFileWriter();
                    //create new video file
                    vfwWriter.Open(gui_settings.sCaptureFolder + "\\capture" + String.Format("-{0:yyMMdd-hhmm}", DateTime.Now) + ".avi", 640, 480, (int)nFrameRate.Value, (VideoCodec)cb_codec.SelectedIndex, (int)(1000000 * nBitRate.Value));
                    b_Record.Text = "Recording";
                    b_Record.BackColor = Color.Red;
                    tsFrameTimeStamp = new TimeSpan(0);
                    tsFrameRate = new TimeSpan(10000000 / (long)nFrameRate.Value);
                    bVideoRecording = true;
                }
                else
                {
                    bVideoRecording = false;
                    System.Threading.Thread.Sleep(50);
                    b_Record.Text = "Start Recording";
                    b_Record.BackColor = Color.Transparent;
                    vfwWriter.Close();
                    l_capture_file.Text = "";
                }
            }
        }

        private void videoSourcePlayer_SizeChanged(object sender, EventArgs e)
        {

            Size currentSize = videoSourcePlayer.Size;
            currentSize.Width = currentSize.Height / 3 * 4;

            if (splitContainer6.Panel1.Size.Width < currentSize.Width)
            {
                currentSize.Width = splitContainer6.Panel1.Size.Width;
                currentSize.Height = currentSize.Width / 4 * 3;
            }

            videoSourcePlayer.Size = currentSize;


        }

        #endregion

        private void bDebugWindws_Click(object sender, EventArgs e)
        {
            frmDebug = new DebugWindow();
            frmDebug.Show();
            frmDebug.AppendText("Hello vilag\n");
        }




        private void cbMagSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal mag_dec = 0;
            mag_dec = nMagDeg.Value;
            mag_dec += (decimal)nMagMin.Value * (decimal)(1.0 / 60.0);
            if (cbMagSign.SelectedIndex == 1) mag_dec *= -1;
            mw_gui.mag_declination = (int)(mag_dec * 10);
            label49.Text = "(" + Convert.ToString((decimal)mw_gui.mag_declination / 10) + ")";

        }

        private void nMagDeg_ValueChanged(object sender, EventArgs e)
        {
            decimal mag_dec = 0;
            mag_dec = nMagDeg.Value;
            mag_dec += (decimal)nMagMin.Value * (decimal)(1.0 / 60.0);
            if (cbMagSign.SelectedIndex == 1) mag_dec *= -1;
            mw_gui.mag_declination = (int)(mag_dec * 10);
            label49.Text = "(" + Convert.ToString((decimal)mw_gui.mag_declination / 10) + ")";
        }

        private void nMagMin_ValueChanged(object sender, EventArgs e)
        {
            decimal mag_dec = 0;
            mag_dec = nMagDeg.Value;
            mag_dec += (decimal)nMagMin.Value * (decimal)(1.0 / 60.0);
            if (cbMagSign.SelectedIndex == 1) mag_dec *= -1;
            mw_gui.mag_declination = (int)(mag_dec * 10);
            label49.Text = "(" + Convert.ToString((decimal)mw_gui.mag_declination / 10) + ")";
        }

        private void bBind_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBoxEx.Show(this, "You have to connect to the FC first!", "Not connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBoxEx.Show(this, "After pressing OK your Spektrum receiver will be in bind mode, power cycle when bind is finished", "Bind Spektrum receiver", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {

                MSPquery(MSP.MSP_BIND);

            }
        }


        int Query_WP(byte wp_to_query)
        {
            bool no_answer;

            //first check for boundary
            // TODO: Check for boundary

            mission_step.wp_updated = false;                // prepare for query
            MSPqueryWP(wp_to_query);

            DateTime startTime = DateTime.Now;
            no_answer = false;

            while (!mission_step.wp_updated && !no_answer)
            {
                if (DateTime.Now.Subtract(startTime).TotalMilliseconds > 2000) { no_answer = true; }
            }

            if (no_answer) return (WP_Query.Timeout);

            if (mission_step.flag == 0xff) return (WP_Query.Error);
            if (mission_step.flag == 0xfe) return (WP_Query.CRC);

            return (WP_Query.OK);
        }


        private void btnUploadMission_Click(object sender, EventArgs e)
        {
            int qStatus = WP_Query.OK;
            byte action, flag, a;
            Int16 p1, p2, p3;
            double lat, lon;
            Int32 altitude;


            //if mission list is empty then upload a single RTH
            //This is for safety reasons
            if (missionDataGrid.Rows.Count == 0)
            {
                action = WP_ACTION.RTH;
                altitude = 25;        //25meter
                p1 = 0;
                p2 = 0;
                p3 = 0;
                lat = 0;
                lon = 0;
                flag = 0xa5;
                sendWPToMultiWii(serialPort, 1, action, lat, lon, altitude, p1,p2,p3, flag);
                qStatus = Query_WP(Convert.ToByte(1));

                if (qStatus == WP_Query.Timeout)
                {
                    MessageBox.Show("No answer from FC, mission upload aborted. Try reading mission again.", "Answer timeout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (qStatus == WP_Query.Error)
                {
                    MessageBox.Show("Error condition occured, most likely Navigatgion is in progress, land, disarm and try again.", "Upload error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //It is possible that we already have a mission in EEPROM and the write command did not go through
                //In this case the waypoint reload will be successfull, but data comes from pervious mission

                //Check wp_action and lat/lon to make it sure
                if ((mission_step.action != action) || (mission_step.lat != (int)(Math.Round(lat * 10000000))) || (mission_step.lon != (int)(Math.Round(lon * 10000000))))
                {
                    MessageBox.Show("Upload failed - most likely a communication error\r\nCheck copter, comms and try again.", "Upload error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    qStatus = WP_Query.Error;
                }
            }

            for (a = 0; a < missionDataGrid.Rows.Count - 0; a++)
            {
                //Put together a waypoint info based on the grid.
                string sAction = missionDataGrid.Rows[a].Cells[Action.Index].Value.ToString();

                action = 0;     //default (switch case does have issues with strings)
                if (sAction == "WAYPOINT") action = WP_ACTION.WAYPOINT;
                if (sAction == "POSHOLD_UNLIM") action = WP_ACTION.HOLD_UNLIM;
                if (sAction == "POSHOLD_TIME") action = WP_ACTION.HOLD_TIME;
                if (sAction == "RTH") action = WP_ACTION.RTH;
                if (sAction == "JUMP") action = WP_ACTION.JUMP;
                if (sAction == "SET_POI") action = WP_ACTION.SET_POI;
                if (sAction == "SET_HEAD") action = WP_ACTION.SET_HEAD;
                if (sAction == "LAND") action = WP_ACTION.LAND;

                altitude = Convert.ToInt32(missionDataGrid.Rows[a].Cells[ALTCOL.Index].Value.ToString()); // alt
                p1 = Convert.ToInt16(missionDataGrid.Rows[a].Cells[Par1.Index].Value.ToString()); // parameter
                p2 = Convert.ToInt16(missionDataGrid.Rows[a].Cells[Par2.Index].Value.ToString()); // parameter
                p3 = Convert.ToInt16(missionDataGrid.Rows[a].Cells[Par3.Index].Value.ToString()); // parameter

                lat = Convert.ToDouble(missionDataGrid.Rows[a].Cells[LATCOL.Index].Value.ToString()); // lat
                lon = Convert.ToDouble(missionDataGrid.Rows[a].Cells[LONCOL.Index].Value.ToString()); // lng

                flag = 0;
                if (a == (missionDataGrid.Rows.Count - 1)) flag = 0xa5;

                sendWPToMultiWii(serialPort, a + 1, action, lat, lon, altitude, p1,p2,p3, flag);

                qStatus = Query_WP(Convert.ToByte(a + 1));

                if (qStatus == WP_Query.Timeout)
                {
                    MessageBox.Show("No answer from FC, mission upload aborted. Try reading mission again.", "Answer timeout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                if (qStatus == WP_Query.Error)
                {
                    MessageBox.Show("Error condition occured, most likely Navigatgion is in progress, land, disarm and try again.", "Upload error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                //It is possible that we already have a mission in EEPROM and the write command did not go through
                //In this case the waypoint reload will be successfull, but data comes from pervious mission

                //Check wp_action and lat/lon to make it sure
                if ((mission_step.action != action) || (mission_step.lat != (int)(Math.Round(lat * 10000000))) || (mission_step.lon != (int)(Math.Round(lon * 10000000))))
                {
                    MessageBox.Show("Upload failed - most likely a communication error\r\nCheck copter, comms and try again.", "Upload error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    qStatus = WP_Query.Error;
                    break;
                }
            }
            if (qStatus == WP_Query.OK)
            {
                MessageBox.Show("Mission successfully uploaded.\r\nIt is recommended to re-download your mission for double checking.", "Upload completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnDownLoadMission_Click(object sender, EventArgs e)
        {
            //Clean up current mission   
            missionDataGrid.Rows.Clear();
            updateMap();

            byte i = 1;         //start from wp1
            int qStatus;
            bool finished = false;
            string strAction = "";

            while (!finished)
            {

                qStatus = Query_WP(i);
                if (qStatus == WP_Query.OK)
                {

                    switch (mission_step.action)
                    {
                        case WP_ACTION.WAYPOINT: strAction = "WAYPOINT";
                            break;
                        case WP_ACTION.HOLD_UNLIM: strAction = "POSHOLD_UNLIM";
                            break;
                        case WP_ACTION.HOLD_TIME: strAction = "POSHOLD_TIME";
                            break;
                        case WP_ACTION.RTH: strAction = "RTH";
                            break;
                        case WP_ACTION.JUMP: strAction = "JUMP";
                            break;
                        case WP_ACTION.SET_POI: strAction = "SET_POI";
                            break;
                        case WP_ACTION.SET_HEAD: strAction = "SET_HEAD";
                            break;
                        case WP_ACTION.LAND: strAction = "LAND";
                            break;
                            
                    }

                    addWP(strAction, mission_step.p1,mission_step.p2,mission_step.p3, (double)mission_step.lat / 10000000.0, (double)mission_step.lon / 10000000.0, mission_step.altitude / 100);
                    //Clear update flag
                    mission_step.wp_updated = false;
                    i++;
                    if (mission_step.flag == MISSION_FLAG_END) finished = true;

                }

                if (qStatus == WP_Query.Timeout)
                {
                    finished = true;
                    MessageBox.Show("No answer from FC, mission list may be uncompleted. Try reading mission again.", "Answer timeout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (qStatus == WP_Query.Error)
                {
                    finished = true;
                    MessageBox.Show("Error condition occured, most likely Navigatgion is in progress, land, disarm and try again.", "Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (qStatus == WP_Query.CRC)
                {
                    finished = true;
                    MessageBox.Show("CRC error during EEPROM read, mission description is corrupted, upload again.", "CRC error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (i == 255)
                {
                    finished = true;
                    missionDataGrid.Rows.Clear();
                    updateMap();
                    MessageBox.Show("Download overrun, invalid responses are received, check communication", "Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void cbShowGauges_CheckedChanged(object sender, EventArgs e)
        {
            if (bShowGauges)
            {
                //Hide gauges
                bShowGauges = false;
                gpsIndicator2.Visible = false;
                vertical_speed_indicator2.Visible = false;
                altitude_meter2.Visible = false;
                barRSSIMission.Visible = false;
                battery_indicator2.Visible = false;
                if (indicators_mission != null) 
                   for (int i = 0; i < iCheckBoxItems; i++) indicators_mission[i].Visible = false;
            }
            else
            {
                //Show gauges
                bShowGauges = true;
                gpsIndicator2.Visible = true;
                vertical_speed_indicator2.Visible = true;
                altitude_meter2.Visible = true;
                barRSSIMission.Visible = true;
                battery_indicator2.Visible = true;
                if (indicators_mission != null)
                   for (int i = 0; i < iCheckBoxItems; i++) indicators_mission[i].Visible = true;

            }





        }

        private void tsMenuAddWP_Click(object sender, EventArgs e)
        {
            addWP("WAYPOINT", 0, 0, 0, start.Lat, start.Lng, iDefAlt);
        }

        private void tsMenuAddPosholdTimed_Click(object sender, EventArgs e)
        {

            string time = "20";
            int iTime = 20;
            if (System.Windows.Forms.DialogResult.Cancel == InputBox.Show("Poshold Time", "Poshold Time in seconds", ref time))
                return;

            int.TryParse(time, out iTime);
            addWP("POSHOLD_TIME", iTime, 0, 0, start.Lat, start.Lng, iDefAlt);
        }

        private void tsMenuAddPosholdUnlim_Click(object sender, EventArgs e)
        {
            addWP("POSHOLD_UNLIM", 0, 0, 0, start.Lat, start.Lng, iDefAlt);
        }

        private void tsMenuAddRTH_Click(object sender, EventArgs e)
        {
            addWP("RTH", 0, 0, 0, 0, 0, 0);
        }

        private void tsMenuAddJump_Click(object sender, EventArgs e)
        {
            int iWp, iRep;

            string wp = "1";
            if (System.Windows.Forms.DialogResult.Cancel == InputBox.Show("WP No", "Jump to WP no?", ref wp))
                return;
            string repeat = "5";
            if (System.Windows.Forms.DialogResult.Cancel == InputBox.Show("Jump repeat", "Number of times to Repeat (-1 means always)", ref repeat))
                return;

            int.TryParse(wp, out iWp);
            int.TryParse(repeat, out iRep);

            if (iWp < 1 || iWp > missionDataGrid.Rows.Count) return;

            addWP("JUMP", iWp, iRep, 0, 0, 0, 0);

        }

        private void tsMenuAddPOI_Click(object sender, EventArgs e)
        {
            addWP("SET_POI", 0, 0, 0, start.Lat, start.Lng, 0);
        }

        private void tsMenuSetHead_Click(object sender, EventArgs e)
        {
            string head = "0";
            int iHead = 0;
            if (System.Windows.Forms.DialogResult.Cancel == InputBox.Show("Set Heading", "Set copter headinf (0-360 degree) -1 clears heading control", ref head))
                return;
            int.TryParse(head, out iHead);
            addWP("SET_HEAD", iHead, 0, 0, 0, 0, 0);

        }

        private void clearMissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clean up current mission   
            missionDataGrid.Rows.Clear();
            updateMap();
        }

        private void createCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string RadiusIn = "50";
            if (System.Windows.Forms.DialogResult.Cancel == InputBox.Show("Radius", "Radius in meters (min 20)", ref RadiusIn))
                return;

            string Pointsin = "20";
            if (System.Windows.Forms.DialogResult.Cancel == InputBox.Show("Points", "Number of points to generate Circle (min 5 - max 30)", ref Pointsin))
                return;

            string Directionin = "1";
            if (System.Windows.Forms.DialogResult.Cancel == InputBox.Show("Points", "Direction of circle (-1 or 1)", ref Directionin))
                return;

            int Points = 0;
            int Radius = 0;
            int Direction = 1;

            if (!int.TryParse(RadiusIn, out Radius) || Radius < 20)
            {
                MessageBox.Show("Invalid Radius");
                return;
            }

            if (!int.TryParse(Pointsin, out Points) || Points < 5 || Points >30 )
            {
                MessageBox.Show("Invalid Number of points");
                return;
            }

            if (!int.TryParse(Directionin, out Direction))
            {
                MessageBox.Show("Invalid Direction value");
                return;
            }

            double a = 0;
            double step = 360.0f / Points;
            if (Direction == -1)
            {
                a = 360;
                step *= -1;
            }
            for (; a <= 360 && a >= 0; a += step)
            {

                float d = Radius;
                float R = 6371000;

                const float rad2deg = (float)(180 / Math.PI);
                const float deg2rad = (float)(1.0 / rad2deg);

                var lat2 = Math.Asin(Math.Sin(start.Lat * deg2rad) * Math.Cos(d / R) +
              Math.Cos(start.Lat * deg2rad) * Math.Sin(d / R) * Math.Cos(a * deg2rad));
                var lon2 = start.Lng * deg2rad + Math.Atan2(Math.Sin(a * deg2rad) * Math.Sin(d / R) * Math.Cos(start.Lat * deg2rad),
                                     Math.Cos(d / R) - Math.Sin(start.Lat * deg2rad) * Math.Sin(lat2));

                PointLatLng pll = new PointLatLng(lat2 * rad2deg, lon2 * rad2deg);
                addWP("WAYPOINT", 0, 0, 0, pll.Lat, pll.Lng, iDefAlt);


            }

        }

        private void contextMenuStripMap_Opening(object sender, CancelEventArgs e)
        {
            if (bGoToClikEnabled) e.Cancel = true;
            return;
        }

        private void bulkAltitudeChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string altdif = "0";
            InputBox.Show("Bulk Altitude Change", "Please enter the required altitude change (either plus or minus)", ref altdif);

            int altchange = int.Parse(altdif);

            foreach (DataGridViewRow line in missionDataGrid.Rows)
            {
                if ( (string)line.Cells[Action.Index].Value == "WAYPOINT" || (string)line.Cells[Action.Index].Value == "POSHOLD_TIME" || (string)line.Cells[Action.Index].Value == "POSHOLD_UNLIM")
                   line.Cells[ALTCOL.Index].Value = (int)(float.Parse(line.Cells[ALTCOL.Index].Value.ToString()) + altchange);
            }

        }

        private void tsMenuDeleteWP_Click(object sender, EventArgs e)
        {

         int no = 0;
         if (CurentRectMarker != null)
         {
             if (int.TryParse(CurentRectMarker.InnerMarker.Tag.ToString(), out no))
             {
                 try
                 {
                     missionDataGrid.Rows.RemoveAt(no - 1); // home is 0
                     updateMap();
                     updateIndex();
                 }
                 catch { MessageBox.Show("error selecting wp, please try again."); }
             }
         }

         if (currentMarker != null)
             CurentRectMarker = null;


        }

        private void checkBoxEx5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsMenuAddLand_Click(object sender, EventArgs e)
        {
            addWP("LAND", 0, 0, 0, start.Lat, start.Lng, iDefAlt);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            serial_ports_enumerate();
        }

        private void cbCellcount_SelectedIndexChanged(object sender, EventArgs e)
        {
            gui_settings.cellcount = Convert.ToByte(cbCellcount.SelectedIndex + 1);
            battery_indicator1.SetVoltage(mw_gui.vBat, gui_settings.cellcount);
            b_save_gui_settings.BackColor = Color.LightCoral;
        }

        private void btnMapZoomUp_Click(object sender, EventArgs e)
        {
            if (MainMap.Zoom < 20) MainMap.Zoom += 1;
        }

        private void btnMapZoopDown_Click(object sender, EventArgs e)
        {
            if (MainMap.Zoom > 2) MainMap.Zoom -= 1;
        }

        private void nSrvMid1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer_announce_Tick(object sender, EventArgs e)
        {
            //Announce is active only when copter is armed
            if (isArmed() && speech !=null && isConnected)
            {
                   if (gui_settings.announce_alt_enabled) speech.SpeakAsync("Altitude " + Convert.ToString(mw_gui.EstAlt / 100) + " meters.");
                   if (gui_settings.announce_vbat_enabled) speech.SpeakAsync("Battery " + Convert.ToString(((double)mw_gui.vBat) / 10) + "volts");
                   if (gui_settings.announce_dist_enabled) speech.SpeakAsync("Distance " + Convert.ToString(mw_gui.GPS_distanceToHome) + "meters.");
            }
        }

        private void cbSpeakBattery_CheckedChanged(object sender, EventArgs e)
        {
            gui_settings.announce_vbat_enabled = cbSpeakBattery.Checked;
            b_save_gui_settings.BackColor = Color.LightCoral;

        }

        private void cbSpeakAlt_CheckedChanged(object sender, EventArgs e)
        {
            gui_settings.announce_alt_enabled = cbSpeakAlt.Checked;
            b_save_gui_settings.BackColor = Color.LightCoral;
        }

        private void cbSpeakDist_CheckedChanged(object sender, EventArgs e)
        {
            gui_settings.announce_dist_enabled = cbSpeakDist.Checked;
            b_save_gui_settings.BackColor = Color.LightCoral;
        }

        private void comboSpeakInterval_SelectedIndexChanged(object sender, EventArgs e)
        {

            gui_settings.announce_interval = comboSpeakInterval.SelectedIndex;
            b_save_gui_settings.BackColor = Color.LightCoral;
            switch(comboSpeakInterval.SelectedIndex)
            {
                case 0: timer_announce.Interval = 10000;
                    break;
                case 1: timer_announce.Interval = 15000;
                    break;
                case 2: timer_announce.Interval = 30000;
                    break;
                case 3: timer_announce.Interval = 60000;
                    break;
                case 4: timer_announce.Interval = 90000;
                    break;
                default: timer_announce.Interval = 60000;
                    break;
            }
            
        }



 
    }

}
