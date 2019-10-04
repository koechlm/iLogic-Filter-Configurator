using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iLogic = Autodesk.iLogic.Interfaces;
using iLogicAuto = Autodesk.iLogic.Automation;

namespace iLogic_Filter_Configurator
{
    public partial class Form2 : Form
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

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _Auto.RunRule(_Doc.Document, "Enable_UpdateModel");
            btnUpdate.Enabled = _UpdateRequired;
            cmbFilterType.Items.AddRange(_Filters.ToArray());
            cmbFilterType.SelectedIndex = cmbFilterType.Items.IndexOf(_FilterType);
        }

        private void cmbFilterType_SelectionChanged(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _Auto.RunRule(_Doc.Document, "UpdateModel");
            btnUpdate.Enabled = _UpdateRequired;
        }
    }
}
