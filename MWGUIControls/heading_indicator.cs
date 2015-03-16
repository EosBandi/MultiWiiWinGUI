using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Data;

namespace MultiWiiGUIControls
{
    class heading_indicator : MWGUIControl
    {
        #region Fields

        // Parameters
        int Heading; 

        // Images
        Bitmap bmpBackground = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.HeadingIndicator_Background);
        Bitmap bmpHeadingwheel = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.HeadingWeel);
        Bitmap bmpAircaft = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.HeadingIndicator_Aircraft);        

        #endregion

        #region Contructor

        /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public heading_indicator()
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

            // Pre Display computings
            Point ptRotation = new Point(75, 75);
            Point ptImgAircraft = new Point(35,20);
            Point ptImgHeadingWeel = new Point(7, 7);

            bmpBackground.MakeTransparent(Color.Yellow);
            bmpHeadingwheel.MakeTransparent(Color.Yellow);
            bmpAircaft.MakeTransparent(Color.Yellow);

            // diplay mask
            Pen maskPen = new Pen(this.BackColor, 30);
            //pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpBackground.Width, bmpBackground.Height);

            // display Background
            pe.Graphics.DrawImageUnscaled(bmpBackground, 0, 0);

            // display HeadingWheel
            Bitmap bmp = new Bitmap(136, 136);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform(68f, 68f);
            gfx.RotateTransform(-Heading);
            gfx.TranslateTransform(-68f, -68f);
            gfx.DrawImageUnscaled(bmpHeadingwheel, 0, 0);
            pe.Graphics.DrawImageUnscaled(bmp, 7, 7);

            //Add text
            System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 8.0F);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            pe.Graphics.DrawString(String.Format("{0:000°}", Heading), drawFont, drawBrush, 115, 3);
            // display aircraft
            pe.Graphics.DrawImageUnscaled(bmpAircaft, (int)(ptImgAircraft.X), (int)(ptImgAircraft.Y));

            //Dispose objects used 
            gfx.Dispose();
            bmp.Dispose();
            maskPen.Dispose();
            drawFont.Dispose();
            drawBrush.Dispose();



        }

        #endregion

        #region Methods

        /// <summary>
        /// Define the physical value to be displayed on the indicator
        /// </summary>
        /// <param name="aircraftHeading">The aircraft heading in °deg</param>
        public void SetHeadingIndicatorParameters(int aircraftHeading)
        {
            if (aircraftHeading < 0) { Heading = 360 + aircraftHeading; }
            else { Heading = aircraftHeading; }
            this.Refresh();
        }

        #endregion
    }
}
