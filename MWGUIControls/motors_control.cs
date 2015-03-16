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
    class MWGUIMotors : MWGUIControl
    {
        #region Fields

        // Parameters

        enum CopterType { Tri = 1, QuadP, QuadX, BI, Gimbal, Y6, Hex6, FlyWing, Y4, Hex6X, Octo8Coax, Octo8P, Octo8X, Airplane, Heli120,Heli90,Vtail };

        static int[,] coord_quadX = {  { 120, 170, 70 },{ 120, 80, 70 },{ 40, 170, 70 },{ 40, 80, 70 }  };
        static int[,] coord_quadP = { { 75, 180, 70 }, { 125, 130, 70 }, { 25, 130, 70 }, { 75, 80, 70 } };
        static int[,] coord_tri = { { 70, 130, 70 },  { 120, 80, 70 },{ 20, 80, 70 }, { 40, 160, 70 } };
        static int[,] coord_y6 = { { 70, 160, 70 }, { 120, 90, 70 }, { 20, 90, 70 }, { 80, 170, 70 }, { 130, 100, 70 }, { 30, 100, 70 } };
        static int[,] coord_y4 = { { 95, 170, 70 }, { 120, 80, 70 }, { 50, 170, 70 }, { 20, 80, 70 } };
        static int[,] coord_wing = { { 70, 80, 70 }, { 20, 140, 70 }, { 120, 140, 70 } };
        static int[,] coord_gimbal = { { 50, 60, 70 }, { 50, 120, 70 } };
        static int[,] coord_bi = { { 40, 90, 70 }, { 120, 90, 70 }, { 10, 120, 70 }, { 90, 120, 70 } };
        static int[,] coord_hex6 = { { 120, 170, 70 }, { 120, 90, 70 }, { 20, 170, 70 }, { 20, 90, 70 }, { 70, 80, 70 }, { 70, 180, 70 } };
        static int[,] coord_hex6x = { { 100, 180, 70 }, { 100, 80, 70 }, { 60, 180, 70 }, { 60, 80, 70 }, { 140, 130, 70 }, { 20, 130, 70 } };
        static int[,] coord_octo8c = { { 110, 170, 60 }, { 110, 70, 60 }, { 30, 170, 60 }, { 30, 70, 60 }, { 130, 180, 60 }, { 130, 80, 60 }, { 50, 180, 60 }, { 50, 80, 60 } };
        static int[,] coord_octo8p = { { 45, 80, 50 }, { 115, 80, 50 }, { 115, 160, 50 }, { 45, 160, 50 }, { 80, 60, 50 }, { 145, 120, 50 }, { 80, 180, 50 }, { 15, 120, 50 } };
        static int[,] coord_octo8x = { { 30, 80, 50 }, { 100, 60, 50 }, { 130, 150, 50 }, { 60, 170, 50 }, { 60, 60, 50 }, { 130, 80, 50 }, { 100, 170, 50 }, { 30, 150, 50 } };
        static int[,] coord_airplane = { { 15, 125, 70 }, { 130, 125, 70 }, { 5, 170, 70 }, { 80, 167, 70 }, { 80, 75, 70 } };
        static int[,] coord_heli120 = { { 85, 105, 70 }, { 50, 95, 70 }, { 75, 155, 70 }, { 120, 95, 70 }, { 10, 150, 110 } };
        static int[,] coord_heli90 = { { 85, 105, 70 }, { 120, 95, 70 }, { 75, 155, 70 }, { 50, 95, 70 }, { 10, 150, 100 } };
        static int[,] coord_vtail = { { 95, 170, 70 }, { 120, 80, 70 }, { 50, 170, 70 }, { 20, 80, 70 } };

        static CopterType CopterTypeToDraw = CopterType.QuadP;
        private static int[] motorvals = {1500,1500,1500,1500,1500,1500,1500,1500};
        private static int[] servovals = { 1500, 1500, 1500, 1500, 1500, 1500, 1500, 1500 };

        private int l;
        private int i;
        private int hval;
        // Images

        Bitmap bmpQuadX = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.quadx);
        Bitmap bmpQuadP = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.quadp);
        Bitmap bmpTri = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.tri);
        Bitmap bmpY6 = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.y6);
        Bitmap bmpY4 = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.y4);
        Bitmap bmpBi = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.bicopter);
        Bitmap bmpHex6 = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.hex6);
        Bitmap bmpHex6X = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.hex6x);
        Bitmap bmpFw = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.fw);
        Bitmap bmpGimbal = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.gimbal);
        Bitmap bmpOcto8x = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.octo8x);
        Bitmap bmpOcto8p = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.octo8p);
        Bitmap bmpOcto8c = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.octo8coax);
        Bitmap bmpAirplane = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.airplane);
        Bitmap bmpHeli120 = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.heli_120);
        Bitmap bmpHeli90 = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.heli_90);
        Bitmap bmpVtail = new Bitmap(MultiWiiWinGUI.MWGUIControls.MWGUIControlsResources.vtail);

        
        #endregion

        #region Constructor

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public MWGUIMotors()
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

            // diplay mask
            Pen drawPen = new Pen(Color.White, 1);
            Pen maskPen = new Pen(this.BackColor, 5);
            System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 8.0F);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.SolidBrush drawBrushGreen = new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen);
            System.Drawing.SolidBrush drawBrushBlue = new System.Drawing.SolidBrush(System.Drawing.Color.LightBlue);


            switch (CopterTypeToDraw)
            {
                case CopterType.QuadX:
                    bmpQuadX.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpQuadX.Width, bmpQuadX.Height);
                    pe.Graphics.DrawImageUnscaled(bmpQuadX, 0, 0, bmpQuadX.Width, bmpQuadX.Height);
                    for (i = 0; i < 4; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_quadX[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_quadX[i, 0], coord_quadX[i, 1] - h, 10, h);
                        pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_quadX[i, 0] + 12, coord_quadX[i, 1] - 10);
                    }
                    break;
                case CopterType.QuadP:
                    bmpQuadP.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpQuadP.Width, bmpQuadP.Height);
                    pe.Graphics.DrawImageUnscaled(bmpQuadP, 0, 0, bmpQuadP.Width, bmpQuadP.Height);
                    for (i = 0; i < 4; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_quadP[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_quadP[i, 0], coord_quadP[i, 1] - h, 10, h);
                        pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_quadP[i, 0] + 12, coord_quadP[i, 1] - 10);
                    }
                    break;
                case CopterType.Tri:
                    bmpTri.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpTri.Width, bmpTri.Height);
                    pe.Graphics.DrawImageUnscaled(bmpTri, 0, 0, bmpTri.Width, bmpTri.Height);
                    for (i = 0; i < 3; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_tri[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_tri[i, 0], coord_tri[i, 1] - h, 10, h);
                        pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_tri[i, 0] + 12, coord_tri[i, 1] - 10);
                    }
                    l = (int)((servovals[5] - 900) * (float)(coord_tri[3, 2] / 1200.0f));
                    pe.Graphics.FillRectangle(drawBrushGreen, coord_tri[3, 0], coord_tri[3, 1] - 10, l, 10);
                    pe.Graphics.DrawString(String.Format("{0:0}", servovals[5]), drawFont, drawBrush, coord_tri[3, 0], coord_tri[3, 1]);  
                    break;
                case CopterType.Gimbal:
                    bmpGimbal.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpGimbal.Width, bmpGimbal.Height);
                    pe.Graphics.DrawImageUnscaled(bmpGimbal, 0, 0, bmpGimbal.Width, bmpGimbal.Height);
                    for (i = 0; i < 2; i++)
                    {
                        l = (int)((servovals[i+1] - 900) * (float)(coord_gimbal[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_gimbal[i, 0], coord_gimbal[i, 1] - 10, l, 10);
                        pe.Graphics.DrawString(String.Format("{0:0}", servovals[i + 1]), drawFont, drawBrush, coord_gimbal[i, 0], coord_gimbal[i, 1]);
                    }
                    break;
                case CopterType.Y6:
                    bmpY6.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpY6.Width, bmpY6.Height);
                    pe.Graphics.DrawImageUnscaled(bmpY6, 0, 0, bmpY6.Width, bmpY6.Height);
                    for (i = 0; i < 6; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_y6[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_y6[i, 0], coord_y6[i, 1] - h, 9, h);
                        if (i < 3)
                        {
                            pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_y6[i, 0] + 9, coord_y6[i, 1] - 73);
                        }
                        else
                        {
                            pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_y6[i, 0] + 9, coord_y6[i, 1] - 11);
                        }
                    }
                    break;
                case CopterType.Y4:
                    bmpY4.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpY4.Width, bmpY4.Height);
                    pe.Graphics.DrawImageUnscaled(bmpY4, 0, 0, bmpY4.Width, bmpY4.Height);
                    for (i = 0; i < 4; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_y4[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_y4[i, 0], coord_y4[i, 1] - h, 10, h);
                        pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_y4[i, 0] + 12, coord_y4[i, 1] - 10);
                    }
                    break;
                case CopterType.BI:
                    bmpBi.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpBi.Width, bmpBi.Height);
                    pe.Graphics.DrawImageUnscaled(bmpBi, 0, 0, bmpBi.Width, bmpBi.Height);
                    for (i = 0; i < 2; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_bi[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_bi[i, 0], coord_bi[i, 1] - h, 10, h);
                        pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_bi[i, 0] + 12, coord_bi[i, 1] - 10);
                    }
                    for (i = 0; i < 2; i++)
                    {
                        l = (int)((servovals[i] - 900) * (float)(coord_bi[2+i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_bi[2+i, 0], coord_bi[2+i, 1] - 10, l, 10);
                        pe.Graphics.DrawString(String.Format("{0:0}", servovals[i]), drawFont, drawBrush, coord_bi[2+i, 0], coord_bi[2+i, 1]);  //??? is servo 0 in new gui also?

                    }
                    break;
                case CopterType.Hex6:
                    bmpHex6.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpHex6.Width, bmpHex6.Height);
                    pe.Graphics.DrawImageUnscaled(bmpHex6, 0, 0, bmpHex6.Width, bmpHex6.Height);
                    for (i = 0; i < 6; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_hex6[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_hex6[i, 0], coord_hex6[i, 1] - h, 10, h);
                        pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_hex6[i, 0] + 9, coord_hex6[i, 1] - 12);
                    }
                    break;
                case CopterType.Hex6X:
                    bmpHex6X.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpHex6X.Width, bmpHex6X.Height);
                    pe.Graphics.DrawImageUnscaled(bmpHex6X, 0, 0, bmpHex6X.Width, bmpHex6X.Height);
                    for (i = 0; i < 6; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_hex6x[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_hex6x[i, 0], coord_hex6x[i, 1] - h, 10, h);
                        if (i > 3) { pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_hex6x[i, 0] - 12, coord_hex6x[i, 1] + 8); }
                        else { pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_hex6x[i, 0] +9, coord_hex6x[i, 1] - 12); }
                    }
                    break;
                case CopterType.FlyWing:
                    bmpFw.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpFw.Width, bmpFw.Height);
                    pe.Graphics.DrawImageUnscaled(bmpFw, 0, 0, bmpFw.Width, bmpFw.Height);
                    int bar = (int)((motorvals[0] - 900) * (float)(coord_wing[0, 2] / 1200.0f));
                    pe.Graphics.FillRectangle(drawBrushGreen, coord_wing[0, 0], coord_wing[0, 1] - bar, 10, bar);
                    pe.Graphics.DrawString(String.Format("{0:0}", motorvals[0]), drawFont, drawBrush, coord_wing[0, 0] + 12, coord_wing[0, 1] - 10);
                    for (i = 1; i < 3; i++)
                    {
                        int h = (int)((servovals[i] - 900) * (float)(coord_wing[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_wing[i, 0], coord_wing[i, 1] - h, 10, h);
                        pe.Graphics.DrawString(String.Format("{0:0}", servovals[i]), drawFont, drawBrush, coord_wing[i, 0] + 12, coord_wing[i, 1] - 10);
                    }
                    break;
                case CopterType.Octo8Coax:
                    bmpOcto8c.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpOcto8c.Width, bmpOcto8c.Height);
                    pe.Graphics.DrawImageUnscaled(bmpOcto8c, 0, 0, bmpOcto8c.Width, bmpOcto8c.Height);
                    for (i = 0; i < 8; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_octo8c[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_octo8c[i, 0], coord_octo8c[i, 1] - h, 10, h);
                        pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_octo8c[i, 0] -12, coord_octo8c[i, 1]);
                    }
                    break;
                case CopterType.Octo8P:
                    bmpOcto8p.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpOcto8p.Width, bmpOcto8p.Height);
                    pe.Graphics.DrawImageUnscaled(bmpOcto8p, 0, 0, bmpOcto8p.Width, bmpOcto8p.Height);
                    for (i = 0; i < 8; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_octo8p[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_octo8p[i, 0], coord_octo8p[i, 1] - h, 10, h);
                        pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_octo8p[i, 0] - 12, coord_octo8p[i, 1]+8);
                    }
                    break;
                case CopterType.Octo8X:
                    bmpOcto8x.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpOcto8x.Width, bmpOcto8x.Height);
                    pe.Graphics.DrawImageUnscaled(bmpOcto8x, 0, 0, bmpOcto8x.Width, bmpOcto8x.Height);
                    for (i = 0; i < 8; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_octo8x[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_octo8x[i, 0], coord_octo8x[i, 1] - h, 10, h);
                        pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_octo8x[i, 0] - 12, coord_octo8x[i, 1]+8);
                    }
                    break;
                case CopterType.Vtail:
                    bmpVtail.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpVtail.Width, bmpVtail.Height);
                    pe.Graphics.DrawImageUnscaled(bmpVtail, 0, 0, bmpVtail.Width, bmpVtail.Height);
                    for (i = 0; i < 4; i++)
                    {
                        int h = (int)((motorvals[i] - 900) * (float)(coord_y4[i, 2] / 1200.0f));
                        pe.Graphics.FillRectangle(drawBrushGreen, coord_y4[i, 0], coord_y4[i, 1] - h, 10, h);
                        pe.Graphics.DrawString(String.Format("{0:0}", motorvals[i]), drawFont, drawBrush, coord_y4[i, 0] + 12, coord_y4[i, 1] - 10);
                    }
                    break;
                case CopterType.Airplane:
                    bmpAirplane.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpAirplane.Width, bmpAirplane.Height);
                    pe.Graphics.DrawImageUnscaled(bmpAirplane, 0, 0, bmpAirplane.Width, bmpAirplane.Height);

                    hval = (int)((servovals[3] - 900) * (float)(coord_airplane[0, 2] / 1200.0f));          //Wing1
                    pe.Graphics.FillRectangle(drawBrushGreen, coord_airplane[0, 0], coord_airplane[0, 1] - hval, 10, hval);
                    pe.Graphics.DrawString(String.Format("{0:0}", servovals[3]), drawFont, drawBrush, coord_airplane[0, 0] + 12, coord_airplane[0, 1] - 10);

                    hval = (int)((servovals[4] - 900) * (float)(coord_airplane[1, 2] / 1200.0f));          //Wing2
                    pe.Graphics.FillRectangle(drawBrushGreen, coord_airplane[1, 0], coord_airplane[1, 1] - hval, 10, hval);
                    pe.Graphics.DrawString(String.Format("{0:0}", servovals[4]), drawFont, drawBrush, coord_airplane[1, 0] + 12, coord_airplane[1, 1] - 10);

                    hval = (int)((servovals[5] - 900) * (float)(coord_airplane[2, 2] / 1200.0f));          //Rudder
                    pe.Graphics.FillRectangle(drawBrushGreen, coord_airplane[2, 0], coord_airplane[2, 1] - 10, hval, 10);
                    pe.Graphics.DrawString(String.Format("{0:0}", servovals[5]), drawFont, drawBrush, coord_airplane[2, 0], coord_airplane[2, 1] + 10);

                    hval = (int)((servovals[6] - 900) * (float)(coord_airplane[3, 2] / 1200.0f));          //Elevator
                    pe.Graphics.FillRectangle(drawBrushGreen, coord_airplane[3, 0], coord_airplane[3, 1] - hval, 10, hval);
                    pe.Graphics.DrawString(String.Format("{0:0}", servovals[6]), drawFont, drawBrush, coord_airplane[3, 0] + 12, coord_airplane[3, 1] - 12);

                    hval = (int)((servovals[7] - 900) * (float)(coord_airplane[4, 2] / 1200.0f));          //Throttle
                    pe.Graphics.FillRectangle(drawBrushGreen, coord_airplane[4, 0], coord_airplane[4, 1] - hval, 10, hval);
                    pe.Graphics.DrawString(String.Format("{0:0}", servovals[7]), drawFont, drawBrush, coord_airplane[4, 0] + 12, coord_airplane[4, 1] - 10);
                    break;
                case CopterType.Heli120:
                    bmpHeli120.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpHeli120.Width, bmpHeli120.Height);
                    pe.Graphics.DrawImageUnscaled(bmpHeli120, 0, 0, bmpHeli120.Width, bmpHeli120.Height);

                    for (i = 0; i <= 4; i++)
                    {
                        hval = (int)((servovals[3 + i] - 900) * (float)(coord_heli120[i, 2] / 1200.0f));
                        if (i == 2) pe.Graphics.FillRectangle(drawBrushGreen, coord_heli120[i, 0], coord_heli120[i, 1] - 10, hval, 10);
                        else pe.Graphics.FillRectangle(drawBrushGreen, coord_heli120[i, 0], coord_heli120[i, 1] - hval, 10, hval);
                        pe.Graphics.DrawString(String.Format("{0:0}", servovals[3 + i]), drawFont, drawBrush, coord_heli120[i, 0], coord_heli120[i, 1] + 10);

                    }
                    break;

                case CopterType.Heli90:
                    bmpHeli90.MakeTransparent(Color.Yellow);
                    pe.Graphics.DrawRectangle(maskPen, 0, 0, bmpHeli90.Width, bmpHeli90.Height);
                    pe.Graphics.DrawImageUnscaled(bmpHeli90, 0, 0, bmpHeli90.Width, bmpHeli90.Height);

                    for (i = 0; i <= 4; i++)
                    {
                        hval = (int)((servovals[3 + i] - 900) * (float)(coord_heli90[i, 2] / 1200.0f));
                        if (i == 2) pe.Graphics.FillRectangle(drawBrushGreen, coord_heli90[i, 0], coord_heli90[i, 1] - 10, hval, 10);
                        else pe.Graphics.FillRectangle(drawBrushGreen, coord_heli90[i, 0], coord_heli90[i, 1] - hval, 10, hval);
                        pe.Graphics.DrawString(String.Format("{0:0}", servovals[3 + i]), drawFont, drawBrush, coord_heli90[i, 0], coord_heli120[i, 1] + 10);

                    }
                    break;








            }
            
            //Disposing graph objects
            drawPen.Dispose();
            maskPen.Dispose();
            drawFont.Dispose();
            drawBrush.Dispose();
            drawBrushGreen.Dispose();
            drawBrushBlue.Dispose();





        }






        #endregion

        #region Methods

        /*        // Parameters
        int Heading;            //Heading to Home
        int Distance;           //Distance to Home
        int Numsat;             //Number of Sats
        bool GPS_fix;           //GPS Fix (color of the sat symbol)
        bool GPS_home;          //GPS Home is set (left led)
        bool GPS_pkt;           //Hearthbeet (right led)

*/



        /// <summary>
        /// Define the physical value to be displayed on the indicator
        /// </summary>
        /// <param name="aircraftHeading">The aircraft heading in °deg</param>
        public void SetMotorsIndicatorParameters(int[] motor_values,int[] servo_values,int MultiType)
        {
            motorvals = motor_values;
            servovals = servo_values;
            CopterTypeToDraw = (CopterType)MultiType;
            this.Refresh();
        }

        #endregion
    }
}
