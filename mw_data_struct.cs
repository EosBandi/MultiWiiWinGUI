using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MultiWiiWinGUI
{

    #region GUI_settings

    
    public class GUI_settings
    {
        public string sLogFolder { get; set; }
        public string sCaptureFolder { get; set; }
        public string sSettingsFolder { get; set; }
        public int iSoftwareVersion { get; set; }
        public bool bEnableLogging { get; set; }
        public string sPreferedComPort { get; set; }
        public string sPreferedSerialSpeed { get; set; }
        //Log fields
        public bool logGraw { get; set; }
        public bool logGatt { get; set; }
        public bool logGmag { get; set; }
        public bool logGrcc { get; set; }
        public bool logGrcx { get; set; }
        public bool logGmot { get; set; }
        public bool logGsrv { get; set; }
        public bool logGnav { get; set; }
        public bool logGpar { get; set; }
        public bool logGdbg { get; set; }

        public int iMapProviderSelectedIndex { get; set; }

        public byte max_wp_number { get; set; }
        public ushort wp_radius { get; set; }

        public bool speech_enabled { get; set; }
        public bool announce_alt_enabled { get; set; }
        public bool announce_vbat_enabled { get; set; }
        public bool announce_dist_enabled { get; set; }
        public int announce_interval { get; set; }

        

        public byte cellcount { get; set; }



        //Constructor, set default values
        public GUI_settings()
        {
            sLogFolder = Directory.GetCurrentDirectory();
            sCaptureFolder = Directory.GetCurrentDirectory();
            sSettingsFolder = Directory.GetCurrentDirectory();
            iSoftwareVersion = 23;
            bEnableLogging = false;
            iMapProviderSelectedIndex = 1;  //Bing Map
            speech_enabled = true;
            announce_alt_enabled = false;
            announce_dist_enabled = false;
            announce_vbat_enabled = false;
            announce_interval = 2;

            cellcount = 3;



        }


        public void save_to_xml(string filename)
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
            tw.WriteComment("GUI Settings");
            tw.WriteComment("Do not change this file manually, unless you know what are you doing");

            tw.WriteStartElement("PARAMETERS");

            tw.WriteStartElement("FCVERSION value=\"" + iSoftwareVersion + "\""); tw.WriteEndElement();
            tw.WriteStartElement("LOGFOLDER value=\"" + sLogFolder + "\""); tw.WriteEndElement();
            tw.WriteStartElement("CAPTUREFOLDER value=\"" + sCaptureFolder + "\""); tw.WriteEndElement();
            tw.WriteStartElement("SETTINGSFOLDER value=\"" + sSettingsFolder + "\""); tw.WriteEndElement();
            tw.WriteStartElement("LOGATCONNECT value=\"" + bEnableLogging + "\""); tw.WriteEndElement();
            tw.WriteStartElement("SERIALPORT value=\"" + sPreferedComPort + "\""); tw.WriteEndElement();
            tw.WriteStartElement("SERIALSPEED value=\"" + sPreferedSerialSpeed + "\""); tw.WriteEndElement();

            tw.WriteStartElement("LOGRAW value=\"" + logGraw + "\""); tw.WriteEndElement();
            tw.WriteStartElement("LOGATT value=\"" + logGatt + "\""); tw.WriteEndElement();
            tw.WriteStartElement("LOGMAG value=\"" + logGmag + "\""); tw.WriteEndElement();
            tw.WriteStartElement("LOGRCC value=\"" + logGrcc + "\""); tw.WriteEndElement();
            tw.WriteStartElement("LOGRCX value=\"" + logGrcx + "\""); tw.WriteEndElement();
            tw.WriteStartElement("LOGMOT value=\"" + logGmot + "\""); tw.WriteEndElement();
            tw.WriteStartElement("LOGSRV value=\"" + logGsrv + "\""); tw.WriteEndElement();
            tw.WriteStartElement("LOGNAV value=\"" + logGnav + "\""); tw.WriteEndElement();
            tw.WriteStartElement("LOGPAR value=\"" + logGpar + "\""); tw.WriteEndElement();
            tw.WriteStartElement("LOGDBG value=\"" + logGdbg + "\""); tw.WriteEndElement();

            tw.WriteStartElement("MAPPROVIDER value=\"" + iMapProviderSelectedIndex + "\""); tw.WriteEndElement();
            tw.WriteStartElement("SPEECH_ENABLED value=\"" + speech_enabled + "\""); tw.WriteEndElement();
            tw.WriteStartElement("ANNOUNCE_ALT value=\"" + announce_alt_enabled + "\""); tw.WriteEndElement();
            tw.WriteStartElement("ANNOUNCE_VBAT value=\"" + announce_vbat_enabled + "\""); tw.WriteEndElement();
            tw.WriteStartElement("ANNOUNCE_DIST value=\"" + announce_dist_enabled + "\""); tw.WriteEndElement();
            tw.WriteStartElement("ANNOUNCE_INTERVAL value=\"" + announce_interval + "\""); tw.WriteEndElement();

            
            tw.WriteStartElement("CELLCOUNT value=\"" + cellcount + "\""); tw.WriteEndElement();
            
            tw.WriteStartElement("MAX_WP_NUMBER value=\"" + max_wp_number + "\""); tw.WriteEndElement();
            tw.WriteStartElement("WP_RADIUS value=\"" +  wp_radius + "\""); tw.WriteEndElement();


            tw.WriteEndElement();

            tw.WriteEndDocument();
            tw.Close();
        }


        public bool read_from_xml(string filename)
        {
            XmlTextReader reader;

            if (!File.Exists(filename))
            {
                MessageBoxEx.Show("Error opening config file :" + filename + "\r\nUnable to continue!!", "Config File not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return (false);
            }
            reader = new XmlTextReader(filename);
            try
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:

                            if (String.Compare(reader.Name, "fcversion", true) == 0 && reader.HasAttributes) { iSoftwareVersion = Convert.ToInt16(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "logfolder", true) == 0 && reader.HasAttributes) { sLogFolder = reader.GetAttribute("value"); }
                            if (String.Compare(reader.Name, "capturefolder", true) == 0 && reader.HasAttributes) { sCaptureFolder = reader.GetAttribute("value"); }
                            if (String.Compare(reader.Name, "settingsfolder", true) == 0 && reader.HasAttributes) { sSettingsFolder = reader.GetAttribute("value"); }
                            if (String.Compare(reader.Name, "logatconnect", true) == 0 && reader.HasAttributes) { bEnableLogging = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "serialport", true) == 0 && reader.HasAttributes) { sPreferedComPort = reader.GetAttribute("value"); }
                            if (String.Compare(reader.Name, "serialspeed", true) == 0 && reader.HasAttributes) { sPreferedSerialSpeed = reader.GetAttribute("value"); }

                            if (String.Compare(reader.Name, "lograw", true) == 0 && reader.HasAttributes) { logGraw = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "logatt", true) == 0 && reader.HasAttributes) { logGatt = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "logmag", true) == 0 && reader.HasAttributes) { logGmag = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "logrcc", true) == 0 && reader.HasAttributes) { logGrcc = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "logrcx", true) == 0 && reader.HasAttributes) { logGrcx = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "logmot", true) == 0 && reader.HasAttributes) { logGmot = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "logsrv", true) == 0 && reader.HasAttributes) { logGsrv = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "lognav", true) == 0 && reader.HasAttributes) { logGnav = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "logpar", true) == 0 && reader.HasAttributes) { logGpar = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "logdbg", true) == 0 && reader.HasAttributes) { logGdbg = Convert.ToBoolean(reader.GetAttribute("value")); }

                            if (String.Compare(reader.Name, "mapprovider", true) == 0 && reader.HasAttributes) { iMapProviderSelectedIndex  = Convert.ToInt16(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "max_wp_number", true) == 0 && reader.HasAttributes) { max_wp_number = Convert.ToByte(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "wp_radius", true) == 0 && reader.HasAttributes) { wp_radius = Convert.ToUInt16(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "speech_enabled", true) == 0 && reader.HasAttributes) { speech_enabled = Convert.ToBoolean(reader.GetAttribute("value")); }

                            if (String.Compare(reader.Name, "announce_alt", true) == 0 && reader.HasAttributes) { announce_alt_enabled = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "announce_vbat", true) == 0 && reader.HasAttributes) { announce_vbat_enabled = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "announce_dist", true) == 0 && reader.HasAttributes) { announce_dist_enabled = Convert.ToBoolean(reader.GetAttribute("value")); }
                            if (String.Compare(reader.Name, "announce_interval", true) == 0 && reader.HasAttributes) { announce_interval = Convert.ToInt16(reader.GetAttribute("value")); }
                            
                            if (String.Compare(reader.Name, "cellcount", true) == 0 && reader.HasAttributes) { cellcount = Convert.ToByte(reader.GetAttribute("value")); }


                            break;
                    }
                }
            }
            catch
            {
                MessageBoxEx.Show("Options file contains invalid data around Line : " + reader.LineNumber + "\r\nUnable to continue!!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return (false);

            }

            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return (true);
        }


    }

    #endregion

    #region PID

    public class PID
    {
        //public fields

        public string name;
        public string description;
        public Label pidLabel;

        public byte P;
        public bool Pshown;
        public decimal Pmin;
        public decimal Pmax;
        public int Pprec;
        public Label Plabel;
        public NumericUpDown Pfield;


        public byte I;
        public bool Ishown;
        public decimal Imin;
        public decimal Imax;
        public int Iprec;
        public Label Ilabel;
        public NumericUpDown Ifield;

        public byte D;
        public bool Dshown;
        public decimal Dmin;
        public decimal Dmax;
        public int Dprec;
        public Label Dlabel;
        public NumericUpDown Dfield;

        public PID()
        {

            P = 0;
        }



    }





    #endregion


    #region mw_settings
    public class mw_settings
    {



        //public fields


        public byte currentSet;             //Current settings

        //PID's
        public byte[] pidP;                 //P values
        public byte[] pidI;                 //I values
        public byte[] pidD;                 //D values

        //RC Tuning
        public byte rcRate; 
        public byte rcExpo;
        public byte RollPitchRate;
        public byte YawRate;
        public byte DynThrPID;
        public byte ThrottleMID;
        public byte ThrottleEXPO;

        //Servo 
        public int[] servoMin;
        public int[] servoMax;
        public int[] servoMiddle;
        public sbyte[] servoRate;


        //NAV settings
        public byte flags1;
        public byte flags2;
        public UInt16 wp_radius;
        public UInt16 safe_wp_distance;
        public UInt16 nav_max_altitude;
        public UInt16 nav_speed_max;
        public UInt16 nav_speed_min;
        public byte crosstrack_gain;
        public UInt16 nav_bank_max;
        public UInt16 rth_altitude;
        public UInt16 fence;
        public byte land_speed;
        public byte max_wp_number;

        //Other parameters

        public Int16 PowerTrigger;
        public UInt16 minThrottle;
        
        public UInt16 failsafe_throttle;

        public Int16 mag_declination;

        public byte vbatscale;
        public byte vbatlevel_warn1;
        public byte vbatlevel_warn2;
        public byte vbatlevel_crit;

        //Rc command parsing

        public UInt32[] activation;


        //For GUI only

        public string[] pidnames;
        private int iPIDItems, iCheckBoxItems;
        private int iSwVer;
        private bool bExtendedAux;

        //Constructor
        public mw_settings(int pidItems, int checkboxItems, int iSoftwareVersion)
        {

            pidP = new byte[pidItems];
            pidI = new byte[pidItems];
            pidD = new byte[pidItems];
             
            activation = new UInt32[checkboxItems];

            servoMin = new int[8];
            servoMax = new int[8];
            servoMiddle = new int[8];
            servoRate = new sbyte[8];

            iPIDItems = pidItems;
            iCheckBoxItems = checkboxItems;
            iSwVer = iSoftwareVersion;
        
            pidnames = new string[pidItems];

        }

        public void write_settings( SerialPort serialport, int cbItems, bool extended_aux)
        {

            byte[] buffer = new byte[250];          //this must be long enough
            int bptr = 0;                           //buffer pointer
            byte[] bInt16 = new byte[2];            //two byte buffer for converting int to two separated bytes
            byte checksum = 0;
            int icbItems = cbItems;


            //Write out settings
            if (serialport.IsOpen)
            {

                //Write RC_TUNING
                bptr = 0;
                checksum = 0;
                buffer[bptr++] = (byte)'$';
                buffer[bptr++] = (byte)'M';
                buffer[bptr++] = (byte)'<';
                buffer[bptr++] = 7;
                buffer[bptr++] = (byte)MSP.MSP_SET_RC_TUNING;

                buffer[bptr++] = rcRate;
                buffer[bptr++] = rcExpo;
                buffer[bptr++] = RollPitchRate;
                buffer[bptr++] = YawRate;
                buffer[bptr++] = DynThrPID;
                buffer[bptr++] = ThrottleMID;
                buffer[bptr++] = ThrottleEXPO;
                for (int i = 3; i < bptr; i++) checksum ^= buffer[i];
                buffer[bptr++] = checksum;
                serialport.Write(buffer, 0, bptr);

            //    while (serialport.BytesToWrite > 0) ;

                //Write PID's 
                bptr = 0;
                checksum = 0;
                buffer[bptr++] = (byte)'$';
                buffer[bptr++] = (byte)'M';
                buffer[bptr++] = (byte)'<';
                buffer[bptr++] = (byte)(3 * iPIDItems);
                buffer[bptr++] = (byte)MSP.MSP_SET_PID;
                for (int i = 0; i < iPIDItems; i++)
                {
                    buffer[bptr++] = pidP[i];
                    buffer[bptr++] = pidI[i];
                    buffer[bptr++] = pidD[i];
                }
                for (int i = 3; i < bptr; i++) checksum ^= buffer[i];
                buffer[bptr++] = checksum;
                serialport.Write(buffer, 0, bptr);

                //Then write checkboxitems

                bptr = 0;
                checksum = 0;
                buffer[bptr++] = (byte)'$';
                buffer[bptr++] = (byte)'M';
                buffer[bptr++] = (byte)'<';
                if (extended_aux)
                 buffer[bptr++] = (byte)(4 * icbItems);
                else
                  buffer[bptr++] = (byte)(2 * icbItems);

                buffer[bptr++] = (byte)MSP.MSP_SET_BOX;

                for (int i = 0; i < icbItems; i++)
                {
                    buffer[bptr++] = (byte)(activation[i] & 0x00ff);
                    buffer[bptr++] = (byte)((activation[i] >> 8) & 0x00ff);
                    if (extended_aux)
                    {
                        buffer[bptr++] = (byte)((activation[i] >> 16) & 0x00ff);
                        buffer[bptr++] = (byte)((activation[i] >> 24) & 0x00ff);
                    }                      
                    
                }
                for (int i = 3; i < bptr; i++) checksum ^= buffer[i];
                buffer[bptr++] = checksum;
                serialport.Write(buffer, 0, bptr);

                //Servo_conf

                bptr = 0;
                checksum = 0;
                buffer[bptr++] = (byte)'$';
                buffer[bptr++] = (byte)'M';
                buffer[bptr++] = (byte)'<';
                buffer[bptr++] = (byte)(56);
                buffer[bptr++] = (byte)MSP.MSP_SET_SERVO_CONF;

                for (int i = 0; i < 8; i++)
                {
                    buffer[bptr++] = (byte)(servoMin[i] & 0x00ff);
                    buffer[bptr++] = (byte)((servoMin[i] >> 8) & 0x00ff);
                    buffer[bptr++] = (byte)(servoMax[i] & 0x00ff);
                    buffer[bptr++] = (byte)((servoMax[i] >> 8) & 0x00ff);
                    buffer[bptr++] = (byte)(servoMiddle[i] & 0x00ff);
                    buffer[bptr++] = (byte)((servoMiddle[i] >> 8) & 0x00ff);
                    buffer[bptr++] = (byte)(servoRate[i]);
                }
                for (int i = 3; i < bptr; i++) checksum ^= buffer[i];
                buffer[bptr++] = checksum;
                serialport.Write(buffer, 0, bptr);


                //then the rest
                bptr = 0;
                checksum = 0;
                buffer[bptr++] = (byte)'$';
                buffer[bptr++] = (byte)'M';
                buffer[bptr++] = (byte)'<';
                buffer[bptr++] = (byte)(22);
                buffer[bptr++] = (byte)MSP.MSP_SET_MISC;

                buffer[bptr++] = (byte)(PowerTrigger & 0x00ff);
                buffer[bptr++] = (byte)((PowerTrigger >> 8) & 0x00ff);

                buffer[bptr++] = (byte)(minThrottle & 0x00ff);
                buffer[bptr++] = (byte)((minThrottle >> 8) & 0x00ff);

                bptr++; bptr++;     //not used MAXThrottle
                bptr++; bptr++;     //not used MinCommand

                buffer[bptr++] = (byte)(failsafe_throttle & 0x00ff);
                buffer[bptr++] = (byte)((failsafe_throttle >> 8) & 0x00ff);

                bptr++; bptr++;                 //not used arm
                bptr++; bptr++; bptr++; bptr++; // not used lifetime

                buffer[bptr++] = (byte)(mag_declination & 0x00ff);
                buffer[bptr++] = (byte)((mag_declination >> 8) & 0x00ff);

                buffer[bptr++] = vbatscale;
                buffer[bptr++] = vbatlevel_warn1;
                buffer[bptr++] = vbatlevel_warn2;
                buffer[bptr++] = vbatlevel_crit;

                for (int i = 3; i < bptr; i++) checksum ^= buffer[i];
                buffer[bptr++] = checksum;
                serialport.Write(buffer, 0, bptr);


                // write navi parameters
                bptr = 0;
                checksum = 0;
                buffer[bptr++] = (byte)'$';
                buffer[bptr++] = (byte)'M';
                buffer[bptr++] = (byte)'<';
                buffer[bptr++] = (byte)(21);
                buffer[bptr++] = (byte)MSP.MSP_SET_NAV_CONFIG;

                buffer[bptr++] = (byte)flags1;
                buffer[bptr++] = (byte)flags2;

                buffer[bptr++] = (byte)(wp_radius & 0x00ff);
                buffer[bptr++] = (byte)((wp_radius >> 8) & 0x00ff);

                buffer[bptr++] = (byte)(safe_wp_distance  & 0x00ff);
                buffer[bptr++] = (byte)((safe_wp_distance >> 8) & 0x00ff);

                buffer[bptr++] = (byte)(nav_max_altitude & 0x00ff);
                buffer[bptr++] = (byte)((nav_max_altitude >> 8) & 0x00ff);

                buffer[bptr++] = (byte)(nav_speed_max & 0x00ff);
                buffer[bptr++] = (byte)((nav_speed_max >> 8) & 0x00ff);

                buffer[bptr++] = (byte)(nav_speed_min & 0x00ff);
                buffer[bptr++] = (byte)((nav_speed_min >> 8) & 0x00ff);

                buffer[bptr++] = (byte)crosstrack_gain;

                buffer[bptr++] = (byte)(nav_bank_max & 0x00ff);
                buffer[bptr++] = (byte)((nav_bank_max >> 8) & 0x00ff);

                buffer[bptr++] = (byte)(rth_altitude & 0x00ff);
                buffer[bptr++] = (byte)((rth_altitude >> 8) & 0x00ff);

                buffer[bptr++] = land_speed;

                buffer[bptr++] = (byte)(fence & 0x00ff);
                buffer[bptr++] = (byte)((fence >> 8) & 0x00ff);

                buffer[bptr++] = max_wp_number;

                for (int i = 3; i < bptr; i++) checksum ^= buffer[i];
                buffer[bptr++] = checksum;
                serialport.Write(buffer, 0, bptr);




                while (serialport.BytesToWrite > 0) ;
                while (serialport.BytesToRead > 0) ;




                byte c = 0;
                byte[] o;
                o = new byte[10];
                // with checksum 
                o[0] = (byte)'$';
                o[1] = (byte)'M';
                o[2] = (byte)'<';
                o[3] = (byte)0; c ^= o[3];       //no payload 
                o[4] = (byte)MSP.MSP_EEPROM_WRITE; c ^= o[4];
                o[5] = (byte)c;
                serialport.Write(o, 0, 6);

       //         DateTime startTime = DateTime.Now;
//                while ((serialport.BytesToRead == 0) && (DateTime.Now.Subtract(startTime).TotalMilliseconds < 2000)) ;
//
                //while (serialport.BytesToWrite > 0) ;
                //while (serialport.BytesToRead > 0) ;


            }
        }

        public void save_to_xml(string filename)
        {
            XmlTextWriter tw = new XmlTextWriter(filename,null);
            tw.Formatting = Formatting.Indented;
            tw.Indentation = 4;
            tw.WriteStartDocument();

            // Get the name and version of the current assembly.
            Assembly assem = Assembly.GetExecutingAssembly();
            AssemblyName assemName = assem.GetName();
            Version ver = assemName.Version;
            tw.WriteComment(String.Format("{0}, Version {1}", assemName.Name, ver.ToString()));
            tw.WriteComment("MultiWii FC Parameters file");
            tw.WriteComment("MultiWii FC software revision 2.3"); 
            
            tw.WriteStartElement("PARAMETERS");

            tw.WriteStartElement("VERSION value=\"" + iSwVer + "\""); tw.WriteEndElement();

            for (int i = 0; i < iPIDItems; i++)
            {
                tw.WriteStartElement("PID id=\"" + i+"\" name=\""+pidnames[i]+"\" p=\""+Convert.ToString(pidP[i])+"\" i=\""+Convert.ToString(pidI[i])+"\" d=\""+Convert.ToString(pidD[i])+"\"");
                tw.WriteEndElement();

            }

            for (int i = 0; i < iCheckBoxItems; i++)
            {
                tw.WriteStartElement("AUXFUNC id=\"" + i + "\" aux1234=\"" + activation[i] + "\"");
                tw.WriteEndElement();
            }

            tw.WriteStartElement("RCRATE value=\"" + rcRate + "\""); tw.WriteEndElement();
            tw.WriteStartElement("RCEXPO value=\"" + rcExpo + "\""); tw.WriteEndElement();
            tw.WriteStartElement("THMID value=\"" + ThrottleMID + "\""); tw.WriteEndElement();
            tw.WriteStartElement("THEXPO value=\"" + ThrottleMID + "\""); tw.WriteEndElement();
            tw.WriteStartElement("ROLLPITCHRATE value=\"" + RollPitchRate + "\""); tw.WriteEndElement();
            tw.WriteStartElement("YAWRATE value=\"" + YawRate + "\""); tw.WriteEndElement();
            tw.WriteStartElement("DYNTHRPID value=\"" + DynThrPID + "\""); tw.WriteEndElement();
            tw.WriteStartElement("POWERTRIGGER value=\"" + PowerTrigger + "\""); tw.WriteEndElement();

            tw.WriteStartElement("VBATSCALE value=\"" + vbatscale + "\""); tw.WriteEndElement();
            tw.WriteStartElement("VBATWARN1 value=\"" + vbatlevel_warn1 + "\""); tw.WriteEndElement();
            tw.WriteStartElement("VBATWARN2 value=\"" + vbatlevel_warn2 + "\""); tw.WriteEndElement();
            tw.WriteStartElement("VBATCRITICAL value=\"" + vbatlevel_crit + "\""); tw.WriteEndElement();

            tw.WriteStartElement("MINTHROTTLE value=\"" + minThrottle + "\""); tw.WriteEndElement();
            tw.WriteStartElement("FAILSAFETHROTTLE value=\"" + failsafe_throttle + "\""); tw.WriteEndElement();
            tw.WriteStartElement("MAGDEC value=\"" + mag_declination + "\""); tw.WriteEndElement();

            for (int i = 0; i < 8; i++)
            {
                tw.WriteStartElement("SERVO id=\"" + i + "\" min=\"" + servoMin[i] + "\" max=\"" + servoMax[i] + "\" middle=\"" + servoMiddle[i] + "\" rate=\"" + servoRate[i] + "\"");
                tw.WriteEndElement();
            }

            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Close();
        }

        public bool read_from_xml(string filename)
        {

                XmlTextReader reader = new XmlTextReader(filename);
                //MessageBox.Show("Options file " + sOptionsConfigFilename + " does not found", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                try
                {
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:

                                if (String.Compare(reader.Name, "version", true) == 0 && reader.HasAttributes)
                                {
                                    if (Convert.ToInt16(reader.GetAttribute("value")) != iSwVer)
                                    {
                                        throw new System.InvalidOperationException("Version of settings file does not match with the version set in GUI");
                                    }
                                }
                                if (String.Compare(reader.Name, "pid", true) == 0 && reader.HasAttributes)
                                {
                                    int tpidID = 0; byte tpidP = 0; byte tpidI = 0; byte tpidD = 0;

                                    tpidID = Convert.ToInt16(reader.GetAttribute("id"));
                                    tpidP = Convert.ToByte(reader.GetAttribute("p"));
                                    tpidI = Convert.ToByte(reader.GetAttribute("i"));
                                    tpidD = Convert.ToByte(reader.GetAttribute("d"));
                                    pidP[tpidID] = tpidP;
                                    pidI[tpidID] = tpidI;
                                    pidD[tpidID] = tpidD;
                                }
                                if (String.Compare(reader.Name, "auxfunc", true) == 0 && reader.HasAttributes)
                                {
                                    int auxID = 0; UInt32 a1 = 0; 
                                    auxID = Convert.ToInt16(reader.GetAttribute("id"));
                                    a1 = Convert.ToUInt32(reader.GetAttribute("aux1234"));
                                    activation[auxID] = a1;
                                }
                                if (String.Compare(reader.Name, "rcrate", true) == 0 && reader.HasAttributes) { rcRate = Convert.ToByte(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "rcexpo", true) == 0 && reader.HasAttributes) { rcExpo = Convert.ToByte(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "thmid", true) == 0 && reader.HasAttributes) { ThrottleMID = Convert.ToByte(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "thexpo", true) == 0 && reader.HasAttributes) { ThrottleEXPO  = Convert.ToByte(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "rollpitchrate", true) == 0 && reader.HasAttributes) { RollPitchRate = Convert.ToByte(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "yawrate", true) == 0 && reader.HasAttributes) { YawRate = Convert.ToByte(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "dynthrpid", true) == 0 && reader.HasAttributes) { DynThrPID = Convert.ToByte(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "powertrigger", true) == 0 && reader.HasAttributes) { PowerTrigger = Convert.ToByte(reader.GetAttribute("value")); }

                                if (String.Compare(reader.Name, "vabtscale", true) == 0 && reader.HasAttributes) { vbatscale = Convert.ToByte(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "vbatwarn1", true) == 0 && reader.HasAttributes) { vbatlevel_warn1 = Convert.ToByte(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "vbatwarn2", true) == 0 && reader.HasAttributes) { vbatlevel_warn2 = Convert.ToByte(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "vbatcritical", true) == 0 && reader.HasAttributes) { vbatlevel_crit = Convert.ToByte(reader.GetAttribute("value")); }
        
                                if (String.Compare(reader.Name, "minthrottle", true) == 0 && reader.HasAttributes) { minThrottle = Convert.ToUInt16(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "failsafethrottle", true) == 0 && reader.HasAttributes) { failsafe_throttle = Convert.ToUInt16(reader.GetAttribute("value")); }
                                if (String.Compare(reader.Name, "magdec", true) == 0 && reader.HasAttributes) { mag_declination = Convert.ToInt16(reader.GetAttribute("value")); }

                                if (String.Compare(reader.Name, "servo", true) == 0 && reader.HasAttributes)
                                {
                                    int servoID = 0;
                                    servoID = Convert.ToInt16(reader.GetAttribute("id"));
                                    servoMin[servoID] = Convert.ToUInt16(reader.GetAttribute("min"));
                                    servoMax[servoID] = Convert.ToUInt16(reader.GetAttribute("max"));
                                    servoMiddle[servoID] = Convert.ToUInt16(reader.GetAttribute("middle"));
                                    servoRate[servoID] = (sbyte) Convert.ToInt16(reader.GetAttribute("rate"));
                                }
                                


                                break;
                        }
                    }
                }
                catch (System.InvalidOperationException e)
                {
                    MessageBoxEx.Show(e.Message,"Version mismatch",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

    
    
    
    }


    #endregion

    #region mw_data_gui

    public class mw_data_gui
    {

        public int ax;          //AccSmooth
        public int ay;          //AccSmooth
        public int az;          //AccSmooth
        public int gx;          //Gyro Smooth
        public int gy;          //Gyro Smooth
        public int gz;          //Gyro Smooth
        public int magx;    //Magnetometer 
        public int magy;    //Magnetometer 
        public int magz;   //Magnetometer 

        public int EstAlt;
        public int vario;

        public int heading;
        public int[] servos;
        public int[] motors;
        public int rcRoll, rcPitch, rcYaw, rcThrottle;
        public int[] rcAUX;
        public int present;            //What sensors are present?
        public UInt32 mode;               //What mode are we in ?
        public int i2cErrors;
        public int cycleTime;
        public int angx;                //Must be /10
        public int angy;                //Must be /10
        public byte multiType;
        public byte version;
        public byte protocol_version;
        public UInt32 capability;
        public byte[] pidP;
        public byte[] pidI;
        public byte[] pidD;
        public byte rcRate;
        public byte rcExpo;
        public byte RollPitchRate;
        public byte YawRate;
        public byte DynThrPID;
        public byte ThrottleMID;
        public byte ThrottleEXPO;
        public UInt32[] activation;
        public string[] sBoxNames;
        public bool bUpdateBoxNames;
        public int GPS_distanceToHome;
        public int GPS_directionToHome;
        public byte GPS_numSat;
        public byte GPS_fix;
        public byte GPS_update;
        public int GPS_latitude;
        public int GPS_longitude;
        public int GPS_altitude;
        public int GPS_speed;
        public int GPS_home_lat;
        public int GPS_home_lon;
        public int GPS_home_alt;
        public int GPS_poshold_lat;
        public int GPS_poshold_lon;
        public int GPS_poshold_alt;
        

        //Analog
        public uint pMeterSum;
        public byte vBat;
        public uint rssi;
        
        
        //Misc
        public uint powerTrigger;
        public uint minThrottle;
        public uint maxThrottle;
        public uint minCommand;

        public uint failsafe_throttle;
        public uint plog_arm;
        public uint plog_lifetime;           //what unit ???

        public int mag_declination;         // *10
        public byte vbatscale;
        public byte vbatlevel_warn1;
        public byte vbatlevel_warn2;
        public byte vbatlevel_crit;

        //Debug
        public int debug1, debug2, debug3, debug4;


        //Servo_conf
        public int[] servoMin;
        public int[] servoMax;
        public int[] servoMiddle;
        public int[] servoRate;
        public Boolean[] servoReverse;


        //Navigation status
        public byte gps_mode;
        public byte nav_state;
        public byte action;
        public byte wp_number;
        public byte nav_error;
        public Int16 target_bearing;


        //temp
        /*
        public Int32 original_altitude;
        public Int32 target_altitude;
        public Int32 alt_to_hold;
        public byte alt_change_flag;
        */



        //Radio 
        public UInt16 rxerrors;
        public UInt16 fixed_errors;
        public byte localrssi;
        public byte remrssi;
        public byte txbuf;
        public byte noise;
        public byte remnoise;


        //NAV settings
        public byte flags1;
        public byte flags2;
        public UInt16 wp_radius;
        public UInt16 safe_wp_distance;
        public UInt16 nav_max_altitude;
        public UInt16 nav_speed_max;
        public UInt16 nav_speed_min;
        public byte crosstrack_gain;
        public UInt16 nav_bank_max;
        public UInt16 rth_altitude;
        public byte land_speed;
        public UInt16 fence;
        public byte max_wp_number;






        private int iPIDItems, iCheckBoxItems;
        private int iSwVer;


        //Constructor
        public mw_data_gui(int pidItems, int checkboxItems, int iSoftwareVersion)
        {
            motors = new int[8];
            servos = new int[8];
            rcAUX = new int[8];        //for sbus

            pidP = new byte[pidItems];
            pidI = new byte[pidItems];
            pidD = new byte[pidItems];

            servoMin = new int[8];
            servoMax = new int[8];
            servoMiddle = new int[8];
            servoRate = new int[8];



            activation = new UInt32[checkboxItems];

            iPIDItems = pidItems;
            iCheckBoxItems = checkboxItems;
            iSwVer = iSoftwareVersion;
            bUpdateBoxNames = false;

            max_wp_number = 72;         //Will be updated when connected to the controller
            multiType = 1;


        }


    }

    public class mission_step_structure
    {
        public byte wp_number;
        public byte action;
        public int lat;
        public int lon;
        public int altitude;
        public Int16 p1;
        public Int16 p2;
        public Int16 p3;
        public byte flag;
        public bool wp_updated;

        public mission_step_structure()
        {
        }

    }






}
    #endregion