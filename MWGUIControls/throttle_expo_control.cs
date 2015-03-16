
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
    class throttle_expo_control : MWGUIControl
    {
        #region Fields

        // Parameters
        private double T_MID  = 0.5f;
        private double T_EXPO = 0.5f;
        private int Throttle = 1100;
        private Boolean got_data = false;
        private int[] lookupT = new int[11];


        // Images

        Bitmap bmpBackground = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.rcexpo);


        #endregion

        #region Contructor

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        //Constructor
        public throttle_expo_control()
        {
            // Double bufferisation
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);

            //fill out lookupT


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



            Pen drawRedPen = new Pen(Color.Red, 2);

            System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 8.0F);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.SolidBrush drawBrushBlue = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            System.Drawing.SolidBrush drawBrushRed = new System.Drawing.SolidBrush(System.Drawing.Color.Red);

            bmpBackground.MakeTransparent(Color.Yellow);
            pe.Graphics.DrawImageUnscaled(bmpBackground, 0, 0);

            double a = T_MID;
            double b = T_EXPO;
            double val;

            int[] curvepoints = new int[75];

            for (int i = 0; i < 11; i++)
            {
                int mid = (int)(100 * a);
                int expo = (int)(100 * b);
                int tmp = 10 * i - mid;
                int y = 1;
                if (tmp > 0) y = 100 - mid;
                if (tmp < 0) y = mid;
                lookupT[i] = (int)(10 * mid + tmp * (100 - expo + tmp * tmp * expo / (y * y)) / 10);
            }



            //4x4 pixel pint fir drawing
            Bitmap bm = new Bitmap(4, 4);
            Graphics gfx = Graphics.FromImage(bm);
            gfx.FillRectangle(drawBrushBlue, 0, 0, 3, 3);

            Bitmap bl = new Bitmap(6, 6);
            Graphics gfx1 = Graphics.FromImage(bl);
            gfx1.FillRectangle(drawBrushRed, 0, 0, 5, 5);

            //Quick hack to scale the original rc rate box to this control size... I was lazy to rewrite the calculations...
            if (got_data)
            {


                for (int i = 0; i < 70; i++)
                {
                    int tmp = 1000 / 70 * i;
                    int tmp2 = tmp / 100;
                    int rccommand = lookupT[tmp2] + (tmp - tmp2 * 100) * (lookupT[tmp2 + 1] - lookupT[tmp2]) / 100;
                    val = rccommand * 70 / 1000;
                    pe.Graphics.DrawImageUnscaled(bm, (int)((double)(i) * 1.9f) + 9, 5 + (int)((70 - val) * 1.2f));
                    curvepoints[i] = (int)((70 - val) * 1.2f);
                }
                curvepoints[70] = curvepoints[69];
                curvepoints[71] = curvepoints[69];
                curvepoints[72] = curvepoints[69];
                curvepoints[73] = curvepoints[69];



//                for (int i =0;i<20;i++) {
                    pe.Graphics.DrawImageUnscaled(bl, (int)((double)((Math.Max(1100,Throttle) - 1100) * 70 / 900)* 1.9f)+9, curvepoints[(int)((double)((Math.Max(1100,Throttle) - 1100) * 70 / 900))]+2);
//                    }

                pe.Graphics.DrawString("Mid:" + String.Format("{0:0.00}", T_MID), drawFont, drawBrush, 10, 5);
                pe.Graphics.DrawString("Expo:" + String.Format("{0:0.00}", T_EXPO), drawFont, drawBrush, 10, 15);
            }
            else
            {
                pe.Graphics.DrawString("No Data", drawFont, drawBrush, 10, 5);
            }

            gfx.Dispose();
            gfx1.Dispose();
            bl.Dispose();
            bm.Dispose();
            drawBrush.Dispose();
            drawBrushBlue.Dispose();
            drawFont.Dispose();
            drawRedPen.Dispose();

        }

        #endregion

        #region Methods

        ///<summary>
        /// Define the values to be displayed on the indicator
        ///</summary>

        public void SetRCExpoParameters(double throttle_MID, double throttle_EXPO, int rcThrottle)
        {
            T_MID = throttle_MID;
            T_EXPO = throttle_EXPO;
            Throttle = rcThrottle;
            
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
