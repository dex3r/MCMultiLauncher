using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using MultiLauncher.Serializing;
using System.IO;

namespace MultiLauncher_Patcher
{
    public partial class frmPatcher : Form
    {
        public frmPatcher()
        {
            InitializeComponent();
            load();
        }

        //public Systems system;
        public Version newVersion = new Version(0, 0, 0, 0);
        public PatcherSettings settings;

        private void error(string txt)
        {
            MessageBox.Show(txt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmPatcher_Shown(object sender, EventArgs e)
        {
            //system = SystemDetection.System;
            lCurrent.Text = "";
#if DEBUG
            //runLauncher();
#endif
            lStatus.Text = "Checking for updates...";
            if (checkVersion())
            {
                lStatus.Text = "Downloading updates...";
            }
            lStatus.Text = "Patcher is up to date";
            lCurrent.Text = "Launching the Launcher";
            //runLauncher();
#if !DEBUG
            //this.Close();
#endif
        }

        private bool checkVersion()
        {
            //TODO: dodać pobieranie wersji

            try
            {
                using (FileStream fs = File.OpenRead("Data/newVersion"))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string[] sv = sr.ReadLine().Split('.');
                        int[] vers = new int[4];
                        for (int i = 0; i < vers.Length; i++)
                        {
                            vers[i] = int.Parse(sv[i]);
                        }
                        newVersion = new Version(vers[0], vers[1], vers[2], vers[3]);
                    }
                }
            }
            catch (Exception ex)
            {
                error(ex.Message);
                return false;
            }

            if (newVersion.CompareTo(settings.ver) > 0)
            {
                return true;
            }
            return false;
        }

        private void runLauncher()
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("MultiLauncher.exe");
            p.StartInfo.Arguments = "updated";
            p.Start();
        }

        public void load()
        {
            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }
            settings = Serializer.DeSerializeObject<PatcherSettings>("Data/version");
            if (settings == null)
            {
                settings = new PatcherSettings();
            }
        }

        public void save()
        {
            Serializer.SerializeObject("Data/version", settings);
        }

        private void frmPatcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            save();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
