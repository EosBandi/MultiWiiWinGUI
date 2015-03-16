namespace MultiWiiWinGUI
{
    partial class mainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGUI));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageFlightDeck = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bBind = new System.Windows.Forms.Button();
            this.b_cal_acc = new System.Windows.Forms.Button();
            this.cb_monitor_rate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_pause = new System.Windows.Forms.Button();
            this.b_cal_mag = new System.Windows.Forms.Button();
            this.l_cycletime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.battery_indicator1 = new MultiWiiGUIControls.battery_indicator();
            this.vertical_speed_indicator1 = new MultiWiiGUIControls.vertical_speed_indicator();
            this.altitude_meter1 = new MultiWiiGUIControls.altitude_meter();
            this.attitudeIndicatorInstrumentControl1 = new MultiWiiGUIControls.artifical_horizon();
            this.gpsIndicator = new MultiWiiGUIControls.GpsIndicatorInstrumentControl();
            this.headingIndicatorInstrumentControl1 = new MultiWiiGUIControls.heading_indicator();
            this.label47 = new System.Windows.Forms.Label();
            this.rc_input_control1 = new MultiWiiGUIControls.rc_input_control();
            this.motorsIndicator1 = new MultiWiiGUIControls.MWGUIMotors();
            this.indACC = new MultiWiiGUIControls.indicator_lamp();
            this.indGPS = new MultiWiiGUIControls.indicator_lamp();
            this.indOPTIC = new MultiWiiGUIControls.indicator_lamp();
            this.indBARO = new MultiWiiGUIControls.indicator_lamp();
            this.indMAG = new MultiWiiGUIControls.indicator_lamp();
            this.indSONAR = new MultiWiiGUIControls.indicator_lamp();
            this.label81 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.barNoise = new MultiWiiGUIControls.ColorProgressBar();
            this.barRSSI = new MultiWiiGUIControls.ColorProgressBar();
            this.labelRSSI = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.labelNoise = new System.Windows.Forms.Label();
            this.labelSentPackets = new System.Windows.Forms.Label();
            this.l_i2cerrors = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelReceivedPackets = new System.Windows.Forms.Label();
            this.l_vbatt = new System.Windows.Forms.Label();
            this.labelCRCErrors = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_powersum = new System.Windows.Forms.Label();
            this.tabPageMisson = new System.Windows.Forms.TabPage();
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuAddWP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddPosholdTimed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddPosholdUnlim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddRTH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddLand = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddJump = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddPOI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSetHead = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuDeleteWP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.clearMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkAltitudeChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fetchMapTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.cbShowFlightPath = new System.Windows.Forms.CheckBox();
            this.cbShowPos = new System.Windows.Forms.CheckBox();
            this.cbShowWP = new System.Windows.Forms.CheckBox();
            this.cbShowMission = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbMapProviders = new System.Windows.Forms.ComboBox();
            this.b_Clear_Route = new System.Windows.Forms.Button();
            this.spcontMapMain = new System.Windows.Forms.SplitContainer();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.btnMapZoopDown = new System.Windows.Forms.Button();
            this.btnMapZoomUp = new System.Windows.Forms.Button();
            this.battery_indicator2 = new MultiWiiGUIControls.battery_indicator();
            this.barRSSIMission = new MultiWiiGUIControls.ColorProgressBar();
            this.lNavError = new System.Windows.Forms.Label();
            this.cbAutoPan = new MultiWiiGUIControls.CheckBoxEx();
            this.cbShowGauges = new MultiWiiGUIControls.CheckBoxEx();
            this.altitude_meter2 = new MultiWiiGUIControls.altitude_meter();
            this.vertical_speed_indicator2 = new MultiWiiGUIControls.vertical_speed_indicator();
            this.gpsIndicator2 = new MultiWiiGUIControls.GpsIndicatorInstrumentControl();
            this.LMousePos = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.lNavState = new System.Windows.Forms.Label();
            this.lGpsMode = new System.Windows.Forms.Label();
            this.l11 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.cbSendGTCAlt = new System.Windows.Forms.CheckBox();
            this.txtGTCAlt = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.bClickToGo = new System.Windows.Forms.Button();
            this.l_GPS_numsat = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.l_GPS_alt = new System.Windows.Forms.Label();
            this.lGPS_lon = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lGPS_lat = new System.Windows.Forms.Label();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.missionDataGrid = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Par1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Par2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Par3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LATCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LONCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALTCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UP = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.DEL = new System.Windows.Forms.DataGridViewImageColumn();
            this.label75 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.lDistLastWP = new System.Windows.Forms.Label();
            this.btnLoadMission = new System.Windows.Forms.Button();
            this.btnSaveMission = new System.Windows.Forms.Button();
            this.btnDownLoadMission = new System.Windows.Forms.Button();
            this.btnUploadMission = new System.Windows.Forms.Button();
            this.txtDefAlt = new System.Windows.Forms.TextBox();
            this.lDistance = new System.Windows.Forms.Label();
            this.lDefAlt = new System.Windows.Forms.Label();
            this.tabPagePID = new System.Windows.Forms.TabPage();
            this.naviGroup = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.nLandSpeed = new System.Windows.Forms.NumericUpDown();
            this.label71 = new System.Windows.Forms.Label();
            this.nFence = new System.Windows.Forms.NumericUpDown();
            this.cbNavBaroTakeover = new MultiWiiGUIControls.CheckBoxEx();
            this.cbNavDisableSticks = new MultiWiiGUIControls.CheckBoxEx();
            this.cbNavGPS_filtering = new MultiWiiGUIControls.CheckBoxEx();
            this.label88 = new System.Windows.Forms.Label();
            this.cbNavGPS_Lead = new MultiWiiGUIControls.CheckBoxEx();
            this.nBanking = new System.Windows.Forms.NumericUpDown();
            this.cbNavResetHome = new MultiWiiGUIControls.CheckBoxEx();
            this.label87 = new System.Windows.Forms.Label();
            this.cbNavHeadingControl = new MultiWiiGUIControls.CheckBoxEx();
            this.nCrosstrack = new System.Windows.Forms.NumericUpDown();
            this.cbNavTailFirst = new MultiWiiGUIControls.CheckBoxEx();
            this.label86 = new System.Windows.Forms.Label();
            this.cbNavRTHHead = new MultiWiiGUIControls.CheckBoxEx();
            this.nRTHAlt = new System.Windows.Forms.NumericUpDown();
            this.cbNavWaitRTHAlt = new MultiWiiGUIControls.CheckBoxEx();
            this.label85 = new System.Windows.Forms.Label();
            this.cbNavSlowNav = new MultiWiiGUIControls.CheckBoxEx();
            this.nMinSpeed = new System.Windows.Forms.NumericUpDown();
            this.nWPRadius = new System.Windows.Forms.NumericUpDown();
            this.label84 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.nMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.nSafeWPDist = new System.Windows.Forms.NumericUpDown();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.nMaxAlt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nTEXPO = new System.Windows.Forms.NumericUpDown();
            this.nTMID = new System.Windows.Forms.NumericUpDown();
            this.trackBar_T_EXPO = new System.Windows.Forms.TrackBar();
            this.trackBar_T_MID = new System.Windows.Forms.TrackBar();
            this.trackbar_RC_Rate = new System.Windows.Forms.TrackBar();
            this.label65 = new System.Windows.Forms.Label();
            this.trackbar_RC_Expo = new System.Windows.Forms.TrackBar();
            this.nRCRate = new System.Windows.Forms.NumericUpDown();
            this.nRCExpo = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label_sok = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.nRATE_tpid = new System.Windows.Forms.NumericUpDown();
            this.nRATE_yaw = new System.Windows.Forms.NumericUpDown();
            this.nRATE_rp = new System.Windows.Forms.NumericUpDown();
            this.throttle_expo_control1 = new MultiWiiGUIControls.throttle_expo_control();
            this.rc_expo_control1 = new MultiWiiGUIControls.rc_expo_control();
            this.tabPageConf = new System.Windows.Forms.TabPage();
            this.lVBatConf = new System.Windows.Forms.Label();
            this.labelvbat = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.lMaxThr = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.nFSThr = new System.Windows.Forms.NumericUpDown();
            this.label59 = new System.Windows.Forms.Label();
            this.nMinThr = new System.Windows.Forms.NumericUpDown();
            this.lMinCommand = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label62 = new System.Windows.Forms.Label();
            this.lLife = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.lArms = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label68 = new System.Windows.Forms.Label();
            this.nVBatCritical = new System.Windows.Forms.NumericUpDown();
            this.nPAlarm = new System.Windows.Forms.NumericUpDown();
            this.nVBatWarn2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nVBatWarn1 = new System.Windows.Forms.NumericUpDown();
            this.label63 = new System.Windows.Forms.Label();
            this.nVBatScale = new System.Windows.Forms.NumericUpDown();
            this.label64 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbMagSign = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.nMagDeg = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.nMagMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nSrvRate4 = new System.Windows.Forms.NumericUpDown();
            this.label56 = new System.Windows.Forms.Label();
            this.cbSrvRev1 = new MultiWiiGUIControls.CheckBoxEx();
            this.label55 = new System.Windows.Forms.Label();
            this.cbSrvRev2 = new MultiWiiGUIControls.CheckBoxEx();
            this.label54 = new System.Windows.Forms.Label();
            this.cbSrvRev3 = new MultiWiiGUIControls.CheckBoxEx();
            this.label53 = new System.Windows.Forms.Label();
            this.cbSrvRev4 = new MultiWiiGUIControls.CheckBoxEx();
            this.label52 = new System.Windows.Forms.Label();
            this.cbSrvRev5 = new MultiWiiGUIControls.CheckBoxEx();
            this.label51 = new System.Windows.Forms.Label();
            this.cbSrvRev6 = new MultiWiiGUIControls.CheckBoxEx();
            this.nSrvMax8 = new System.Windows.Forms.NumericUpDown();
            this.cbSrvRev7 = new MultiWiiGUIControls.CheckBoxEx();
            this.nSrvMax7 = new System.Windows.Forms.NumericUpDown();
            this.cbSrvRev8 = new MultiWiiGUIControls.CheckBoxEx();
            this.nSrvMax6 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID1 = new System.Windows.Forms.Label();
            this.nSrvMax5 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID2 = new System.Windows.Forms.Label();
            this.nSrvMax4 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID3 = new System.Windows.Forms.Label();
            this.nSrvMax3 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID4 = new System.Windows.Forms.Label();
            this.nSrvMax2 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID5 = new System.Windows.Forms.Label();
            this.nSrvMax1 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID6 = new System.Windows.Forms.Label();
            this.nSrvMid8 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID7 = new System.Windows.Forms.Label();
            this.nSrvMid7 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID8 = new System.Windows.Forms.Label();
            this.nSrvMid6 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName1 = new System.Windows.Forms.Label();
            this.nSrvMid5 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName3 = new System.Windows.Forms.Label();
            this.nSrvMid4 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName2 = new System.Windows.Forms.Label();
            this.nSrvMid3 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName4 = new System.Windows.Forms.Label();
            this.nSrvMid2 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName5 = new System.Windows.Forms.Label();
            this.nSrvMid1 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName6 = new System.Windows.Forms.Label();
            this.nSrvMin8 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName7 = new System.Windows.Forms.Label();
            this.nSrvMin7 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName8 = new System.Windows.Forms.Label();
            this.nSrvMin6 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate1 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMin5 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate2 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMin4 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate3 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMin3 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate5 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMin2 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate6 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMin1 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate7 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate8 = new System.Windows.Forms.NumericUpDown();
            this.tabPageRC = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rci_Control_settings = new MultiWiiGUIControls.rc_input_control();
            this.tabSensorGraph = new System.Windows.Forms.TabPage();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.splitContainer12 = new System.Windows.Forms.SplitContainer();
            this.zgMonitor = new ZedGraph.ZedGraphControl();
            this.label28 = new System.Windows.Forms.Label();
            this.cb_dbg1 = new System.Windows.Forms.CheckBox();
            this.l_dbg1 = new System.Windows.Forms.Label();
            this.cb_dbg2 = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.l_dbg2 = new System.Windows.Forms.Label();
            this.cb_dbg3 = new System.Windows.Forms.CheckBox();
            this.l_dbg4 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.l_dbg3 = new System.Windows.Forms.Label();
            this.cb_dbg4 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_uncheck_all_ACC = new System.Windows.Forms.Button();
            this.b_check_all_ACC = new System.Windows.Forms.Button();
            this.l_acc_z = new System.Windows.Forms.Label();
            this.l_acc_pitch = new System.Windows.Forms.Label();
            this.l_acc_roll = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_acc_z = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_acc_pitch = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_acc_roll = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_uncheck_all_GYRO = new System.Windows.Forms.Button();
            this.b_check_all_GYRO = new System.Windows.Forms.Button();
            this.l_gyro_yaw = new System.Windows.Forms.Label();
            this.l_gyro_pitch = new System.Windows.Forms.Label();
            this.l_gyro_roll = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cb_gyro_yaw = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cb_gyro_pitch = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cb_gyro_roll = new System.Windows.Forms.CheckBox();
            this.cb_alt = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_uncheck_all_MAG = new System.Windows.Forms.Button();
            this.b_check_all_MAG = new System.Windows.Forms.Button();
            this.l_mag_yaw = new System.Windows.Forms.Label();
            this.l_mag_pitch = new System.Windows.Forms.Label();
            this.l_mag_roll = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.cb_mag_yaw = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cb_mag_pitch = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.cb_mag_roll = new System.Windows.Forms.CheckBox();
            this.l_alt = new System.Windows.Forms.Label();
            this.cb_head = new System.Windows.Forms.CheckBox();
            this.l_head = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPageVideo = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.dropdown_devices = new System.Windows.Forms.ComboBox();
            this.b_video_connect = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.b_Record = new System.Windows.Forms.Button();
            this.cb_codec = new System.Windows.Forms.ComboBox();
            this.nFrameRate = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nBitRate = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.l_capture_file = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.comboSpeakInterval = new System.Windows.Forms.ComboBox();
            this.cbSpeakDist = new System.Windows.Forms.CheckBox();
            this.cbSpeakAlt = new System.Windows.Forms.CheckBox();
            this.cbSpeakBattery = new System.Windows.Forms.CheckBox();
            this.cbGUISpeechEnabled = new System.Windows.Forms.CheckBox();
            this.cbCellcount = new System.Windows.Forms.ComboBox();
            this.label70 = new System.Windows.Forms.Label();
            this.l_i2cdatasupress = new System.Windows.Forms.Label();
            this.b_check_update = new System.Windows.Forms.Button();
            this.b_select_settings_folder = new System.Windows.Forms.Button();
            this.l_Settings_folder = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cb_Log10 = new System.Windows.Forms.CheckBox();
            this.cb_Log9 = new System.Windows.Forms.CheckBox();
            this.cb_Log8 = new System.Windows.Forms.CheckBox();
            this.cb_Log7 = new System.Windows.Forms.CheckBox();
            this.cb_Log6 = new System.Windows.Forms.CheckBox();
            this.cb_Log5 = new System.Windows.Forms.CheckBox();
            this.cb_Log4 = new System.Windows.Forms.CheckBox();
            this.cb_Log3 = new System.Windows.Forms.CheckBox();
            this.cb_Log2 = new System.Windows.Forms.CheckBox();
            this.cb_Log1 = new System.Windows.Forms.CheckBox();
            this.b_save_gui_settings = new System.Windows.Forms.Button();
            this.cb_Logging_enabled = new System.Windows.Forms.CheckBox();
            this.b_select_capture_folder = new System.Windows.Forms.Button();
            this.l_Capture_folder = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.b_select_log_folder = new System.Windows.Forms.Button();
            this.l_LogFolder = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPageCLI = new System.Windows.Forms.TabPage();
            this.gbTerminal = new System.Windows.Forms.GroupBox();
            this.cmdCLISend = new System.Windows.Forms.Button();
            this.txtCLICommand = new System.Windows.Forms.TextBox();
            this.txtCLIResult = new System.Windows.Forms.TextBox();
            this.timer_realtime = new System.Windows.Forms.Timer(this.components);
            this.bkgWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cb_serial_port = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cb_serial_speed = new System.Windows.Forms.ToolStripComboBox();
            this.b_connect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.b_read_settings = new System.Windows.Forms.ToolStripButton();
            this.b_write_settings = new System.Windows.Forms.ToolStripButton();
            this.b_reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.b_load_from_file = new System.Windows.Forms.ToolStripButton();
            this.b_write_to_file = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.b_log = new System.Windows.Forms.ToolStripButton();
            this.b_start_KML_log = new System.Windows.Forms.ToolStripButton();
            this.b_log_browser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.b_about = new System.Windows.Forms.ToolStripButton();
            this.bDebugWindws = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer_announce = new System.Windows.Forms.Timer(this.components);
            this.tabMain.SuspendLayout();
            this.tabPageFlightDeck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabPageMisson.SuspendLayout();
            this.contextMenuStripMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcontMapMain)).BeginInit();
            this.spcontMapMain.Panel1.SuspendLayout();
            this.spcontMapMain.Panel2.SuspendLayout();
            this.spcontMapMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missionDataGrid)).BeginInit();
            this.tabPagePID.SuspendLayout();
            this.naviGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLandSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCrosstrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRTHAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWPRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSafeWPDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTEXPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTMID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_T_EXPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_T_MID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_RC_Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_RC_Expo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRCRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRCExpo)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_tpid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_rp)).BeginInit();
            this.tabPageConf.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFSThr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinThr)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatCritical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatWarn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatWarn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatScale)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMagDeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMagMin)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate8)).BeginInit();
            this.tabPageRC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabSensorGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).BeginInit();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).BeginInit();
            this.splitContainer12.Panel1.SuspendLayout();
            this.splitContainer12.Panel2.SuspendLayout();
            this.splitContainer12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFrameRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBitRate)).BeginInit();
            this.tabPageSettings.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPageCLI.SuspendLayout();
            this.gbTerminal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageFlightDeck);
            this.tabMain.Controls.Add(this.tabPageMisson);
            this.tabMain.Controls.Add(this.tabPagePID);
            this.tabMain.Controls.Add(this.tabPageConf);
            this.tabMain.Controls.Add(this.tabPageRC);
            this.tabMain.Controls.Add(this.tabSensorGraph);
            this.tabMain.Controls.Add(this.tabPageVideo);
            this.tabMain.Controls.Add(this.tabPageSettings);
            this.tabMain.Controls.Add(this.tabPageCLI);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 54);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 1;
            this.tabMain.Size = new System.Drawing.Size(1056, 470);
            this.tabMain.TabIndex = 9;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabPageFlightDeck
            // 
            this.tabPageFlightDeck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageFlightDeck.Controls.Add(this.splitContainer1);
            this.tabPageFlightDeck.ForeColor = System.Drawing.Color.White;
            this.tabPageFlightDeck.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlightDeck.Name = "tabPageFlightDeck";
            this.tabPageFlightDeck.Size = new System.Drawing.Size(1048, 444);
            this.tabPageFlightDeck.TabIndex = 2;
            this.tabPageFlightDeck.Text = "Flight Deck";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bBind);
            this.splitContainer1.Panel1.Controls.Add(this.b_cal_acc);
            this.splitContainer1.Panel1.Controls.Add(this.cb_monitor_rate);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.b_pause);
            this.splitContainer1.Panel1.Controls.Add(this.b_cal_mag);
            this.splitContainer1.Panel1.Controls.Add(this.l_cycletime);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1048, 444);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.TabIndex = 108;
            // 
            // bBind
            // 
            this.bBind.ForeColor = System.Drawing.Color.Black;
            this.bBind.Location = new System.Drawing.Point(478, 3);
            this.bBind.Name = "bBind";
            this.bBind.Size = new System.Drawing.Size(90, 21);
            this.bBind.TabIndex = 100;
            this.bBind.Text = "Bind Spektrum";
            this.bBind.UseVisualStyleBackColor = true;
            this.bBind.Click += new System.EventHandler(this.bBind_Click);
            // 
            // b_cal_acc
            // 
            this.b_cal_acc.ForeColor = System.Drawing.Color.Black;
            this.b_cal_acc.Location = new System.Drawing.Point(237, 3);
            this.b_cal_acc.Name = "b_cal_acc";
            this.b_cal_acc.Size = new System.Drawing.Size(90, 21);
            this.b_cal_acc.TabIndex = 78;
            this.b_cal_acc.Text = "Calibrate ACC";
            this.b_cal_acc.UseVisualStyleBackColor = true;
            this.b_cal_acc.Click += new System.EventHandler(this.b_cal_acc_Click);
            // 
            // cb_monitor_rate
            // 
            this.cb_monitor_rate.BackColor = System.Drawing.Color.DimGray;
            this.cb_monitor_rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_monitor_rate.ForeColor = System.Drawing.Color.White;
            this.cb_monitor_rate.FormattingEnabled = true;
            this.cb_monitor_rate.Location = new System.Drawing.Point(4, 3);
            this.cb_monitor_rate.Name = "cb_monitor_rate";
            this.cb_monitor_rate.Size = new System.Drawing.Size(61, 21);
            this.cb_monitor_rate.TabIndex = 3;
            this.cb_monitor_rate.SelectedIndexChanged += new System.EventHandler(this.cb_monitor_rate_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Refresh Rate";
            // 
            // b_pause
            // 
            this.b_pause.ForeColor = System.Drawing.Color.Black;
            this.b_pause.Location = new System.Drawing.Point(157, 3);
            this.b_pause.Name = "b_pause";
            this.b_pause.Size = new System.Drawing.Size(74, 21);
            this.b_pause.TabIndex = 77;
            this.b_pause.Text = "Pause";
            this.b_pause.UseVisualStyleBackColor = true;
            this.b_pause.Click += new System.EventHandler(this.b_pause_Click);
            // 
            // b_cal_mag
            // 
            this.b_cal_mag.ForeColor = System.Drawing.Color.Black;
            this.b_cal_mag.Location = new System.Drawing.Point(333, 3);
            this.b_cal_mag.Name = "b_cal_mag";
            this.b_cal_mag.Size = new System.Drawing.Size(90, 21);
            this.b_cal_mag.TabIndex = 79;
            this.b_cal_mag.Text = "Calibrate Mag";
            this.b_cal_mag.UseVisualStyleBackColor = true;
            this.b_cal_mag.Click += new System.EventHandler(this.b_cal_mag_Click);
            // 
            // l_cycletime
            // 
            this.l_cycletime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l_cycletime.AutoSize = true;
            this.l_cycletime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cycletime.Location = new System.Drawing.Point(977, 9);
            this.l_cycletime.Name = "l_cycletime";
            this.l_cycletime.Size = new System.Drawing.Size(55, 15);
            this.l_cycletime.TabIndex = 98;
            this.l_cycletime.Text = "0000 ms";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(904, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 99;
            this.label11.Text = "Cycle Time:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label81);
            this.splitContainer2.Panel2.Controls.Add(this.label80);
            this.splitContainer2.Panel2.Controls.Add(this.label79);
            this.splitContainer2.Panel2.Controls.Add(this.barNoise);
            this.splitContainer2.Panel2.Controls.Add(this.barRSSI);
            this.splitContainer2.Panel2.Controls.Add(this.labelRSSI);
            this.splitContainer2.Panel2.Controls.Add(this.label69);
            this.splitContainer2.Panel2.Controls.Add(this.labelNoise);
            this.splitContainer2.Panel2.Controls.Add(this.labelSentPackets);
            this.splitContainer2.Panel2.Controls.Add(this.l_i2cerrors);
            this.splitContainer2.Panel2.Controls.Add(this.label44);
            this.splitContainer2.Panel2.Controls.Add(this.label21);
            this.splitContainer2.Panel2.Controls.Add(this.label43);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.labelReceivedPackets);
            this.splitContainer2.Panel2.Controls.Add(this.l_vbatt);
            this.splitContainer2.Panel2.Controls.Add(this.labelCRCErrors);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.l_powersum);
            this.splitContainer2.Size = new System.Drawing.Size(1048, 408);
            this.splitContainer2.SplitterDistance = 312;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.battery_indicator1);
            this.splitContainer3.Panel1.Controls.Add(this.vertical_speed_indicator1);
            this.splitContainer3.Panel1.Controls.Add(this.altitude_meter1);
            this.splitContainer3.Panel1.Controls.Add(this.attitudeIndicatorInstrumentControl1);
            this.splitContainer3.Panel1.Controls.Add(this.gpsIndicator);
            this.splitContainer3.Panel1.Controls.Add(this.headingIndicatorInstrumentControl1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label47);
            this.splitContainer3.Panel2.Controls.Add(this.rc_input_control1);
            this.splitContainer3.Panel2.Controls.Add(this.motorsIndicator1);
            this.splitContainer3.Panel2.Controls.Add(this.indACC);
            this.splitContainer3.Panel2.Controls.Add(this.indGPS);
            this.splitContainer3.Panel2.Controls.Add(this.indOPTIC);
            this.splitContainer3.Panel2.Controls.Add(this.indBARO);
            this.splitContainer3.Panel2.Controls.Add(this.indMAG);
            this.splitContainer3.Panel2.Controls.Add(this.indSONAR);
            this.splitContainer3.Size = new System.Drawing.Size(1048, 312);
            this.splitContainer3.SplitterDistance = 632;
            this.splitContainer3.TabIndex = 0;
            // 
            // battery_indicator1
            // 
            this.battery_indicator1.Location = new System.Drawing.Point(326, 154);
            this.battery_indicator1.Name = "battery_indicator1";
            this.battery_indicator1.Size = new System.Drawing.Size(150, 150);
            this.battery_indicator1.TabIndex = 110;
            this.battery_indicator1.Text = "battery_indicator1";
            // 
            // vertical_speed_indicator1
            // 
            this.vertical_speed_indicator1.Location = new System.Drawing.Point(166, 154);
            this.vertical_speed_indicator1.Name = "vertical_speed_indicator1";
            this.vertical_speed_indicator1.Size = new System.Drawing.Size(160, 148);
            this.vertical_speed_indicator1.TabIndex = 109;
            this.vertical_speed_indicator1.Text = "vertical_speed_indicator1";
            // 
            // altitude_meter1
            // 
            this.altitude_meter1.Location = new System.Drawing.Point(166, 6);
            this.altitude_meter1.Name = "altitude_meter1";
            this.altitude_meter1.Size = new System.Drawing.Size(160, 148);
            this.altitude_meter1.TabIndex = 108;
            this.altitude_meter1.Text = "altitude_meter1";
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            this.attitudeIndicatorInstrumentControl1.Location = new System.Drawing.Point(9, 6);
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Size = new System.Drawing.Size(160, 148);
            this.attitudeIndicatorInstrumentControl1.TabIndex = 71;
            this.attitudeIndicatorInstrumentControl1.Text = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Click += new System.EventHandler(this.attitudeIndicatorInstrumentControl1_Click);
            // 
            // gpsIndicator
            // 
            this.gpsIndicator.Location = new System.Drawing.Point(9, 154);
            this.gpsIndicator.Name = "gpsIndicator";
            this.gpsIndicator.Size = new System.Drawing.Size(160, 148);
            this.gpsIndicator.TabIndex = 74;
            this.gpsIndicator.Text = "gpsIndicator";
            // 
            // headingIndicatorInstrumentControl1
            // 
            this.headingIndicatorInstrumentControl1.Location = new System.Drawing.Point(326, 7);
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            this.headingIndicatorInstrumentControl1.Size = new System.Drawing.Size(160, 148);
            this.headingIndicatorInstrumentControl1.TabIndex = 72;
            this.headingIndicatorInstrumentControl1.Text = "headingIndicatorInstrumentControl1";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(13, 206);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(78, 13);
            this.label47.TabIndex = 108;
            this.label47.Text = "Active Sensors";
            // 
            // rc_input_control1
            // 
            this.rc_input_control1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rc_input_control1.Location = new System.Drawing.Point(193, 6);
            this.rc_input_control1.Name = "rc_input_control1";
            this.rc_input_control1.Size = new System.Drawing.Size(200, 200);
            this.rc_input_control1.TabIndex = 76;
            this.rc_input_control1.Text = "rc_input_control1";
            // 
            // motorsIndicator1
            // 
            this.motorsIndicator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.motorsIndicator1.Location = new System.Drawing.Point(10, 6);
            this.motorsIndicator1.Name = "motorsIndicator1";
            this.motorsIndicator1.Size = new System.Drawing.Size(182, 197);
            this.motorsIndicator1.TabIndex = 75;
            this.motorsIndicator1.Text = "motorsIndicator1";
            // 
            // indACC
            // 
            this.indACC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.indACC.Location = new System.Drawing.Point(10, 221);
            this.indACC.Margin = new System.Windows.Forms.Padding(1);
            this.indACC.Name = "indACC";
            this.indACC.Size = new System.Drawing.Size(65, 17);
            this.indACC.TabIndex = 82;
            this.indACC.Text = "ACC";
            // 
            // indGPS
            // 
            this.indGPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.indGPS.Location = new System.Drawing.Point(91, 221);
            this.indGPS.Margin = new System.Windows.Forms.Padding(1);
            this.indGPS.Name = "indGPS";
            this.indGPS.Size = new System.Drawing.Size(65, 17);
            this.indGPS.TabIndex = 86;
            this.indGPS.Text = "GPS";
            // 
            // indOPTIC
            // 
            this.indOPTIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.indOPTIC.Location = new System.Drawing.Point(334, 248);
            this.indOPTIC.Margin = new System.Windows.Forms.Padding(1);
            this.indOPTIC.Name = "indOPTIC";
            this.indOPTIC.Size = new System.Drawing.Size(65, 17);
            this.indOPTIC.TabIndex = 103;
            this.indOPTIC.Text = "OPTIC";
            // 
            // indBARO
            // 
            this.indBARO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.indBARO.Location = new System.Drawing.Point(172, 221);
            this.indBARO.Margin = new System.Windows.Forms.Padding(1);
            this.indBARO.Name = "indBARO";
            this.indBARO.Size = new System.Drawing.Size(65, 17);
            this.indBARO.TabIndex = 83;
            this.indBARO.Text = "BARO";
            // 
            // indMAG
            // 
            this.indMAG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.indMAG.Location = new System.Drawing.Point(253, 221);
            this.indMAG.Margin = new System.Windows.Forms.Padding(1);
            this.indMAG.Name = "indMAG";
            this.indMAG.Size = new System.Drawing.Size(65, 17);
            this.indMAG.TabIndex = 84;
            this.indMAG.Text = "MAG";
            // 
            // indSONAR
            // 
            this.indSONAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.indSONAR.Location = new System.Drawing.Point(334, 221);
            this.indSONAR.Margin = new System.Windows.Forms.Padding(1);
            this.indSONAR.Name = "indSONAR";
            this.indSONAR.Size = new System.Drawing.Size(65, 17);
            this.indSONAR.TabIndex = 85;
            this.indSONAR.Text = "SONAR";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(454, 7);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(106, 15);
            this.label81.TabIndex = 119;
            this.label81.Text = "Telemetry link info";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(372, 46);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(39, 15);
            this.label80.TabIndex = 118;
            this.label80.Text = "Noise";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(372, 26);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(35, 15);
            this.label79.TabIndex = 117;
            this.label79.Text = "RSSI";
            // 
            // barNoise
            // 
            this.barNoise.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.barNoise.BkgColor = System.Drawing.Color.Transparent;
            this.barNoise.BorderColor = System.Drawing.Color.Black;
            this.barNoise.FillStyle = MultiWiiGUIControls.ColorProgressBar.FillStyles.Solid;
            this.barNoise.Location = new System.Drawing.Point(416, 46);
            this.barNoise.Maximum = 255;
            this.barNoise.Minimum = 0;
            this.barNoise.Name = "barNoise";
            this.barNoise.Size = new System.Drawing.Size(199, 14);
            this.barNoise.Step = 1;
            this.barNoise.TabIndex = 116;
            this.barNoise.Text = "barNoise";
            this.barNoise.Value = 0;
            // 
            // barRSSI
            // 
            this.barRSSI.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.barRSSI.BkgColor = System.Drawing.Color.Transparent;
            this.barRSSI.BorderColor = System.Drawing.Color.Black;
            this.barRSSI.FillStyle = MultiWiiGUIControls.ColorProgressBar.FillStyles.Solid;
            this.barRSSI.Location = new System.Drawing.Point(416, 26);
            this.barRSSI.Maximum = 255;
            this.barRSSI.Minimum = 0;
            this.barRSSI.Name = "barRSSI";
            this.barRSSI.Size = new System.Drawing.Size(199, 14);
            this.barRSSI.Step = 1;
            this.barRSSI.TabIndex = 115;
            this.barRSSI.Text = "colorProgressBar1";
            this.barRSSI.Value = 0;
            // 
            // labelRSSI
            // 
            this.labelRSSI.AutoSize = true;
            this.labelRSSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRSSI.Location = new System.Drawing.Point(622, 26);
            this.labelRSSI.Name = "labelRSSI";
            this.labelRSSI.Size = new System.Drawing.Size(48, 15);
            this.labelRSSI.TabIndex = 114;
            this.labelRSSI.Text = "no data";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(9, 9);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(71, 13);
            this.label69.TabIndex = 109;
            this.label69.Text = "Packet\'s sent";
            // 
            // labelNoise
            // 
            this.labelNoise.AutoSize = true;
            this.labelNoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoise.Location = new System.Drawing.Point(622, 44);
            this.labelNoise.Name = "labelNoise";
            this.labelNoise.Size = new System.Drawing.Size(48, 15);
            this.labelNoise.TabIndex = 113;
            this.labelNoise.Text = "no data";
            // 
            // labelSentPackets
            // 
            this.labelSentPackets.AutoSize = true;
            this.labelSentPackets.Location = new System.Drawing.Point(113, 9);
            this.labelSentPackets.Name = "labelSentPackets";
            this.labelSentPackets.Size = new System.Drawing.Size(13, 13);
            this.labelSentPackets.TabIndex = 108;
            this.labelSentPackets.Text = "0";
            // 
            // l_i2cerrors
            // 
            this.l_i2cerrors.AutoSize = true;
            this.l_i2cerrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_i2cerrors.Location = new System.Drawing.Point(957, 26);
            this.l_i2cerrors.Name = "l_i2cerrors";
            this.l_i2cerrors.Size = new System.Drawing.Size(35, 15);
            this.l_i2cerrors.TabIndex = 102;
            this.l_i2cerrors.Text = "0000";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(9, 46);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(90, 13);
            this.label44.TabIndex = 107;
            this.label44.Text = "Packet CRC error";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(864, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 15);
            this.label21.TabIndex = 101;
            this.label21.Text = "I²C Error count:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(9, 27);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(92, 13);
            this.label43.TabIndex = 106;
            this.label43.Text = "Packet\'s received";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(861, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 94;
            this.label6.Text = "Battery Voltage:";
            // 
            // labelReceivedPackets
            // 
            this.labelReceivedPackets.AutoSize = true;
            this.labelReceivedPackets.Location = new System.Drawing.Point(113, 27);
            this.labelReceivedPackets.Name = "labelReceivedPackets";
            this.labelReceivedPackets.Size = new System.Drawing.Size(13, 13);
            this.labelReceivedPackets.TabIndex = 105;
            this.labelReceivedPackets.Text = "0";
            // 
            // l_vbatt
            // 
            this.l_vbatt.AutoSize = true;
            this.l_vbatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_vbatt.Location = new System.Drawing.Point(957, 38);
            this.l_vbatt.Name = "l_vbatt";
            this.l_vbatt.Size = new System.Drawing.Size(51, 15);
            this.l_vbatt.TabIndex = 97;
            this.l_vbatt.Text = "0.0 volts";
            // 
            // labelCRCErrors
            // 
            this.labelCRCErrors.AutoSize = true;
            this.labelCRCErrors.Location = new System.Drawing.Point(113, 47);
            this.labelCRCErrors.Name = "labelCRCErrors";
            this.labelCRCErrors.Size = new System.Drawing.Size(13, 13);
            this.labelCRCErrors.TabIndex = 104;
            this.labelCRCErrors.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(879, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 95;
            this.label7.Text = "Power Sum:";
            // 
            // l_powersum
            // 
            this.l_powersum.AutoSize = true;
            this.l_powersum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_powersum.Location = new System.Drawing.Point(957, 53);
            this.l_powersum.Name = "l_powersum";
            this.l_powersum.Size = new System.Drawing.Size(35, 15);
            this.l_powersum.TabIndex = 96;
            this.l_powersum.Text = "0000";
            // 
            // tabPageMisson
            // 
            this.tabPageMisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageMisson.ContextMenuStrip = this.contextMenuStripMap;
            this.tabPageMisson.Controls.Add(this.splitContainer7);
            this.tabPageMisson.Location = new System.Drawing.Point(4, 22);
            this.tabPageMisson.Name = "tabPageMisson";
            this.tabPageMisson.Size = new System.Drawing.Size(1048, 444);
            this.tabPageMisson.TabIndex = 5;
            this.tabPageMisson.Text = "Mission";
            // 
            // contextMenuStripMap
            // 
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuAddWP,
            this.tsMenuAddPosholdTimed,
            this.tsMenuAddPosholdUnlim,
            this.tsMenuAddRTH,
            this.tsMenuAddLand,
            this.tsMenuAddJump,
            this.tsMenuAddPOI,
            this.tsMenuSetHead,
            this.tsMenuDeleteWP,
            this.toolStripSeparator5,
            this.clearMissionToolStripMenuItem,
            this.createCircleToolStripMenuItem,
            this.bulkAltitudeChangeToolStripMenuItem,
            this.toolStripSeparator6,
            this.fetchMapTilesToolStripMenuItem});
            this.contextMenuStripMap.Name = "contextMenuStripMap";
            this.contextMenuStripMap.Size = new System.Drawing.Size(185, 302);
            this.contextMenuStripMap.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripMap_Opening);
            // 
            // tsMenuAddWP
            // 
            this.tsMenuAddWP.Image = global::MultiWiiWinGUI.Properties.Resources.wpicon;
            this.tsMenuAddWP.Name = "tsMenuAddWP";
            this.tsMenuAddWP.Size = new System.Drawing.Size(184, 22);
            this.tsMenuAddWP.Text = "Add Waypoint";
            this.tsMenuAddWP.ToolTipText = "Add a waypoint at the cursor";
            this.tsMenuAddWP.Click += new System.EventHandler(this.tsMenuAddWP_Click);
            // 
            // tsMenuAddPosholdTimed
            // 
            this.tsMenuAddPosholdTimed.Image = global::MultiWiiWinGUI.Properties.Resources.phicon;
            this.tsMenuAddPosholdTimed.Name = "tsMenuAddPosholdTimed";
            this.tsMenuAddPosholdTimed.Size = new System.Drawing.Size(184, 22);
            this.tsMenuAddPosholdTimed.Text = "Timed PosHold ";
            this.tsMenuAddPosholdTimed.ToolTipText = "Add a point to go and hold position there for a specific amount of time";
            this.tsMenuAddPosholdTimed.Click += new System.EventHandler(this.tsMenuAddPosholdTimed_Click);
            // 
            // tsMenuAddPosholdUnlim
            // 
            this.tsMenuAddPosholdUnlim.Image = global::MultiWiiWinGUI.Properties.Resources.poshold_unlim;
            this.tsMenuAddPosholdUnlim.Name = "tsMenuAddPosholdUnlim";
            this.tsMenuAddPosholdUnlim.Size = new System.Drawing.Size(184, 22);
            this.tsMenuAddPosholdUnlim.Text = "PosHold Unlimited";
            this.tsMenuAddPosholdUnlim.ToolTipText = "Add a point to go and hold position there (ends mission)";
            this.tsMenuAddPosholdUnlim.Click += new System.EventHandler(this.tsMenuAddPosholdUnlim_Click);
            // 
            // tsMenuAddRTH
            // 
            this.tsMenuAddRTH.Image = global::MultiWiiWinGUI.Properties.Resources.bluehome;
            this.tsMenuAddRTH.Name = "tsMenuAddRTH";
            this.tsMenuAddRTH.Size = new System.Drawing.Size(184, 22);
            this.tsMenuAddRTH.Text = "Add RTH";
            this.tsMenuAddRTH.ToolTipText = "Initiate Return To Home";
            this.tsMenuAddRTH.Click += new System.EventHandler(this.tsMenuAddRTH_Click);
            // 
            // tsMenuAddLand
            // 
            this.tsMenuAddLand.Name = "tsMenuAddLand";
            this.tsMenuAddLand.Size = new System.Drawing.Size(184, 22);
            this.tsMenuAddLand.Text = "Add Land Here";
            this.tsMenuAddLand.Click += new System.EventHandler(this.tsMenuAddLand_Click);
            // 
            // tsMenuAddJump
            // 
            this.tsMenuAddJump.Name = "tsMenuAddJump";
            this.tsMenuAddJump.Size = new System.Drawing.Size(184, 22);
            this.tsMenuAddJump.Text = "JUMP";
            this.tsMenuAddJump.ToolTipText = "Jumps to a given mission step ";
            this.tsMenuAddJump.Click += new System.EventHandler(this.tsMenuAddJump_Click);
            // 
            // tsMenuAddPOI
            // 
            this.tsMenuAddPOI.Name = "tsMenuAddPOI";
            this.tsMenuAddPOI.Size = new System.Drawing.Size(184, 22);
            this.tsMenuAddPOI.Text = "Set POI";
            this.tsMenuAddPOI.ToolTipText = "Sets a Point of Interest\r\n(copter will adjust heading towards this point)";
            this.tsMenuAddPOI.Click += new System.EventHandler(this.tsMenuAddPOI_Click);
            // 
            // tsMenuSetHead
            // 
            this.tsMenuSetHead.Name = "tsMenuSetHead";
            this.tsMenuSetHead.Size = new System.Drawing.Size(184, 22);
            this.tsMenuSetHead.Text = "Set Heading";
            this.tsMenuSetHead.ToolTipText = "Set copter heading ";
            this.tsMenuSetHead.Click += new System.EventHandler(this.tsMenuSetHead_Click);
            // 
            // tsMenuDeleteWP
            // 
            this.tsMenuDeleteWP.Name = "tsMenuDeleteWP";
            this.tsMenuDeleteWP.Size = new System.Drawing.Size(184, 22);
            this.tsMenuDeleteWP.Text = "Delete Waypoint";
            this.tsMenuDeleteWP.Click += new System.EventHandler(this.tsMenuDeleteWP_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(181, 6);
            // 
            // clearMissionToolStripMenuItem
            // 
            this.clearMissionToolStripMenuItem.Image = global::MultiWiiWinGUI.Properties.Resources.del_btn;
            this.clearMissionToolStripMenuItem.Name = "clearMissionToolStripMenuItem";
            this.clearMissionToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.clearMissionToolStripMenuItem.Text = "Clear Mission";
            this.clearMissionToolStripMenuItem.ToolTipText = "Clears the mission (only in the WinGUI!)";
            this.clearMissionToolStripMenuItem.Click += new System.EventHandler(this.clearMissionToolStripMenuItem_Click);
            // 
            // createCircleToolStripMenuItem
            // 
            this.createCircleToolStripMenuItem.Name = "createCircleToolStripMenuItem";
            this.createCircleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createCircleToolStripMenuItem.Text = "Create Circle";
            this.createCircleToolStripMenuItem.ToolTipText = "Put down a circular path around this point";
            this.createCircleToolStripMenuItem.Click += new System.EventHandler(this.createCircleToolStripMenuItem_Click);
            // 
            // bulkAltitudeChangeToolStripMenuItem
            // 
            this.bulkAltitudeChangeToolStripMenuItem.Name = "bulkAltitudeChangeToolStripMenuItem";
            this.bulkAltitudeChangeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.bulkAltitudeChangeToolStripMenuItem.Text = "Bulk Altitude change";
            this.bulkAltitudeChangeToolStripMenuItem.ToolTipText = "Change altitude of all navigation points in the mission";
            this.bulkAltitudeChangeToolStripMenuItem.Click += new System.EventHandler(this.bulkAltitudeChangeToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(181, 6);
            // 
            // fetchMapTilesToolStripMenuItem
            // 
            this.fetchMapTilesToolStripMenuItem.Name = "fetchMapTilesToolStripMenuItem";
            this.fetchMapTilesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.fetchMapTilesToolStripMenuItem.Text = "Fetch Map tiles";
            this.fetchMapTilesToolStripMenuItem.ToolTipText = "Fetch map tiles for offline usage";
            this.fetchMapTilesToolStripMenuItem.Click += new System.EventHandler(this.fetchMapTilesToolStripMenuItem_Click);
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.cbShowFlightPath);
            this.splitContainer7.Panel1.Controls.Add(this.cbShowPos);
            this.splitContainer7.Panel1.Controls.Add(this.cbShowWP);
            this.splitContainer7.Panel1.Controls.Add(this.cbShowMission);
            this.splitContainer7.Panel1.Controls.Add(this.label23);
            this.splitContainer7.Panel1.Controls.Add(this.cbMapProviders);
            this.splitContainer7.Panel1.Controls.Add(this.b_Clear_Route);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.spcontMapMain);
            this.splitContainer7.Size = new System.Drawing.Size(1048, 444);
            this.splitContainer7.SplitterDistance = 31;
            this.splitContainer7.TabIndex = 10;
            // 
            // cbShowFlightPath
            // 
            this.cbShowFlightPath.AutoSize = true;
            this.cbShowFlightPath.Checked = true;
            this.cbShowFlightPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFlightPath.ForeColor = System.Drawing.Color.White;
            this.cbShowFlightPath.Location = new System.Drawing.Point(419, 7);
            this.cbShowFlightPath.Name = "cbShowFlightPath";
            this.cbShowFlightPath.Size = new System.Drawing.Size(102, 17);
            this.cbShowFlightPath.TabIndex = 37;
            this.cbShowFlightPath.Text = "Show flight path";
            this.cbShowFlightPath.UseVisualStyleBackColor = true;
            this.cbShowFlightPath.CheckedChanged += new System.EventHandler(this.cbShowFlightPath_CheckedChanged);
            // 
            // cbShowPos
            // 
            this.cbShowPos.AutoSize = true;
            this.cbShowPos.Checked = true;
            this.cbShowPos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowPos.ForeColor = System.Drawing.Color.White;
            this.cbShowPos.Location = new System.Drawing.Point(268, 7);
            this.cbShowPos.Name = "cbShowPos";
            this.cbShowPos.Size = new System.Drawing.Size(136, 17);
            this.cbShowPos.TabIndex = 36;
            this.cbShowPos.Text = "Show current posititons";
            this.cbShowPos.UseVisualStyleBackColor = true;
            this.cbShowPos.CheckedChanged += new System.EventHandler(this.cbShowPos_CheckedChanged);
            // 
            // cbShowWP
            // 
            this.cbShowWP.AutoSize = true;
            this.cbShowWP.Checked = true;
            this.cbShowWP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowWP.ForeColor = System.Drawing.Color.White;
            this.cbShowWP.Location = new System.Drawing.Point(148, 7);
            this.cbShowWP.Name = "cbShowWP";
            this.cbShowWP.Size = new System.Drawing.Size(106, 17);
            this.cbShowWP.TabIndex = 35;
            this.cbShowWP.Text = "Show Waypoints";
            this.cbShowWP.UseVisualStyleBackColor = true;
            this.cbShowWP.CheckedChanged += new System.EventHandler(this.cbShowWP_CheckedChanged);
            // 
            // cbShowMission
            // 
            this.cbShowMission.AutoSize = true;
            this.cbShowMission.Checked = true;
            this.cbShowMission.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowMission.ForeColor = System.Drawing.Color.White;
            this.cbShowMission.Location = new System.Drawing.Point(12, 7);
            this.cbShowMission.Name = "cbShowMission";
            this.cbShowMission.Size = new System.Drawing.Size(122, 17);
            this.cbShowMission.TabIndex = 34;
            this.cbShowMission.Text = "Show mission Route";
            this.cbShowMission.UseVisualStyleBackColor = true;
            this.cbShowMission.CheckedChanged += new System.EventHandler(this.cbShowMission_CheckedChanged);
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(804, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "Map Provider";
            // 
            // cbMapProviders
            // 
            this.cbMapProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMapProviders.FormattingEnabled = true;
            this.cbMapProviders.Location = new System.Drawing.Point(884, 8);
            this.cbMapProviders.Name = "cbMapProviders";
            this.cbMapProviders.Size = new System.Drawing.Size(154, 21);
            this.cbMapProviders.TabIndex = 32;
            this.cbMapProviders.SelectedIndexChanged += new System.EventHandler(this.cbMapProviders_SelectedIndexChanged);
            // 
            // b_Clear_Route
            // 
            this.b_Clear_Route.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.b_Clear_Route.Location = new System.Drawing.Point(579, 3);
            this.b_Clear_Route.Name = "b_Clear_Route";
            this.b_Clear_Route.Size = new System.Drawing.Size(80, 22);
            this.b_Clear_Route.TabIndex = 9;
            this.b_Clear_Route.Text = "Clear Route";
            this.b_Clear_Route.UseVisualStyleBackColor = true;
            this.b_Clear_Route.Click += new System.EventHandler(this.b_Clear_Route_Click);
            // 
            // spcontMapMain
            // 
            this.spcontMapMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcontMapMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcontMapMain.Location = new System.Drawing.Point(0, 0);
            this.spcontMapMain.Margin = new System.Windows.Forms.Padding(0);
            this.spcontMapMain.Name = "spcontMapMain";
            // 
            // spcontMapMain.Panel1
            // 
            this.spcontMapMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spcontMapMain.Panel1.Controls.Add(this.splitContainer9);
            // 
            // spcontMapMain.Panel2
            // 
            this.spcontMapMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spcontMapMain.Panel2.Controls.Add(this.splitContainer8);
            this.spcontMapMain.Panel2.Leave += new System.EventHandler(this.txtDefAlt_TextChanged);
            this.spcontMapMain.Size = new System.Drawing.Size(1048, 409);
            this.spcontMapMain.SplitterDistance = 601;
            this.spcontMapMain.TabIndex = 0;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.btnMapZoopDown);
            this.splitContainer9.Panel1.Controls.Add(this.btnMapZoomUp);
            this.splitContainer9.Panel1.Controls.Add(this.battery_indicator2);
            this.splitContainer9.Panel1.Controls.Add(this.barRSSIMission);
            this.splitContainer9.Panel1.Controls.Add(this.lNavError);
            this.splitContainer9.Panel1.Controls.Add(this.cbAutoPan);
            this.splitContainer9.Panel1.Controls.Add(this.cbShowGauges);
            this.splitContainer9.Panel1.Controls.Add(this.altitude_meter2);
            this.splitContainer9.Panel1.Controls.Add(this.vertical_speed_indicator2);
            this.splitContainer9.Panel1.Controls.Add(this.gpsIndicator2);
            this.splitContainer9.Panel1.Controls.Add(this.LMousePos);
            this.splitContainer9.Panel1.Controls.Add(this.label45);
            this.splitContainer9.Panel1.Controls.Add(this.MainMap);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer9.Panel2.Controls.Add(this.lNavState);
            this.splitContainer9.Panel2.Controls.Add(this.lGpsMode);
            this.splitContainer9.Panel2.Controls.Add(this.l11);
            this.splitContainer9.Panel2.Controls.Add(this.label72);
            this.splitContainer9.Panel2.Controls.Add(this.cbSendGTCAlt);
            this.splitContainer9.Panel2.Controls.Add(this.txtGTCAlt);
            this.splitContainer9.Panel2.Controls.Add(this.label46);
            this.splitContainer9.Panel2.Controls.Add(this.bClickToGo);
            this.splitContainer9.Panel2.Controls.Add(this.l_GPS_numsat);
            this.splitContainer9.Panel2.Controls.Add(this.label25);
            this.splitContainer9.Panel2.Controls.Add(this.label39);
            this.splitContainer9.Panel2.Controls.Add(this.label32);
            this.splitContainer9.Panel2.Controls.Add(this.l_GPS_alt);
            this.splitContainer9.Panel2.Controls.Add(this.lGPS_lon);
            this.splitContainer9.Panel2.Controls.Add(this.label34);
            this.splitContainer9.Panel2.Controls.Add(this.lGPS_lat);
            this.splitContainer9.Size = new System.Drawing.Size(601, 409);
            this.splitContainer9.SplitterDistance = 331;
            this.splitContainer9.TabIndex = 0;
            // 
            // btnMapZoopDown
            // 
            this.btnMapZoopDown.Location = new System.Drawing.Point(0, 57);
            this.btnMapZoopDown.Name = "btnMapZoopDown";
            this.btnMapZoopDown.Size = new System.Drawing.Size(25, 22);
            this.btnMapZoopDown.TabIndex = 120;
            this.btnMapZoopDown.Text = "&-";
            this.btnMapZoopDown.UseVisualStyleBackColor = true;
            this.btnMapZoopDown.Click += new System.EventHandler(this.btnMapZoopDown_Click);
            // 
            // btnMapZoomUp
            // 
            this.btnMapZoomUp.Location = new System.Drawing.Point(0, 30);
            this.btnMapZoomUp.Name = "btnMapZoomUp";
            this.btnMapZoomUp.Size = new System.Drawing.Size(25, 22);
            this.btnMapZoomUp.TabIndex = 119;
            this.btnMapZoomUp.Text = "&+";
            this.btnMapZoomUp.UseVisualStyleBackColor = true;
            this.btnMapZoomUp.Click += new System.EventHandler(this.btnMapZoomUp_Click);
            // 
            // battery_indicator2
            // 
            this.battery_indicator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.battery_indicator2.Location = new System.Drawing.Point(462, 183);
            this.battery_indicator2.Name = "battery_indicator2";
            this.battery_indicator2.Size = new System.Drawing.Size(150, 150);
            this.battery_indicator2.TabIndex = 118;
            this.battery_indicator2.Text = "battery_indicator2";
            this.battery_indicator2.Visible = false;
            // 
            // barRSSIMission
            // 
            this.barRSSIMission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.barRSSIMission.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.barRSSIMission.BkgColor = System.Drawing.Color.Transparent;
            this.barRSSIMission.BorderColor = System.Drawing.Color.Black;
            this.barRSSIMission.FillStyle = MultiWiiGUIControls.ColorProgressBar.FillStyles.Solid;
            this.barRSSIMission.Location = new System.Drawing.Point(-2, 168);
            this.barRSSIMission.Maximum = 255;
            this.barRSSIMission.Minimum = 0;
            this.barRSSIMission.Name = "barRSSIMission";
            this.barRSSIMission.Size = new System.Drawing.Size(199, 14);
            this.barRSSIMission.Step = 1;
            this.barRSSIMission.TabIndex = 117;
            this.barRSSIMission.Value = 0;
            this.barRSSIMission.Visible = false;
            // 
            // lNavError
            // 
            this.lNavError.AutoSize = true;
            this.lNavError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNavError.ForeColor = System.Drawing.Color.White;
            this.lNavError.Location = new System.Drawing.Point(-3, 13);
            this.lNavError.Name = "lNavError";
            this.lNavError.Size = new System.Drawing.Size(0, 13);
            this.lNavError.TabIndex = 45;
            // 
            // cbAutoPan
            // 
            this.cbAutoPan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoPan.AutoSize = true;
            this.cbAutoPan.aux = 0;
            this.cbAutoPan.BackColor = System.Drawing.Color.Transparent;
            this.cbAutoPan.Checked = true;
            this.cbAutoPan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoPan.ForeColor = System.Drawing.Color.White;
            this.cbAutoPan.IsHighlighted = false;
            this.cbAutoPan.item = 0;
            this.cbAutoPan.Location = new System.Drawing.Point(426, 0);
            this.cbAutoPan.Name = "cbAutoPan";
            this.cbAutoPan.rclevel = 0;
            this.cbAutoPan.Size = new System.Drawing.Size(70, 17);
            this.cbAutoPan.TabIndex = 113;
            this.cbAutoPan.Text = "Auto Pan";
            this.cbAutoPan.UseVisualStyleBackColor = false;
            // 
            // cbShowGauges
            // 
            this.cbShowGauges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShowGauges.AutoSize = true;
            this.cbShowGauges.aux = 0;
            this.cbShowGauges.BackColor = System.Drawing.Color.Transparent;
            this.cbShowGauges.ForeColor = System.Drawing.Color.White;
            this.cbShowGauges.IsHighlighted = false;
            this.cbShowGauges.item = 0;
            this.cbShowGauges.Location = new System.Drawing.Point(505, 0);
            this.cbShowGauges.Name = "cbShowGauges";
            this.cbShowGauges.rclevel = 0;
            this.cbShowGauges.Size = new System.Drawing.Size(93, 17);
            this.cbShowGauges.TabIndex = 112;
            this.cbShowGauges.Text = "Show Gauges";
            this.cbShowGauges.UseVisualStyleBackColor = false;
            this.cbShowGauges.CheckedChanged += new System.EventHandler(this.cbShowGauges_CheckedChanged);
            // 
            // altitude_meter2
            // 
            this.altitude_meter2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.altitude_meter2.Location = new System.Drawing.Point(305, 183);
            this.altitude_meter2.Name = "altitude_meter2";
            this.altitude_meter2.Size = new System.Drawing.Size(160, 148);
            this.altitude_meter2.TabIndex = 111;
            this.altitude_meter2.Text = "altitude_meter2";
            this.altitude_meter2.Visible = false;
            // 
            // vertical_speed_indicator2
            // 
            this.vertical_speed_indicator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vertical_speed_indicator2.Location = new System.Drawing.Point(148, 183);
            this.vertical_speed_indicator2.Name = "vertical_speed_indicator2";
            this.vertical_speed_indicator2.Size = new System.Drawing.Size(160, 148);
            this.vertical_speed_indicator2.TabIndex = 110;
            this.vertical_speed_indicator2.Text = "vertical_speed_indicator2";
            this.vertical_speed_indicator2.Visible = false;
            // 
            // gpsIndicator2
            // 
            this.gpsIndicator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gpsIndicator2.Location = new System.Drawing.Point(-4, 183);
            this.gpsIndicator2.Name = "gpsIndicator2";
            this.gpsIndicator2.Size = new System.Drawing.Size(160, 148);
            this.gpsIndicator2.TabIndex = 75;
            this.gpsIndicator2.Text = "gpsIndicatorInstrumentControl1";
            this.gpsIndicator2.Visible = false;
            // 
            // LMousePos
            // 
            this.LMousePos.AutoSize = true;
            this.LMousePos.ForeColor = System.Drawing.Color.White;
            this.LMousePos.Location = new System.Drawing.Point(80, 0);
            this.LMousePos.Name = "LMousePos";
            this.LMousePos.Size = new System.Drawing.Size(22, 13);
            this.LMousePos.TabIndex = 35;
            this.LMousePos.Text = "0,0";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(-3, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(72, 13);
            this.label45.TabIndex = 34;
            this.label45.Text = "POS@Mouse";
            // 
            // MainMap
            // 
            this.MainMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMap.EmptyTileColor = System.Drawing.Color.MidnightBlue;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(0, 0);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 20;
            this.MainMap.MinZoom = 5;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(601, 331);
            this.MainMap.TabIndex = 33;
            this.MainMap.Zoom = 10D;
            // 
            // lNavState
            // 
            this.lNavState.AutoSize = true;
            this.lNavState.ForeColor = System.Drawing.Color.White;
            this.lNavState.Location = new System.Drawing.Point(511, 26);
            this.lNavState.Name = "lNavState";
            this.lNavState.Size = new System.Drawing.Size(13, 13);
            this.lNavState.TabIndex = 44;
            this.lNavState.Text = "0";
            // 
            // lGpsMode
            // 
            this.lGpsMode.AutoSize = true;
            this.lGpsMode.ForeColor = System.Drawing.Color.White;
            this.lGpsMode.Location = new System.Drawing.Point(511, 14);
            this.lGpsMode.Name = "lGpsMode";
            this.lGpsMode.Size = new System.Drawing.Size(13, 13);
            this.lGpsMode.TabIndex = 42;
            this.lGpsMode.Text = "0";
            // 
            // l11
            // 
            this.l11.AutoSize = true;
            this.l11.ForeColor = System.Drawing.Color.White;
            this.l11.Location = new System.Drawing.Point(430, 26);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(70, 13);
            this.l11.TabIndex = 40;
            this.l11.Text = "NAV_STATE";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Location = new System.Drawing.Point(430, 14);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(61, 13);
            this.label72.TabIndex = 39;
            this.label72.Text = "GPSMODE";
            // 
            // cbSendGTCAlt
            // 
            this.cbSendGTCAlt.AutoSize = true;
            this.cbSendGTCAlt.Checked = true;
            this.cbSendGTCAlt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSendGTCAlt.ForeColor = System.Drawing.Color.White;
            this.cbSendGTCAlt.Location = new System.Drawing.Point(242, 44);
            this.cbSendGTCAlt.Name = "cbSendGTCAlt";
            this.cbSendGTCAlt.Size = new System.Drawing.Size(86, 17);
            this.cbSendGTCAlt.TabIndex = 38;
            this.cbSendGTCAlt.Text = "Send GtC alt";
            this.cbSendGTCAlt.UseVisualStyleBackColor = true;
            this.cbSendGTCAlt.CheckedChanged += new System.EventHandler(this.cbSendGTCAlt_CheckedChanged);
            // 
            // txtGTCAlt
            // 
            this.txtGTCAlt.BackColor = System.Drawing.Color.White;
            this.txtGTCAlt.ForeColor = System.Drawing.Color.Black;
            this.txtGTCAlt.Location = new System.Drawing.Point(202, 42);
            this.txtGTCAlt.MaxLength = 3;
            this.txtGTCAlt.Multiline = true;
            this.txtGTCAlt.Name = "txtGTCAlt";
            this.txtGTCAlt.Size = new System.Drawing.Size(33, 20);
            this.txtGTCAlt.TabIndex = 8;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(137, 46);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(65, 13);
            this.label46.TabIndex = 8;
            this.label46.Text = "GtC altitude:";
            // 
            // bClickToGo
            // 
            this.bClickToGo.Location = new System.Drawing.Point(9, 40);
            this.bClickToGo.Name = "bClickToGo";
            this.bClickToGo.Size = new System.Drawing.Size(121, 22);
            this.bClickToGo.TabIndex = 37;
            this.bClickToGo.Text = "Go to Click disabled";
            this.bClickToGo.UseVisualStyleBackColor = true;
            this.bClickToGo.Click += new System.EventHandler(this.bClickToGo_Click);
            // 
            // l_GPS_numsat
            // 
            this.l_GPS_numsat.AutoSize = true;
            this.l_GPS_numsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_GPS_numsat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l_GPS_numsat.Location = new System.Drawing.Point(384, 16);
            this.l_GPS_numsat.Name = "l_GPS_numsat";
            this.l_GPS_numsat.Size = new System.Drawing.Size(16, 16);
            this.l_GPS_numsat.TabIndex = 8;
            this.l_GPS_numsat.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Location = new System.Drawing.Point(9, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Latitude";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label39.Location = new System.Drawing.Point(384, 3);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(23, 13);
            this.label39.TabIndex = 7;
            this.label39.Text = "Sat";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label32.Location = new System.Drawing.Point(137, 3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(54, 13);
            this.label32.TabIndex = 2;
            this.label32.Text = "Longitude";
            // 
            // l_GPS_alt
            // 
            this.l_GPS_alt.AutoSize = true;
            this.l_GPS_alt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_GPS_alt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l_GPS_alt.Location = new System.Drawing.Point(317, 16);
            this.l_GPS_alt.Name = "l_GPS_alt";
            this.l_GPS_alt.Size = new System.Drawing.Size(16, 16);
            this.l_GPS_alt.TabIndex = 6;
            this.l_GPS_alt.Text = "0";
            // 
            // lGPS_lon
            // 
            this.lGPS_lon.AutoSize = true;
            this.lGPS_lon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGPS_lon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lGPS_lon.Location = new System.Drawing.Point(137, 16);
            this.lGPS_lon.Name = "lGPS_lon";
            this.lGPS_lon.Size = new System.Drawing.Size(16, 16);
            this.lGPS_lon.TabIndex = 3;
            this.lGPS_lon.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label34.Location = new System.Drawing.Point(317, 3);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(43, 13);
            this.label34.TabIndex = 5;
            this.label34.Text = "GPS alt";
            // 
            // lGPS_lat
            // 
            this.lGPS_lat.AutoSize = true;
            this.lGPS_lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGPS_lat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lGPS_lat.Location = new System.Drawing.Point(9, 16);
            this.lGPS_lat.Name = "lGPS_lat";
            this.lGPS_lat.Size = new System.Drawing.Size(16, 16);
            this.lGPS_lat.TabIndex = 4;
            this.lGPS_lat.Text = "0";
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.missionDataGrid);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.label75);
            this.splitContainer8.Panel2.Controls.Add(this.label74);
            this.splitContainer8.Panel2.Controls.Add(this.label73);
            this.splitContainer8.Panel2.Controls.Add(this.lDistLastWP);
            this.splitContainer8.Panel2.Controls.Add(this.btnLoadMission);
            this.splitContainer8.Panel2.Controls.Add(this.btnSaveMission);
            this.splitContainer8.Panel2.Controls.Add(this.btnDownLoadMission);
            this.splitContainer8.Panel2.Controls.Add(this.btnUploadMission);
            this.splitContainer8.Panel2.Controls.Add(this.txtDefAlt);
            this.splitContainer8.Panel2.Controls.Add(this.lDistance);
            this.splitContainer8.Panel2.Controls.Add(this.lDefAlt);
            this.splitContainer8.Size = new System.Drawing.Size(443, 409);
            this.splitContainer8.SplitterDistance = 274;
            this.splitContainer8.TabIndex = 0;
            // 
            // missionDataGrid
            // 
            this.missionDataGrid.AllowUserToAddRows = false;
            this.missionDataGrid.AllowUserToDeleteRows = false;
            this.missionDataGrid.AllowUserToResizeRows = false;
            this.missionDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.missionDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.missionDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.missionDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.missionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.missionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Action,
            this.Par1,
            this.Par2,
            this.Par3,
            this.LATCOL,
            this.LONCOL,
            this.ALTCOL,
            this.UP,
            this.Down,
            this.DEL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.missionDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.missionDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missionDataGrid.EnableHeadersVisualStyles = false;
            this.missionDataGrid.Location = new System.Drawing.Point(0, 0);
            this.missionDataGrid.Margin = new System.Windows.Forms.Padding(1);
            this.missionDataGrid.Name = "missionDataGrid";
            this.missionDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.missionDataGrid.RowHeadersVisible = false;
            this.missionDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.missionDataGrid.Size = new System.Drawing.Size(443, 274);
            this.missionDataGrid.TabIndex = 0;
            this.missionDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.missionDataGrid_CellContentClick);
            this.missionDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.missionDataGrid_CellEndEdit);
            this.missionDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.missionDataGrid_CellEnter);
            this.missionDataGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.missionDataGrid_CellValidated);
            this.missionDataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.missionDataGrid_CurrentCellDirtyStateChanged);
            this.missionDataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.missionDataGrid_RowEnter);
            this.missionDataGrid.SelectionChanged += new System.EventHandler(this.missionDataGrid_SelectionChanged);
            // 
            // No
            // 
            this.No.HeaderText = "#";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.No.Width = 20;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Items.AddRange(new object[] {
            "WAYPOINT",
            "POSHOLD_UNLIM",
            "POSHOLD_TIME",
            "RTH",
            "LAND",
            "JUMP",
            "SET_POI",
            "SET_HEAD"});
            this.Action.Name = "Action";
            this.Action.Width = 90;
            // 
            // Par1
            // 
            this.Par1.HeaderText = "P1";
            this.Par1.Name = "Par1";
            this.Par1.Width = 35;
            // 
            // Par2
            // 
            this.Par2.HeaderText = "P2";
            this.Par2.Name = "Par2";
            this.Par2.Width = 35;
            // 
            // Par3
            // 
            this.Par3.HeaderText = "P3";
            this.Par3.Name = "Par3";
            this.Par3.Width = 35;
            // 
            // LATCOL
            // 
            this.LATCOL.HeaderText = "Lat";
            this.LATCOL.Name = "LATCOL";
            this.LATCOL.ReadOnly = true;
            this.LATCOL.Width = 65;
            // 
            // LONCOL
            // 
            this.LONCOL.HeaderText = "Lon";
            this.LONCOL.Name = "LONCOL";
            this.LONCOL.ReadOnly = true;
            this.LONCOL.Width = 65;
            // 
            // ALTCOL
            // 
            this.ALTCOL.HeaderText = "Alt";
            this.ALTCOL.Name = "ALTCOL";
            this.ALTCOL.Width = 40;
            // 
            // UP
            // 
            this.UP.HeaderText = "";
            this.UP.Image = global::MultiWiiWinGUI.Properties.Resources.up_btn;
            this.UP.Name = "UP";
            this.UP.Width = 18;
            // 
            // Down
            // 
            this.Down.HeaderText = "";
            this.Down.Image = global::MultiWiiWinGUI.Properties.Resources.down_btn;
            this.Down.Name = "Down";
            this.Down.Width = 18;
            // 
            // DEL
            // 
            this.DEL.HeaderText = "";
            this.DEL.Image = global::MultiWiiWinGUI.Properties.Resources.del_btn;
            this.DEL.Name = "DEL";
            this.DEL.Width = 18;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label75.Location = new System.Drawing.Point(154, 103);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(169, 13);
            this.label75.TabIndex = 47;
            this.label75.Text = "Right Click for Context menu";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label74.Location = new System.Drawing.Point(188, 82);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(108, 13);
            this.label74.TabIndex = 46;
            this.label74.Text = "adds Mission step";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label73.Location = new System.Drawing.Point(188, 69);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(108, 13);
            this.label73.TabIndex = 45;
            this.label73.Text = "CTRL+LEFT Click";
            // 
            // lDistLastWP
            // 
            this.lDistLastWP.AutoSize = true;
            this.lDistLastWP.ForeColor = System.Drawing.Color.White;
            this.lDistLastWP.Location = new System.Drawing.Point(162, 10);
            this.lDistLastWP.Name = "lDistLastWP";
            this.lDistLastWP.Size = new System.Drawing.Size(91, 13);
            this.lDistLastWP.TabIndex = 8;
            this.lDistLastWP.Text = "Dist from last WP:";
            // 
            // btnLoadMission
            // 
            this.btnLoadMission.Location = new System.Drawing.Point(352, 94);
            this.btnLoadMission.Name = "btnLoadMission";
            this.btnLoadMission.Size = new System.Drawing.Size(109, 22);
            this.btnLoadMission.TabIndex = 7;
            this.btnLoadMission.Text = "Load Mission";
            this.btnLoadMission.UseVisualStyleBackColor = true;
            this.btnLoadMission.Click += new System.EventHandler(this.btnLoadMission_Click);
            // 
            // btnSaveMission
            // 
            this.btnSaveMission.Location = new System.Drawing.Point(352, 65);
            this.btnSaveMission.Name = "btnSaveMission";
            this.btnSaveMission.Size = new System.Drawing.Size(109, 22);
            this.btnSaveMission.TabIndex = 6;
            this.btnSaveMission.Text = "Save Mission";
            this.btnSaveMission.UseVisualStyleBackColor = true;
            this.btnSaveMission.Click += new System.EventHandler(this.btnSaveMission_Click);
            // 
            // btnDownLoadMission
            // 
            this.btnDownLoadMission.Location = new System.Drawing.Point(14, 93);
            this.btnDownLoadMission.Name = "btnDownLoadMission";
            this.btnDownLoadMission.Size = new System.Drawing.Size(109, 22);
            this.btnDownLoadMission.TabIndex = 5;
            this.btnDownLoadMission.Text = "Download mission";
            this.btnDownLoadMission.UseVisualStyleBackColor = true;
            this.btnDownLoadMission.Click += new System.EventHandler(this.btnDownLoadMission_Click);
            // 
            // btnUploadMission
            // 
            this.btnUploadMission.Location = new System.Drawing.Point(14, 64);
            this.btnUploadMission.Name = "btnUploadMission";
            this.btnUploadMission.Size = new System.Drawing.Size(109, 22);
            this.btnUploadMission.TabIndex = 4;
            this.btnUploadMission.Text = "Upload mission";
            this.btnUploadMission.UseVisualStyleBackColor = true;
            this.btnUploadMission.Click += new System.EventHandler(this.btnUploadMission_Click);
            // 
            // txtDefAlt
            // 
            this.txtDefAlt.BackColor = System.Drawing.Color.White;
            this.txtDefAlt.ForeColor = System.Drawing.Color.Black;
            this.txtDefAlt.Location = new System.Drawing.Point(132, 26);
            this.txtDefAlt.MaxLength = 3;
            this.txtDefAlt.Multiline = true;
            this.txtDefAlt.Name = "txtDefAlt";
            this.txtDefAlt.Size = new System.Drawing.Size(33, 20);
            this.txtDefAlt.TabIndex = 2;
            this.txtDefAlt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDefAlt_KeyDown);
            this.txtDefAlt.Leave += new System.EventHandler(this.txtDefAlt_TextChanged);
            // 
            // lDistance
            // 
            this.lDistance.AutoSize = true;
            this.lDistance.ForeColor = System.Drawing.Color.White;
            this.lDistance.Location = new System.Drawing.Point(10, 10);
            this.lDistance.Name = "lDistance";
            this.lDistance.Size = new System.Drawing.Size(111, 13);
            this.lDistance.TabIndex = 1;
            this.lDistance.Text = "Mission total distance:";
            // 
            // lDefAlt
            // 
            this.lDefAlt.AutoSize = true;
            this.lDefAlt.ForeColor = System.Drawing.Color.White;
            this.lDefAlt.Location = new System.Drawing.Point(10, 29);
            this.lDefAlt.Name = "lDefAlt";
            this.lDefAlt.Size = new System.Drawing.Size(108, 13);
            this.lDefAlt.TabIndex = 3;
            this.lDefAlt.Text = "Default altitude (AGL)";
            // 
            // tabPagePID
            // 
            this.tabPagePID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPagePID.Controls.Add(this.naviGroup);
            this.tabPagePID.Controls.Add(this.label2);
            this.tabPagePID.Controls.Add(this.label1);
            this.tabPagePID.Controls.Add(this.nTEXPO);
            this.tabPagePID.Controls.Add(this.nTMID);
            this.tabPagePID.Controls.Add(this.trackBar_T_EXPO);
            this.tabPagePID.Controls.Add(this.trackBar_T_MID);
            this.tabPagePID.Controls.Add(this.trackbar_RC_Rate);
            this.tabPagePID.Controls.Add(this.label65);
            this.tabPagePID.Controls.Add(this.trackbar_RC_Expo);
            this.tabPagePID.Controls.Add(this.nRCRate);
            this.tabPagePID.Controls.Add(this.nRCExpo);
            this.tabPagePID.Controls.Add(this.label66);
            this.tabPagePID.Controls.Add(this.groupBox12);
            this.tabPagePID.Controls.Add(this.throttle_expo_control1);
            this.tabPagePID.Controls.Add(this.rc_expo_control1);
            this.tabPagePID.Location = new System.Drawing.Point(4, 22);
            this.tabPagePID.Name = "tabPagePID";
            this.tabPagePID.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePID.Size = new System.Drawing.Size(1048, 444);
            this.tabPagePID.TabIndex = 1;
            this.tabPagePID.Text = "Flight Tuning";
            // 
            // naviGroup
            // 
            this.naviGroup.Controls.Add(this.label41);
            this.naviGroup.Controls.Add(this.nLandSpeed);
            this.naviGroup.Controls.Add(this.label71);
            this.naviGroup.Controls.Add(this.nFence);
            this.naviGroup.Controls.Add(this.cbNavBaroTakeover);
            this.naviGroup.Controls.Add(this.cbNavDisableSticks);
            this.naviGroup.Controls.Add(this.cbNavGPS_filtering);
            this.naviGroup.Controls.Add(this.label88);
            this.naviGroup.Controls.Add(this.cbNavGPS_Lead);
            this.naviGroup.Controls.Add(this.nBanking);
            this.naviGroup.Controls.Add(this.cbNavResetHome);
            this.naviGroup.Controls.Add(this.label87);
            this.naviGroup.Controls.Add(this.cbNavHeadingControl);
            this.naviGroup.Controls.Add(this.nCrosstrack);
            this.naviGroup.Controls.Add(this.cbNavTailFirst);
            this.naviGroup.Controls.Add(this.label86);
            this.naviGroup.Controls.Add(this.cbNavRTHHead);
            this.naviGroup.Controls.Add(this.nRTHAlt);
            this.naviGroup.Controls.Add(this.cbNavWaitRTHAlt);
            this.naviGroup.Controls.Add(this.label85);
            this.naviGroup.Controls.Add(this.cbNavSlowNav);
            this.naviGroup.Controls.Add(this.nMinSpeed);
            this.naviGroup.Controls.Add(this.nWPRadius);
            this.naviGroup.Controls.Add(this.label84);
            this.naviGroup.Controls.Add(this.label76);
            this.naviGroup.Controls.Add(this.nMaxSpeed);
            this.naviGroup.Controls.Add(this.nSafeWPDist);
            this.naviGroup.Controls.Add(this.label83);
            this.naviGroup.Controls.Add(this.label82);
            this.naviGroup.Controls.Add(this.nMaxAlt);
            this.naviGroup.ForeColor = System.Drawing.Color.White;
            this.naviGroup.Location = new System.Drawing.Point(602, 9);
            this.naviGroup.Name = "naviGroup";
            this.naviGroup.Size = new System.Drawing.Size(436, 430);
            this.naviGroup.TabIndex = 56;
            this.naviGroup.TabStop = false;
            this.naviGroup.Text = "Navigation settings";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label41.Location = new System.Drawing.Point(305, 338);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(65, 13);
            this.label41.TabIndex = 61;
            this.label41.Text = "Land Speed";
            // 
            // nLandSpeed
            // 
            this.nLandSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nLandSpeed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLandSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nLandSpeed.Location = new System.Drawing.Point(308, 358);
            this.nLandSpeed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nLandSpeed.Name = "nLandSpeed";
            this.nLandSpeed.Size = new System.Drawing.Size(57, 19);
            this.nLandSpeed.TabIndex = 60;
            this.nLandSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label71.Location = new System.Drawing.Point(305, 385);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(85, 13);
            this.label71.TabIndex = 59;
            this.label71.Text = "Fence radius (m)";
            // 
            // nFence
            // 
            this.nFence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nFence.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFence.Location = new System.Drawing.Point(308, 406);
            this.nFence.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nFence.Name = "nFence";
            this.nFence.Size = new System.Drawing.Size(57, 19);
            this.nFence.TabIndex = 58;
            this.nFence.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cbNavBaroTakeover
            // 
            this.cbNavBaroTakeover.AutoSize = true;
            this.cbNavBaroTakeover.aux = 0;
            this.cbNavBaroTakeover.ForeColor = System.Drawing.Color.White;
            this.cbNavBaroTakeover.IsHighlighted = false;
            this.cbNavBaroTakeover.item = 0;
            this.cbNavBaroTakeover.Location = new System.Drawing.Point(234, 208);
            this.cbNavBaroTakeover.Name = "cbNavBaroTakeover";
            this.cbNavBaroTakeover.rclevel = 0;
            this.cbNavBaroTakeover.Size = new System.Drawing.Size(134, 17);
            this.cbNavBaroTakeover.TabIndex = 57;
            this.cbNavBaroTakeover.Text = "Takeover BARO mode";
            this.cbNavBaroTakeover.UseVisualStyleBackColor = true;
            // 
            // cbNavDisableSticks
            // 
            this.cbNavDisableSticks.AutoSize = true;
            this.cbNavDisableSticks.aux = 0;
            this.cbNavDisableSticks.ForeColor = System.Drawing.Color.White;
            this.cbNavDisableSticks.IsHighlighted = false;
            this.cbNavDisableSticks.item = 0;
            this.cbNavDisableSticks.Location = new System.Drawing.Point(19, 208);
            this.cbNavDisableSticks.Name = "cbNavDisableSticks";
            this.cbNavDisableSticks.rclevel = 0;
            this.cbNavDisableSticks.Size = new System.Drawing.Size(193, 17);
            this.cbNavDisableSticks.TabIndex = 56;
            this.cbNavDisableSticks.Text = "Ignore throttle during Nav and RTH";
            this.cbNavDisableSticks.UseVisualStyleBackColor = true;
            // 
            // cbNavGPS_filtering
            // 
            this.cbNavGPS_filtering.AutoSize = true;
            this.cbNavGPS_filtering.aux = 0;
            this.cbNavGPS_filtering.ForeColor = System.Drawing.Color.White;
            this.cbNavGPS_filtering.IsHighlighted = false;
            this.cbNavGPS_filtering.item = 0;
            this.cbNavGPS_filtering.Location = new System.Drawing.Point(19, 18);
            this.cbNavGPS_filtering.Name = "cbNavGPS_filtering";
            this.cbNavGPS_filtering.rclevel = 0;
            this.cbNavGPS_filtering.Size = new System.Drawing.Size(120, 17);
            this.cbNavGPS_filtering.TabIndex = 32;
            this.cbNavGPS_filtering.Text = "Enable GPS filtering";
            this.cbNavGPS_filtering.UseVisualStyleBackColor = true;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label88.Location = new System.Drawing.Point(16, 338);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(133, 13);
            this.label88.TabIndex = 55;
            this.label88.Text = "Max Nav banking (degree)";
            // 
            // cbNavGPS_Lead
            // 
            this.cbNavGPS_Lead.AutoSize = true;
            this.cbNavGPS_Lead.aux = 0;
            this.cbNavGPS_Lead.ForeColor = System.Drawing.Color.White;
            this.cbNavGPS_Lead.IsHighlighted = false;
            this.cbNavGPS_Lead.item = 0;
            this.cbNavGPS_Lead.Location = new System.Drawing.Point(19, 42);
            this.cbNavGPS_Lead.Name = "cbNavGPS_Lead";
            this.cbNavGPS_Lead.rclevel = 0;
            this.cbNavGPS_Lead.Size = new System.Drawing.Size(193, 17);
            this.cbNavGPS_Lead.TabIndex = 33;
            this.cbNavGPS_Lead.Text = "Enable GPS forward prediction filter";
            this.cbNavGPS_Lead.UseVisualStyleBackColor = true;
            // 
            // nBanking
            // 
            this.nBanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nBanking.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBanking.Location = new System.Drawing.Point(19, 358);
            this.nBanking.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nBanking.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nBanking.Name = "nBanking";
            this.nBanking.Size = new System.Drawing.Size(57, 19);
            this.nBanking.TabIndex = 54;
            this.nBanking.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // cbNavResetHome
            // 
            this.cbNavResetHome.AutoSize = true;
            this.cbNavResetHome.aux = 0;
            this.cbNavResetHome.ForeColor = System.Drawing.Color.White;
            this.cbNavResetHome.IsHighlighted = false;
            this.cbNavResetHome.item = 0;
            this.cbNavResetHome.Location = new System.Drawing.Point(19, 66);
            this.cbNavResetHome.Name = "cbNavResetHome";
            this.cbNavResetHome.rclevel = 0;
            this.cbNavResetHome.Size = new System.Drawing.Size(177, 17);
            this.cbNavResetHome.TabIndex = 34;
            this.cbNavResetHome.Text = "Don\'t reset home position at arm";
            this.cbNavResetHome.UseVisualStyleBackColor = true;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label87.Location = new System.Drawing.Point(305, 243);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(80, 13);
            this.label87.TabIndex = 53;
            this.label87.Text = "Crosstrack gain";
            // 
            // cbNavHeadingControl
            // 
            this.cbNavHeadingControl.AutoSize = true;
            this.cbNavHeadingControl.aux = 0;
            this.cbNavHeadingControl.ForeColor = System.Drawing.Color.White;
            this.cbNavHeadingControl.IsHighlighted = false;
            this.cbNavHeadingControl.item = 0;
            this.cbNavHeadingControl.Location = new System.Drawing.Point(19, 90);
            this.cbNavHeadingControl.Name = "cbNavHeadingControl";
            this.cbNavHeadingControl.rclevel = 0;
            this.cbNavHeadingControl.Size = new System.Drawing.Size(127, 17);
            this.cbNavHeadingControl.TabIndex = 35;
            this.cbNavHeadingControl.Text = "Nav controls heading";
            this.cbNavHeadingControl.UseVisualStyleBackColor = true;
            // 
            // nCrosstrack
            // 
            this.nCrosstrack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nCrosstrack.DecimalPlaces = 2;
            this.nCrosstrack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCrosstrack.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nCrosstrack.Location = new System.Drawing.Point(308, 264);
            this.nCrosstrack.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nCrosstrack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nCrosstrack.Name = "nCrosstrack";
            this.nCrosstrack.Size = new System.Drawing.Size(57, 19);
            this.nCrosstrack.TabIndex = 52;
            this.nCrosstrack.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cbNavTailFirst
            // 
            this.cbNavTailFirst.AutoSize = true;
            this.cbNavTailFirst.aux = 0;
            this.cbNavTailFirst.ForeColor = System.Drawing.Color.White;
            this.cbNavTailFirst.IsHighlighted = false;
            this.cbNavTailFirst.item = 0;
            this.cbNavTailFirst.Location = new System.Drawing.Point(19, 114);
            this.cbNavTailFirst.Name = "cbNavTailFirst";
            this.cbNavTailFirst.rclevel = 0;
            this.cbNavTailFirst.Size = new System.Drawing.Size(96, 17);
            this.cbNavTailFirst.TabIndex = 36;
            this.cbNavTailFirst.Text = "Fly with tail first";
            this.cbNavTailFirst.UseVisualStyleBackColor = true;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label86.Location = new System.Drawing.Point(162, 243);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(85, 13);
            this.label86.TabIndex = 51;
            this.label86.Text = "RTH Altitude (m)";
            // 
            // cbNavRTHHead
            // 
            this.cbNavRTHHead.AutoSize = true;
            this.cbNavRTHHead.aux = 0;
            this.cbNavRTHHead.ForeColor = System.Drawing.Color.White;
            this.cbNavRTHHead.IsHighlighted = false;
            this.cbNavRTHHead.item = 0;
            this.cbNavRTHHead.Location = new System.Drawing.Point(19, 137);
            this.cbNavRTHHead.Name = "cbNavRTHHead";
            this.cbNavRTHHead.rclevel = 0;
            this.cbNavRTHHead.Size = new System.Drawing.Size(178, 17);
            this.cbNavRTHHead.TabIndex = 37;
            this.cbNavRTHHead.Text = "Turn to takeoff heading at home";
            this.cbNavRTHHead.UseVisualStyleBackColor = true;
            this.cbNavRTHHead.CheckedChanged += new System.EventHandler(this.checkBoxEx5_CheckedChanged);
            // 
            // nRTHAlt
            // 
            this.nRTHAlt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRTHAlt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRTHAlt.Location = new System.Drawing.Point(166, 264);
            this.nRTHAlt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nRTHAlt.Name = "nRTHAlt";
            this.nRTHAlt.Size = new System.Drawing.Size(57, 19);
            this.nRTHAlt.TabIndex = 50;
            this.nRTHAlt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cbNavWaitRTHAlt
            // 
            this.cbNavWaitRTHAlt.AutoSize = true;
            this.cbNavWaitRTHAlt.aux = 0;
            this.cbNavWaitRTHAlt.ForeColor = System.Drawing.Color.White;
            this.cbNavWaitRTHAlt.IsHighlighted = false;
            this.cbNavWaitRTHAlt.item = 0;
            this.cbNavWaitRTHAlt.Location = new System.Drawing.Point(19, 161);
            this.cbNavWaitRTHAlt.Name = "cbNavWaitRTHAlt";
            this.cbNavWaitRTHAlt.rclevel = 0;
            this.cbNavWaitRTHAlt.Size = new System.Drawing.Size(136, 17);
            this.cbNavWaitRTHAlt.TabIndex = 38;
            this.cbNavWaitRTHAlt.Text = "Wait for reach RTH alt.";
            this.cbNavWaitRTHAlt.UseVisualStyleBackColor = true;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label85.Location = new System.Drawing.Point(162, 290);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(112, 13);
            this.label85.TabIndex = 49;
            this.label85.Text = "Min Nav speed (cm/s)";
            // 
            // cbNavSlowNav
            // 
            this.cbNavSlowNav.AutoSize = true;
            this.cbNavSlowNav.aux = 0;
            this.cbNavSlowNav.ForeColor = System.Drawing.Color.White;
            this.cbNavSlowNav.IsHighlighted = false;
            this.cbNavSlowNav.item = 0;
            this.cbNavSlowNav.Location = new System.Drawing.Point(19, 184);
            this.cbNavSlowNav.Name = "cbNavSlowNav";
            this.cbNavSlowNav.rclevel = 0;
            this.cbNavSlowNav.Size = new System.Drawing.Size(135, 17);
            this.cbNavSlowNav.TabIndex = 39;
            this.cbNavSlowNav.Text = "Enable slow navigation";
            this.cbNavSlowNav.UseVisualStyleBackColor = true;
            // 
            // nMinSpeed
            // 
            this.nMinSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nMinSpeed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMinSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nMinSpeed.Location = new System.Drawing.Point(166, 311);
            this.nMinSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMinSpeed.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nMinSpeed.Name = "nMinSpeed";
            this.nMinSpeed.Size = new System.Drawing.Size(57, 19);
            this.nMinSpeed.TabIndex = 48;
            this.nMinSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nWPRadius
            // 
            this.nWPRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nWPRadius.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nWPRadius.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nWPRadius.Location = new System.Drawing.Point(19, 264);
            this.nWPRadius.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nWPRadius.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nWPRadius.Name = "nWPRadius";
            this.nWPRadius.Size = new System.Drawing.Size(57, 19);
            this.nWPRadius.TabIndex = 40;
            this.nWPRadius.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label84.Location = new System.Drawing.Point(16, 290);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(115, 13);
            this.label84.TabIndex = 47;
            this.label84.Text = "Max Nav speed (cm/s)";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label76.Location = new System.Drawing.Point(16, 243);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(84, 13);
            this.label76.TabIndex = 41;
            this.label76.Text = "WP Radius (cm)";
            // 
            // nMaxSpeed
            // 
            this.nMaxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nMaxSpeed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMaxSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nMaxSpeed.Location = new System.Drawing.Point(19, 311);
            this.nMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMaxSpeed.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nMaxSpeed.Name = "nMaxSpeed";
            this.nMaxSpeed.Size = new System.Drawing.Size(57, 19);
            this.nMaxSpeed.TabIndex = 46;
            this.nMaxSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nSafeWPDist
            // 
            this.nSafeWPDist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nSafeWPDist.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSafeWPDist.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nSafeWPDist.Location = new System.Drawing.Point(19, 406);
            this.nSafeWPDist.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nSafeWPDist.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nSafeWPDist.Name = "nSafeWPDist";
            this.nSafeWPDist.Size = new System.Drawing.Size(57, 19);
            this.nSafeWPDist.TabIndex = 42;
            this.nSafeWPDist.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label83.Location = new System.Drawing.Point(162, 385);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(105, 13);
            this.label83.TabIndex = 45;
            this.label83.Text = "Max Nav Altitude (m)";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label82.Location = new System.Drawing.Point(16, 385);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(110, 13);
            this.label82.TabIndex = 43;
            this.label82.Text = "Safe WP distance (m)";
            // 
            // nMaxAlt
            // 
            this.nMaxAlt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nMaxAlt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMaxAlt.Location = new System.Drawing.Point(166, 406);
            this.nMaxAlt.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nMaxAlt.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nMaxAlt.Name = "nMaxAlt";
            this.nMaxAlt.Size = new System.Drawing.Size(57, 19);
            this.nMaxAlt.TabIndex = 44;
            this.nMaxAlt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(343, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Thr. EXPO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(343, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Thr. MID";
            // 
            // nTEXPO
            // 
            this.nTEXPO.BackColor = System.Drawing.Color.LightGray;
            this.nTEXPO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nTEXPO.DecimalPlaces = 2;
            this.nTEXPO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTEXPO.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nTEXPO.Location = new System.Drawing.Point(343, 234);
            this.nTEXPO.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTEXPO.Name = "nTEXPO";
            this.nTEXPO.Size = new System.Drawing.Size(58, 18);
            this.nTEXPO.TabIndex = 29;
            this.nTEXPO.ValueChanged += new System.EventHandler(this.nTEXPO_ValueChanged);
            // 
            // nTMID
            // 
            this.nTMID.BackColor = System.Drawing.Color.LightGray;
            this.nTMID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nTMID.DecimalPlaces = 2;
            this.nTMID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTMID.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nTMID.Location = new System.Drawing.Point(343, 188);
            this.nTMID.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTMID.Name = "nTMID";
            this.nTMID.Size = new System.Drawing.Size(58, 18);
            this.nTMID.TabIndex = 28;
            this.nTMID.ValueChanged += new System.EventHandler(this.nTMID_ValueChanged);
            // 
            // trackBar_T_EXPO
            // 
            this.trackBar_T_EXPO.AutoSize = false;
            this.trackBar_T_EXPO.LargeChange = 1;
            this.trackBar_T_EXPO.Location = new System.Drawing.Point(338, 287);
            this.trackBar_T_EXPO.Maximum = 100;
            this.trackBar_T_EXPO.Name = "trackBar_T_EXPO";
            this.trackBar_T_EXPO.Size = new System.Drawing.Size(239, 20);
            this.trackBar_T_EXPO.TabIndex = 27;
            this.trackBar_T_EXPO.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_T_EXPO.Value = 100;
            this.trackBar_T_EXPO.Scroll += new System.EventHandler(this.trackBar_T_EXPO_Scroll);
            // 
            // trackBar_T_MID
            // 
            this.trackBar_T_MID.AutoSize = false;
            this.trackBar_T_MID.Location = new System.Drawing.Point(338, 270);
            this.trackBar_T_MID.Maximum = 100;
            this.trackBar_T_MID.Name = "trackBar_T_MID";
            this.trackBar_T_MID.Size = new System.Drawing.Size(239, 20);
            this.trackBar_T_MID.TabIndex = 26;
            this.trackBar_T_MID.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_T_MID.Value = 80;
            this.trackBar_T_MID.Scroll += new System.EventHandler(this.trackBar_T_MID_Scroll);
            // 
            // trackbar_RC_Rate
            // 
            this.trackbar_RC_Rate.AutoSize = false;
            this.trackbar_RC_Rate.LargeChange = 1;
            this.trackbar_RC_Rate.Location = new System.Drawing.Point(336, 138);
            this.trackbar_RC_Rate.Maximum = 250;
            this.trackbar_RC_Rate.Name = "trackbar_RC_Rate";
            this.trackbar_RC_Rate.Size = new System.Drawing.Size(239, 20);
            this.trackbar_RC_Rate.TabIndex = 17;
            this.trackbar_RC_Rate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbar_RC_Rate.Value = 100;
            this.trackbar_RC_Rate.Scroll += new System.EventHandler(this.trackbar_RC_Rate_Scroll);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.ForeColor = System.Drawing.Color.Gainsboro;
            this.label65.Location = new System.Drawing.Point(340, 71);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(48, 13);
            this.label65.TabIndex = 18;
            this.label65.Text = "RC Rate";
            // 
            // trackbar_RC_Expo
            // 
            this.trackbar_RC_Expo.AutoSize = false;
            this.trackbar_RC_Expo.Location = new System.Drawing.Point(336, 121);
            this.trackbar_RC_Expo.Maximum = 100;
            this.trackbar_RC_Expo.Name = "trackbar_RC_Expo";
            this.trackbar_RC_Expo.Size = new System.Drawing.Size(239, 20);
            this.trackbar_RC_Expo.TabIndex = 16;
            this.trackbar_RC_Expo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbar_RC_Expo.Value = 80;
            this.trackbar_RC_Expo.Scroll += new System.EventHandler(this.trackbar_RC_Expo_Scroll);
            // 
            // nRCRate
            // 
            this.nRCRate.BackColor = System.Drawing.Color.LightGray;
            this.nRCRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRCRate.DecimalPlaces = 2;
            this.nRCRate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRCRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nRCRate.Location = new System.Drawing.Point(343, 88);
            this.nRCRate.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nRCRate.Name = "nRCRate";
            this.nRCRate.Size = new System.Drawing.Size(58, 18);
            this.nRCRate.TabIndex = 20;
            this.nRCRate.ValueChanged += new System.EventHandler(this.nRCRate_ValueChanged);
            // 
            // nRCExpo
            // 
            this.nRCExpo.BackColor = System.Drawing.Color.LightGray;
            this.nRCExpo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRCExpo.DecimalPlaces = 2;
            this.nRCExpo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRCExpo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nRCExpo.Location = new System.Drawing.Point(343, 38);
            this.nRCExpo.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRCExpo.Name = "nRCExpo";
            this.nRCExpo.Size = new System.Drawing.Size(58, 18);
            this.nRCExpo.TabIndex = 21;
            this.nRCExpo.ValueChanged += new System.EventHandler(this.nRCExpo_ValueChanged);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.ForeColor = System.Drawing.Color.Gainsboro;
            this.label66.Location = new System.Drawing.Point(340, 22);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(49, 13);
            this.label66.TabIndex = 19;
            this.label66.Text = "RC Expo";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label50);
            this.groupBox12.Controls.Add(this.label_sok);
            this.groupBox12.Controls.Add(this.label60);
            this.groupBox12.Controls.Add(this.nRATE_tpid);
            this.groupBox12.Controls.Add(this.nRATE_yaw);
            this.groupBox12.Controls.Add(this.nRATE_rp);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.ForeColor = System.Drawing.Color.White;
            this.groupBox12.Location = new System.Drawing.Point(9, 344);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(263, 94);
            this.groupBox12.TabIndex = 8;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Rates/Expo";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(16, 69);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(144, 13);
            this.label50.TabIndex = 5;
            this.label50.Text = "Throttle PID attenuation";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_sok
            // 
            this.label_sok.AutoSize = true;
            this.label_sok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sok.ForeColor = System.Drawing.Color.White;
            this.label_sok.Location = new System.Drawing.Point(16, 43);
            this.label_sok.Name = "label_sok";
            this.label_sok.Size = new System.Drawing.Size(68, 13);
            this.label_sok.TabIndex = 4;
            this.label_sok.Text = "Yaw RATE";
            this.label_sok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(16, 18);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(101, 13);
            this.label60.TabIndex = 3;
            this.label60.Text = "Roll/Pitch RATE";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nRATE_tpid
            // 
            this.nRATE_tpid.BackColor = System.Drawing.Color.LightGray;
            this.nRATE_tpid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRATE_tpid.DecimalPlaces = 2;
            this.nRATE_tpid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRATE_tpid.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nRATE_tpid.Location = new System.Drawing.Point(170, 67);
            this.nRATE_tpid.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRATE_tpid.Name = "nRATE_tpid";
            this.nRATE_tpid.Size = new System.Drawing.Size(73, 18);
            this.nRATE_tpid.TabIndex = 2;
            this.nRATE_tpid.ValueChanged += new System.EventHandler(this.nRATE_tpid_ValueChanged);
            // 
            // nRATE_yaw
            // 
            this.nRATE_yaw.BackColor = System.Drawing.Color.LightGray;
            this.nRATE_yaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRATE_yaw.DecimalPlaces = 2;
            this.nRATE_yaw.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRATE_yaw.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nRATE_yaw.Location = new System.Drawing.Point(170, 42);
            this.nRATE_yaw.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRATE_yaw.Name = "nRATE_yaw";
            this.nRATE_yaw.Size = new System.Drawing.Size(73, 18);
            this.nRATE_yaw.TabIndex = 1;
            this.nRATE_yaw.ValueChanged += new System.EventHandler(this.nRATE_yaw_ValueChanged);
            // 
            // nRATE_rp
            // 
            this.nRATE_rp.BackColor = System.Drawing.Color.LightGray;
            this.nRATE_rp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRATE_rp.DecimalPlaces = 2;
            this.nRATE_rp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRATE_rp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nRATE_rp.Location = new System.Drawing.Point(170, 16);
            this.nRATE_rp.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRATE_rp.Name = "nRATE_rp";
            this.nRATE_rp.Size = new System.Drawing.Size(73, 18);
            this.nRATE_rp.TabIndex = 0;
            this.nRATE_rp.ValueChanged += new System.EventHandler(this.nRATE_rp_ValueChanged);
            // 
            // throttle_expo_control1
            // 
            this.throttle_expo_control1.Location = new System.Drawing.Point(410, 166);
            this.throttle_expo_control1.Name = "throttle_expo_control1";
            this.throttle_expo_control1.Size = new System.Drawing.Size(150, 100);
            this.throttle_expo_control1.TabIndex = 25;
            this.throttle_expo_control1.Text = "throttle_expo_control1";
            // 
            // rc_expo_control1
            // 
            this.rc_expo_control1.Location = new System.Drawing.Point(409, 17);
            this.rc_expo_control1.Name = "rc_expo_control1";
            this.rc_expo_control1.Size = new System.Drawing.Size(150, 100);
            this.rc_expo_control1.TabIndex = 15;
            this.rc_expo_control1.Text = "rc_expo_control1";
            // 
            // tabPageConf
            // 
            this.tabPageConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageConf.Controls.Add(this.lVBatConf);
            this.tabPageConf.Controls.Add(this.labelvbat);
            this.tabPageConf.Controls.Add(this.groupBox8);
            this.tabPageConf.Controls.Add(this.groupBox7);
            this.tabPageConf.Controls.Add(this.groupBox6);
            this.tabPageConf.Controls.Add(this.groupBox5);
            this.tabPageConf.Controls.Add(this.groupBox4);
            this.tabPageConf.Location = new System.Drawing.Point(4, 22);
            this.tabPageConf.Name = "tabPageConf";
            this.tabPageConf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConf.Size = new System.Drawing.Size(1048, 444);
            this.tabPageConf.TabIndex = 7;
            this.tabPageConf.Text = "FC Config";
            // 
            // lVBatConf
            // 
            this.lVBatConf.AutoSize = true;
            this.lVBatConf.ForeColor = System.Drawing.Color.White;
            this.lVBatConf.Location = new System.Drawing.Point(899, 26);
            this.lVBatConf.Name = "lVBatConf";
            this.lVBatConf.Size = new System.Drawing.Size(41, 13);
            this.lVBatConf.TabIndex = 123;
            this.lVBatConf.Text = "label77";
            // 
            // labelvbat
            // 
            this.labelvbat.AutoSize = true;
            this.labelvbat.ForeColor = System.Drawing.Color.White;
            this.labelvbat.Location = new System.Drawing.Point(861, 26);
            this.labelvbat.Name = "labelvbat";
            this.labelvbat.Size = new System.Drawing.Size(30, 13);
            this.labelvbat.TabIndex = 122;
            this.labelvbat.Text = "VBat";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label58);
            this.groupBox8.Controls.Add(this.lMaxThr);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label57);
            this.groupBox8.Controls.Add(this.nFSThr);
            this.groupBox8.Controls.Add(this.label59);
            this.groupBox8.Controls.Add(this.nMinThr);
            this.groupBox8.Controls.Add(this.lMinCommand);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(605, 159);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(249, 201);
            this.groupBox8.TabIndex = 121;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Throttle limits";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(6, 53);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(78, 13);
            this.label58.TabIndex = 102;
            this.label58.Text = "Max Throttle";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lMaxThr
            // 
            this.lMaxThr.AutoSize = true;
            this.lMaxThr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMaxThr.ForeColor = System.Drawing.Color.White;
            this.lMaxThr.Location = new System.Drawing.Point(157, 51);
            this.lMaxThr.Name = "lMaxThr";
            this.lMaxThr.Size = new System.Drawing.Size(15, 15);
            this.lMaxThr.TabIndex = 120;
            this.lMaxThr.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "MinThrottle";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.White;
            this.label57.Location = new System.Drawing.Point(6, 81);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(85, 13);
            this.label57.TabIndex = 101;
            this.label57.Text = "Min Command";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nFSThr
            // 
            this.nFSThr.BackColor = System.Drawing.Color.LightGray;
            this.nFSThr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nFSThr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFSThr.Location = new System.Drawing.Point(160, 108);
            this.nFSThr.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nFSThr.Name = "nFSThr";
            this.nFSThr.Size = new System.Drawing.Size(73, 18);
            this.nFSThr.TabIndex = 117;
            this.nFSThr.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(6, 108);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(99, 13);
            this.label59.TabIndex = 103;
            this.label59.Text = "Failsafe Throttle";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nMinThr
            // 
            this.nMinThr.BackColor = System.Drawing.Color.LightGray;
            this.nMinThr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nMinThr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMinThr.Location = new System.Drawing.Point(160, 26);
            this.nMinThr.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nMinThr.Name = "nMinThr";
            this.nMinThr.Size = new System.Drawing.Size(73, 18);
            this.nMinThr.TabIndex = 114;
            this.nMinThr.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // lMinCommand
            // 
            this.lMinCommand.AutoSize = true;
            this.lMinCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMinCommand.ForeColor = System.Drawing.Color.White;
            this.lMinCommand.Location = new System.Drawing.Point(157, 78);
            this.lMinCommand.Name = "lMinCommand";
            this.lMinCommand.Size = new System.Drawing.Size(15, 15);
            this.lMinCommand.TabIndex = 116;
            this.lMinCommand.Text = "0";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label62);
            this.groupBox7.Controls.Add(this.lLife);
            this.groupBox7.Controls.Add(this.label61);
            this.groupBox7.Controls.Add(this.lArms);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(378, 282);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(218, 78);
            this.groupBox7.TabIndex = 119;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lifetime (PLog)";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(16, 24);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(76, 13);
            this.label62.TabIndex = 105;
            this.label62.Text = "Flights (arm)";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lLife
            // 
            this.lLife.AutoSize = true;
            this.lLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLife.ForeColor = System.Drawing.Color.White;
            this.lLife.Location = new System.Drawing.Point(151, 46);
            this.lLife.Name = "lLife";
            this.lLife.Size = new System.Drawing.Size(15, 15);
            this.lLife.TabIndex = 118;
            this.lLife.Text = "0";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.White;
            this.label61.Location = new System.Drawing.Point(16, 46);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(101, 13);
            this.label61.TabIndex = 104;
            this.label61.Text = "Total armed time";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArms
            // 
            this.lArms.AutoSize = true;
            this.lArms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArms.ForeColor = System.Drawing.Color.White;
            this.lArms.Location = new System.Drawing.Point(151, 22);
            this.lArms.Name = "lArms";
            this.lArms.Size = new System.Drawing.Size(15, 15);
            this.lArms.TabIndex = 115;
            this.lArms.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label68);
            this.groupBox6.Controls.Add(this.nVBatCritical);
            this.groupBox6.Controls.Add(this.nPAlarm);
            this.groupBox6.Controls.Add(this.nVBatWarn2);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.nVBatWarn1);
            this.groupBox6.Controls.Add(this.label63);
            this.groupBox6.Controls.Add(this.nVBatScale);
            this.groupBox6.Controls.Add(this.label64);
            this.groupBox6.Controls.Add(this.label67);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(602, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 142);
            this.groupBox6.TabIndex = 114;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Battery Monitoring";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(6, 21);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(70, 13);
            this.label68.TabIndex = 109;
            this.label68.Text = "VBat Scale";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nVBatCritical
            // 
            this.nVBatCritical.BackColor = System.Drawing.Color.LightGray;
            this.nVBatCritical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nVBatCritical.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nVBatCritical.Location = new System.Drawing.Point(162, 93);
            this.nVBatCritical.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.nVBatCritical.Name = "nVBatCritical";
            this.nVBatCritical.Size = new System.Drawing.Size(73, 18);
            this.nVBatCritical.TabIndex = 113;
            // 
            // nPAlarm
            // 
            this.nPAlarm.BackColor = System.Drawing.Color.LightGray;
            this.nPAlarm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nPAlarm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPAlarm.Location = new System.Drawing.Point(162, 116);
            this.nPAlarm.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.nPAlarm.Name = "nPAlarm";
            this.nPAlarm.Size = new System.Drawing.Size(73, 18);
            this.nPAlarm.TabIndex = 22;
            // 
            // nVBatWarn2
            // 
            this.nVBatWarn2.BackColor = System.Drawing.Color.LightGray;
            this.nVBatWarn2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nVBatWarn2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nVBatWarn2.Location = new System.Drawing.Point(162, 69);
            this.nVBatWarn2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nVBatWarn2.Name = "nVBatWarn2";
            this.nVBatWarn2.Size = new System.Drawing.Size(73, 18);
            this.nVBatWarn2.TabIndex = 112;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Power Meter Alarm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nVBatWarn1
            // 
            this.nVBatWarn1.BackColor = System.Drawing.Color.LightGray;
            this.nVBatWarn1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nVBatWarn1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nVBatWarn1.Location = new System.Drawing.Point(162, 46);
            this.nVBatWarn1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nVBatWarn1.Name = "nVBatWarn1";
            this.nVBatWarn1.Size = new System.Drawing.Size(73, 18);
            this.nVBatWarn1.TabIndex = 111;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(6, 91);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(108, 13);
            this.label63.TabIndex = 106;
            this.label63.Text = "VBat Critical level";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nVBatScale
            // 
            this.nVBatScale.BackColor = System.Drawing.Color.LightGray;
            this.nVBatScale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nVBatScale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nVBatScale.Location = new System.Drawing.Point(162, 22);
            this.nVBatScale.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nVBatScale.Name = "nVBatScale";
            this.nVBatScale.Size = new System.Drawing.Size(73, 18);
            this.nVBatScale.TabIndex = 110;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(6, 68);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(124, 13);
            this.label64.TabIndex = 107;
            this.label64.Text = "VBat warning level 2";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(6, 44);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(124, 13);
            this.label67.TabIndex = 108;
            this.label67.Text = "VBat warning level 1";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbMagSign);
            this.groupBox5.Controls.Add(this.linkLabel1);
            this.groupBox5.Controls.Add(this.nMagDeg);
            this.groupBox5.Controls.Add(this.label49);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label48);
            this.groupBox5.Controls.Add(this.nMagMin);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(9, 282);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(362, 78);
            this.groupBox5.TabIndex = 99;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Magnetic Decliniation";
            // 
            // cbMagSign
            // 
            this.cbMagSign.FormattingEnabled = true;
            this.cbMagSign.Items.AddRange(new object[] {
            "EAST",
            "WEST"});
            this.cbMagSign.Location = new System.Drawing.Point(10, 18);
            this.cbMagSign.Name = "cbMagSign";
            this.cbMagSign.Size = new System.Drawing.Size(74, 21);
            this.cbMagSign.TabIndex = 92;
            this.cbMagSign.SelectedIndexChanged += new System.EventHandler(this.cbMagSign_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(18, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(275, 13);
            this.linkLabel1.TabIndex = 98;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Check your location at  http://magnetic-declination.com/";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // nMagDeg
            // 
            this.nMagDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMagDeg.Location = new System.Drawing.Point(102, 18);
            this.nMagDeg.Name = "nMagDeg";
            this.nMagDeg.Size = new System.Drawing.Size(42, 21);
            this.nMagDeg.TabIndex = 93;
            this.nMagDeg.ValueChanged += new System.EventHandler(this.nMagDeg_ValueChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.Coral;
            this.label49.Location = new System.Drawing.Point(298, 21);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(38, 16);
            this.label49.TabIndex = 97;
            this.label49.Text = "(0.0)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(150, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "degree";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(246, 22);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(43, 13);
            this.label48.TabIndex = 96;
            this.label48.Text = "minutes";
            // 
            // nMagMin
            // 
            this.nMagMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMagMin.Location = new System.Drawing.Point(198, 18);
            this.nMagMin.Name = "nMagMin";
            this.nMagMin.Size = new System.Drawing.Size(42, 21);
            this.nMagMin.TabIndex = 95;
            this.nMagMin.ValueChanged += new System.EventHandler(this.nMagMin_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nSrvRate4);
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Controls.Add(this.cbSrvRev1);
            this.groupBox4.Controls.Add(this.label55);
            this.groupBox4.Controls.Add(this.cbSrvRev2);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.cbSrvRev3);
            this.groupBox4.Controls.Add(this.label53);
            this.groupBox4.Controls.Add(this.cbSrvRev4);
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Controls.Add(this.cbSrvRev5);
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.cbSrvRev6);
            this.groupBox4.Controls.Add(this.nSrvMax8);
            this.groupBox4.Controls.Add(this.cbSrvRev7);
            this.groupBox4.Controls.Add(this.nSrvMax7);
            this.groupBox4.Controls.Add(this.cbSrvRev8);
            this.groupBox4.Controls.Add(this.nSrvMax6);
            this.groupBox4.Controls.Add(this.lSrvID1);
            this.groupBox4.Controls.Add(this.nSrvMax5);
            this.groupBox4.Controls.Add(this.lSrvID2);
            this.groupBox4.Controls.Add(this.nSrvMax4);
            this.groupBox4.Controls.Add(this.lSrvID3);
            this.groupBox4.Controls.Add(this.nSrvMax3);
            this.groupBox4.Controls.Add(this.lSrvID4);
            this.groupBox4.Controls.Add(this.nSrvMax2);
            this.groupBox4.Controls.Add(this.lSrvID5);
            this.groupBox4.Controls.Add(this.nSrvMax1);
            this.groupBox4.Controls.Add(this.lSrvID6);
            this.groupBox4.Controls.Add(this.nSrvMid8);
            this.groupBox4.Controls.Add(this.lSrvID7);
            this.groupBox4.Controls.Add(this.nSrvMid7);
            this.groupBox4.Controls.Add(this.lSrvID8);
            this.groupBox4.Controls.Add(this.nSrvMid6);
            this.groupBox4.Controls.Add(this.lSrvName1);
            this.groupBox4.Controls.Add(this.nSrvMid5);
            this.groupBox4.Controls.Add(this.lSrvName3);
            this.groupBox4.Controls.Add(this.nSrvMid4);
            this.groupBox4.Controls.Add(this.lSrvName2);
            this.groupBox4.Controls.Add(this.nSrvMid3);
            this.groupBox4.Controls.Add(this.lSrvName4);
            this.groupBox4.Controls.Add(this.nSrvMid2);
            this.groupBox4.Controls.Add(this.lSrvName5);
            this.groupBox4.Controls.Add(this.nSrvMid1);
            this.groupBox4.Controls.Add(this.lSrvName6);
            this.groupBox4.Controls.Add(this.nSrvMin8);
            this.groupBox4.Controls.Add(this.lSrvName7);
            this.groupBox4.Controls.Add(this.nSrvMin7);
            this.groupBox4.Controls.Add(this.lSrvName8);
            this.groupBox4.Controls.Add(this.nSrvMin6);
            this.groupBox4.Controls.Add(this.nSrvRate1);
            this.groupBox4.Controls.Add(this.nSrvMin5);
            this.groupBox4.Controls.Add(this.nSrvRate2);
            this.groupBox4.Controls.Add(this.nSrvMin4);
            this.groupBox4.Controls.Add(this.nSrvRate3);
            this.groupBox4.Controls.Add(this.nSrvMin3);
            this.groupBox4.Controls.Add(this.nSrvRate5);
            this.groupBox4.Controls.Add(this.nSrvMin2);
            this.groupBox4.Controls.Add(this.nSrvRate6);
            this.groupBox4.Controls.Add(this.nSrvMin1);
            this.groupBox4.Controls.Add(this.nSrvRate7);
            this.groupBox4.Controls.Add(this.nSrvRate8);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(9, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(588, 270);
            this.groupBox4.TabIndex = 90;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Servo settings";
            // 
            // nSrvRate4
            // 
            this.nSrvRate4.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvRate4.Location = new System.Drawing.Point(259, 124);
            this.nSrvRate4.Name = "nSrvRate4";
            this.nSrvRate4.Size = new System.Drawing.Size(52, 22);
            this.nSrvRate4.TabIndex = 55;
            this.nSrvRate4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(525, 16);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(27, 13);
            this.label56.TabIndex = 89;
            this.label56.Text = "Max";
            // 
            // cbSrvRev1
            // 
            this.cbSrvRev1.AutoSize = true;
            this.cbSrvRev1.aux = 0;
            this.cbSrvRev1.IsHighlighted = false;
            this.cbSrvRev1.item = 0;
            this.cbSrvRev1.Location = new System.Drawing.Point(215, 44);
            this.cbSrvRev1.Name = "cbSrvRev1";
            this.cbSrvRev1.rclevel = 0;
            this.cbSrvRev1.Size = new System.Drawing.Size(15, 14);
            this.cbSrvRev1.TabIndex = 44;
            this.cbSrvRev1.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(426, 16);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(38, 13);
            this.label55.TabIndex = 88;
            this.label55.Text = "Middle";
            // 
            // cbSrvRev2
            // 
            this.cbSrvRev2.AutoSize = true;
            this.cbSrvRev2.aux = 0;
            this.cbSrvRev2.IsHighlighted = false;
            this.cbSrvRev2.item = 0;
            this.cbSrvRev2.Location = new System.Drawing.Point(215, 72);
            this.cbSrvRev2.Name = "cbSrvRev2";
            this.cbSrvRev2.rclevel = 0;
            this.cbSrvRev2.Size = new System.Drawing.Size(15, 14);
            this.cbSrvRev2.TabIndex = 45;
            this.cbSrvRev2.UseVisualStyleBackColor = true;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(348, 16);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(24, 13);
            this.label54.TabIndex = 87;
            this.label54.Text = "Min";
            // 
            // cbSrvRev3
            // 
            this.cbSrvRev3.AutoSize = true;
            this.cbSrvRev3.aux = 0;
            this.cbSrvRev3.IsHighlighted = false;
            this.cbSrvRev3.item = 0;
            this.cbSrvRev3.Location = new System.Drawing.Point(215, 99);
            this.cbSrvRev3.Name = "cbSrvRev3";
            this.cbSrvRev3.rclevel = 0;
            this.cbSrvRev3.Size = new System.Drawing.Size(15, 14);
            this.cbSrvRev3.TabIndex = 46;
            this.cbSrvRev3.UseVisualStyleBackColor = true;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(268, 16);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(30, 13);
            this.label53.TabIndex = 86;
            this.label53.Text = "Rate";
            // 
            // cbSrvRev4
            // 
            this.cbSrvRev4.AutoSize = true;
            this.cbSrvRev4.aux = 0;
            this.cbSrvRev4.IsHighlighted = false;
            this.cbSrvRev4.item = 0;
            this.cbSrvRev4.Location = new System.Drawing.Point(215, 127);
            this.cbSrvRev4.Name = "cbSrvRev4";
            this.cbSrvRev4.rclevel = 0;
            this.cbSrvRev4.Size = new System.Drawing.Size(15, 14);
            this.cbSrvRev4.TabIndex = 47;
            this.cbSrvRev4.UseVisualStyleBackColor = true;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(196, 16);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(47, 13);
            this.label52.TabIndex = 85;
            this.label52.Text = "Reverse";
            // 
            // cbSrvRev5
            // 
            this.cbSrvRev5.AutoSize = true;
            this.cbSrvRev5.aux = 0;
            this.cbSrvRev5.IsHighlighted = false;
            this.cbSrvRev5.item = 0;
            this.cbSrvRev5.Location = new System.Drawing.Point(215, 154);
            this.cbSrvRev5.Name = "cbSrvRev5";
            this.cbSrvRev5.rclevel = 0;
            this.cbSrvRev5.Size = new System.Drawing.Size(15, 14);
            this.cbSrvRev5.TabIndex = 48;
            this.cbSrvRev5.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(109, 16);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(48, 13);
            this.label51.TabIndex = 84;
            this.label51.Text = "Function";
            // 
            // cbSrvRev6
            // 
            this.cbSrvRev6.AutoSize = true;
            this.cbSrvRev6.aux = 0;
            this.cbSrvRev6.IsHighlighted = false;
            this.cbSrvRev6.item = 0;
            this.cbSrvRev6.Location = new System.Drawing.Point(215, 182);
            this.cbSrvRev6.Name = "cbSrvRev6";
            this.cbSrvRev6.rclevel = 0;
            this.cbSrvRev6.Size = new System.Drawing.Size(15, 14);
            this.cbSrvRev6.TabIndex = 49;
            this.cbSrvRev6.UseVisualStyleBackColor = true;
            // 
            // nSrvMax8
            // 
            this.nSrvMax8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMax8.Location = new System.Drawing.Point(508, 234);
            this.nSrvMax8.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax8.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax8.Name = "nSrvMax8";
            this.nSrvMax8.Size = new System.Drawing.Size(68, 22);
            this.nSrvMax8.TabIndex = 83;
            this.nSrvMax8.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cbSrvRev7
            // 
            this.cbSrvRev7.AutoSize = true;
            this.cbSrvRev7.aux = 0;
            this.cbSrvRev7.IsHighlighted = false;
            this.cbSrvRev7.item = 0;
            this.cbSrvRev7.Location = new System.Drawing.Point(215, 210);
            this.cbSrvRev7.Name = "cbSrvRev7";
            this.cbSrvRev7.rclevel = 0;
            this.cbSrvRev7.Size = new System.Drawing.Size(15, 14);
            this.cbSrvRev7.TabIndex = 50;
            this.cbSrvRev7.UseVisualStyleBackColor = true;
            // 
            // nSrvMax7
            // 
            this.nSrvMax7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMax7.Location = new System.Drawing.Point(508, 208);
            this.nSrvMax7.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax7.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax7.Name = "nSrvMax7";
            this.nSrvMax7.Size = new System.Drawing.Size(68, 22);
            this.nSrvMax7.TabIndex = 82;
            this.nSrvMax7.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cbSrvRev8
            // 
            this.cbSrvRev8.AutoSize = true;
            this.cbSrvRev8.aux = 0;
            this.cbSrvRev8.IsHighlighted = false;
            this.cbSrvRev8.item = 0;
            this.cbSrvRev8.Location = new System.Drawing.Point(215, 238);
            this.cbSrvRev8.Name = "cbSrvRev8";
            this.cbSrvRev8.rclevel = 0;
            this.cbSrvRev8.Size = new System.Drawing.Size(15, 14);
            this.cbSrvRev8.TabIndex = 51;
            this.cbSrvRev8.UseVisualStyleBackColor = true;
            // 
            // nSrvMax6
            // 
            this.nSrvMax6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMax6.Location = new System.Drawing.Point(508, 179);
            this.nSrvMax6.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax6.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax6.Name = "nSrvMax6";
            this.nSrvMax6.Size = new System.Drawing.Size(68, 22);
            this.nSrvMax6.TabIndex = 81;
            this.nSrvMax6.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID1
            // 
            this.lSrvID1.AutoSize = true;
            this.lSrvID1.ForeColor = System.Drawing.Color.White;
            this.lSrvID1.Location = new System.Drawing.Point(6, 44);
            this.lSrvID1.Name = "lSrvID1";
            this.lSrvID1.Size = new System.Drawing.Size(41, 13);
            this.lSrvID1.TabIndex = 28;
            this.lSrvID1.Text = "Servo1";
            // 
            // nSrvMax5
            // 
            this.nSrvMax5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMax5.Location = new System.Drawing.Point(508, 152);
            this.nSrvMax5.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax5.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax5.Name = "nSrvMax5";
            this.nSrvMax5.Size = new System.Drawing.Size(68, 22);
            this.nSrvMax5.TabIndex = 80;
            this.nSrvMax5.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID2
            // 
            this.lSrvID2.AutoSize = true;
            this.lSrvID2.ForeColor = System.Drawing.Color.White;
            this.lSrvID2.Location = new System.Drawing.Point(6, 72);
            this.lSrvID2.Name = "lSrvID2";
            this.lSrvID2.Size = new System.Drawing.Size(41, 13);
            this.lSrvID2.TabIndex = 29;
            this.lSrvID2.Text = "Servo2";
            // 
            // nSrvMax4
            // 
            this.nSrvMax4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMax4.Location = new System.Drawing.Point(508, 124);
            this.nSrvMax4.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax4.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax4.Name = "nSrvMax4";
            this.nSrvMax4.Size = new System.Drawing.Size(68, 22);
            this.nSrvMax4.TabIndex = 79;
            this.nSrvMax4.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID3
            // 
            this.lSrvID3.AutoSize = true;
            this.lSrvID3.ForeColor = System.Drawing.Color.White;
            this.lSrvID3.Location = new System.Drawing.Point(6, 99);
            this.lSrvID3.Name = "lSrvID3";
            this.lSrvID3.Size = new System.Drawing.Size(41, 13);
            this.lSrvID3.TabIndex = 30;
            this.lSrvID3.Text = "Servo3";
            // 
            // nSrvMax3
            // 
            this.nSrvMax3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMax3.Location = new System.Drawing.Point(508, 97);
            this.nSrvMax3.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax3.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax3.Name = "nSrvMax3";
            this.nSrvMax3.Size = new System.Drawing.Size(68, 22);
            this.nSrvMax3.TabIndex = 78;
            this.nSrvMax3.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID4
            // 
            this.lSrvID4.AutoSize = true;
            this.lSrvID4.ForeColor = System.Drawing.Color.White;
            this.lSrvID4.Location = new System.Drawing.Point(6, 127);
            this.lSrvID4.Name = "lSrvID4";
            this.lSrvID4.Size = new System.Drawing.Size(41, 13);
            this.lSrvID4.TabIndex = 31;
            this.lSrvID4.Text = "Servo4";
            // 
            // nSrvMax2
            // 
            this.nSrvMax2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMax2.Location = new System.Drawing.Point(508, 69);
            this.nSrvMax2.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax2.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax2.Name = "nSrvMax2";
            this.nSrvMax2.Size = new System.Drawing.Size(68, 22);
            this.nSrvMax2.TabIndex = 77;
            this.nSrvMax2.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID5
            // 
            this.lSrvID5.AutoSize = true;
            this.lSrvID5.ForeColor = System.Drawing.Color.White;
            this.lSrvID5.Location = new System.Drawing.Point(6, 154);
            this.lSrvID5.Name = "lSrvID5";
            this.lSrvID5.Size = new System.Drawing.Size(41, 13);
            this.lSrvID5.TabIndex = 32;
            this.lSrvID5.Text = "Servo5";
            // 
            // nSrvMax1
            // 
            this.nSrvMax1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMax1.Location = new System.Drawing.Point(508, 42);
            this.nSrvMax1.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax1.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax1.Name = "nSrvMax1";
            this.nSrvMax1.Size = new System.Drawing.Size(68, 22);
            this.nSrvMax1.TabIndex = 76;
            this.nSrvMax1.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID6
            // 
            this.lSrvID6.AutoSize = true;
            this.lSrvID6.ForeColor = System.Drawing.Color.White;
            this.lSrvID6.Location = new System.Drawing.Point(6, 182);
            this.lSrvID6.Name = "lSrvID6";
            this.lSrvID6.Size = new System.Drawing.Size(41, 13);
            this.lSrvID6.TabIndex = 33;
            this.lSrvID6.Text = "Servo6";
            // 
            // nSrvMid8
            // 
            this.nSrvMid8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMid8.Location = new System.Drawing.Point(418, 234);
            this.nSrvMid8.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid8.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid8.Name = "nSrvMid8";
            this.nSrvMid8.Size = new System.Drawing.Size(68, 22);
            this.nSrvMid8.TabIndex = 75;
            this.nSrvMid8.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvID7
            // 
            this.lSrvID7.AutoSize = true;
            this.lSrvID7.ForeColor = System.Drawing.Color.White;
            this.lSrvID7.Location = new System.Drawing.Point(6, 210);
            this.lSrvID7.Name = "lSrvID7";
            this.lSrvID7.Size = new System.Drawing.Size(41, 13);
            this.lSrvID7.TabIndex = 34;
            this.lSrvID7.Text = "Servo7";
            // 
            // nSrvMid7
            // 
            this.nSrvMid7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMid7.Location = new System.Drawing.Point(418, 208);
            this.nSrvMid7.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid7.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid7.Name = "nSrvMid7";
            this.nSrvMid7.Size = new System.Drawing.Size(68, 22);
            this.nSrvMid7.TabIndex = 74;
            this.nSrvMid7.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvID8
            // 
            this.lSrvID8.AutoSize = true;
            this.lSrvID8.ForeColor = System.Drawing.Color.White;
            this.lSrvID8.Location = new System.Drawing.Point(6, 238);
            this.lSrvID8.Name = "lSrvID8";
            this.lSrvID8.Size = new System.Drawing.Size(41, 13);
            this.lSrvID8.TabIndex = 35;
            this.lSrvID8.Text = "Servo8";
            // 
            // nSrvMid6
            // 
            this.nSrvMid6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMid6.Location = new System.Drawing.Point(418, 179);
            this.nSrvMid6.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid6.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid6.Name = "nSrvMid6";
            this.nSrvMid6.Size = new System.Drawing.Size(68, 22);
            this.nSrvMid6.TabIndex = 73;
            this.nSrvMid6.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvName1
            // 
            this.lSrvName1.AutoSize = true;
            this.lSrvName1.ForeColor = System.Drawing.Color.White;
            this.lSrvName1.Location = new System.Drawing.Point(70, 44);
            this.lSrvName1.Name = "lSrvName1";
            this.lSrvName1.Size = new System.Drawing.Size(121, 13);
            this.lSrvName1.TabIndex = 36;
            this.lSrvName1.Text = "--------------------------------------";
            // 
            // nSrvMid5
            // 
            this.nSrvMid5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMid5.Location = new System.Drawing.Point(418, 152);
            this.nSrvMid5.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid5.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid5.Name = "nSrvMid5";
            this.nSrvMid5.Size = new System.Drawing.Size(68, 22);
            this.nSrvMid5.TabIndex = 72;
            this.nSrvMid5.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvName3
            // 
            this.lSrvName3.AutoSize = true;
            this.lSrvName3.ForeColor = System.Drawing.Color.White;
            this.lSrvName3.Location = new System.Drawing.Point(70, 99);
            this.lSrvName3.Name = "lSrvName3";
            this.lSrvName3.Size = new System.Drawing.Size(121, 13);
            this.lSrvName3.TabIndex = 37;
            this.lSrvName3.Text = "--------------------------------------";
            // 
            // nSrvMid4
            // 
            this.nSrvMid4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMid4.Location = new System.Drawing.Point(418, 124);
            this.nSrvMid4.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid4.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid4.Name = "nSrvMid4";
            this.nSrvMid4.Size = new System.Drawing.Size(68, 22);
            this.nSrvMid4.TabIndex = 71;
            this.nSrvMid4.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvName2
            // 
            this.lSrvName2.AutoSize = true;
            this.lSrvName2.ForeColor = System.Drawing.Color.White;
            this.lSrvName2.Location = new System.Drawing.Point(70, 72);
            this.lSrvName2.Name = "lSrvName2";
            this.lSrvName2.Size = new System.Drawing.Size(121, 13);
            this.lSrvName2.TabIndex = 38;
            this.lSrvName2.Text = "--------------------------------------";
            // 
            // nSrvMid3
            // 
            this.nSrvMid3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMid3.Location = new System.Drawing.Point(418, 97);
            this.nSrvMid3.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid3.Name = "nSrvMid3";
            this.nSrvMid3.Size = new System.Drawing.Size(68, 22);
            this.nSrvMid3.TabIndex = 70;
            this.nSrvMid3.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvName4
            // 
            this.lSrvName4.AutoSize = true;
            this.lSrvName4.ForeColor = System.Drawing.Color.White;
            this.lSrvName4.Location = new System.Drawing.Point(70, 127);
            this.lSrvName4.Name = "lSrvName4";
            this.lSrvName4.Size = new System.Drawing.Size(121, 13);
            this.lSrvName4.TabIndex = 39;
            this.lSrvName4.Text = "--------------------------------------";
            // 
            // nSrvMid2
            // 
            this.nSrvMid2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMid2.Location = new System.Drawing.Point(418, 69);
            this.nSrvMid2.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid2.Name = "nSrvMid2";
            this.nSrvMid2.Size = new System.Drawing.Size(68, 22);
            this.nSrvMid2.TabIndex = 69;
            this.nSrvMid2.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvName5
            // 
            this.lSrvName5.AutoSize = true;
            this.lSrvName5.ForeColor = System.Drawing.Color.White;
            this.lSrvName5.Location = new System.Drawing.Point(70, 154);
            this.lSrvName5.Name = "lSrvName5";
            this.lSrvName5.Size = new System.Drawing.Size(121, 13);
            this.lSrvName5.TabIndex = 40;
            this.lSrvName5.Text = "--------------------------------------";
            // 
            // nSrvMid1
            // 
            this.nSrvMid1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMid1.Location = new System.Drawing.Point(418, 42);
            this.nSrvMid1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid1.Name = "nSrvMid1";
            this.nSrvMid1.Size = new System.Drawing.Size(68, 22);
            this.nSrvMid1.TabIndex = 68;
            this.nSrvMid1.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nSrvMid1.ValueChanged += new System.EventHandler(this.nSrvMid1_ValueChanged);
            // 
            // lSrvName6
            // 
            this.lSrvName6.AutoSize = true;
            this.lSrvName6.ForeColor = System.Drawing.Color.White;
            this.lSrvName6.Location = new System.Drawing.Point(70, 182);
            this.lSrvName6.Name = "lSrvName6";
            this.lSrvName6.Size = new System.Drawing.Size(121, 13);
            this.lSrvName6.TabIndex = 41;
            this.lSrvName6.Text = "--------------------------------------";
            // 
            // nSrvMin8
            // 
            this.nSrvMin8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMin8.Location = new System.Drawing.Point(332, 234);
            this.nSrvMin8.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin8.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin8.Name = "nSrvMin8";
            this.nSrvMin8.Size = new System.Drawing.Size(68, 22);
            this.nSrvMin8.TabIndex = 67;
            this.nSrvMin8.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lSrvName7
            // 
            this.lSrvName7.AutoSize = true;
            this.lSrvName7.ForeColor = System.Drawing.Color.White;
            this.lSrvName7.Location = new System.Drawing.Point(70, 210);
            this.lSrvName7.Name = "lSrvName7";
            this.lSrvName7.Size = new System.Drawing.Size(121, 13);
            this.lSrvName7.TabIndex = 42;
            this.lSrvName7.Text = "--------------------------------------";
            // 
            // nSrvMin7
            // 
            this.nSrvMin7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMin7.Location = new System.Drawing.Point(332, 208);
            this.nSrvMin7.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin7.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin7.Name = "nSrvMin7";
            this.nSrvMin7.Size = new System.Drawing.Size(68, 22);
            this.nSrvMin7.TabIndex = 66;
            this.nSrvMin7.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lSrvName8
            // 
            this.lSrvName8.AutoSize = true;
            this.lSrvName8.ForeColor = System.Drawing.Color.White;
            this.lSrvName8.Location = new System.Drawing.Point(70, 238);
            this.lSrvName8.Name = "lSrvName8";
            this.lSrvName8.Size = new System.Drawing.Size(121, 13);
            this.lSrvName8.TabIndex = 43;
            this.lSrvName8.Text = "--------------------------------------";
            // 
            // nSrvMin6
            // 
            this.nSrvMin6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMin6.Location = new System.Drawing.Point(332, 179);
            this.nSrvMin6.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin6.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin6.Name = "nSrvMin6";
            this.nSrvMin6.Size = new System.Drawing.Size(68, 22);
            this.nSrvMin6.TabIndex = 65;
            this.nSrvMin6.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate1
            // 
            this.nSrvRate1.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvRate1.Location = new System.Drawing.Point(259, 42);
            this.nSrvRate1.Name = "nSrvRate1";
            this.nSrvRate1.Size = new System.Drawing.Size(52, 22);
            this.nSrvRate1.TabIndex = 52;
            this.nSrvRate1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvMin5
            // 
            this.nSrvMin5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMin5.Location = new System.Drawing.Point(332, 152);
            this.nSrvMin5.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin5.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin5.Name = "nSrvMin5";
            this.nSrvMin5.Size = new System.Drawing.Size(68, 22);
            this.nSrvMin5.TabIndex = 64;
            this.nSrvMin5.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate2
            // 
            this.nSrvRate2.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvRate2.Location = new System.Drawing.Point(259, 69);
            this.nSrvRate2.Name = "nSrvRate2";
            this.nSrvRate2.Size = new System.Drawing.Size(52, 22);
            this.nSrvRate2.TabIndex = 53;
            this.nSrvRate2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvMin4
            // 
            this.nSrvMin4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMin4.Location = new System.Drawing.Point(332, 124);
            this.nSrvMin4.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin4.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin4.Name = "nSrvMin4";
            this.nSrvMin4.Size = new System.Drawing.Size(68, 22);
            this.nSrvMin4.TabIndex = 63;
            this.nSrvMin4.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate3
            // 
            this.nSrvRate3.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvRate3.Location = new System.Drawing.Point(259, 97);
            this.nSrvRate3.Name = "nSrvRate3";
            this.nSrvRate3.Size = new System.Drawing.Size(52, 22);
            this.nSrvRate3.TabIndex = 54;
            this.nSrvRate3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvMin3
            // 
            this.nSrvMin3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMin3.Location = new System.Drawing.Point(332, 97);
            this.nSrvMin3.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin3.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin3.Name = "nSrvMin3";
            this.nSrvMin3.Size = new System.Drawing.Size(68, 22);
            this.nSrvMin3.TabIndex = 62;
            this.nSrvMin3.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate5
            // 
            this.nSrvRate5.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvRate5.Location = new System.Drawing.Point(259, 152);
            this.nSrvRate5.Name = "nSrvRate5";
            this.nSrvRate5.Size = new System.Drawing.Size(52, 22);
            this.nSrvRate5.TabIndex = 56;
            this.nSrvRate5.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvMin2
            // 
            this.nSrvMin2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMin2.Location = new System.Drawing.Point(332, 69);
            this.nSrvMin2.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin2.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin2.Name = "nSrvMin2";
            this.nSrvMin2.Size = new System.Drawing.Size(68, 22);
            this.nSrvMin2.TabIndex = 61;
            this.nSrvMin2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate6
            // 
            this.nSrvRate6.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvRate6.Location = new System.Drawing.Point(259, 179);
            this.nSrvRate6.Name = "nSrvRate6";
            this.nSrvRate6.Size = new System.Drawing.Size(52, 22);
            this.nSrvRate6.TabIndex = 57;
            this.nSrvRate6.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvMin1
            // 
            this.nSrvMin1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvMin1.Location = new System.Drawing.Point(332, 42);
            this.nSrvMin1.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin1.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin1.Name = "nSrvMin1";
            this.nSrvMin1.Size = new System.Drawing.Size(68, 22);
            this.nSrvMin1.TabIndex = 60;
            this.nSrvMin1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate7
            // 
            this.nSrvRate7.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvRate7.Location = new System.Drawing.Point(259, 206);
            this.nSrvRate7.Name = "nSrvRate7";
            this.nSrvRate7.Size = new System.Drawing.Size(52, 21);
            this.nSrvRate7.TabIndex = 58;
            this.nSrvRate7.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvRate8
            // 
            this.nSrvRate8.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSrvRate8.Location = new System.Drawing.Point(259, 234);
            this.nSrvRate8.Name = "nSrvRate8";
            this.nSrvRate8.Size = new System.Drawing.Size(52, 22);
            this.nSrvRate8.TabIndex = 59;
            this.nSrvRate8.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tabPageRC
            // 
            this.tabPageRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageRC.Controls.Add(this.label5);
            this.tabPageRC.Controls.Add(this.label4);
            this.tabPageRC.Controls.Add(this.pictureBox1);
            this.tabPageRC.Controls.Add(this.rci_Control_settings);
            this.tabPageRC.Location = new System.Drawing.Point(4, 22);
            this.tabPageRC.Name = "tabPageRC";
            this.tabPageRC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRC.Size = new System.Drawing.Size(1048, 444);
            this.tabPageRC.TabIndex = 0;
            this.tabPageRC.Text = "RC Control Settings";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(895, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Live RC data";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(678, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Orange border indicates, that setting was changed but not written to FC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MultiWiiWinGUI.Properties.Resources.checkbox_legend;
            this.pictureBox1.Location = new System.Drawing.Point(636, 422);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // rci_Control_settings
            // 
            this.rci_Control_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rci_Control_settings.Location = new System.Drawing.Point(826, 6);
            this.rci_Control_settings.Name = "rci_Control_settings";
            this.rci_Control_settings.Size = new System.Drawing.Size(200, 200);
            this.rci_Control_settings.TabIndex = 15;
            this.rci_Control_settings.Text = "rc_input_control2";
            // 
            // tabSensorGraph
            // 
            this.tabSensorGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabSensorGraph.Controls.Add(this.splitContainer10);
            this.tabSensorGraph.Location = new System.Drawing.Point(4, 22);
            this.tabSensorGraph.Name = "tabSensorGraph";
            this.tabSensorGraph.Size = new System.Drawing.Size(1048, 444);
            this.tabSensorGraph.TabIndex = 8;
            this.tabSensorGraph.Text = "Sensor Graph";
            // 
            // splitContainer10
            // 
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.Location = new System.Drawing.Point(0, 0);
            this.splitContainer10.Name = "splitContainer10";
            this.splitContainer10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.splitContainer11);
            this.splitContainer10.Size = new System.Drawing.Size(1048, 444);
            this.splitContainer10.SplitterDistance = 55;
            this.splitContainer10.TabIndex = 0;
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.Location = new System.Drawing.Point(0, 0);
            this.splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.splitContainer12);
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer11.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer11.Panel2.Controls.Add(this.cb_alt);
            this.splitContainer11.Panel2.Controls.Add(this.label22);
            this.splitContainer11.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer11.Panel2.Controls.Add(this.l_alt);
            this.splitContainer11.Panel2.Controls.Add(this.cb_head);
            this.splitContainer11.Panel2.Controls.Add(this.l_head);
            this.splitContainer11.Panel2.Controls.Add(this.label26);
            this.splitContainer11.Size = new System.Drawing.Size(1048, 385);
            this.splitContainer11.SplitterDistance = 806;
            this.splitContainer11.TabIndex = 0;
            // 
            // splitContainer12
            // 
            this.splitContainer12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer12.Location = new System.Drawing.Point(0, 0);
            this.splitContainer12.Name = "splitContainer12";
            this.splitContainer12.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer12.Panel1
            // 
            this.splitContainer12.Panel1.Controls.Add(this.zgMonitor);
            // 
            // splitContainer12.Panel2
            // 
            this.splitContainer12.Panel2.Controls.Add(this.label28);
            this.splitContainer12.Panel2.Controls.Add(this.cb_dbg1);
            this.splitContainer12.Panel2.Controls.Add(this.l_dbg1);
            this.splitContainer12.Panel2.Controls.Add(this.cb_dbg2);
            this.splitContainer12.Panel2.Controls.Add(this.label33);
            this.splitContainer12.Panel2.Controls.Add(this.l_dbg2);
            this.splitContainer12.Panel2.Controls.Add(this.cb_dbg3);
            this.splitContainer12.Panel2.Controls.Add(this.l_dbg4);
            this.splitContainer12.Panel2.Controls.Add(this.label38);
            this.splitContainer12.Panel2.Controls.Add(this.label40);
            this.splitContainer12.Panel2.Controls.Add(this.l_dbg3);
            this.splitContainer12.Panel2.Controls.Add(this.cb_dbg4);
            this.splitContainer12.Size = new System.Drawing.Size(806, 385);
            this.splitContainer12.SplitterDistance = 309;
            this.splitContainer12.TabIndex = 0;
            // 
            // zgMonitor
            // 
            this.zgMonitor.AutoSize = true;
            this.zgMonitor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zgMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zgMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgMonitor.IsZoomOnMouseCenter = true;
            this.zgMonitor.Location = new System.Drawing.Point(0, 0);
            this.zgMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.zgMonitor.Name = "zgMonitor";
            this.zgMonitor.ScrollGrace = 0D;
            this.zgMonitor.ScrollMaxX = 0D;
            this.zgMonitor.ScrollMaxY = 0D;
            this.zgMonitor.ScrollMaxY2 = 0D;
            this.zgMonitor.ScrollMinX = 0D;
            this.zgMonitor.ScrollMinY = 0D;
            this.zgMonitor.ScrollMinY2 = 0D;
            this.zgMonitor.Size = new System.Drawing.Size(806, 309);
            this.zgMonitor.TabIndex = 6;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(204, 30);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 14);
            this.label28.TabIndex = 72;
            this.label28.Text = "DBG1";
            // 
            // cb_dbg1
            // 
            this.cb_dbg1.AutoSize = true;
            this.cb_dbg1.Location = new System.Drawing.Point(190, 30);
            this.cb_dbg1.Name = "cb_dbg1";
            this.cb_dbg1.Size = new System.Drawing.Size(15, 14);
            this.cb_dbg1.TabIndex = 71;
            this.cb_dbg1.UseVisualStyleBackColor = true;
            // 
            // l_dbg1
            // 
            this.l_dbg1.AutoSize = true;
            this.l_dbg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_dbg1.ForeColor = System.Drawing.Color.White;
            this.l_dbg1.Location = new System.Drawing.Point(250, 30);
            this.l_dbg1.Name = "l_dbg1";
            this.l_dbg1.Size = new System.Drawing.Size(14, 13);
            this.l_dbg1.TabIndex = 73;
            this.l_dbg1.Text = "0";
            // 
            // cb_dbg2
            // 
            this.cb_dbg2.AutoSize = true;
            this.cb_dbg2.Location = new System.Drawing.Point(301, 29);
            this.cb_dbg2.Name = "cb_dbg2";
            this.cb_dbg2.Size = new System.Drawing.Size(15, 14);
            this.cb_dbg2.TabIndex = 74;
            this.cb_dbg2.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(314, 29);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(44, 14);
            this.label33.TabIndex = 75;
            this.label33.Text = "DBG2";
            // 
            // l_dbg2
            // 
            this.l_dbg2.AutoSize = true;
            this.l_dbg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_dbg2.ForeColor = System.Drawing.Color.White;
            this.l_dbg2.Location = new System.Drawing.Point(362, 30);
            this.l_dbg2.Name = "l_dbg2";
            this.l_dbg2.Size = new System.Drawing.Size(14, 13);
            this.l_dbg2.TabIndex = 76;
            this.l_dbg2.Text = "0";
            // 
            // cb_dbg3
            // 
            this.cb_dbg3.AutoSize = true;
            this.cb_dbg3.Location = new System.Drawing.Point(413, 29);
            this.cb_dbg3.Name = "cb_dbg3";
            this.cb_dbg3.Size = new System.Drawing.Size(15, 14);
            this.cb_dbg3.TabIndex = 77;
            this.cb_dbg3.UseVisualStyleBackColor = true;
            // 
            // l_dbg4
            // 
            this.l_dbg4.AutoSize = true;
            this.l_dbg4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_dbg4.ForeColor = System.Drawing.Color.White;
            this.l_dbg4.Location = new System.Drawing.Point(602, 30);
            this.l_dbg4.Name = "l_dbg4";
            this.l_dbg4.Size = new System.Drawing.Size(14, 13);
            this.l_dbg4.TabIndex = 82;
            this.l_dbg4.Text = "0";
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(426, 29);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(44, 14);
            this.label38.TabIndex = 78;
            this.label38.Text = "DBG3";
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(553, 29);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(44, 14);
            this.label40.TabIndex = 81;
            this.label40.Text = "DBG4";
            // 
            // l_dbg3
            // 
            this.l_dbg3.AutoSize = true;
            this.l_dbg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_dbg3.ForeColor = System.Drawing.Color.White;
            this.l_dbg3.Location = new System.Drawing.Point(474, 30);
            this.l_dbg3.Name = "l_dbg3";
            this.l_dbg3.Size = new System.Drawing.Size(14, 13);
            this.l_dbg3.TabIndex = 79;
            this.l_dbg3.Text = "0";
            // 
            // cb_dbg4
            // 
            this.cb_dbg4.AutoSize = true;
            this.cb_dbg4.Location = new System.Drawing.Point(538, 29);
            this.cb_dbg4.Name = "cb_dbg4";
            this.cb_dbg4.Size = new System.Drawing.Size(15, 14);
            this.cb_dbg4.TabIndex = 80;
            this.cb_dbg4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.b_uncheck_all_ACC);
            this.groupBox1.Controls.Add(this.b_check_all_ACC);
            this.groupBox1.Controls.Add(this.l_acc_z);
            this.groupBox1.Controls.Add(this.l_acc_pitch);
            this.groupBox1.Controls.Add(this.l_acc_roll);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cb_acc_z);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cb_acc_pitch);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cb_acc_roll);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(58, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 68);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accelerometer";
            // 
            // b_uncheck_all_ACC
            // 
            this.b_uncheck_all_ACC.ForeColor = System.Drawing.Color.Black;
            this.b_uncheck_all_ACC.Location = new System.Drawing.Point(94, 44);
            this.b_uncheck_all_ACC.Name = "b_uncheck_all_ACC";
            this.b_uncheck_all_ACC.Size = new System.Drawing.Size(22, 20);
            this.b_uncheck_all_ACC.TabIndex = 105;
            this.b_uncheck_all_ACC.Text = "X";
            this.b_uncheck_all_ACC.UseVisualStyleBackColor = true;
            this.b_uncheck_all_ACC.Click += new System.EventHandler(this.b_uncheck_all_ACC_Click);
            // 
            // b_check_all_ACC
            // 
            this.b_check_all_ACC.ForeColor = System.Drawing.Color.Black;
            this.b_check_all_ACC.Location = new System.Drawing.Point(94, 12);
            this.b_check_all_ACC.Name = "b_check_all_ACC";
            this.b_check_all_ACC.Size = new System.Drawing.Size(22, 20);
            this.b_check_all_ACC.TabIndex = 104;
            this.b_check_all_ACC.Text = "+";
            this.b_check_all_ACC.UseVisualStyleBackColor = true;
            this.b_check_all_ACC.Click += new System.EventHandler(this.b_check_all_ACC_Click);
            // 
            // l_acc_z
            // 
            this.l_acc_z.AutoSize = true;
            this.l_acc_z.Location = new System.Drawing.Point(70, 44);
            this.l_acc_z.Name = "l_acc_z";
            this.l_acc_z.Size = new System.Drawing.Size(13, 13);
            this.l_acc_z.TabIndex = 52;
            this.l_acc_z.Text = "0";
            // 
            // l_acc_pitch
            // 
            this.l_acc_pitch.AutoSize = true;
            this.l_acc_pitch.Location = new System.Drawing.Point(70, 30);
            this.l_acc_pitch.Name = "l_acc_pitch";
            this.l_acc_pitch.Size = new System.Drawing.Size(13, 13);
            this.l_acc_pitch.TabIndex = 51;
            this.l_acc_pitch.Text = "0";
            // 
            // l_acc_roll
            // 
            this.l_acc_roll.AutoSize = true;
            this.l_acc_roll.Location = new System.Drawing.Point(70, 16);
            this.l_acc_roll.Name = "l_acc_roll";
            this.l_acc_roll.Size = new System.Drawing.Size(13, 13);
            this.l_acc_roll.TabIndex = 50;
            this.l_acc_roll.Text = "0";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Blue;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 14);
            this.label18.TabIndex = 49;
            this.label18.Text = "Z";
            // 
            // cb_acc_z
            // 
            this.cb_acc_z.AutoSize = true;
            this.cb_acc_z.Checked = true;
            this.cb_acc_z.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_acc_z.Location = new System.Drawing.Point(10, 43);
            this.cb_acc_z.Name = "cb_acc_z";
            this.cb_acc_z.Size = new System.Drawing.Size(15, 14);
            this.cb_acc_z.TabIndex = 48;
            this.cb_acc_z.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Green;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 14);
            this.label16.TabIndex = 47;
            this.label16.Text = "PITCH";
            // 
            // cb_acc_pitch
            // 
            this.cb_acc_pitch.AutoSize = true;
            this.cb_acc_pitch.Checked = true;
            this.cb_acc_pitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_acc_pitch.Location = new System.Drawing.Point(10, 30);
            this.cb_acc_pitch.Name = "cb_acc_pitch";
            this.cb_acc_pitch.Size = new System.Drawing.Size(15, 14);
            this.cb_acc_pitch.TabIndex = 46;
            this.cb_acc_pitch.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 14);
            this.label14.TabIndex = 45;
            this.label14.Text = "ROLL";
            // 
            // cb_acc_roll
            // 
            this.cb_acc_roll.AutoSize = true;
            this.cb_acc_roll.Checked = true;
            this.cb_acc_roll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_acc_roll.Location = new System.Drawing.Point(10, 16);
            this.cb_acc_roll.Name = "cb_acc_roll";
            this.cb_acc_roll.Size = new System.Drawing.Size(15, 14);
            this.cb_acc_roll.TabIndex = 44;
            this.cb_acc_roll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.b_uncheck_all_GYRO);
            this.groupBox2.Controls.Add(this.b_check_all_GYRO);
            this.groupBox2.Controls.Add(this.l_gyro_yaw);
            this.groupBox2.Controls.Add(this.l_gyro_pitch);
            this.groupBox2.Controls.Add(this.l_gyro_roll);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.cb_gyro_yaw);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.cb_gyro_pitch);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.cb_gyro_roll);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(58, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 68);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gyroscope";
            // 
            // b_uncheck_all_GYRO
            // 
            this.b_uncheck_all_GYRO.ForeColor = System.Drawing.Color.Black;
            this.b_uncheck_all_GYRO.Location = new System.Drawing.Point(94, 44);
            this.b_uncheck_all_GYRO.Name = "b_uncheck_all_GYRO";
            this.b_uncheck_all_GYRO.Size = new System.Drawing.Size(22, 20);
            this.b_uncheck_all_GYRO.TabIndex = 108;
            this.b_uncheck_all_GYRO.Text = "X";
            this.b_uncheck_all_GYRO.UseVisualStyleBackColor = true;
            this.b_uncheck_all_GYRO.Click += new System.EventHandler(this.b_uncheck_all_GYRO_Click);
            // 
            // b_check_all_GYRO
            // 
            this.b_check_all_GYRO.ForeColor = System.Drawing.Color.Black;
            this.b_check_all_GYRO.Location = new System.Drawing.Point(94, 12);
            this.b_check_all_GYRO.Name = "b_check_all_GYRO";
            this.b_check_all_GYRO.Size = new System.Drawing.Size(22, 20);
            this.b_check_all_GYRO.TabIndex = 107;
            this.b_check_all_GYRO.Text = "+";
            this.b_check_all_GYRO.UseVisualStyleBackColor = true;
            this.b_check_all_GYRO.Click += new System.EventHandler(this.b_check_all_GYRO_Click);
            // 
            // l_gyro_yaw
            // 
            this.l_gyro_yaw.AutoSize = true;
            this.l_gyro_yaw.Location = new System.Drawing.Point(70, 44);
            this.l_gyro_yaw.Name = "l_gyro_yaw";
            this.l_gyro_yaw.Size = new System.Drawing.Size(13, 13);
            this.l_gyro_yaw.TabIndex = 52;
            this.l_gyro_yaw.Text = "0";
            // 
            // l_gyro_pitch
            // 
            this.l_gyro_pitch.AutoSize = true;
            this.l_gyro_pitch.Location = new System.Drawing.Point(70, 30);
            this.l_gyro_pitch.Name = "l_gyro_pitch";
            this.l_gyro_pitch.Size = new System.Drawing.Size(13, 13);
            this.l_gyro_pitch.TabIndex = 51;
            this.l_gyro_pitch.Text = "0";
            // 
            // l_gyro_roll
            // 
            this.l_gyro_roll.AutoSize = true;
            this.l_gyro_roll.Location = new System.Drawing.Point(70, 16);
            this.l_gyro_roll.Name = "l_gyro_roll";
            this.l_gyro_roll.Size = new System.Drawing.Size(13, 13);
            this.l_gyro_roll.TabIndex = 50;
            this.l_gyro_roll.Text = "0";
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Magenta;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(23, 43);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 14);
            this.label29.TabIndex = 49;
            this.label29.Text = "YAW";
            // 
            // cb_gyro_yaw
            // 
            this.cb_gyro_yaw.AutoSize = true;
            this.cb_gyro_yaw.Checked = true;
            this.cb_gyro_yaw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gyro_yaw.Location = new System.Drawing.Point(10, 43);
            this.cb_gyro_yaw.Name = "cb_gyro_yaw";
            this.cb_gyro_yaw.Size = new System.Drawing.Size(15, 14);
            this.cb_gyro_yaw.TabIndex = 48;
            this.cb_gyro_yaw.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Cyan;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(23, 30);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(44, 14);
            this.label30.TabIndex = 47;
            this.label30.Text = "PITCH";
            // 
            // cb_gyro_pitch
            // 
            this.cb_gyro_pitch.AutoSize = true;
            this.cb_gyro_pitch.Checked = true;
            this.cb_gyro_pitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gyro_pitch.Location = new System.Drawing.Point(10, 30);
            this.cb_gyro_pitch.Name = "cb_gyro_pitch";
            this.cb_gyro_pitch.Size = new System.Drawing.Size(15, 14);
            this.cb_gyro_pitch.TabIndex = 46;
            this.cb_gyro_pitch.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Khaki;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(23, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 14);
            this.label31.TabIndex = 45;
            this.label31.Text = "ROLL";
            // 
            // cb_gyro_roll
            // 
            this.cb_gyro_roll.AutoSize = true;
            this.cb_gyro_roll.Checked = true;
            this.cb_gyro_roll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gyro_roll.Location = new System.Drawing.Point(10, 16);
            this.cb_gyro_roll.Name = "cb_gyro_roll";
            this.cb_gyro_roll.Size = new System.Drawing.Size(15, 14);
            this.cb_gyro_roll.TabIndex = 44;
            this.cb_gyro_roll.UseVisualStyleBackColor = true;
            // 
            // cb_alt
            // 
            this.cb_alt.AutoSize = true;
            this.cb_alt.Location = new System.Drawing.Point(67, 281);
            this.cb_alt.Name = "cb_alt";
            this.cb_alt.Size = new System.Drawing.Size(15, 14);
            this.cb_alt.TabIndex = 60;
            this.cb_alt.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Gainsboro;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(81, 281);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 14);
            this.label22.TabIndex = 62;
            this.label22.Text = "ALT";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.b_uncheck_all_MAG);
            this.groupBox3.Controls.Add(this.b_check_all_MAG);
            this.groupBox3.Controls.Add(this.l_mag_yaw);
            this.groupBox3.Controls.Add(this.l_mag_pitch);
            this.groupBox3.Controls.Add(this.l_mag_roll);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.cb_mag_yaw);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.cb_mag_pitch);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.cb_mag_roll);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(58, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 68);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Magnetometer";
            // 
            // b_uncheck_all_MAG
            // 
            this.b_uncheck_all_MAG.ForeColor = System.Drawing.Color.Black;
            this.b_uncheck_all_MAG.Location = new System.Drawing.Point(94, 43);
            this.b_uncheck_all_MAG.Name = "b_uncheck_all_MAG";
            this.b_uncheck_all_MAG.Size = new System.Drawing.Size(22, 20);
            this.b_uncheck_all_MAG.TabIndex = 107;
            this.b_uncheck_all_MAG.Text = "X";
            this.b_uncheck_all_MAG.UseVisualStyleBackColor = true;
            this.b_uncheck_all_MAG.Click += new System.EventHandler(this.b_uncheck_all_MAG_Click);
            // 
            // b_check_all_MAG
            // 
            this.b_check_all_MAG.ForeColor = System.Drawing.Color.Black;
            this.b_check_all_MAG.Location = new System.Drawing.Point(94, 12);
            this.b_check_all_MAG.Name = "b_check_all_MAG";
            this.b_check_all_MAG.Size = new System.Drawing.Size(22, 20);
            this.b_check_all_MAG.TabIndex = 106;
            this.b_check_all_MAG.Text = "+";
            this.b_check_all_MAG.UseVisualStyleBackColor = true;
            this.b_check_all_MAG.Click += new System.EventHandler(this.b_check_all_MAG_Click);
            // 
            // l_mag_yaw
            // 
            this.l_mag_yaw.AutoSize = true;
            this.l_mag_yaw.Location = new System.Drawing.Point(70, 44);
            this.l_mag_yaw.Name = "l_mag_yaw";
            this.l_mag_yaw.Size = new System.Drawing.Size(13, 13);
            this.l_mag_yaw.TabIndex = 52;
            this.l_mag_yaw.Text = "0";
            // 
            // l_mag_pitch
            // 
            this.l_mag_pitch.AutoSize = true;
            this.l_mag_pitch.Location = new System.Drawing.Point(70, 30);
            this.l_mag_pitch.Name = "l_mag_pitch";
            this.l_mag_pitch.Size = new System.Drawing.Size(13, 13);
            this.l_mag_pitch.TabIndex = 51;
            this.l_mag_pitch.Text = "0";
            // 
            // l_mag_roll
            // 
            this.l_mag_roll.AutoSize = true;
            this.l_mag_roll.Location = new System.Drawing.Point(70, 16);
            this.l_mag_roll.Name = "l_mag_roll";
            this.l_mag_roll.Size = new System.Drawing.Size(13, 13);
            this.l_mag_roll.TabIndex = 50;
            this.l_mag_roll.Text = "0";
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(23, 43);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 14);
            this.label35.TabIndex = 49;
            this.label35.Text = "YAW";
            // 
            // cb_mag_yaw
            // 
            this.cb_mag_yaw.AutoSize = true;
            this.cb_mag_yaw.Location = new System.Drawing.Point(10, 43);
            this.cb_mag_yaw.Name = "cb_mag_yaw";
            this.cb_mag_yaw.Size = new System.Drawing.Size(15, 14);
            this.cb_mag_yaw.TabIndex = 48;
            this.cb_mag_yaw.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.MediumPurple;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(23, 30);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(44, 14);
            this.label36.TabIndex = 47;
            this.label36.Text = "PITCH";
            // 
            // cb_mag_pitch
            // 
            this.cb_mag_pitch.AutoSize = true;
            this.cb_mag_pitch.Location = new System.Drawing.Point(10, 30);
            this.cb_mag_pitch.Name = "cb_mag_pitch";
            this.cb_mag_pitch.Size = new System.Drawing.Size(15, 14);
            this.cb_mag_pitch.TabIndex = 46;
            this.cb_mag_pitch.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.CadetBlue;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(23, 16);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(44, 14);
            this.label37.TabIndex = 45;
            this.label37.Text = "ROLL";
            // 
            // cb_mag_roll
            // 
            this.cb_mag_roll.AutoSize = true;
            this.cb_mag_roll.Location = new System.Drawing.Point(10, 16);
            this.cb_mag_roll.Name = "cb_mag_roll";
            this.cb_mag_roll.Size = new System.Drawing.Size(15, 14);
            this.cb_mag_roll.TabIndex = 44;
            this.cb_mag_roll.UseVisualStyleBackColor = true;
            // 
            // l_alt
            // 
            this.l_alt.AutoSize = true;
            this.l_alt.ForeColor = System.Drawing.Color.White;
            this.l_alt.Location = new System.Drawing.Point(128, 282);
            this.l_alt.Name = "l_alt";
            this.l_alt.Size = new System.Drawing.Size(13, 13);
            this.l_alt.TabIndex = 64;
            this.l_alt.Text = "0";
            // 
            // cb_head
            // 
            this.cb_head.AutoSize = true;
            this.cb_head.Location = new System.Drawing.Point(67, 298);
            this.cb_head.Name = "cb_head";
            this.cb_head.Size = new System.Drawing.Size(15, 14);
            this.cb_head.TabIndex = 65;
            this.cb_head.UseVisualStyleBackColor = true;
            // 
            // l_head
            // 
            this.l_head.AutoSize = true;
            this.l_head.ForeColor = System.Drawing.Color.White;
            this.l_head.Location = new System.Drawing.Point(128, 298);
            this.l_head.Name = "l_head";
            this.l_head.Size = new System.Drawing.Size(13, 13);
            this.l_head.TabIndex = 67;
            this.l_head.Text = "0";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Orange;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(81, 298);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 14);
            this.label26.TabIndex = 66;
            this.label26.Text = "HEAD";
            // 
            // tabPageVideo
            // 
            this.tabPageVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageVideo.Controls.Add(this.splitContainer6);
            this.tabPageVideo.Controls.Add(this.l_capture_file);
            this.tabPageVideo.Location = new System.Drawing.Point(4, 22);
            this.tabPageVideo.Name = "tabPageVideo";
            this.tabPageVideo.Size = new System.Drawing.Size(1048, 444);
            this.tabPageVideo.TabIndex = 3;
            this.tabPageVideo.Text = "VideoCapture";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.videoSourcePlayer);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.dropdown_devices);
            this.splitContainer6.Panel2.Controls.Add(this.b_video_connect);
            this.splitContainer6.Panel2.Controls.Add(this.label19);
            this.splitContainer6.Panel2.Controls.Add(this.b_Record);
            this.splitContainer6.Panel2.Controls.Add(this.cb_codec);
            this.splitContainer6.Panel2.Controls.Add(this.nFrameRate);
            this.splitContainer6.Panel2.Controls.Add(this.label17);
            this.splitContainer6.Panel2.Controls.Add(this.label12);
            this.splitContainer6.Panel2.Controls.Add(this.label15);
            this.splitContainer6.Panel2.Controls.Add(this.nBitRate);
            this.splitContainer6.Panel2.Controls.Add(this.label13);
            this.splitContainer6.Size = new System.Drawing.Size(1048, 444);
            this.splitContainer6.SplitterDistance = 829;
            this.splitContainer6.TabIndex = 13;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Padding = new System.Windows.Forms.Padding(10);
            this.videoSourcePlayer.Size = new System.Drawing.Size(829, 444);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.SizeChanged += new System.EventHandler(this.videoSourcePlayer_SizeChanged);
            // 
            // dropdown_devices
            // 
            this.dropdown_devices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropdown_devices.BackColor = System.Drawing.Color.Gray;
            this.dropdown_devices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdown_devices.FormattingEnabled = true;
            this.dropdown_devices.Location = new System.Drawing.Point(1, 12);
            this.dropdown_devices.Name = "dropdown_devices";
            this.dropdown_devices.Size = new System.Drawing.Size(202, 21);
            this.dropdown_devices.TabIndex = 1;
            // 
            // b_video_connect
            // 
            this.b_video_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_video_connect.Location = new System.Drawing.Point(1, 39);
            this.b_video_connect.Name = "b_video_connect";
            this.b_video_connect.Size = new System.Drawing.Size(202, 22);
            this.b_video_connect.TabIndex = 2;
            this.b_video_connect.Text = "Connect video device";
            this.b_video_connect.UseVisualStyleBackColor = true;
            this.b_video_connect.Click += new System.EventHandler(this.b_video_connect_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(25, 332);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "CODEC";
            // 
            // b_Record
            // 
            this.b_Record.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Record.Location = new System.Drawing.Point(1, 69);
            this.b_Record.Name = "b_Record";
            this.b_Record.Size = new System.Drawing.Size(202, 22);
            this.b_Record.TabIndex = 3;
            this.b_Record.Text = "Record";
            this.b_Record.UseVisualStyleBackColor = true;
            this.b_Record.Click += new System.EventHandler(this.b_Record_Click);
            // 
            // cb_codec
            // 
            this.cb_codec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_codec.FormattingEnabled = true;
            this.cb_codec.Items.AddRange(new object[] {
            "MPEG4 part2",
            "WMV-7",
            "WMV-8",
            "MS-MPEG4v2",
            "MS-MPEG4v3",
            "H.263+",
            "FLV",
            "MPEG2",
            "RAW"});
            this.cb_codec.Location = new System.Drawing.Point(78, 329);
            this.cb_codec.Name = "cb_codec";
            this.cb_codec.Size = new System.Drawing.Size(110, 21);
            this.cb_codec.TabIndex = 10;
            // 
            // nFrameRate
            // 
            this.nFrameRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nFrameRate.Location = new System.Drawing.Point(78, 381);
            this.nFrameRate.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nFrameRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nFrameRate.Name = "nFrameRate";
            this.nFrameRate.Size = new System.Drawing.Size(52, 20);
            this.nFrameRate.TabIndex = 4;
            this.nFrameRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(137, 358);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Mbit/sec";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(9, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "FrameRate";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(137, 383);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "FPS";
            // 
            // nBitRate
            // 
            this.nBitRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nBitRate.DecimalPlaces = 1;
            this.nBitRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nBitRate.Location = new System.Drawing.Point(78, 355);
            this.nBitRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nBitRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nBitRate.Name = "nBitRate";
            this.nBitRate.Size = new System.Drawing.Size(52, 20);
            this.nBitRate.TabIndex = 6;
            this.nBitRate.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "BitRate";
            // 
            // l_capture_file
            // 
            this.l_capture_file.AutoSize = true;
            this.l_capture_file.ForeColor = System.Drawing.Color.Gainsboro;
            this.l_capture_file.Location = new System.Drawing.Point(1299, 882);
            this.l_capture_file.Name = "l_capture_file";
            this.l_capture_file.Size = new System.Drawing.Size(0, 13);
            this.l_capture_file.TabIndex = 12;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageSettings.Controls.Add(this.groupBox9);
            this.tabPageSettings.Controls.Add(this.cbCellcount);
            this.tabPageSettings.Controls.Add(this.label70);
            this.tabPageSettings.Controls.Add(this.l_i2cdatasupress);
            this.tabPageSettings.Controls.Add(this.b_check_update);
            this.tabPageSettings.Controls.Add(this.b_select_settings_folder);
            this.tabPageSettings.Controls.Add(this.l_Settings_folder);
            this.tabPageSettings.Controls.Add(this.label27);
            this.tabPageSettings.Controls.Add(this.groupBox11);
            this.tabPageSettings.Controls.Add(this.b_save_gui_settings);
            this.tabPageSettings.Controls.Add(this.cb_Logging_enabled);
            this.tabPageSettings.Controls.Add(this.b_select_capture_folder);
            this.tabPageSettings.Controls.Add(this.l_Capture_folder);
            this.tabPageSettings.Controls.Add(this.label24);
            this.tabPageSettings.Controls.Add(this.b_select_log_folder);
            this.tabPageSettings.Controls.Add(this.l_LogFolder);
            this.tabPageSettings.Controls.Add(this.label20);
            this.tabPageSettings.ForeColor = System.Drawing.Color.White;
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(1048, 444);
            this.tabPageSettings.TabIndex = 4;
            this.tabPageSettings.Text = "GUI Settings";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label42);
            this.groupBox9.Controls.Add(this.comboSpeakInterval);
            this.groupBox9.Controls.Add(this.cbSpeakDist);
            this.groupBox9.Controls.Add(this.cbSpeakAlt);
            this.groupBox9.Controls.Add(this.cbSpeakBattery);
            this.groupBox9.Controls.Add(this.cbGUISpeechEnabled);
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(199, 166);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(193, 205);
            this.groupBox9.TabIndex = 39;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Voice";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(74, 148);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(93, 13);
            this.label42.TabIndex = 38;
            this.label42.Text = "Announce interval";
            // 
            // comboSpeakInterval
            // 
            this.comboSpeakInterval.FormattingEnabled = true;
            this.comboSpeakInterval.Items.AddRange(new object[] {
            "10s",
            "15s",
            "30s",
            "60s",
            "90s"});
            this.comboSpeakInterval.Location = new System.Drawing.Point(20, 144);
            this.comboSpeakInterval.Name = "comboSpeakInterval";
            this.comboSpeakInterval.Size = new System.Drawing.Size(46, 21);
            this.comboSpeakInterval.TabIndex = 37;
            this.comboSpeakInterval.SelectedIndexChanged += new System.EventHandler(this.comboSpeakInterval_SelectedIndexChanged);
            // 
            // cbSpeakDist
            // 
            this.cbSpeakDist.AutoSize = true;
            this.cbSpeakDist.Location = new System.Drawing.Point(20, 112);
            this.cbSpeakDist.Name = "cbSpeakDist";
            this.cbSpeakDist.Size = new System.Drawing.Size(147, 17);
            this.cbSpeakDist.TabIndex = 36;
            this.cbSpeakDist.Text = "Announce home distance";
            this.cbSpeakDist.UseVisualStyleBackColor = true;
            this.cbSpeakDist.CheckedChanged += new System.EventHandler(this.cbSpeakDist_CheckedChanged);
            // 
            // cbSpeakAlt
            // 
            this.cbSpeakAlt.AutoSize = true;
            this.cbSpeakAlt.Location = new System.Drawing.Point(20, 89);
            this.cbSpeakAlt.Name = "cbSpeakAlt";
            this.cbSpeakAlt.Size = new System.Drawing.Size(112, 17);
            this.cbSpeakAlt.TabIndex = 35;
            this.cbSpeakAlt.Text = "Announce altitude";
            this.cbSpeakAlt.UseVisualStyleBackColor = true;
            this.cbSpeakAlt.CheckedChanged += new System.EventHandler(this.cbSpeakAlt_CheckedChanged);
            // 
            // cbSpeakBattery
            // 
            this.cbSpeakBattery.AutoSize = true;
            this.cbSpeakBattery.Location = new System.Drawing.Point(20, 65);
            this.cbSpeakBattery.Name = "cbSpeakBattery";
            this.cbSpeakBattery.Size = new System.Drawing.Size(148, 17);
            this.cbSpeakBattery.TabIndex = 34;
            this.cbSpeakBattery.Text = "Announce battery voltage";
            this.cbSpeakBattery.UseVisualStyleBackColor = true;
            this.cbSpeakBattery.CheckedChanged += new System.EventHandler(this.cbSpeakBattery_CheckedChanged);
            // 
            // cbGUISpeechEnabled
            // 
            this.cbGUISpeechEnabled.AutoSize = true;
            this.cbGUISpeechEnabled.Location = new System.Drawing.Point(20, 24);
            this.cbGUISpeechEnabled.Name = "cbGUISpeechEnabled";
            this.cbGUISpeechEnabled.Size = new System.Drawing.Size(156, 17);
            this.cbGUISpeechEnabled.TabIndex = 30;
            this.cbGUISpeechEnabled.Text = "Enable spoken notifications";
            this.cbGUISpeechEnabled.UseVisualStyleBackColor = true;
            this.cbGUISpeechEnabled.Click += new System.EventHandler(this.cbGUISpeechEnabled_CheckedChanged);
            // 
            // cbCellcount
            // 
            this.cbCellcount.FormattingEnabled = true;
            this.cbCellcount.Items.AddRange(new object[] {
            "1s",
            "2s",
            "3s",
            "4s",
            "5s",
            "6s",
            "7s",
            "8s",
            "9s",
            "10s"});
            this.cbCellcount.Location = new System.Drawing.Point(420, 175);
            this.cbCellcount.Name = "cbCellcount";
            this.cbCellcount.Size = new System.Drawing.Size(56, 21);
            this.cbCellcount.TabIndex = 33;
            this.cbCellcount.SelectedIndexChanged += new System.EventHandler(this.cbCellcount_SelectedIndexChanged);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(483, 179);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(91, 13);
            this.label70.TabIndex = 32;
            this.label70.Text = "Battery Cell Count";
            // 
            // l_i2cdatasupress
            // 
            this.l_i2cdatasupress.AutoSize = true;
            this.l_i2cdatasupress.Location = new System.Drawing.Point(164, 50);
            this.l_i2cdatasupress.Name = "l_i2cdatasupress";
            this.l_i2cdatasupress.Size = new System.Drawing.Size(0, 13);
            this.l_i2cdatasupress.TabIndex = 29;
            // 
            // b_check_update
            // 
            this.b_check_update.ForeColor = System.Drawing.Color.Black;
            this.b_check_update.Location = new System.Drawing.Point(886, 414);
            this.b_check_update.Name = "b_check_update";
            this.b_check_update.Size = new System.Drawing.Size(156, 22);
            this.b_check_update.TabIndex = 28;
            this.b_check_update.Text = "Check for Update";
            this.b_check_update.UseVisualStyleBackColor = true;
            this.b_check_update.Click += new System.EventHandler(this.b_check_update_Click);
            // 
            // b_select_settings_folder
            // 
            this.b_select_settings_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_select_settings_folder.ForeColor = System.Drawing.Color.Black;
            this.b_select_settings_folder.Location = new System.Drawing.Point(12, 117);
            this.b_select_settings_folder.Name = "b_select_settings_folder";
            this.b_select_settings_folder.Size = new System.Drawing.Size(38, 26);
            this.b_select_settings_folder.TabIndex = 26;
            this.b_select_settings_folder.Text = "...";
            this.b_select_settings_folder.UseVisualStyleBackColor = true;
            this.b_select_settings_folder.Click += new System.EventHandler(this.b_select_settings_folder_Click);
            // 
            // l_Settings_folder
            // 
            this.l_Settings_folder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_Settings_folder.Location = new System.Drawing.Point(51, 124);
            this.l_Settings_folder.Name = "l_Settings_folder";
            this.l_Settings_folder.Size = new System.Drawing.Size(492, 19);
            this.l_Settings_folder.TabIndex = 25;
            this.l_Settings_folder.Text = "C:\\Hello world\\kisfaszom";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(48, 111);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 13);
            this.label27.TabIndex = 24;
            this.label27.Text = "Settings folder";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cb_Log10);
            this.groupBox11.Controls.Add(this.cb_Log9);
            this.groupBox11.Controls.Add(this.cb_Log8);
            this.groupBox11.Controls.Add(this.cb_Log7);
            this.groupBox11.Controls.Add(this.cb_Log6);
            this.groupBox11.Controls.Add(this.cb_Log5);
            this.groupBox11.Controls.Add(this.cb_Log4);
            this.groupBox11.Controls.Add(this.cb_Log3);
            this.groupBox11.Controls.Add(this.cb_Log2);
            this.groupBox11.Controls.Add(this.cb_Log1);
            this.groupBox11.ForeColor = System.Drawing.Color.White;
            this.groupBox11.Location = new System.Drawing.Point(13, 165);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(173, 240);
            this.groupBox11.TabIndex = 23;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "LOG Datasets";
            // 
            // cb_Log10
            // 
            this.cb_Log10.AutoSize = true;
            this.cb_Log10.Location = new System.Drawing.Point(15, 210);
            this.cb_Log10.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log10.Name = "cb_Log10";
            this.cb_Log10.Size = new System.Drawing.Size(58, 17);
            this.cb_Log10.TabIndex = 22;
            this.cb_Log10.Text = "Debug";
            this.cb_Log10.UseVisualStyleBackColor = true;
            this.cb_Log10.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log9
            // 
            this.cb_Log9.AutoSize = true;
            this.cb_Log9.Location = new System.Drawing.Point(15, 190);
            this.cb_Log9.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log9.Name = "cb_Log9";
            this.cb_Log9.Size = new System.Drawing.Size(140, 17);
            this.cb_Log9.TabIndex = 21;
            this.cb_Log9.Text = "Cycle, I2CErrors, Battery";
            this.cb_Log9.UseVisualStyleBackColor = true;
            this.cb_Log9.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log8
            // 
            this.cb_Log8.AutoSize = true;
            this.cb_Log8.Location = new System.Drawing.Point(15, 170);
            this.cb_Log8.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log8.Name = "cb_Log8";
            this.cb_Log8.Size = new System.Drawing.Size(71, 17);
            this.cb_Log8.TabIndex = 20;
            this.cb_Log8.Text = "GPS Nav";
            this.cb_Log8.UseVisualStyleBackColor = true;
            this.cb_Log8.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log7
            // 
            this.cb_Log7.AutoSize = true;
            this.cb_Log7.Location = new System.Drawing.Point(15, 149);
            this.cb_Log7.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log7.Name = "cb_Log7";
            this.cb_Log7.Size = new System.Drawing.Size(59, 17);
            this.cb_Log7.TabIndex = 19;
            this.cb_Log7.Text = "Servos";
            this.cb_Log7.UseVisualStyleBackColor = true;
            this.cb_Log7.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log6
            // 
            this.cb_Log6.AutoSize = true;
            this.cb_Log6.Location = new System.Drawing.Point(15, 128);
            this.cb_Log6.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log6.Name = "cb_Log6";
            this.cb_Log6.Size = new System.Drawing.Size(58, 17);
            this.cb_Log6.TabIndex = 18;
            this.cb_Log6.Text = "Motors";
            this.cb_Log6.UseVisualStyleBackColor = true;
            this.cb_Log6.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log5
            // 
            this.cb_Log5.AutoSize = true;
            this.cb_Log5.Location = new System.Drawing.Point(15, 107);
            this.cb_Log5.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log5.Name = "cb_Log5";
            this.cb_Log5.Size = new System.Drawing.Size(112, 17);
            this.cb_Log5.TabIndex = 17;
            this.cb_Log5.Text = "RC AUX channels";
            this.cb_Log5.UseVisualStyleBackColor = true;
            this.cb_Log5.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log4
            // 
            this.cb_Log4.AutoSize = true;
            this.cb_Log4.Location = new System.Drawing.Point(15, 86);
            this.cb_Log4.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log4.Name = "cb_Log4";
            this.cb_Log4.Size = new System.Drawing.Size(82, 17);
            this.cb_Log4.TabIndex = 16;
            this.cb_Log4.Text = "RC Controls";
            this.cb_Log4.UseVisualStyleBackColor = true;
            this.cb_Log4.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log3
            // 
            this.cb_Log3.AutoSize = true;
            this.cb_Log3.Location = new System.Drawing.Point(15, 66);
            this.cb_Log3.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log3.Name = "cb_Log3";
            this.cb_Log3.Size = new System.Drawing.Size(119, 17);
            this.cb_Log3.TabIndex = 15;
            this.cb_Log3.Text = "Mag and Barometer";
            this.cb_Log3.UseVisualStyleBackColor = true;
            this.cb_Log3.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log2
            // 
            this.cb_Log2.AutoSize = true;
            this.cb_Log2.Location = new System.Drawing.Point(15, 46);
            this.cb_Log2.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log2.Name = "cb_Log2";
            this.cb_Log2.Size = new System.Drawing.Size(119, 17);
            this.cb_Log2.TabIndex = 14;
            this.cb_Log2.Text = "Attitude (Roll, Pitch)";
            this.cb_Log2.UseVisualStyleBackColor = true;
            this.cb_Log2.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log1
            // 
            this.cb_Log1.AutoSize = true;
            this.cb_Log1.Location = new System.Drawing.Point(15, 25);
            this.cb_Log1.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Log1.Name = "cb_Log1";
            this.cb_Log1.Size = new System.Drawing.Size(114, 17);
            this.cb_Log1.TabIndex = 13;
            this.cb_Log1.Text = "RAW Sensor Data";
            this.cb_Log1.UseVisualStyleBackColor = true;
            this.cb_Log1.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // b_save_gui_settings
            // 
            this.b_save_gui_settings.BackColor = System.Drawing.Color.Transparent;
            this.b_save_gui_settings.ForeColor = System.Drawing.Color.Black;
            this.b_save_gui_settings.Location = new System.Drawing.Point(434, 400);
            this.b_save_gui_settings.Name = "b_save_gui_settings";
            this.b_save_gui_settings.Size = new System.Drawing.Size(111, 37);
            this.b_save_gui_settings.TabIndex = 7;
            this.b_save_gui_settings.Text = "Save Settings";
            this.b_save_gui_settings.UseVisualStyleBackColor = false;
            this.b_save_gui_settings.Click += new System.EventHandler(this.b_save_gui_settings_Click);
            // 
            // cb_Logging_enabled
            // 
            this.cb_Logging_enabled.AutoSize = true;
            this.cb_Logging_enabled.Location = new System.Drawing.Point(13, 419);
            this.cb_Logging_enabled.Name = "cb_Logging_enabled";
            this.cb_Logging_enabled.Size = new System.Drawing.Size(164, 17);
            this.cb_Logging_enabled.TabIndex = 6;
            this.cb_Logging_enabled.Text = "Start data logging at Connect";
            this.cb_Logging_enabled.UseVisualStyleBackColor = true;
            this.cb_Logging_enabled.Click += new System.EventHandler(this.cb_Logging_enabled_Click);
            // 
            // b_select_capture_folder
            // 
            this.b_select_capture_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_select_capture_folder.ForeColor = System.Drawing.Color.Black;
            this.b_select_capture_folder.Location = new System.Drawing.Point(13, 77);
            this.b_select_capture_folder.Name = "b_select_capture_folder";
            this.b_select_capture_folder.Size = new System.Drawing.Size(38, 26);
            this.b_select_capture_folder.TabIndex = 5;
            this.b_select_capture_folder.Text = "...";
            this.b_select_capture_folder.UseVisualStyleBackColor = true;
            this.b_select_capture_folder.Click += new System.EventHandler(this.b_select_capture_folder_Click);
            // 
            // l_Capture_folder
            // 
            this.l_Capture_folder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_Capture_folder.Location = new System.Drawing.Point(52, 84);
            this.l_Capture_folder.Name = "l_Capture_folder";
            this.l_Capture_folder.Size = new System.Drawing.Size(492, 19);
            this.l_Capture_folder.TabIndex = 4;
            this.l_Capture_folder.Text = "C:\\Hello world\\kisfaszom";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(49, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Video capture folder";
            // 
            // b_select_log_folder
            // 
            this.b_select_log_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_select_log_folder.ForeColor = System.Drawing.Color.Black;
            this.b_select_log_folder.Location = new System.Drawing.Point(12, 34);
            this.b_select_log_folder.Name = "b_select_log_folder";
            this.b_select_log_folder.Size = new System.Drawing.Size(38, 26);
            this.b_select_log_folder.TabIndex = 2;
            this.b_select_log_folder.Text = "...";
            this.b_select_log_folder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_select_log_folder.UseVisualStyleBackColor = true;
            this.b_select_log_folder.Click += new System.EventHandler(this.b_select_log_folder_Click);
            // 
            // l_LogFolder
            // 
            this.l_LogFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_LogFolder.Location = new System.Drawing.Point(51, 42);
            this.l_LogFolder.Name = "l_LogFolder";
            this.l_LogFolder.Size = new System.Drawing.Size(492, 19);
            this.l_LogFolder.TabIndex = 1;
            this.l_LogFolder.Text = "C:\\Hello world\\kisfaszom";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(48, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Data logging folder";
            // 
            // tabPageCLI
            // 
            this.tabPageCLI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageCLI.Controls.Add(this.gbTerminal);
            this.tabPageCLI.Location = new System.Drawing.Point(4, 22);
            this.tabPageCLI.Name = "tabPageCLI";
            this.tabPageCLI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCLI.Size = new System.Drawing.Size(1048, 444);
            this.tabPageCLI.TabIndex = 6;
            this.tabPageCLI.Text = "CLI";
            // 
            // gbTerminal
            // 
            this.gbTerminal.Controls.Add(this.cmdCLISend);
            this.gbTerminal.Controls.Add(this.txtCLICommand);
            this.gbTerminal.Controls.Add(this.txtCLIResult);
            this.gbTerminal.Location = new System.Drawing.Point(9, 6);
            this.gbTerminal.Name = "gbTerminal";
            this.gbTerminal.Size = new System.Drawing.Size(1030, 431);
            this.gbTerminal.TabIndex = 1;
            this.gbTerminal.TabStop = false;
            this.gbTerminal.Text = "Terminal";
            // 
            // cmdCLISend
            // 
            this.cmdCLISend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCLISend.Location = new System.Drawing.Point(944, 404);
            this.cmdCLISend.Name = "cmdCLISend";
            this.cmdCLISend.Size = new System.Drawing.Size(80, 22);
            this.cmdCLISend.TabIndex = 1;
            this.cmdCLISend.Text = "Send";
            this.cmdCLISend.UseVisualStyleBackColor = true;
            this.cmdCLISend.Click += new System.EventHandler(this.cmdCLISend_Click);
            // 
            // txtCLICommand
            // 
            this.txtCLICommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCLICommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCLICommand.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCLICommand.Location = new System.Drawing.Point(6, 404);
            this.txtCLICommand.Name = "txtCLICommand";
            this.txtCLICommand.Size = new System.Drawing.Size(931, 20);
            this.txtCLICommand.TabIndex = 0;
            // 
            // txtCLIResult
            // 
            this.txtCLIResult.AllowDrop = true;
            this.txtCLIResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCLIResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCLIResult.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCLIResult.Location = new System.Drawing.Point(6, 18);
            this.txtCLIResult.Multiline = true;
            this.txtCLIResult.Name = "txtCLIResult";
            this.txtCLIResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCLIResult.Size = new System.Drawing.Size(1018, 379);
            this.txtCLIResult.TabIndex = 0;
            // 
            // timer_realtime
            // 
            this.timer_realtime.Tick += new System.EventHandler(this.timer_realtime_Tick);
            // 
            // bkgWorker
            // 
            this.bkgWorker.WorkerSupportsCancellation = true;
            this.bkgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorker_DoWork);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cb_serial_port,
            this.toolStripLabel2,
            this.cb_serial_speed,
            this.b_connect,
            this.toolStripSeparator1,
            this.b_read_settings,
            this.b_write_settings,
            this.b_reset,
            this.toolStripSeparator2,
            this.b_load_from_file,
            this.b_write_to_file,
            this.toolStripSeparator3,
            this.b_log,
            this.b_start_KML_log,
            this.b_log_browser,
            this.toolStripSeparator4,
            this.b_about,
            this.bDebugWindws});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1056, 54);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 51);
            this.toolStripLabel1.Text = "Port";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // cb_serial_port
            // 
            this.cb_serial_port.Name = "cb_serial_port";
            this.cb_serial_port.Size = new System.Drawing.Size(80, 54);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 51);
            this.toolStripLabel2.Text = "Speed";
            // 
            // cb_serial_speed
            // 
            this.cb_serial_speed.Name = "cb_serial_speed";
            this.cb_serial_speed.Size = new System.Drawing.Size(80, 54);
            // 
            // b_connect
            // 
            this.b_connect.Image = global::MultiWiiWinGUI.Properties.Resources.connect;
            this.b_connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_connect.Name = "b_connect";
            this.b_connect.Size = new System.Drawing.Size(56, 51);
            this.b_connect.Text = "Connect";
            this.b_connect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // b_read_settings
            // 
            this.b_read_settings.Image = global::MultiWiiWinGUI.Properties.Resources.read_settings;
            this.b_read_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_read_settings.Name = "b_read_settings";
            this.b_read_settings.Size = new System.Drawing.Size(82, 51);
            this.b_read_settings.Text = "Read Settings";
            this.b_read_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_read_settings.Click += new System.EventHandler(this.b_read_settings_Click);
            // 
            // b_write_settings
            // 
            this.b_write_settings.Image = global::MultiWiiWinGUI.Properties.Resources.write_settings;
            this.b_write_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_write_settings.Name = "b_write_settings";
            this.b_write_settings.Size = new System.Drawing.Size(84, 51);
            this.b_write_settings.Text = "Write Settings";
            this.b_write_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_write_settings.Click += new System.EventHandler(this.b_write_settings_Click);
            // 
            // b_reset
            // 
            this.b_reset.Image = global::MultiWiiWinGUI.Properties.Resources.reset;
            this.b_reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(83, 51);
            this.b_reset.Text = "Load Defaults";
            this.b_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // b_load_from_file
            // 
            this.b_load_from_file.Image = global::MultiWiiWinGUI.Properties.Resources.load_from_file;
            this.b_load_from_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_load_from_file.Name = "b_load_from_file";
            this.b_load_from_file.Size = new System.Drawing.Size(87, 51);
            this.b_load_from_file.Text = "Load from File";
            this.b_load_from_file.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_load_from_file.Click += new System.EventHandler(this.b_load_from_file_Click);
            // 
            // b_write_to_file
            // 
            this.b_write_to_file.Image = global::MultiWiiWinGUI.Properties.Resources.write_to_file;
            this.b_write_to_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_write_to_file.Name = "b_write_to_file";
            this.b_write_to_file.Size = new System.Drawing.Size(70, 51);
            this.b_write_to_file.Text = "Save to File";
            this.b_write_to_file.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_write_to_file.Click += new System.EventHandler(this.b_write_to_file_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // b_log
            // 
            this.b_log.Image = global::MultiWiiWinGUI.Properties.Resources.start_log;
            this.b_log.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_log.Name = "b_log";
            this.b_log.Size = new System.Drawing.Size(58, 51);
            this.b_log.Text = "Start Log";
            this.b_log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_log.Click += new System.EventHandler(this.b_log_Click);
            // 
            // b_start_KML_log
            // 
            this.b_start_KML_log.BackColor = System.Drawing.Color.Transparent;
            this.b_start_KML_log.Image = global::MultiWiiWinGUI.Properties.Resources.earth_3;
            this.b_start_KML_log.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_start_KML_log.Name = "b_start_KML_log";
            this.b_start_KML_log.Size = new System.Drawing.Size(79, 51);
            this.b_start_KML_log.Text = "Start GPS log";
            this.b_start_KML_log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_start_KML_log.Click += new System.EventHandler(this.b_start_KML_log_Click);
            // 
            // b_log_browser
            // 
            this.b_log_browser.Image = global::MultiWiiWinGUI.Properties.Resources.logbrowser;
            this.b_log_browser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_log_browser.Name = "b_log_browser";
            this.b_log_browser.Size = new System.Drawing.Size(76, 51);
            this.b_log_browser.Text = "Log Browser";
            this.b_log_browser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_log_browser.Click += new System.EventHandler(this.b_log_browser_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 54);
            // 
            // b_about
            // 
            this.b_about.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.b_about.Image = global::MultiWiiWinGUI.Properties.Resources.about;
            this.b_about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_about.Name = "b_about";
            this.b_about.Size = new System.Drawing.Size(44, 51);
            this.b_about.Text = "About";
            this.b_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_about.Click += new System.EventHandler(this.b_about_Click);
            // 
            // bDebugWindws
            // 
            this.bDebugWindws.Image = ((System.Drawing.Image)(resources.GetObject("bDebugWindws.Image")));
            this.bDebugWindws.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bDebugWindws.Name = "bDebugWindws";
            this.bDebugWindws.Size = new System.Drawing.Size(46, 51);
            this.bDebugWindws.Text = "Debug";
            this.bDebugWindws.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bDebugWindws.ToolTipText = "Debug Window";
            this.bDebugWindws.Click += new System.EventHandler(this.bDebugWindws_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::MultiWiiWinGUI.Properties.Resources.up_btn;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 16;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::MultiWiiWinGUI.Properties.Resources.down_btn;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 16;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::MultiWiiWinGUI.Properties.Resources.del_btn;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 16;
            // 
            // timer_announce
            // 
            this.timer_announce.Enabled = true;
            this.timer_announce.Interval = 30000;
            this.timer_announce.Tick += new System.EventHandler(this.timer_announce_Tick);
            // 
            // mainGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1056, 524);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1071, 561);
            this.Name = "mainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainGUI_FormClosing);
            this.Load += new System.EventHandler(this.mainGUI_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPageFlightDeck.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabPageMisson.ResumeLayout(false);
            this.contextMenuStripMap.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.spcontMapMain.Panel1.ResumeLayout(false);
            this.spcontMapMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcontMapMain)).EndInit();
            this.spcontMapMain.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel1.PerformLayout();
            this.splitContainer9.Panel2.ResumeLayout(false);
            this.splitContainer9.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            this.splitContainer8.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.missionDataGrid)).EndInit();
            this.tabPagePID.ResumeLayout(false);
            this.tabPagePID.PerformLayout();
            this.naviGroup.ResumeLayout(false);
            this.naviGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLandSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCrosstrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRTHAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWPRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSafeWPDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTEXPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTMID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_T_EXPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_T_MID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_RC_Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_RC_Expo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRCRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRCExpo)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_tpid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_yaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_rp)).EndInit();
            this.tabPageConf.ResumeLayout(false);
            this.tabPageConf.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFSThr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinThr)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatCritical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatWarn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatWarn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatScale)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMagDeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMagMin)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate8)).EndInit();
            this.tabPageRC.ResumeLayout(false);
            this.tabPageRC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabSensorGraph.ResumeLayout(false);
            this.splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
            this.splitContainer10.ResumeLayout(false);
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            this.splitContainer11.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            this.splitContainer12.Panel1.ResumeLayout(false);
            this.splitContainer12.Panel1.PerformLayout();
            this.splitContainer12.Panel2.ResumeLayout(false);
            this.splitContainer12.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).EndInit();
            this.splitContainer12.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageVideo.ResumeLayout(false);
            this.tabPageVideo.PerformLayout();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nFrameRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBitRate)).EndInit();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPageCLI.ResumeLayout(false);
            this.gbTerminal.ResumeLayout(false);
            this.gbTerminal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageRC;
        private System.Windows.Forms.TabPage tabPagePID;
        private System.Windows.Forms.TabPage tabPageFlightDeck;
        private System.Windows.Forms.Timer timer_realtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_monitor_rate;
        private MultiWiiGUIControls.artifical_horizon attitudeIndicatorInstrumentControl1;
        private MultiWiiGUIControls.heading_indicator headingIndicatorInstrumentControl1;
        private MultiWiiGUIControls.GpsIndicatorInstrumentControl gpsIndicator;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label_sok;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown nRATE_tpid;
        private System.Windows.Forms.NumericUpDown nRATE_yaw;
        private System.Windows.Forms.NumericUpDown nRATE_rp;
        private MultiWiiGUIControls.MWGUIMotors motorsIndicator1;
        private System.Windows.Forms.TabPage tabPageVideo;
        private MultiWiiGUIControls.rc_input_control rc_input_control1;
        private System.Windows.Forms.Button b_pause;
        private MultiWiiGUIControls.rc_input_control rci_Control_settings;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TrackBar trackbar_RC_Rate;
        private System.Windows.Forms.TrackBar trackbar_RC_Expo;
        private MultiWiiGUIControls.rc_expo_control rc_expo_control1;
        private System.ComponentModel.BackgroundWorker bkgWorker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nRCExpo;
        private System.Windows.Forms.NumericUpDown nRCRate;
        private System.Windows.Forms.Button b_cal_acc;
        private System.Windows.Forms.Button b_cal_mag;
        private MultiWiiGUIControls.indicator_lamp indGPS;
        private MultiWiiGUIControls.indicator_lamp indSONAR;
        private MultiWiiGUIControls.indicator_lamp indMAG;
        private MultiWiiGUIControls.indicator_lamp indBARO;
        private MultiWiiGUIControls.indicator_lamp indACC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l_cycletime;
        private System.Windows.Forms.Label l_vbatt;
        private System.Windows.Forms.Label l_powersum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_video_connect;
        private System.Windows.Forms.ComboBox dropdown_devices;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Button b_Record;
        private System.Windows.Forms.ComboBox cb_codec;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nBitRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nFrameRate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Button b_select_log_folder;
        private System.Windows.Forms.Label l_LogFolder;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button b_select_capture_folder;
        private System.Windows.Forms.Label l_Capture_folder;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button b_save_gui_settings;
        private System.Windows.Forms.CheckBox cb_Logging_enabled;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label l_capture_file;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox cb_Log10;
        private System.Windows.Forms.CheckBox cb_Log9;
        private System.Windows.Forms.CheckBox cb_Log8;
        private System.Windows.Forms.CheckBox cb_Log7;
        private System.Windows.Forms.CheckBox cb_Log6;
        private System.Windows.Forms.CheckBox cb_Log5;
        private System.Windows.Forms.CheckBox cb_Log4;
        private System.Windows.Forms.CheckBox cb_Log3;
        private System.Windows.Forms.CheckBox cb_Log2;
        private System.Windows.Forms.CheckBox cb_Log1;
        private System.Windows.Forms.Label l_i2cerrors;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button b_select_settings_folder;
        private System.Windows.Forms.Label l_Settings_folder;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button b_check_update;
        private System.Windows.Forms.Label l_i2cdatasupress;
        private System.Windows.Forms.TrackBar trackBar_T_EXPO;
        private System.Windows.Forms.TrackBar trackBar_T_MID;
        private MultiWiiGUIControls.throttle_expo_control throttle_expo_control1;
        private System.Windows.Forms.NumericUpDown nTEXPO;
        private System.Windows.Forms.NumericUpDown nTMID;
        private System.Windows.Forms.TabPage tabPageMisson;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cb_serial_port;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cb_serial_speed;
        private System.Windows.Forms.ToolStripButton b_connect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton b_read_settings;
        private System.Windows.Forms.ToolStripButton b_write_settings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton b_load_from_file;
        private System.Windows.Forms.ToolStripButton b_write_to_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton b_log;
        private System.Windows.Forms.ToolStripButton b_log_browser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton b_about;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MultiWiiGUIControls.indicator_lamp indOPTIC;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lGPS_lat;
        private System.Windows.Forms.Label lGPS_lon;
        private System.Windows.Forms.ToolStripButton b_start_KML_log;
        private System.Windows.Forms.Label l_GPS_numsat;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label l_GPS_alt;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button b_Clear_Route;
        private System.Windows.Forms.Label labelCRCErrors;
        private System.Windows.Forms.Label labelReceivedPackets;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer spcontMapMain;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbMapProviders;
        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.Label LMousePos;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ToolStripButton b_reset;
        private System.Windows.Forms.TabPage tabPageCLI;
        private System.Windows.Forms.GroupBox gbTerminal;
        private System.Windows.Forms.Button cmdCLISend;
        private System.Windows.Forms.TextBox txtCLICommand;
        private System.Windows.Forms.TextBox txtCLIResult;
        private System.Windows.Forms.DataGridView missionDataGrid;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Label lDistance;
        private System.Windows.Forms.CheckBox cbShowMission;
        private System.Windows.Forms.CheckBox cbShowWP;
        private System.Windows.Forms.CheckBox cbShowFlightPath;
        private System.Windows.Forms.CheckBox cbShowPos;
        private System.Windows.Forms.Button bClickToGo;
        private System.Windows.Forms.Label lDefAlt;
        private System.Windows.Forms.TextBox txtDefAlt;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.Button btnLoadMission;
        private System.Windows.Forms.Button btnSaveMission;
        private System.Windows.Forms.Button btnDownLoadMission;
        private System.Windows.Forms.Button btnUploadMission;
        private System.Windows.Forms.TextBox txtGTCAlt;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label lDistLastWP;
        private System.Windows.Forms.CheckBox cbSendGTCAlt;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ToolStripButton bDebugWindws;
        private System.Windows.Forms.TabPage tabPageConf;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown nMagMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nMagDeg;
        private System.Windows.Forms.ComboBox cbMagSign;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nSrvRate4;
        private System.Windows.Forms.Label label56;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev1;
        private System.Windows.Forms.Label label55;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev2;
        private System.Windows.Forms.Label label54;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev3;
        private System.Windows.Forms.Label label53;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev4;
        private System.Windows.Forms.Label label52;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev5;
        private System.Windows.Forms.Label label51;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev6;
        private System.Windows.Forms.NumericUpDown nSrvMax8;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev7;
        private System.Windows.Forms.NumericUpDown nSrvMax7;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev8;
        private System.Windows.Forms.NumericUpDown nSrvMax6;
        private System.Windows.Forms.Label lSrvID1;
        private System.Windows.Forms.NumericUpDown nSrvMax5;
        private System.Windows.Forms.Label lSrvID2;
        private System.Windows.Forms.NumericUpDown nSrvMax4;
        private System.Windows.Forms.Label lSrvID3;
        private System.Windows.Forms.NumericUpDown nSrvMax3;
        private System.Windows.Forms.Label lSrvID4;
        private System.Windows.Forms.NumericUpDown nSrvMax2;
        private System.Windows.Forms.Label lSrvID5;
        private System.Windows.Forms.NumericUpDown nSrvMax1;
        private System.Windows.Forms.Label lSrvID6;
        private System.Windows.Forms.NumericUpDown nSrvMid8;
        private System.Windows.Forms.Label lSrvID7;
        private System.Windows.Forms.NumericUpDown nSrvMid7;
        private System.Windows.Forms.Label lSrvID8;
        private System.Windows.Forms.NumericUpDown nSrvMid6;
        private System.Windows.Forms.Label lSrvName1;
        private System.Windows.Forms.NumericUpDown nSrvMid5;
        private System.Windows.Forms.Label lSrvName3;
        private System.Windows.Forms.NumericUpDown nSrvMid4;
        private System.Windows.Forms.Label lSrvName2;
        private System.Windows.Forms.NumericUpDown nSrvMid3;
        private System.Windows.Forms.Label lSrvName4;
        private System.Windows.Forms.NumericUpDown nSrvMid2;
        private System.Windows.Forms.Label lSrvName5;
        private System.Windows.Forms.NumericUpDown nSrvMid1;
        private System.Windows.Forms.Label lSrvName6;
        private System.Windows.Forms.NumericUpDown nSrvMin8;
        private System.Windows.Forms.Label lSrvName7;
        private System.Windows.Forms.NumericUpDown nSrvMin7;
        private System.Windows.Forms.Label lSrvName8;
        private System.Windows.Forms.NumericUpDown nSrvMin6;
        private System.Windows.Forms.NumericUpDown nSrvRate1;
        private System.Windows.Forms.NumericUpDown nSrvMin5;
        private System.Windows.Forms.NumericUpDown nSrvRate2;
        private System.Windows.Forms.NumericUpDown nSrvMin4;
        private System.Windows.Forms.NumericUpDown nSrvRate3;
        private System.Windows.Forms.NumericUpDown nSrvMin3;
        private System.Windows.Forms.NumericUpDown nSrvRate5;
        private System.Windows.Forms.NumericUpDown nSrvMin2;
        private System.Windows.Forms.NumericUpDown nSrvRate6;
        private System.Windows.Forms.NumericUpDown nSrvMin1;
        private System.Windows.Forms.NumericUpDown nSrvRate7;
        private System.Windows.Forms.NumericUpDown nSrvRate8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nPAlarm;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nVBatCritical;
        private System.Windows.Forms.NumericUpDown nVBatWarn2;
        private System.Windows.Forms.NumericUpDown nVBatWarn1;
        private System.Windows.Forms.NumericUpDown nVBatScale;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lMaxThr;
        private System.Windows.Forms.NumericUpDown nFSThr;
        private System.Windows.Forms.NumericUpDown nMinThr;
        private System.Windows.Forms.Label lMinCommand;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lLife;
        private System.Windows.Forms.Label lArms;
        private System.Windows.Forms.Button bBind;
        private System.Windows.Forms.TabPage tabSensorGraph;
        private System.Windows.Forms.SplitContainer splitContainer10;
        private System.Windows.Forms.SplitContainer splitContainer11;
        private System.Windows.Forms.SplitContainer splitContainer12;
        private ZedGraph.ZedGraphControl zgMonitor;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox cb_dbg1;
        private System.Windows.Forms.Label l_dbg1;
        private System.Windows.Forms.CheckBox cb_dbg2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label l_dbg2;
        private System.Windows.Forms.CheckBox cb_dbg3;
        private System.Windows.Forms.Label l_dbg4;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label l_dbg3;
        private System.Windows.Forms.CheckBox cb_dbg4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_uncheck_all_ACC;
        private System.Windows.Forms.Button b_check_all_ACC;
        private System.Windows.Forms.Label l_acc_z;
        private System.Windows.Forms.Label l_acc_pitch;
        private System.Windows.Forms.Label l_acc_roll;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cb_acc_z;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cb_acc_pitch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cb_acc_roll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_uncheck_all_GYRO;
        private System.Windows.Forms.Button b_check_all_GYRO;
        private System.Windows.Forms.Label l_gyro_yaw;
        private System.Windows.Forms.Label l_gyro_pitch;
        private System.Windows.Forms.Label l_gyro_roll;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cb_gyro_yaw;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox cb_gyro_pitch;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox cb_gyro_roll;
        private System.Windows.Forms.CheckBox cb_alt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_uncheck_all_MAG;
        private System.Windows.Forms.Button b_check_all_MAG;
        private System.Windows.Forms.Label l_mag_yaw;
        private System.Windows.Forms.Label l_mag_pitch;
        private System.Windows.Forms.Label l_mag_roll;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox cb_mag_yaw;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox cb_mag_pitch;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.CheckBox cb_mag_roll;
        private System.Windows.Forms.Label l_alt;
        private System.Windows.Forms.CheckBox cb_head;
        private System.Windows.Forms.Label l_head;
        private System.Windows.Forms.Label label26;
        private MultiWiiGUIControls.altitude_meter altitude_meter1;
        private MultiWiiGUIControls.vertical_speed_indicator vertical_speed_indicator1;
        private System.Windows.Forms.Label labelSentPackets;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label lNavState;
        private System.Windows.Forms.Label lGpsMode;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label lNavError;
        private System.Windows.Forms.Label labelNoise;
        private System.Windows.Forms.Label labelRSSI;
        private MultiWiiGUIControls.ColorProgressBar barRSSI;
        private MultiWiiGUIControls.ColorProgressBar barNoise;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label81;
        private MultiWiiGUIControls.GpsIndicatorInstrumentControl gpsIndicator2;
        private MultiWiiGUIControls.altitude_meter altitude_meter2;
        private MultiWiiGUIControls.vertical_speed_indicator vertical_speed_indicator2;
        private MultiWiiGUIControls.CheckBoxEx cbShowGauges;
        private MultiWiiGUIControls.CheckBoxEx cbAutoPan;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddWP;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddPosholdTimed;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddPosholdUnlim;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddRTH;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddJump;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddPOI;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSetHead;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem clearMissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulkAltitudeChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuDeleteWP;
        private System.Windows.Forms.Label label75;
        private MultiWiiGUIControls.CheckBoxEx cbNavSlowNav;
        private MultiWiiGUIControls.CheckBoxEx cbNavWaitRTHAlt;
        private MultiWiiGUIControls.CheckBoxEx cbNavRTHHead;
        private MultiWiiGUIControls.CheckBoxEx cbNavTailFirst;
        private MultiWiiGUIControls.CheckBoxEx cbNavHeadingControl;
        private MultiWiiGUIControls.CheckBoxEx cbNavResetHome;
        private MultiWiiGUIControls.CheckBoxEx cbNavGPS_Lead;
        private MultiWiiGUIControls.CheckBoxEx cbNavGPS_filtering;
        private System.Windows.Forms.NumericUpDown nWPRadius;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.NumericUpDown nBanking;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.NumericUpDown nCrosstrack;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.NumericUpDown nRTHAlt;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.NumericUpDown nMinSpeed;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.NumericUpDown nMaxSpeed;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.NumericUpDown nMaxAlt;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.NumericUpDown nSafeWPDist;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.CheckBox cbGUISpeechEnabled;
        private MultiWiiGUIControls.ColorProgressBar barRSSIMission;
        private System.Windows.Forms.GroupBox naviGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem fetchMapTilesToolStripMenuItem;
        private System.Windows.Forms.Label label70;
        private MultiWiiGUIControls.CheckBoxEx cbNavDisableSticks;
        private MultiWiiGUIControls.CheckBoxEx cbNavBaroTakeover;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.NumericUpDown nFence;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddLand;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewComboBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Par1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Par2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Par3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LATCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LONCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALTCOL;
        private System.Windows.Forms.DataGridViewImageColumn UP;
        private System.Windows.Forms.DataGridViewImageColumn Down;
        private System.Windows.Forms.DataGridViewImageColumn DEL;
        private MultiWiiGUIControls.battery_indicator battery_indicator1;
        private System.Windows.Forms.ComboBox cbCellcount;
        private MultiWiiGUIControls.battery_indicator battery_indicator2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown nLandSpeed;
        private System.Windows.Forms.Button btnMapZoopDown;
        private System.Windows.Forms.Button btnMapZoomUp;
        private System.Windows.Forms.Label lVBatConf;
        private System.Windows.Forms.Label labelvbat;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox comboSpeakInterval;
        private System.Windows.Forms.CheckBox cbSpeakDist;
        private System.Windows.Forms.CheckBox cbSpeakAlt;
        private System.Windows.Forms.CheckBox cbSpeakBattery;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Timer timer_announce;
    }
}

