using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using System.Security.Cryptography.X509Certificates;

using System.Net;
using System.Net.Sockets;
using System.Xml; // config file
using System.Runtime.InteropServices; // dll imports
using ZedGraph; // Graphs
using System.Reflection;

using System.IO;

using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;

namespace MultiWiiWinGUI
{
    public class GMapMarkerRect : GMapMarker
    {
        public Pen Pen = new Pen(Brushes.White, 2);
        public Color Color { get { return Pen.Color; } set { Pen.Color = value; } }
        public GMapMarker InnerMarker;
        public int wprad = 0;
        public GMapControl MainMap;

        public GMapMarkerRect(PointLatLng p)
            : base(p)
        {
            Pen.DashStyle = DashStyle.Dot;
            Size = new System.Drawing.Size(50, 50);
            Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2 - 20);
        }

        public override void OnRender(Graphics g)
        {
            base.OnRender(g);

            if (wprad == 0 || MainMap == null)
                return;

            // undo autochange in mouse over
            if (Pen.Color == Color.Blue)
                Pen.Color = Color.White;

            double width = (MainMap.MapProvider.Projection.GetDistance(MainMap.FromLocalToLatLng(0, 0), MainMap.FromLocalToLatLng(MainMap.Width, 0)) * 1000.0);
            double height = (MainMap.MapProvider.Projection.GetDistance(MainMap.FromLocalToLatLng(0, 0), MainMap.FromLocalToLatLng(MainMap.Height, 0)) * 1000.0);
            double m2pixelwidth = MainMap.Width / width;
            double m2pixelheight = MainMap.Height / height;

            GPoint loc = new GPoint((int)(LocalPosition.X - (m2pixelwidth * wprad * 2)), LocalPosition.Y);// MainMap.FromLatLngToLocal(wpradposition);
            try
            {
                g.DrawArc(Pen, new System.Drawing.Rectangle((int)(LocalPosition.X - Offset.X - (Math.Abs(loc.X - LocalPosition.X) / 2)), (int)(LocalPosition.Y - Offset.Y - Math.Abs(loc.X - LocalPosition.X) / 2), (int)(Math.Abs(loc.X - LocalPosition.X)), (int)(Math.Abs(loc.X - LocalPosition.X))), 0, 360);
            }
            catch { }

        }
    }
    public class GMapMarkerCopter : GMapMarker
    {
        const float rad2deg = (float)(180 / Math.PI);
        const float deg2rad = (float)(1.0 / rad2deg);

        static readonly System.Drawing.Size SizeSt = new System.Drawing.Size(global::MultiWiiWinGUI.Properties.Resources.quadicon.Width, global::MultiWiiWinGUI.Properties.Resources.quadicon.Height);
        float heading = 0;
        float cog = -1;
        float target = -1;
        byte coptertype;

        public GMapMarkerCopter(PointLatLng p, float heading, float cog, float target, byte coptertype)
            : base(p)
        {
            this.heading = heading;
            this.cog = cog;
            this.target = target;
            this.coptertype = coptertype;
            Size = SizeSt;
        }

        public override void OnRender(Graphics g)
        {
            Matrix temp = g.Transform;
            g.TranslateTransform(LocalPosition.X, LocalPosition.Y);

            Image pic = global::MultiWiiWinGUI.Properties.Resources.marker_tri;


            switch (coptertype)
            {
                case 1:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_tri;
                    break;
                case 2:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_quadp;
                    break;
                case 3:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_quadx;
                    break;
                case 4:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_bi;
                    break;
                case 5:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_tri;
                    break;
                case 6:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_y6;
                    break;
                case 7:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_hex6p;
                    break;
                case 8:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_fwing;
                    break;
                case 9:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_y4;
                    break;
                case 10:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_hex6x;
                    break;
                case 11:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_octox8;
                    break;
                case 12:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_octoflatx;
                    break;
                case 13:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_oktoflatp;
                    break;
                case 14:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_airplane;
                    break;
                case 15:
                case 16:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_heli;
                    break;
                case 17:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_vtail4;
                    break;
                case 18:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_hex6x;
                    break;
                default:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_tri;
                    break;
            }

            int length = 100;
            // anti NaN
            g.DrawLine(new Pen(Color.Red, 2), 0.0f, 0.0f, (float)Math.Cos((heading - 90) * deg2rad) * length, (float)Math.Sin((heading - 90) * deg2rad) * length);
            //g.DrawLine(new Pen(Color.Black, 2), 0.0f, 0.0f, (float)Math.Cos((cog - 90) * deg2rad) * length, (float)Math.Sin((cog - 90) * deg2rad) * length);
            g.DrawLine(new Pen(Color.Orange, 2), 0.0f, 0.0f, (float)Math.Cos((target - 90) * deg2rad) * length, (float)Math.Sin((target - 90) * deg2rad) * length);
            // anti NaN
            g.RotateTransform(heading);
            g.DrawImageUnscaled(pic,pic.Width /-2, pic.Height/-2);
            g.Transform = temp;
        }
    }
    public class GMapMarkerFlyHere : GMapMarker
    {
        static readonly System.Drawing.Size SizeSt = new System.Drawing.Size(global::MultiWiiWinGUI.Properties.Resources.home_marker.Width, global::MultiWiiWinGUI.Properties.Resources.home_marker.Height);

        public GMapMarkerFlyHere(PointLatLng p)
            : base(p)
        {
            Size = SizeSt;
        }

        public override void OnRender(Graphics g)
        {
            Matrix temp = g.Transform;
            g.TranslateTransform(LocalPosition.X, LocalPosition.Y);
            Image pic = global::MultiWiiWinGUI.Properties.Resources.flight_here;
            g.DrawImageUnscaled(pic, pic.Width / -2 - 4, -pic.Height - 14);
            g.Transform = temp;

        }
    }

    public class GMapMarkerHome : GMapMarker
    {
        static readonly System.Drawing.Size SizeSt = new System.Drawing.Size(global::MultiWiiWinGUI.Properties.Resources.home_marker.Width, global::MultiWiiWinGUI.Properties.Resources.home_marker.Height);

        public GMapMarkerHome(PointLatLng p)
            : base(p)
        {
            Size = SizeSt;
        }

        public override void OnRender(Graphics g)
        {
            Matrix temp = g.Transform;
            g.TranslateTransform(LocalPosition.X, LocalPosition.Y);
            Image pic = global::MultiWiiWinGUI.Properties.Resources.home_marker;
            g.DrawImageUnscaled(pic, pic.Width / -2 - 4, -pic.Height - 14);
            g.Transform = temp;

        }
    }

    public class GMapMarkerMissionStep : GMapMarker
    {
        static readonly System.Drawing.Size SizeSt = new System.Drawing.Size(global::MultiWiiWinGUI.Properties.Resources.marker_poi.Width, global::MultiWiiWinGUI.Properties.Resources.marker_poi.Height);
        private byte number;
        private byte markertype;
        public GMapMarkerMissionStep(PointLatLng p, byte id, byte type)
            : base(p)
        {
            Size = SizeSt;
            number = id;
            markertype = type;
        }

        public override void OnRender(Graphics g)
        {
            Image pic;
            Matrix temp = g.Transform;
            g.TranslateTransform(LocalPosition.X, LocalPosition.Y);

            // Set graphics
            switch (markertype)
            {
                case WP_ACTION.WAYPOINT:
                    pic = global::MultiWiiWinGUI.Properties.Resources.map_point1;
                    break;
                case WP_ACTION.HOLD_UNLIM:
                    pic = global::MultiWiiWinGUI.Properties.Resources.poshold_markert;
                    break;
                case WP_ACTION.HOLD_TIME:
                    pic = global::MultiWiiWinGUI.Properties.Resources.timed_marker;
                    break;
                case WP_ACTION.SET_POI:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_poi;
                    break;
                case WP_ACTION.LAND:
                    pic = global::MultiWiiWinGUI.Properties.Resources.marker_land;
                    break;
                default:
                    pic = global::MultiWiiWinGUI.Properties.Resources.map_point1;
                    break;

            }

            g.DrawImageUnscaled(pic, pic.Width / -2 - 4, -pic.Height - 14);
            System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 9.0F, FontStyle.Bold);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);

            if (markertype == WP_ACTION.WAYPOINT)
            {
                drawBrush.Color = Color.Yellow;
                g.DrawString("WP", drawFont, drawBrush, -8, -51);
                drawBrush.Color = Color.White;
            }
            if (number < 10) g.DrawString(String.Format("{0:0}", number), drawFont, drawBrush, -5, -40);
            if (number < 100 && number > 9) g.DrawString(String.Format("{0:0}", number), drawFont, drawBrush, -8, -40);
            if (number > 100) g.DrawString(String.Format("{0:0}", number), drawFont, drawBrush, -12, -40);
            g.Transform = temp;

        }
    }

    public class Stuff
    {
        public static bool PingNetwork(string hostNameOrAddress)
        {
            bool pingStatus = false;

            using (Ping p = new Ping())
            {
                byte[] buffer = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                int timeout = 4444; // 4s

                try
                {
                    PingReply reply = p.Send(hostNameOrAddress, timeout, buffer);
                    pingStatus = (reply.Status == IPStatus.Success);
                }
                catch (Exception)
                {
                    pingStatus = false;
                }
            }

            return pingStatus;
        }
    }

    public class InputBox
    {
        public delegate void ThemeManager(Control ctl);

        public static event ThemeManager ApplyTheme;

        public static string value = "";

        //from http://www.csharp-examples.net/inputbox/
        public static DialogResult Show(string title, string promptText, ref string value, bool password = false)
        {
            DialogResult answer = DialogResult.Cancel;

            InputBox.value = value;
            string passin = value;

            // ensure we run this on the right thread - mono - mac
            if (Application.OpenForms.Count > 0 && Application.OpenForms[0].InvokeRequired)
            {
                Application.OpenForms[0].Invoke((MethodInvoker)delegate
                {
                    answer = ShowUI(title, promptText, passin, password);
                });
            }
            else
            {
                answer = ShowUI(title, promptText, passin, password);
            }

            value = InputBox.value;

            return answer;
        }

        static DialogResult ShowUI(string title, string promptText, string value, bool password = false)
        {
            Form form = new Form();
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            TextBox textBox = new TextBox();
            if (password)
                textBox.UseSystemPasswordChar = true;
            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonCancel = new System.Windows.Forms.Button();
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainV2));
            //form.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

            form.TopMost = true;
            form.TopLevel = true;

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            if (ApplyTheme != null)
                ApplyTheme(form);

            DialogResult dialogResult = DialogResult.Cancel;

            Console.WriteLine("Input Box " + System.Threading.Thread.CurrentThread.Name);

            Application.DoEvents();

            form.ShowDialog();

            Console.WriteLine("Input Box 2 " + System.Threading.Thread.CurrentThread.Name);

            dialogResult = form.DialogResult;

            if (dialogResult == DialogResult.OK)
            {
                value = textBox.Text;
                InputBox.value = value;
            }

            form.Dispose();

            form = null;

            return dialogResult;
        }
    }




}
