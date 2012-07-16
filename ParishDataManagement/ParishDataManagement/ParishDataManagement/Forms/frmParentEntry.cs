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
    public partial class frmParentEntry : Form
    {
        Person newPerson = new Person();
        Parent newParent = new Parent();


        public frmParentEntry()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SetDataToPerson();

            if (newPerson.PersonExist(newPerson))
            {
                MessageBox.Show("The information you entered already exist.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstname.Focus();
                return;
            }
            newPerson.AddNew(newPerson);

            newParent.PersonID = newPerson.GetPersonIDByName(newPerson);
            newParent.AddNew(newParent);

            MessageBox.Show("New record successfully saved.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void SetDataToPerson()
        {
            newPerson.Firstname = txtFirstname.Text;
            newPerson.Middlename = txtMiddlename.Text;
            newPerson.Lastname = txtLastname.Text;
            newPerson.Birthdate = Convert.ToString(dtBirthdate.Value);
            if (String.IsNullOrEmpty(txtBarangay.Text))
            {
                newPerson.Birthplace = cboTown.Text + ", " + cboProvince.Text;
            }
            else newPerson.Birthplace = txtBarangay.Text + ", " + cboTown.Text + ", " + cboProvince.Text;
            newPerson.Status = "Married";
            newPerson.Gender = cboGender.Text;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParentEntry_Load(object sender, EventArgs e)
        {
            String strProvQuery = "SELECT * FROM tblProvince ORDER BY ProvinceName ASC";

            Procedure.PopulateComboBox(cboProvince, strProvQuery, "tblProvince", "ProvinceName", "ProvinceID");
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            String strQuery = "SELECT TownID,TownName FROM tblTown INNER JOIN tblProvince ON tblProvince.ProvinceID = tblTown.ProvinceID" +
                              " WHERE ProvinceName='" + cboProvince.Text + "' ORDER BY TownName ASC";

            Procedure.PopulateComboBox(cboTown, strQuery, "tblTown", "TownName", "TownID");
        }
    }
}
