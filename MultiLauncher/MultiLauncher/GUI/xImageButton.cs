using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MultiLauncher.GUI
{
    public partial class xImageButton : Button
    {
        private static PictureBox pb = new PictureBox();
        public Image staticImage = pb.ErrorImage;
        public Image mouseOverImage = pb.ErrorImage;
        public Image mouseDownImage = pb.ErrorImage;

        public xImageButton()
        {
            InitializeComponent();
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Image = staticImage;
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Text = "";
#if DEBUG
            this.FlatAppearance.BorderSize = 1;
#else
            this.FlatAppearance.BorderSize = 0;
#endif
            this.FontHeight = 0;
        }
    }
}
