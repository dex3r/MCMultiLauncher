namespace MultiLauncher
{
    partial class frmLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xLabel2 = new MultiLauncher.GUI.xLabel();
            this.xLabel1 = new MultiLauncher.GUI.xLabel();
            this.SuspendLayout();
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(231, 242);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 13);
            this.xLabel2.TabIndex = 4;
            this.xLabel2.Text = "Password:";
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(229, 221);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(58, 13);
            this.xLabel1.TabIndex = 2;
            this.xLabel1.Text = "Username:";
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 373);
            this.ControlBox = true;
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.xLabel1);
            this.Name = "frmLauncher";
            this.Opacity = 0.985D;
            this.Text = "MultiLauncher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLauncher_FormClosed);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.xLabel2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MultiLauncher.GUI.xLabel xLabel2;
        private GUI.xLabel xLabel1;














    }
}