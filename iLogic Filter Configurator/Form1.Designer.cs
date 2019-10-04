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
            this.ctxMnuListView1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ctxMnuListView1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.ctxMnuListView1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(486, 309);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 2;
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
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(529, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuLayout
            // 
            this.mnuLayout.AutoToolTip = true;
            this.mnuLayout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListView,
            this.mnuLargeIcons,
            this.mnuSmallIcons});
            this.mnuLayout.Image = global::iLogic_Filter_Configurator.Resource1.Layout_16x16;
            this.mnuLayout.Name = "mnuLayout";
            this.mnuLayout.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mnuLayout.Size = new System.Drawing.Size(71, 24);
            this.mnuLayout.Text = "Layout";
            this.mnuLayout.ToolTipText = "Change list layout for available filter types.";
            this.mnuLayout.Click += new System.EventHandler(this.mnuLayout_Click);
            // 
            // mnuListView
            // 
            this.mnuListView.AutoToolTip = true;
            this.mnuListView.Checked = true;
            this.mnuListView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuListView.Name = "mnuListView";
            this.mnuListView.Size = new System.Drawing.Size(180, 22);
            this.mnuListView.Text = "List View";
            this.mnuListView.ToolTipText = "Small Icons + Name in rows";
            this.mnuListView.Click += new System.EventHandler(this.mnuListView_Click);
            // 
            // mnuLargeIcons
            // 
            this.mnuLargeIcons.AutoToolTip = true;
            this.mnuLargeIcons.Name = "mnuLargeIcons";
            this.mnuLargeIcons.Size = new System.Drawing.Size(180, 22);
            this.mnuLargeIcons.Text = "Large Icons";
            this.mnuLargeIcons.ToolTipText = "Large Icons Tiles +Name (below)";
            this.mnuLargeIcons.Click += new System.EventHandler(this.largeIconsToolStripMenuItem_Click);
            // 
            // mnuSmallIcons
            // 
            this.mnuSmallIcons.AutoToolTip = true;
            this.mnuSmallIcons.Name = "mnuSmallIcons";
            this.mnuSmallIcons.Size = new System.Drawing.Size(180, 22);
            this.mnuSmallIcons.Text = "Small Icons";
            this.mnuSmallIcons.ToolTipText = "Small Icon Tiles + Name (right)";
            this.mnuSmallIcons.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
            // 
            // mnuRefreshData
            // 
            this.mnuRefreshData.AutoToolTip = true;
            this.mnuRefreshData.Image = global::iLogic_Filter_Configurator.Resource1.Refresh_16;
            this.mnuRefreshData.Name = "mnuRefreshData";
            this.mnuRefreshData.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mnuRefreshData.Size = new System.Drawing.Size(74, 24);
            this.mnuRefreshData.Text = "Refresh";
            this.mnuRefreshData.ToolTipText = "Reload part family and thumbnails from Vault.";
            this.mnuRefreshData.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // mnuUpdateModel
            // 
            this.mnuUpdateModel.AutoToolTip = true;
            this.mnuUpdateModel.Image = global::iLogic_Filter_Configurator.Resource1.Update_16x16;
            this.mnuUpdateModel.Name = "mnuUpdateModel";
            this.mnuUpdateModel.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mnuUpdateModel.Size = new System.Drawing.Size(110, 24);
            this.mnuUpdateModel.Text = "Update Model";
            this.mnuUpdateModel.ToolTipText = "Replace current filter by selected filter type.";
            this.mnuUpdateModel.Click += new System.EventHandler(this.updateModelToolStripMenuItem_Click);
            // 
            // txtCurrentFilter
            // 
            this.txtCurrentFilter.BackColor = System.Drawing.SystemColors.Info;
            this.txtCurrentFilter.Location = new System.Drawing.Point(123, 41);
            this.txtCurrentFilter.Name = "txtCurrentFilter";
            this.txtCurrentFilter.ReadOnly = true;
            this.txtCurrentFilter.Size = new System.Drawing.Size(387, 20);
            this.txtCurrentFilter.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Filter";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(18, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 328);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Filter";
            // 
            // ctxMnuListView1
            // 
            this.ctxMnuListView1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateModelToolStripMenuItem});
            this.ctxMnuListView1.Name = "ctxMnuListView1";
            this.ctxMnuListView1.Size = new System.Drawing.Size(150, 26);
            // 
            // updateModelToolStripMenuItem
            // 
            this.updateModelToolStripMenuItem.AutoToolTip = true;
            this.updateModelToolStripMenuItem.Image = global::iLogic_Filter_Configurator.Resource1.Update_16x16;
            this.updateModelToolStripMenuItem.Name = "updateModelToolStripMenuItem";
            this.updateModelToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.updateModelToolStripMenuItem.Text = "Update Model";
            this.updateModelToolStripMenuItem.ToolTipText = "Replace current filter by selected filter type.";
            this.updateModelToolStripMenuItem.Click += new System.EventHandler(this.updateModelToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(529, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentFilter);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "iLogic-Vault | Select Filter from Vault...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ctxMnuListView1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ContextMenuStrip ctxMnuListView1;
        private System.Windows.Forms.ToolStripMenuItem updateModelToolStripMenuItem;
    }
}