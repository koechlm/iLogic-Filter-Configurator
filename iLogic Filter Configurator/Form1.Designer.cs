namespace iLogic_Filter_Configurator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDataRefresh = new System.Windows.Forms.Button();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLargeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSmallIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefreshData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateModel = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCurrentFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter Type";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(70, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(225, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Model";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(195, 344);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDataRefresh
            // 
            this.btnDataRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnDataRefresh.Image")));
            this.btnDataRefresh.Location = new System.Drawing.Point(271, 46);
            this.btnDataRefresh.Name = "btnDataRefresh";
            this.btnDataRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnDataRefresh.TabIndex = 4;
            this.btnDataRefresh.UseVisualStyleBackColor = true;
            this.btnDataRefresh.Click += new System.EventHandler(this.btnDataRefresh_Click);
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(70, 49);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(195, 21);
            this.cmbFilterType.TabIndex = 6;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterTyple_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 19);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 309);
            this.listView1.TabIndex = 8;
            this.listView1.TileSize = new System.Drawing.Size(50, 50);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "HYDAC-LFN_LFNF_40_IB.jpg");
            this.imageList1.Images.SetKeyName(1, "HYDAC-SWB-000.jpg");
            this.imageList1.Images.SetKeyName(2, "Parker Main FRL Unit.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLayout,
            this.mnuRefreshData,
            this.mnuUpdateModel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuLayout
            // 
            this.mnuLayout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListView,
            this.mnuLargeIcons,
            this.mnuSmallIcons});
            this.mnuLayout.Image = global::iLogic_Filter_Configurator.Resource1.Layout_16x16;
            this.mnuLayout.Name = "mnuLayout";
            this.mnuLayout.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mnuLayout.Size = new System.Drawing.Size(71, 24);
            this.mnuLayout.Text = "Layout";
            this.mnuLayout.Click += new System.EventHandler(this.mnuLayout_Click);
            // 
            // mnuListView
            // 
            this.mnuListView.Checked = true;
            this.mnuListView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuListView.Name = "mnuListView";
            this.mnuListView.Size = new System.Drawing.Size(134, 22);
            this.mnuListView.Text = "List View";
            this.mnuListView.Click += new System.EventHandler(this.mnuListView_Click);
            // 
            // mnuLargeIcons
            // 
            this.mnuLargeIcons.Name = "mnuLargeIcons";
            this.mnuLargeIcons.Size = new System.Drawing.Size(134, 22);
            this.mnuLargeIcons.Text = "Large Icons";
            this.mnuLargeIcons.Click += new System.EventHandler(this.largeIconsToolStripMenuItem_Click);
            // 
            // mnuSmallIcons
            // 
            this.mnuSmallIcons.Name = "mnuSmallIcons";
            this.mnuSmallIcons.Size = new System.Drawing.Size(134, 22);
            this.mnuSmallIcons.Text = "Small Icons";
            this.mnuSmallIcons.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
            // 
            // mnuRefreshData
            // 
            this.mnuRefreshData.Image = global::iLogic_Filter_Configurator.Resource1.Refresh_16;
            this.mnuRefreshData.Name = "mnuRefreshData";
            this.mnuRefreshData.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mnuRefreshData.Size = new System.Drawing.Size(74, 24);
            this.mnuRefreshData.Text = "Refresh";
            this.mnuRefreshData.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // mnuUpdateModel
            // 
            this.mnuUpdateModel.Image = global::iLogic_Filter_Configurator.Resource1.Update_16x16;
            this.mnuUpdateModel.Name = "mnuUpdateModel";
            this.mnuUpdateModel.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mnuUpdateModel.Size = new System.Drawing.Size(110, 24);
            this.mnuUpdateModel.Text = "Update Model";
            this.mnuUpdateModel.Click += new System.EventHandler(this.updateModelToolStripMenuItem_Click);
            // 
            // txtCurrentFilter
            // 
            this.txtCurrentFilter.BackColor = System.Drawing.SystemColors.Info;
            this.txtCurrentFilter.Location = new System.Drawing.Point(436, 49);
            this.txtCurrentFilter.Name = "txtCurrentFilter";
            this.txtCurrentFilter.ReadOnly = true;
            this.txtCurrentFilter.Size = new System.Drawing.Size(387, 20);
            this.txtCurrentFilter.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Filter";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(331, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 328);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(835, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.btnDataRefresh);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Select Filter from Vault";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDataRefresh;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuLayout;
        private System.Windows.Forms.ToolStripMenuItem mnuSmallIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuLargeIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshData;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateModel;
        private System.Windows.Forms.ToolStripMenuItem mnuListView;
        private System.Windows.Forms.TextBox txtCurrentFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}