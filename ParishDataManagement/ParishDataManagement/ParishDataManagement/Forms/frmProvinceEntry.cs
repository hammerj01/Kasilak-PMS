using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParishDataManagement
{
    public partial class frmProvinceEntry : Form
    {
        Province newProvince = new Province();
        int iProvID;
        String strProvinceName;
        byte flagProvince = 1;
        public frmProvinceEntry()
        {
            InitializeComponent();
        }

        private void Province_Load(object sender, EventArgs e)
        {
            DisplayProvince();
        }

        public void DisplayProvince()
        { 
            String qryProvince = "SELECT * FROM tblProvince";
            Procedure.PopulateListView(lsvProvince, qryProvince);
        }

        private void setDataProvince()
        {
            newProvince.PlaceName = txtProvinceName.Text;
        }

        private void setCurrProvince()
        {
            newProvince.ProvinceID = iProvID;
            newProvince.PlaceName = txtProvinceName.Text;
        }
        
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            flagProvince = 1;
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProvinceName.Text))
            {
                MessageBox.Show("Please select a province name.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                flagProvince = 0;     
            }
        }

        private void lsvProvince_Click(object sender, EventArgs e)
        { 
            iProvID = Convert.ToInt16(lsvProvince.SelectedItems[0].SubItems[0].Text.ToString());
            strProvinceName = lsvProvince.SelectedItems[0].SubItems[1].Text.ToString();
            txtProvinceName.Text = strProvinceName;
            cmdEdit.Enabled = true;
        }

        private void cmdSave_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProvinceName.Text))
            {
                MessageBox.Show("Please specify a province name.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProvinceName.Focus();
                return;
            }

            setDataProvince();
            if (newProvince.IsExist("tblProvince","ProvinceName",newProvince))
            {
                MessageBox.Show("The information you entered already exist.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProvinceName.Focus();
                return;
            }
                if (flagProvince == 1)
                {
                    
                    newProvince.AddNew(newProvince);
                    MessageBox.Show("New record has been successfully saved.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setCurrProvince();
                    newProvince.Update(newProvince);
                    MessageBox.Show("Record has been successfully edited.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtProvinceName.Clear();
                DisplayProvince();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
