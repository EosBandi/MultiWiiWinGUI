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
    class rc_input_control : MWGUIControl
    {
        #region Fields

        // Parameters
        private int[] bar_pos = { 25, 40, 55, 70, 85, 100, 115, 130, 145, 160, 175, 190 };
        private int[] RC_Values = { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000,1000,1000,1000,1000,1000,1000,1000 };
        private int RC_Channels = 18;

        // Images
        Bitmap bmpBackground = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.rc_control);

        #endregion

        #region Constructor

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;


        public rc_input_control()
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
            this.Height = 200;
            this.Width = 200;
        }
        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);

            // diplay mask
            System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 8.0F);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.SolidBrush drawBrushGreen = new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen);

            bmpBackground.MakeTransparent(Color.Yellow);
            pe.Graphics.DrawImageUnscaled(bmpBackground, 0, 0);

            for (int i = 0; i < RC_Channels; i++)
            {
                if (i < 12)     //do not draw above channel 12
                {
                    string strLabel = "";
                    if (i == 0) { strLabel = "Thr"; }
                    if (i == 1) { strLabel = "Pitch"; }
                    if (i == 2) { strLabel = "Roll"; }
                    if (i == 3) { strLabel = "Yaw"; }
                    if (i > 3) { strLabel = "Aux" + (i - 3); }

                    pe.Graphics.DrawString(String.Format("{0:0}", strLabel), drawFont, drawBrush, 5, bar_pos[i] - 18);
                    pe.Graphics.DrawString(String.Format("{0:0}", RC_Values[i]), drawFont, drawBrush, 165, bar_pos[i] - 18);
                    int w = (int)((RC_Values[i] - 1000) / (double)(1000 / 120));
                    if (w < 0) { w = 0; }
                    if (w > 120) { w = 120; }

                    pe.Graphics.FillRectangle(drawBrushGreen, 40, bar_pos[i] - 15, w, 10);
                }
            }

            drawFont.Dispose();
            drawBrush.Dispose();
            drawBrushGreen.Dispose();
        
        }

        #endregion

        #region Methods

        ///<summary>
        /// Set the bar values based on the input variables
        ///</summary>

        public void SetRCInputParameters(int rcThr, int rcPitch, int rcRoll, int rcYaw, int[] rcAux, int RCchannels)
        {
            RC_Values[0] = rcThr;
            RC_Values[1] = rcPitch;
            RC_Values[2] = rcRoll;
            RC_Values[3] = rcYaw;
            int i = 4;
            foreach  (int Aux in rcAux) {
                RC_Values[i] = Aux;
                i++;
            }
            RC_Channels = RCchannels;
            this.Refresh();
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(200, 200);
            }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, 200, 200, specified);
        }

        #endregion
    }
}
