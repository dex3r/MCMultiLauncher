using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultiLauncher.GUI
{
    public partial class xForm : Form
    {
        public xForm()
        {
            InitializeComponent();
            xInit();

            graphicalOverlay1.Owner = this;
            tShowUp.Interval = 50;
        }

        public void xInit()
        {
            string text = this.Text;
            System.Drawing.Size size = this.Size;

            this.SuspendLayout();
            this.Text = "";
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ResumeLayout(false);

            lTitle.Text = text;
            this.DoubleBuffered = false;
            this.Opacity = 0.00001D;
            tShowUp.Tick += new EventHandler(tShowUp_Tick);
            tShowUp.Start();
        }

        void tShowUp_Tick(object sender, EventArgs e)
        {
            if (initOpacity)
            {
                this.Opacity = 0;
                this.initOpacity = false;
            }
            else if (this.Opacity < 0.2D)
            {
                this.Opacity += 0.015D;
            }
            else if (this.Opacity < 0.5D)
            {
                this.Opacity += 0.025D;
            }
            else if (this.Opacity < 0.98D)
            {
                this.Opacity += 0.05D;
            }
            else
            {
                this.Opacity = defaultOpacity;
                tShowUp.Stop();
            }
        }

        Timer tShowUp = new Timer();
        double defaultOpacity = 0.985D;
        bool initOpacity = true;

        private bool isMouseDown = false;
        int startFormX = 0;
        int startFormY = 0;
        int startCursorX = 0;
        int startCursorY = 0;

        private void TitleMouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            startFormX = this.Location.X;
            startFormY = this.Location.Y;
            startCursorX = Cursor.Position.X;
            startCursorY = Cursor.Position.Y;
            this.Opacity = 0.9D;
        }

        private void TitleMouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            this.Opacity = defaultOpacity;
        }

        private void TitleMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(startFormX + (Cursor.Position.X - startCursorX), startFormY + (Cursor.Position.Y - startCursorY));
            }
        }

        private void xForm_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void graphicalOverlay1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //g.DrawLine(new Pen(new SolidBrush(Color.Black), 1.0F), new Point(1, 1), new Point(1, 50));
            //g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            g.DrawRectangle(new Pen(new SolidBrush(Color.LightGray), 3.0F), 0, 0, this.Size.Width - 1, this.Size.Height - 1);
            //g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
        }

        private const int cGrip = 16;      // Grip size

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void xForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > this.Size.Width - 10 && e.Y > this.Size.Height - 10)
            {
                Cursor.Current = Cursors.SizeNWSE;
            }
            else
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
