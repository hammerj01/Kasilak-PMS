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
    public partial class frmChapelEntry : Form
    {
        Chapel newChapel = new Chapel();
        String strQuery = "SELECT * FROM tblChapel ORDER BY ChapelName ASC";

        public frmChapelEntry()
        {
            InitializeComponent();
        }

        private void frmChapelEntry_Load(object sender, EventArgs e)
        {
            String strQuery = "SELECT BarangayID,BarangayName FROM tblBarangay ORDER BY BarangayName ASC";
            Procedure.PopulateComboBox(cboBarangayName, strQuery, "tblBarangay", "BarangayName", "BarangayID");
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboBarangayName.Text))
            {
                MessageBox.Show("Please select a barangay name.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBarangayName.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtChapelName.Text))
            {
                MessageBox.Show("Please specify a chapel name.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChapelName.Focus();
                return;
            }

            SetDataToChapel();

            newChapel.AddNew(newChapel);
            MessageBox.Show("New record has been successfully saved.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Procedure.PopulateListView(lstChapel, strQuery);
        }

        private void SetDataToChapel()
        {
            newChapel.BarangayID = Convert.ToInt16(cboBarangayName.SelectedValue.ToString());
            newChapel.PlaceName = txtChapelName.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
