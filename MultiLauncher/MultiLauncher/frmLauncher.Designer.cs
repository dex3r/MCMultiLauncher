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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLauncher));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.newsPage = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bTags = new System.Windows.Forms.Button();
            this.cbSClient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bSearch = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbSAutoSearch = new System.Windows.Forms.ToolStripButton();
            this.cbSAutoSearch = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 701);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.newsPage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 704);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "News";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // newsPage
            // 
            this.newsPage.AllowNavigation = false;
            this.newsPage.AllowWebBrowserDrop = false;
            this.newsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsPage.IsWebBrowserContextMenuEnabled = false;
            this.newsPage.Location = new System.Drawing.Point(3, 3);
            this.newsPage.MinimumSize = new System.Drawing.Size(20, 20);
            this.newsPage.Name = "newsPage";
            this.newsPage.Size = new System.Drawing.Size(994, 698);
            this.newsPage.TabIndex = 0;
            this.newsPage.Url = new System.Uri("", System.UriKind.Relative);
            this.newsPage.WebBrowserShortcutsEnabled = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Servers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(994, 669);
            this.splitContainer1.SplitterDistance = 76;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSAutoSearch);
            this.groupBox1.Controls.Add(this.bSearch);
            this.groupBox1.Controls.Add(this.bTags);
            this.groupBox1.Controls.Add(this.cbSClient);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbSType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbSState);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSCountry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSServerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // bTags
            // 
            this.bTags.Location = new System.Drawing.Point(803, 29);
            this.bTags.Name = "bTags";
            this.bTags.Size = new System.Drawing.Size(75, 23);
            this.bTags.TabIndex = 12;
            this.bTags.Text = "Select Tags";
            this.bTags.UseVisualStyleBackColor = true;
            // 
            // cbSClient
            // 
            this.cbSClient.DisplayMember = "sad";
            this.cbSClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSClient.FormattingEnabled = true;
            this.cbSClient.Location = new System.Drawing.Point(655, 31);
            this.cbSClient.Name = "cbSClient";
            this.cbSClient.Size = new System.Drawing.Size(142, 21);
            this.cbSClient.TabIndex = 11;
            this.cbSClient.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Client:";
            // 
            // cbSType
            // 
            this.cbSType.DisplayMember = "sad";
            this.cbSType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSType.FormattingEnabled = true;
            this.cbSType.Location = new System.Drawing.Point(507, 31);
            this.cbSType.Name = "cbSType";
            this.cbSType.Size = new System.Drawing.Size(142, 21);
            this.cbSType.TabIndex = 8;
            this.cbSType.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbSType_DrawItem);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type:";
            // 
            // cbSState
            // 
            this.cbSState.DisplayMember = "sad";
            this.cbSState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSState.FormattingEnabled = true;
            this.cbSState.Location = new System.Drawing.Point(393, 31);
            this.cbSState.Name = "cbSState";
            this.cbSState.Size = new System.Drawing.Size(108, 21);
            this.cbSState.TabIndex = 5;
            this.cbSState.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbSState_DrawItem);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current state:";
            // 
            // cbSCountry
            // 
            this.cbSCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSCountry.FormattingEnabled = true;
            this.cbSCountry.Location = new System.Drawing.Point(227, 31);
            this.cbSCountry.Name = "cbSCountry";
            this.cbSCountry.Size = new System.Drawing.Size(160, 21);
            this.cbSCountry.TabIndex = 3;
            this.cbSCountry.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbSCountry_DrawItem);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country:";
            // 
            // tbSServerName
            // 
            this.tbSServerName.Location = new System.Drawing.Point(9, 32);
            this.tbSServerName.Name = "tbSServerName";
            this.tbSServerName.Size = new System.Drawing.Size(212, 20);
            this.tbSServerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1000, 704);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recommended Servers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1000, 704);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Log";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(884, 28);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 13;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1008, 730);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbSAutoSearch
            // 
            this.tbSAutoSearch.CheckOnClick = true;
            this.tbSAutoSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSAutoSearch.Image = ((System.Drawing.Image)(resources.GetObject("tbSAutoSearch.Image")));
            this.tbSAutoSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSAutoSearch.Name = "tbSAutoSearch";
            this.tbSAutoSearch.Size = new System.Drawing.Size(23, 22);
            this.tbSAutoSearch.Text = "toolStripButton1";
            // 
            // cbSAutoSearch
            // 
            this.cbSAutoSearch.AutoSize = true;
            this.cbSAutoSearch.Checked = true;
            this.cbSAutoSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSAutoSearch.Location = new System.Drawing.Point(884, 57);
            this.cbSAutoSearch.Name = "cbSAutoSearch";
            this.cbSAutoSearch.Size = new System.Drawing.Size(83, 17);
            this.cbSAutoSearch.TabIndex = 14;
            this.cbSAutoSearch.Text = "Auto search";
            this.cbSAutoSearch.UseVisualStyleBackColor = true;
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.splitContainer2);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiLauncher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLauncher_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.WebBrowser newsPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSType;
        private System.Windows.Forms.ComboBox cbSClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bTags;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.CheckBox cbSAutoSearch;
        private System.Windows.Forms.ToolStripButton tbSAutoSearch;















    }
}