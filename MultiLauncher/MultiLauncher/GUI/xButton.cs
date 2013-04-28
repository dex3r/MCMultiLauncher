using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MultiLauncher.GUI
{
    public partial class xButton : Button
    {
        public xButton()
        {
            InitializeComponent();
            this.BackColor = Color.DeepSkyBlue;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            Font f = new Font(Button.DefaultFont, FontStyle.Bold);
            this.Font = f;
            this.ForeColor = Color.White;
        }
    }
}
