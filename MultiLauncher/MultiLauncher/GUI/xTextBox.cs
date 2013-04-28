using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MultiLauncher.GUI
{
    public partial class xTextBox : UserControl
    {
        private string text;
        public string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        TextBox textBox = new TextBox();
        public delegate void dTextChanged(object sender, EventArgs e);
        public event dTextChanged TextChanged;

        public xTextBox()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(UserControl1_Paint);
            this.Resize += new EventHandler(UserControl1_Resize);
            textBox.Multiline = false;
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = Color.FromArgb(240, 240, 240);
            this.Controls.Add(textBox);
            this.BackColor = textBox.BackColor;
            this.Size = new Size(200, 150);
            this.MinimumSize = new Size(10, 18);
            this.MaximumSize = new Size(500, 18);
            this.textBox.MinimumSize = this.MinimumSize;
            this.textBox.MaximumSize = this.MaximumSize;
            textBox.TextChanged += new EventHandler(textBox_TextChanged);
        }

        void textBox_TextChanged(object sender, EventArgs e)
        {
            //TextChanged(sender, e);
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            textBox.Size = new Size(this.Width - 4, this.Height - 4);
            textBox.Location = new Point(3, 2);
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ControlPaint.DrawBorder(g, this.ClientRectangle, Color.FromArgb(200, 200, 200), ButtonBorderStyle.Solid);
            ControlPaint.DrawBorder(g, new Rectangle(ClientRectangle.X + 1, ClientRectangle.Y + 1, ClientRectangle.Width - 2, ClientRectangle.Height - 2), Color.White, ButtonBorderStyle.Solid);

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);

        }
    }
}
