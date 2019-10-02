using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using iLogic = Autodesk.iLogic.Interfaces;
using iLogicAuto = Autodesk.iLogic.Automation;

namespace iLogic_Filter_Configurator
{
    public partial class Form1 : Form
    {
        public string _FilterType;
        public List<string> _Filters;
        public bool _UpdateRequired;
        public Image _Thumbnail;
        public Dictionary<String, Image> _Thumbnails;
        private ImageList _ThumbnailList = new ImageList();
        public iLogic.ICadDoc _Doc;
        public iLogic.iLogicRule _Rule;
        public iLogicAuto.iLogicAutomationNonCOM _Auto;
        public string _RuleName;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _Auto.RunRule(_Doc.Document, "Enable_UpdateModel");
            btnUpdate.Enabled = _UpdateRequired;
            cmbFilterType.Items.AddRange(_Filters.ToArray());
            cmbFilterType.SelectedIndex = cmbFilterType.Items.IndexOf(_FilterType);

            //listView1.InitializeLifetimeService();
            fillListView();
            listView1.View = View.List;
            mnuLargeIcons.Checked = false;
            mnuSmallIcons.Checked = false;
            mnuListView.Checked = true;

            txtCurrentFilter.Text = _FilterType;

            listView1.Select();
            listView1.HideSelection = false;
            listView1.Items[_FilterType].Selected = true;

        }

        private void fillListView()
        {
            ImageList imgListLarge = new ImageList();
            imgListLarge.ImageSize = new Size() { Height = 128, Width = 128 };
            ImageList imgListSmall = new ImageList();
            imgListSmall.ImageSize = new Size() { Height = 50, Width = 50 };
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size() { Height = 32, Width = 32 };

            foreach (var item in _Thumbnails)
            {
                imgListLarge.Images.Add(item.Key, item.Value);
                imgListSmall.Images.Add(item.Key, item.Value);
                imgList.Images.Add(item.Key, item.Value);
                listView1.LargeImageList = imgListLarge;
                listView1.SmallImageList = imgListSmall;

                listView1.Items.Add(new ListViewItem { ImageKey = item.Key, Text = item.Key, Name = item.Key });
            }
        }

        private void cmbFilterTyple_SelectionChanged(object sender, EventArgs e)
        {
            _FilterType = cmbFilterType.SelectedItem.ToString();
            _Auto.RunRule(_Doc.Document, "Enable_UpdateModel");
            btnUpdate.Enabled = _UpdateRequired;
            pictureBox1.Image = _Thumbnails[_FilterType];
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            _FilterType = cmbFilterType.SelectedText;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDataRefresh_Click(object sender, EventArgs e)
        {
            _Auto.RunRule(_Doc.Document, "DataRefresh");
            cmbFilterType.Items.Clear();
            cmbFilterType.Items.AddRange(_Filters.ToArray());
            cmbFilterType.Text = _FilterType;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _Auto.RunRule(_Doc.Document, "UpdateModel");
            mnuUpdateModel.Enabled = _UpdateRequired;
            txtCurrentFilter.Text = _FilterType;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Auto.RunRule(_Doc.Document, "DataRefresh");
            cmbFilterType.Items.Clear();
            cmbFilterType.Items.AddRange(_Filters.ToArray());
            cmbFilterType.Text = _FilterType;
            listView1.Items.Clear();
            fillListView();
        }

        private void updateModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Auto.RunRule(_Doc.Document, "UpdateModel");
            mnuUpdateModel.Enabled = _UpdateRequired;
            txtCurrentFilter.Text = _FilterType;
        }

        private void mnuLayout_Click(object sender, EventArgs e)
        {

        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuSmallIcons.Checked = true;
            mnuLargeIcons.Checked = false;
            mnuListView.Checked = false;
            listView1.View = View.SmallIcon;
        }

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuLargeIcons.Checked = true;
            mnuSmallIcons.Checked = false;
            mnuListView.Checked = false;
            listView1.View = View.LargeIcon;
        }

        private void mnuListView_Click(object sender, EventArgs e)
        {
            mnuLargeIcons.Checked = false;
            mnuSmallIcons.Checked = false;
            mnuListView.Checked = true;
            listView1.View = View.List;
        }

         private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _FilterType = e.Item.Name;
            _Auto.RunRule(_Doc.Document, "Enable_UpdateModel");
            mnuUpdateModel.Enabled = _UpdateRequired;
        }

    }
}
