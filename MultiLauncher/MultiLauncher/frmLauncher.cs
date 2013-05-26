using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MultiLauncher.Serializing;
using MultiLauncher.Network;
using MultiLauncher.Properties;

namespace MultiLauncher
{
    public partial class frmLauncher : Form
    {
        public frmLauncher()
        {
            InitializeComponent();

            settings = new LauncherSettings();
            load();

            cbSCountry.Items.Add("Any");
            cbSCountry.Items.AddRange(Tags.countries);
            cbSCountry.SelectedIndex = 0;
            cbSCountry.ItemHeight = 18;

            cbSState.Items.Add("Any");
            cbSState.Items.AddRange(Tags.states);
            cbSState.SelectedIndex = 0;
            cbSState.ItemHeight = 18;

            cbSClient.Items.Add("Any");
            cbSClient.Items.AddRange(Tags.clients);
            cbSClient.SelectedIndex = 0;
            cbSClient.ItemHeight = 18;

            dgvServers.Rows.Add(new object[] { false, null, "Hello", "21/60", "1.4.7" });
            dgvServers.Rows.Add(new object[] { true, null, "DeX3r's extreme server 24/7", "212/500", "1.5.2" });
            dgvServers.Rows.Add(new object[] { true, null, "ForgeCraft1", "7/20", "1.5.2 Forge 7.8.0.710" });
            dgvServers.Rows.Add(new object[] { false, null, "Hello", "21/60", "1.4.7" });
            dgvServers.Rows.Add(new object[] { false, null, "Hello", "21/60", "1.4.7" });
            dgvServers.Rows.Add(new object[] { false, null, "Hello", "21/60", "1.4.7" });
            dgvServers.Rows.Add(new object[] { false, null, "Hello", "21/60", "1.4.7" });
            dgvServers.Rows.Add(new object[] { false, null, "Hello", "21/60", "1.4.7" });
        }

        public string[] countriesNames;
        public Image[] countriesFlags;

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

        private void cbSCountry_DrawItem(object sender, DrawItemEventArgs e)
        {
            drawCBWithImages(e, Tags.countries, null);

            Rectangle rectangle = new Rectangle(6, e.Bounds.Top + 2, 16, 16);
            Object o = null;
            if (e.Index > 0)
            {
                o = (Image)Resources.ResourceManager.GetObject(Tags.countries[e.Index - 1].Replace(' ', '_'));
                if(o != null)
                {
                    e.Graphics.DrawImage((Image)o, rectangle);
                }
            }
        }

        private void cbSState_DrawItem(object sender, DrawItemEventArgs e)
        {
            drawCBWithImages(e, Tags.states, new Image[] { Resources.full, Resources.not_empty, Resources.empty });
        }

        private void drawNormalCB(DrawItemEventArgs e, string[] options)
        {
            e.DrawBackground();

            Font myFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);
            string s = "Any";
            if (e.Index > 0)
            {
                s = options[e.Index - 1];
            }
            e.Graphics.DrawString(s, myFont, System.Drawing.Brushes.Black, new RectangleF(e.Bounds.X + 3, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));

            e.DrawFocusRectangle();
        }

        private void drawCBWithImages(DrawItemEventArgs e, string[] options, Image[] images)
        {
            float size = 8.25F;
            Font myFont;

            e.DrawBackground();

            Rectangle rectangle = new Rectangle(6, e.Bounds.Top + 2, 16, 16);
            if (images != null)
            {
                if (e.Index > 0)
                {
                    e.Graphics.DrawImage(images[e.Index - 1], rectangle);
                }
            }

            myFont = new Font("Microsoft Sans Serif", size, FontStyle.Regular);

            string s = "Any";
            if (e.Index > 0)
            {
                s = options[e.Index - 1];
            }
            e.Graphics.DrawString(s, myFont, System.Drawing.Brushes.Black, new RectangleF(e.Bounds.X + rectangle.Width + 7, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height));

            e.DrawFocusRectangle();
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            drawCBWithImages(e, Tags.clients, new Image[] { Resources.vanilla, Resources.modded });
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvServers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
