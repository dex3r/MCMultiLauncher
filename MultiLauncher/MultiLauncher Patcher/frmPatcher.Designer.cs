namespace MultiLauncher_Patcher
{
    partial class frmPatcher
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
            this.lStatus = new System.Windows.Forms.Label();
            this.lCurrent = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(133, 9);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(117, 13);
            this.lStatus.TabIndex = 0;
            this.lStatus.Text = "Checking for updates...";
            // 
            // lCurrent
            // 
            this.lCurrent.AutoSize = true;
            this.lCurrent.Location = new System.Drawing.Point(12, 51);
            this.lCurrent.Name = "lCurrent";
            this.lCurrent.Size = new System.Drawing.Size(16, 13);
            this.lCurrent.TabIndex = 1;
            this.lCurrent.Text = "...";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 25);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(359, 23);
            this.pb1.TabIndex = 2;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(296, 64);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Cancel";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // frmPatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 99);
            this.ControlBox = false;
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lCurrent);
            this.Controls.Add(this.lStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPatcher";
            this.Text = "MultiLauncher Patcher v. 0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPatcher_FormClosing);
            this.Shown += new System.EventHandler(this.frmPatcher_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lCurrent;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.Button bClose;
    }
}