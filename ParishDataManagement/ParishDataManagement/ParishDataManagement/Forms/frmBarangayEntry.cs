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
    public partial class frmBarangayEntry : Form
    {
        Barangay newBarangay = new Barangay();
        String strQuery = "SELECT * FROM tblBarangay";

        public frmBarangayEntry()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboTownName.Text))
            {
                MessageBox.Show("Please select a town.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTownName.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtBarangayName.Text))
            {
                MessageBox.Show("Please specify a barangay name.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBarangayName.Focus();
                return;
            }

            SetDataToBarangay();

            newBarangay.AddNew(newBarangay);
            MessageBox.Show("New record has been successfully saved.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Procedure.PopulateListView(lstBarangay, strQuery);
        }

        public void SetDataToBarangay()
        {
            newBarangay.TownID = Convert.ToInt16(cboTownName.SelectedValue.ToString());
            newBarangay.PlaceName = txtBarangayName.Text;
        }

        private void frmBarangayEntry_Load(object sender, EventArgs e)
        {
            String strQueryBarangay = "SELECT * FROM tblBarangay";
            String strQuery = "SELECT TownID,TownName FROM tblTown where TownName = 'Loon' ORDER BY TownName ASC";
            Procedure.PopulateComboBox(cboTownName, strQuery, "tblTown", "TownName", "TownID");
            Procedure.PopulateListView(lstBarangay, strQueryBarangay);
        }

        private void cboTownName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
