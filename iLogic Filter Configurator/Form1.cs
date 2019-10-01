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
    public partial class Form1 : Form
    {
        public string _FilterType;
        public List<string> _Filters;
        public bool _UpdateRequired;
        public Image _Thumbnail;
        public List<Image> _Thumbnails;
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
            cmbFilterType.SelectedItem = _FilterType;
        }

        private void cmbFilterTyple_SelectionChanged(object sender, EventArgs e)
        {
            _FilterType = cmbFilterType.SelectedItem.ToString();
            _Auto.RunRule(_Doc.Document, "Enable_UpdateModel");
            btnUpdate.Enabled = _UpdateRequired;
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
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _Auto.RunRule(_Doc.Document, "UpdateModel");
        }
    }
}
