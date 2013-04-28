﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MultiLauncher.GUI;
using MultiLauncher.Serializing;

namespace MultiLauncher
{
    public partial class frmLauncher : xForm
    {
        public frmLauncher()
        {
            InitializeComponent();
            xInit();

            settings = new LauncherSettings();
            load();
        }

        public LauncherSettings settings;

        public void save()
        {
            Serializer.SerializeObject("settings.dat", settings);
        }

        public void load()
        {
            settings = Serializer.DeSerializeObject<LauncherSettings>("settings.dat");
        }

        private void frmLauncher_FormClosed(object sender, FormClosedEventArgs e)
        {
            save();
        }
    }
}
