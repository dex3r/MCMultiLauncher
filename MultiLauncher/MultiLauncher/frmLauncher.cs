using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MultiLauncher.Serializing;
using MultiLauncher.Network;

namespace MultiLauncher
{
    public partial class frmLauncher : Form
    {
        public frmLauncher()
        {
            InitializeComponent();

            settings = new LauncherSettings();
            load();
            new Server();
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
