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
    /// <summary>
    /// Custom iLogic-Form Sample - Basic
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// Name of current filter component
        /// </summary>
        public string _FilterType;
        /// <summary>
        /// List names of all available filter components
        /// </summary>
        public List<string> _Filters;
        /// <summary>
        /// Used to enable/disable Update Model command
        /// </summary>
        public bool _UpdateRequired;
        /// <summary>
        /// Preview Image - selected component
        /// </summary>
        public Image _Thumbnail;
        /// <summary>
        /// All preview images
        /// </summary>
        public Dictionary<String, Image> _Thumbnails;
        private ImageList _ThumbnailList = new ImageList();
        /// <summary>
        /// iLogic Document - ThisDoc
        /// </summary>
        public iLogic.ICadDoc _Doc;
        /// <summary>
        /// Rule to be called from dialog
        /// </summary>
        public iLogic.iLogicRule _Rule;
        /// <summary>
        /// Share iLogic Automation runtime to a dialog 
        /// </summary>
        public iLogicAuto.iLogicAutomationNonCOM _Auto;

        /// <summary>
        /// 
        /// </summary>
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
