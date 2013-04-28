using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MultiLauncher.GUI
{
    public partial class xLabel : Label
    {
        public xLabel()
        {
            InitializeComponent();
            this.ForeColor = Color.Black;
        }

        //public xLabel(IContainer container)
        //{
        //    container.Add(this);

        //    InitializeComponent();
        //}
    }
}
