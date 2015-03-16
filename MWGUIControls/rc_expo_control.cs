
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
    class rc_expo_control : MWGUIControl
    {
        #region Fields

        // Parameters
        private double RC_Rate = 1.00f;
        private double RC_Expo = 0.8f;
        private Boolean got_data = false;

        // Images

        Bitmap bmpBackground = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.rcexpo);


        #endregion

        #region Contructor

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;


        public rc_expo_control()
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
            this.Height = 100;
            this.Width = 150;
        }
        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);



            Pen drawRedPen = new Pen(Color.Red,2);

            System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 8.0F);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.SolidBrush drawBrushGreen = new System.Drawing.SolidBrush(System.Drawing.Color.Green);

            bmpBackground.MakeTransparent(Color.Yellow);
            pe.Graphics.DrawImageUnscaled(bmpBackground, 0, 0);

            double a = Math.Min(RC_Rate, 1.0f);
            double b = RC_Expo;
            int inter;
            double val;

            //4x4 pixel pint fir drawing
            Bitmap bm=new Bitmap(4,4);
            Graphics gfx = Graphics.FromImage(bm);
            gfx.FillRectangle(drawBrushGreen, 0, 0, 3, 3);
      
            //Quick hack to scale the original rc rate box to this control size... I was lazy to rewrite the calculations...
            if (got_data)
            {


                for (int i = 0; i < 70; i++)
                {
                    inter = 10 * i;
                    val = a * inter * (1 - b + inter * inter * b / 490000);
                    pe.Graphics.DrawImageUnscaled(bm, (int)((double)(i) * 1.9f) + 9, 5 + (int)((70 - val / 10) * 1.2f));
                }

                if (RC_Rate > 1)
                {
                    pe.Graphics.DrawEllipse(drawRedPen, 138, 4, 6, 6);
                }

                pe.Graphics.DrawString("Rate:" + String.Format("{0:0.00}", RC_Rate), drawFont, drawBrush, 10, 5);
                pe.Graphics.DrawString("Expo:" + String.Format("{0:0.00}", RC_Expo), drawFont, drawBrush, 10, 15);
            }
            else
            {
                pe.Graphics.DrawString("No Data", drawFont, drawBrush, 10, 5);
            }

            gfx.Dispose();
            bm.Dispose();
            drawBrush.Dispose();
            drawBrushGreen.Dispose();
            drawFont.Dispose();
            drawRedPen.Dispose();

        }

        #endregion

        #region Methods

        ///<summary>
        /// Define the values to be displayed on the indicator
        ///</summary>

        public void SetRCExpoParameters(double rc_rate, double rc_expo)
        {
            RC_Rate = rc_rate;
            RC_Expo = rc_expo;
            got_data = true;

            this.Refresh();
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(150, 100);
            }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, 150, 100, specified);
        }


        #endregion
    }
}
