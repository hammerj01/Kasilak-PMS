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
    public partial class frmClusterEntry : Form
    {
        Cluster newCluster = new Cluster();
        String strQuery = "SELECT * FROM tblCluster";

        public frmClusterEntry()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataToComboBarangay()
        {
            String strQuery = "SELECT BarangayID,BarangayName FROM tblBarangay ORDER BY BarangayName ASC";
            Procedure.PopulateComboBox(cboBarangayName, strQuery, "tblBarangay", "BarangayName", "BarangayID");
        }

        private void LoadDataToComboChapel(String strBarangayName)
        {
            String strQuery = "SELECT ChapelID,ChapelName FROM tblChapel INNER JOIN tblBarangay ON tblChapel.BarangayID = tblBarangay.BarangayID" +
                              " WHERE BarangayName='" + strBarangayName + "'";

            Procedure.PopulateComboBox(cboChapelName, strQuery, "tblChapel", "ChapelName", "ChapelID");
        }

        private void frmClusterEntry_Load(object sender, EventArgs e)
        {
            LoadDataToComboBarangay();
            Procedure.PopulateListView(lstCluster, strQuery);
        }

        private void cboBarangayName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataToComboChapel(cboBarangayName.Text);
        }

        private void SetDataToCluster()
        {
            newCluster.ChapelID = Convert.ToInt16(cboChapelName.SelectedValue.ToString());
            newCluster.PlaceName = txtClusterName.Text;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboBarangayName.Text))
            {
                MessageBox.Show("Please select a barangay.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBarangayName.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cboChapelName.Text))
            {
                MessageBox.Show("Please select a chapel.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
               cboChapelName.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtClusterName.Text))
            {
                MessageBox.Show("Please select a chapel.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClusterName.Focus();
                return;
            }

            SetDataToCluster();

            newCluster.AddNew(newCluster);
            MessageBox.Show("New record has been successfully saved.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Procedure.PopulateListView(lstCluster, strQuery);
        }
    }
}
