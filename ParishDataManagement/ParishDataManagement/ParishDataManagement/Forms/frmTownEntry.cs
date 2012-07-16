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
    public partial class frmTownEntry : Form
    {
        Town newTown = new Town();
        byte flagCity = 1;

        public frmTownEntry()
        {
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            flagCity = 1;
            EnabledFields();  
        }

        private void SetDataToTown()
        {
            newTown.ProvinceID = Convert.ToInt16(cboProvName.SelectedValue.ToString());
            newTown.PlaceName = txtCityName.Text;
            newTown.Status = 0;
        }

        private void currDataToCity()
        {
            newTown.ProvinceID = Convert.ToInt16(cboProvName.SelectedValue.ToString());
            newTown.PlaceName = txtCityName.Text;
            newTown.Status = 0;
        }

        private void EnabledFields()
        {
            cboProvName.Enabled = true;
            txtCityName.Enabled = true;
           // cmdAdd.Enabled = false;  
        }

        private void DisplayTolsvCity()
        {
            String  qryCity = null;
            String strCityName;
            strCityName = cboProvName.Text;
            if (strCityName == "Abra")
            {
                qryCity = "SELECT TownID, tblTown.ProvinceID, TownName FROM tblTown inner join tblProvince on tblTown.ProvinceID = tblprovince.provinceID WHERE ProvinceName = '" + strCityName + "'";
                Procedure.PopulateListView(lsvCity, qryCity);
            }
            else
            {
                qryCity = "SELECT TownID, tblTown.ProvinceID, TownName FROM tblTown inner join tblProvince on tblTown.ProvinceID = tblprovince.provinceID WHERE ProvinceName = '" + cboProvName.Text + "'";
                Procedure.PopulateListView(lsvCity, qryCity);
            }
           
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCityName.Text))
            {
                MessageBox.Show("Please specify the city name.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCityName.Focus();
                return;
            }
            else
            {
                flagCity = 0;
            }
        }

        private void frmTownEntry_Load(object sender, EventArgs e)
        {
            PopulateProvinceCombo();
            DisplayTolsvCity();
        }

        private void PopulateProvinceCombo()
        {
            String qryProv = null;

            qryProv = "SELECT ProvinceID,ProvinceName FROM tblProvince ORDER BY ProvinceName ASC";
            Procedure.PopulateComboBox(cboProvName, qryProv, "tblProvince", "ProvinceName", "ProvinceID");
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCityName.Text))
            {
                MessageBox.Show("Please specify a city name.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCityName.Focus();
                return;
            }
            
            SetDataToTown();

            if (flagCity == 1)
            {
                newTown.AddNew(newTown);
                MessageBox.Show("New record has been successfully saved.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                currDataToCity();
                newTown.Update(newTown);
                MessageBox.Show("Record has been successfully edited.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtCityName.Text = "";
            DisplayTolsvCity();
        }

        private void cboProvName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTolsvCity();
        }
    }
}
