using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Data;

namespace MultiWiiGUIControls
{
    class GpsIndicatorInstrumentControl : MWGUIControl
    {
        #region Fields

        // Parameters
        private int Heading;            //Heading to Home
        private int Distance;           //Distance to Home
        private int Numsat;             //Number of Sats
        private bool GPS_fix;           //GPS Fix (color of the sat symbol)
        private bool GPS_home;          //GPS Home is set (left led)
        private bool GPS_pkt;           //Hearthbeet (right led)


        // Images

        Bitmap bmpLeftLedGreen = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.gps_left_led_green);
        Bitmap bmpLeftLedRed = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.gps_left_led_red);

        Bitmap bmpRightLedGreen = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.gps_right_led_green);
        Bitmap bmpRightLedRed = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.gps_right_led_red);

        Bitmap bmpHeadingWheel = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.gps_direction);
        Bitmap bmpSatGreen = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.gps_sat_green);
        Bitmap bmpSatRed = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.gps_sat_red);
        Bitmap bmpBackGround = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.gps_background);


        #endregion

        #region Contructor

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public GpsIndicatorInstrumentControl()
        {
            // Double bufferisation
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);
        }

        #endregion

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);

            bmpHeadingWheel.MakeTransparent(Color.Yellow);
            bmpLeftLedGreen.MakeTransparent(Color.Yellow);
            bmpLeftLedRed.MakeTransparent(Color.Yellow);
            bmpRightLedGreen.MakeTransparent(Color.Yellow);
            bmpRightLedRed.MakeTransparent(Color.Yellow);
            bmpSatGreen.MakeTransparent(Color.Yellow);
            bmpSatRed.MakeTransparent(Color.Yellow);
            bmpBackGround.MakeTransparent(Color.Yellow);
 

            // diplay mask
            Pen maskPen = new Pen(this.BackColor, 30);
            pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpBackGround.Width, bmpBackGround.Height);

            // display background
            pe.Graphics.DrawImageUnscaled(bmpBackGround, 0, 0);

            //Leds
            if (GPS_home)
            {
                pe.Graphics.DrawImageUnscaled(bmpLeftLedGreen, 0, 0);
            }
            else
            {
                pe.Graphics.DrawImageUnscaled(bmpLeftLedRed, 0, 0);
            }
            if (GPS_pkt)
            {
                pe.Graphics.DrawImageUnscaled(bmpRightLedGreen, 0, 0);
            }
            else
            {
                pe.Graphics.DrawImageUnscaled(bmpRightLedRed, 0, 0);
            }


            Bitmap bmp = new Bitmap(136, 136);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform(68f, 68f);
            gfx.RotateTransform(Heading);
            gfx.TranslateTransform(-68f, -68f);
            gfx.DrawImageUnscaled(bmpHeadingWheel, 0, 0);
            pe.Graphics.DrawImageUnscaled(bmp, 7, 7);

            // display Sat

            if (GPS_fix)
            {
                pe.Graphics.DrawImageUnscaled(bmpSatGreen, 0, 0);
            }
            else
            {
                pe.Graphics.DrawImageUnscaled(bmpSatRed, 0, 0);
            }


            //And add text
            System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 8.0F);
            System.Drawing.Font drawSatFont = new System.Drawing.Font("Arial", 10.0F);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            pe.Graphics.DrawString(String.Format("{0:0000 m}",Distance), drawFont, drawBrush, 55, 100);
            pe.Graphics.DrawString(String.Format("{0:000°}",Heading), drawFont, drawBrush, 62, 40);
            pe.Graphics.DrawString(String.Format("{0:0}",Numsat), drawSatFont, drawBrush, 89, 64);

            //Dispose temp objects
            maskPen.Dispose();
            gfx.Dispose();
            bmp.Dispose();
            drawFont.Dispose();
            drawSatFont.Dispose();
            drawBrush.Dispose();

            
        }

        #endregion

        #region Methods


        /// <summary>
        /// Define the physical value to be displayed on the indicator
        /// </summary>
        public void SetGPSIndicatorParameters(int headingtohome, int distancetohome, int numsat,bool gpsfix,bool gpshome,bool gpspkt)
        {
            Heading = headingtohome;
            Distance = distancetohome;
            Numsat = numsat;
            GPS_fix = gpsfix;
            GPS_home = gpshome;
            GPS_pkt = gpspkt;
            this.Refresh();
        }

        #endregion
    }
}
