using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Data;

namespace MultiWiiGUIControls
{
    class battery_indicator : MWGUIControl
    {

        //parameters 
        int voltage;
        byte cellcount;
        float cellvoltage;

        Bitmap bmpBackground = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.battery_indicator_background);

                #region Contructor

        /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public battery_indicator()
		{
			// Double bufferisation
			SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
				ControlStyles.AllPaintingInWmPaint, true);
            voltage = 0;
            cellcount = 3;
            cellvoltage = (float)voltage / 10 / cellcount;

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
            this.Height = 150;
            this.Width = 150;
        }
        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs pe)
        {
            
            // Calling the base class OnPaint
            base.OnPaint(pe);

            string sVoltage;
            sVoltage = String.Format("{0:0.0}v", (float)voltage/10);

            bmpBackground.MakeTransparent(Color.Yellow);

            // diplay mask
            Pen maskPen = new Pen(this.BackColor, 30);
            System.Drawing.SolidBrush drawBrushWhite = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.SolidBrush drawBrushGreen = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            System.Drawing.SolidBrush drawBrushYellow = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            System.Drawing.SolidBrush drawBrushRed = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 16.0F, FontStyle.Bold);
            System.Drawing.Font drawFontSmall = new System.Drawing.Font(FontFamily.GenericMonospace, 8.0F, FontStyle.Bold);

            // display Background
            pe.Graphics.DrawImageUnscaled(bmpBackground, 0, 0);
            //display text
            pe.Graphics.DrawString(sVoltage, drawFont, drawBrushWhite, 77-((sVoltage.Length*16)/2), 95);
            pe.Graphics.DrawString(String.Format("{0:0}s",cellcount),drawFontSmall,drawBrushWhite,130,135);
            
            //draw rectangles

            int a = (int)Math.Ceiling(cellvoltage * 10); //28-42
            for (int i = 27; i <= 42; i++)
            {
                if (i > a) break;

                if (i<=31) pe.Graphics.FillRectangle(drawBrushRed, 28+((i-27)*6), 38, 3, 20);
                if (i > 31 && i <= 36) pe.Graphics.FillRectangle(drawBrushYellow, 28 + ((i - 27) * 6), 38, 3, 20);
                if (i > 36) pe.Graphics.FillRectangle(drawBrushGreen, 28 + ((i - 27) * 6), 38, 3, 20);
            }


            drawFont.Dispose();
            drawBrushWhite.Dispose();
            drawBrushGreen.Dispose();



        }

        #endregion

        public void SetVoltage(int v, byte c)
        {
            voltage = v;
            cellcount = c;
            cellvoltage  = (float)voltage / 10 / cellcount;


            this.Refresh();
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(150, 150);
            }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, 150, 150, specified);
        }


    }
}
