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
    public partial class frmDeathEntry : Form
    {
        Person newPerson = new Person();
        Parent newParent = new Parent();
        SeriesNumber newSeriesNumber = new SeriesNumber();
        Book newBook = new Book();
        Death newDeath = new Death();

        bool bLiveSearch = false;
        String strParentState = null;
        int iPersonID = 0;
        private static String strCategoryFlag = "Death";

        public frmDeathEntry()
        {
            InitializeComponent();
        }

        private void chkLiveSearch_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkLiveSearch.Checked)
            {
                bLiveSearch = true;
                lblNote.ForeColor = SystemColors.ActiveCaption;
                chkLiveSearch.ForeColor = Color.Blue;
                this.ChangeFontStyle(txtFirstname);
                this.ChangeFontStyle(txtLastname);
            }
            else
            {
                bLiveSearch = false;
                lblNote.ForeColor = Color.Black;
                chkLiveSearch.ForeColor = Color.Black;
                this.ChangeTextboxStyle(txtFirstname);
                this.ChangeTextboxStyle(txtLastname);
            }
            if (bLiveSearch)
                DisableControl();
            else
            {
                this.txtFirstname.Clear();
                this.txtLastname.Clear();
                EnabledControl();
            }
        }

        private void ChangeFontStyle(TextBox TextboxName)
        {
            TextboxName.Text = "Enter search text here:";
            TextboxName.ForeColor = SystemColors.ScrollBar;
            TextboxName.Font = new Font(this.Font, FontStyle.Italic);
        }

        private void ChangeTextboxStyle(TextBox TextboxName)
        {
            TextboxName.ForeColor = SystemColors.WindowText;
            TextboxName.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        }

        private void DisableControl()
        {
            dtBirthdate.Enabled = false;
            cboGender.Enabled = false;
            cboCivil.Enabled = false;
            cboBirthProvince.Enabled = false;
            cboBirthTown.Enabled = false;
            txtBarangay.Enabled = false;
            txtSpouse.Enabled = false;
            cboParentName.Visible = true;
            cboParentName.Width = txtParentName.Width;
            cboParentName.Left = txtParentName.Left;
            cboParentName.Top = txtParentName.Top;
            txtParentName.Visible = false;
            lnkAddParent.Visible = false;
            lnkAddSpouse.Visible = false;
        }

        private void EnabledControl()
        {
            dtBirthdate.Enabled = true;
            cboGender.Enabled = true;
            cboCivil.Enabled = true;
            cboBirthProvince.Enabled = true;
            cboBirthTown.Enabled = true;
            txtBarangay.Enabled = true;
        }

        private void txtFirstname_Enter(object sender, EventArgs e)
        {
            this.txtFirstname.Clear();
            this.ChangeTextboxStyle(txtFirstname);
        }

        private void txtLastname_Enter(object sender, EventArgs e)
        {
            this.txtLastname.Clear();
            this.ChangeTextboxStyle(txtLastname);
        }

        private void PopulatePersonInfoList(String strFieldname, String strText)
        {
            String strQuery = "SELECT tblBaptismal.PersonID, Firstname, Middlename, Lastname FROM tblPerson RIGHT JOIN tblBaptismal ON tblPerson.PersonID = tblBaptismal.PersonID" +
                              " WHERE tblBaptismal.PersonID NOT IN (SELECT tblConfirmation.PersonID FROM tblConfirmation) AND Status = 'Single' AND " + strFieldname + " LIKE '%" + strText + "%'";
            Procedure.PopulateListView(lstPersonInfo, strQuery);
        }

        private void SetListviewPosition(TextBox TextboxName, ListView lstPersonInfo)
        {
            lstPersonInfo.Left = TextboxName.Left;
            lstPersonInfo.Top = TextboxName.Top + TextboxName.Height;
            if (!String.IsNullOrEmpty(TextboxName.Text))
            {
                lstPersonInfo.Visible = true;
            }
            else lstPersonInfo.Visible = false;
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            if (bLiveSearch)
            {
                if (txtFirstname.Text != "Enter search text here:")
                {
                    PopulatePersonInfoList("Firstname", txtFirstname.Text);
                    SetListviewPosition(txtFirstname, lstPersonInfo);
                }
            }
        }

        private void lstPersonInfo_DoubleClick(object sender, EventArgs e)
        {
            Person newPersonInfo = new Person();
            Baptismal newBaptismalInfo = new Baptismal();
            Marriage newMarriageInfo = new Marriage();

            String strAddress = null;
            String strPresentAdd = null;
            String strBaptismalID = null;
            String strGender = null;
            List<String> strListParents = new List<String>();

            iPersonID = Convert.ToInt16(lstPersonInfo.SelectedItems[0].Text);
            lblPersonID.Text = lstPersonInfo.SelectedItems[0].Text;
            strGender = newPersonInfo.GetPersonGenderByID(iPersonID);

            strBaptismalID = newBaptismalInfo.GetBaptismalIDByPersonID(iPersonID);
            newBaptismalInfo.SetBaptismalInfo(strBaptismalID);
            newPersonInfo.SetPersonInfo(iPersonID);

            txtFirstname.Text = lstPersonInfo.SelectedItems[0].SubItems[1].Text;
            txtMiddlename.Text = lstPersonInfo.Items[0].SubItems[2].Text;
            txtLastname.Text = lstPersonInfo.Items[0].SubItems[3].Text;

            dtBirthdate.Text = newPersonInfo.Birthdate;
            cboGender.Text = newPersonInfo.Gender;
            cboCivil.Text = newPersonInfo.Status;
            dtDateofDeath.Text = newBaptismalInfo.DateofBaptism;
            int iFatherID = newParent.GetPersonIDByParentsID(newPerson.GetParentIDByPersonID(iPersonID, "ParentIDForFather"));
            int iMotherID = newParent.GetPersonIDByParentsID(newPerson.GetParentIDByPersonID(iPersonID, "ParentIDForMother"));
            strListParents.Add(newPerson.GetPersonNameByID(iMotherID));
            strListParents.Add(newPerson.GetPersonNameByID(iFatherID));
            this.PopulateParentsComboBox(strListParents);

            lblSpouseID.Text = Convert.ToString(newMarriageInfo.GetSpouseIDByPersonID(iPersonID, strGender));
            txtSpouse.Text = newPersonInfo.GetPersonNameByID(Convert.ToInt16(lblSpouseID.Text));

            strAddress = newPersonInfo.Birthplace;
            String[] temp = strAddress.Split(',');
            if (temp.Length == 3)
            {
                txtBarangay.Text = temp[0];
                cboBirthTown.Text = temp[1].Trim();
                cboBirthProvince.Text = temp[2].Trim();
            }
            else if (temp.Length == 2)
            {
                cboBirthTown.Text = temp[0];
                cboBirthProvince.Text = temp[1].Trim();
            }
            else cboBirthProvince.Text = temp[0];

            strPresentAdd = newBaptismalInfo.Resident;
            String[] temp_add = strPresentAdd.Split(',');
            if (temp_add.Length == 3)
            {
                txtPresentBarangay.Text = temp_add[0];
                cboTown.Text = temp_add[1].Trim();
                cboProvince.Text = temp_add[2].Trim();
            }
            else if (temp.Length == 2)
            {
                cboTown.Text = temp_add[0];
                cboProvince.Text = temp_add[1].Trim();
            }
            else cboProvince.Text = temp_add[0];

            lstPersonInfo.Visible = false;
            this.ChangeTextboxStyle(txtFirstname);
            this.ChangeTextboxStyle(txtLastname);
        }

        private void PopulateDeathComboBox()
        {
            String strQuery = "SELECT * FROM tblProvince ORDER BY ProvinceName ASC";
            String strTownQuery = "SELECT * FROM tblTown ORDER BY TownName ASC";

            Procedure.PopulateComboBox(cboProvince, strQuery, "tblProvince", "ProvinceName", "ProvinceID");
            Procedure.PopulateComboBox(cboTown, strTownQuery, "tblTown", "TownName", "TownID");
            Procedure.PopulateComboBox(cboBirthProvince, strQuery, "tblProvince", "ProvinceName", "ProvinceID");
            Procedure.PopulateComboBox(cboBirthTown, strTownQuery, "tblTown", "TownName", "TownID");
        }

        private void PopulateParentsComboBox(List<String> strListParents)
        {
            cboParentName.Items.Clear();
            foreach (String strParent in strListParents)
            {
                cboParentName.Items.Add(strParent);
            }
            cboParentName.SelectedIndex = 0;
        }

        private void frmDeathEntry_Load(object sender, EventArgs e)
        {
            this.PopulateDeathComboBox();
            txtDeathNo.Text = newBook.GetActiveBook(strCategoryFlag) + "-" + newSeriesNumber.GetActiveYear() + "-" + newSeriesNumber.GetSeriesNumberByYear(newSeriesNumber.GetActiveYear(), "DeathSeries");
        }

        private void txtMinister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblMinisterID.Text = lstMinister.Items[0].Text;
                txtMinister.Text = lstMinister.Items[0].SubItems[1].Text;
                lstMinister.Visible = false;
                this.strParentState = null;
            }
        }

        private void txtMinister_TextChanged(object sender, EventArgs e)
        {
            strParentState = "Minister";
            lstMinister.Top = txtMinister.Top + txtMinister.Height;
            lstMinister.Width = txtMinister.Width;
            lstMinister.Left = txtMinister.Left;
            lstMinister.Visible = true;

            this.PopulateParentsList(txtMinister.Text);
        }

        private void PopulateParentsList(String strText)
        {
            String strQuery = null;

            switch (strParentState)
            {
                case "Father":
                    strQuery = "SELECT tblParent.ParentsNo, CONCAT(Firstname ,' ', Middlename ,' ', Lastname) FROM tblPerson" +
                               " RIGHT JOIN tblParent ON tblPerson.PersonID = tblParent.PersonID WHERE Gender = 'Male' AND (Firstname LIKE '%" + strText + "%'" +
                               " OR Lastname LIKE '%" + strText + "%' OR Middlename LIKE '%" + strText + "%')";

                    //Procedure.PopulateListView(lstParents, strQuery);
                    break;

                case "Mother":
                    strQuery = "SELECT tblParent.ParentsNo, CONCAT(Firstname ,' ', Middlename ,' ', Lastname) FROM tblPerson" +
                               " RIGHT JOIN tblParent ON tblPerson.PersonID = tblParent.PersonID WHERE Gender = 'Female' AND (Firstname LIKE '%" + strText + "%'" +
                               " OR Lastname LIKE '%" + strText + "%' OR Middlename LIKE '%" + strText + "%')";

                    //Procedure.PopulateListView(lstParents, strQuery);
                    break;

                case "Minister":
                    strQuery = "SELECT tblMinister.MinisterNo, CONCAT(Firstname ,' ', Middlename ,' ', Lastname) FROM tblPerson" +
                              " RIGHT JOIN tblMinister ON tblPerson.PersonID = tblMinister.PersonID WHERE Firstname LIKE '%" + txtMinister.Text + "%'" +
                              " OR Lastname LIKE '%" + txtMinister.Text + "%' OR Middlename LIKE '%" + txtMinister.Text + "%'";

                    Procedure.PopulateListView(lstMinister, strQuery);
                    break;
            }
        }

        private void SetDataToDeath()
        {
            newDeath.DeathID = txtDeathNo.Text;
            newDeath.PersonID = Convert.ToInt16(lblPersonID.Text);
            newDeath.ParentID = newParent.GetParentIDByPersonID(this.GetParentID());
            newDeath.SpouseID = Convert.ToInt16(lblSpouseID.Text);
            newDeath.MinisterID = Convert.ToInt16(lblMinisterID.Text);
            newDeath.BookID = newBook.GetBookIDByNo(newBook.GetActiveBook(strCategoryFlag));
            newDeath.DateofDeath = String.Format("{0:dddd, MMMM d, yyyy}", dtDateofDeath.Value);
            newDeath.DateofBurial = String.Format("{0:dddd, MMMM d, yyyy}", dtDateofBurial.Value);
            newDeath.PlaceofBurial = txtPlaceofBurial.Text;
            newDeath.Resident = txtPresentBarangay.Text + ", " + cboTown.Text + ", " + cboProvince.Text;
            newDeath.Sacraments = "";
        }

        private void lstMinister_DoubleClick(object sender, EventArgs e)
        {
            lblMinisterID.Text = lstMinister.SelectedItems[0].Text;
            txtMinister.Text = lstMinister.SelectedItems[0].SubItems[1].Text;
            lstMinister.Visible = false;
            this.strParentState = null;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            int ans;
            ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to cancel this operation?", SystemVariable.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (ans == 6)
            {
                this.Close();
                this.Dispose();
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.SetDataToPerson();
            if (!bLiveSearch) 
            {
                if (!newPerson.PersonExist(newPerson)) newPerson.AddNew(newPerson);
            }
            this.SetDataToDeath();
            newDeath.AddNew(newDeath);
        }

        private int GetParentID()
        {
            Person newParent = new Person();

            String strParentName = "";
            strParentName = cboParentName.Text;
            String[] temp_name = strParentName.Split(' ');
            if (temp_name.Length == 3)
            {
                newParent.Firstname = temp_name[0];
                newParent.Lastname = temp_name[2];
            }
            else 
            {
                newParent.Firstname = temp_name[0];
                newParent.Lastname = temp_name[1];  
            }

            return newParent.GetPersonIDByName(newParent);
        }

        private void SetDataToPerson()
        {
            newPerson.Firstname = txtFirstname.Text;
            newPerson.Middlename = txtMiddlename.Text;
            newPerson.Lastname = txtLastname.Text;
            newPerson.Birthdate = String.Format("{0:dddd, MMMM d, yyyy}", dtBirthdate.Value);
            if (String.IsNullOrEmpty(txtBarangay.Text))
            {
                newPerson.Birthplace = cboBirthTown.Text + ", " + cboBirthProvince.Text;
            }
            else
            {
                newPerson.Birthplace = txtBarangay.Text + ", " + cboBirthTown.Text + ", " + cboBirthProvince.Text;
            }
            newPerson.Gender = cboGender.Text;
            newPerson.Status = cboCivil.Text;
            newPerson.ClusterID = 0;//Convert.ToInt16(cboCluster.SelectedValue.ToString());
            newPerson.ParentIDForFather = Convert.ToInt16(lblFatherID.Text);
            newPerson.ParentIDForMother = Convert.ToInt16(lblMotherID.Text);
        }
    }
}
