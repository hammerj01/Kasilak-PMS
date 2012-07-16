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
    public partial class frmConfirmationEntry : Form
    {
        Person newPerson = new Person();
        Parent newParent = new Parent();
        Book newBook = new Book();
        Sponsor newSponsor = new Sponsor();
        SeriesNumber newSeriesNumber = new SeriesNumber();
        Confirmation newConfirmation = new Confirmation();
        SeriesNumber currSeriesNumber = new SeriesNumber();
        bool bLiveSearch = false;
        int iBookID = 0;
        int iPersonID = 0;
        String strParentState = null;
        private static String strCategoryFlag = "Confirmation";
       
        public frmConfirmationEntry()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            int ans;
            int iLength = SystemVariable.arrSponsorPersonID.Length;
            ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to cancel this operation?", SystemVariable.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (ans == 6)
            {
                Array.Clear(SystemVariable.arrSponsorPersonID, 0, iLength);
                Array.Clear(SystemVariable.arrSponsorFirstname, 0, iLength);
                Array.Clear(SystemVariable.arrSponsorMiddlename, 0, iLength);
                Array.Clear(SystemVariable.arrSponsorLastname, 0, iLength);
                Array.Clear(SystemVariable.arrSponsorAddress, 0, iLength);
                this.Close();
                this.Dispose();
            }
        }

        private void chkLiveSearch_CheckedChanged(object sender, EventArgs e)
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

        private void ChangeTextboxStyle(TextBox TextboxName) 
        {
            TextboxName.ForeColor = SystemColors.WindowText;
            TextboxName.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            if (bLiveSearch)
            {
                if (txtLastname.Text != "Enter search text here:")
                {
                    PopulatePersonInfoList("Lastname", txtLastname.Text);
                    SetListviewPosition(txtLastname, lstPersonInfo);
                }
            }
        }

        private void PopulatePersonInfoList(String strFieldname, String strText)
        {
            String strQuery = "SELECT tblBaptismal.PersonID, Firstname, Middlename, Lastname FROM tblPerson RIGHT JOIN tblBaptismal ON tblPerson.PersonID = tblBaptismal.PersonID" +
                              " WHERE tblBaptismal.PersonID NOT IN (SELECT tblDeath.PersonID FROM tblDeath) AND " + strFieldname + " LIKE '%" + strText + "%'";
            Procedure.PopulateListView(lstPersonInfo, strQuery);
        }

        private void lstPersonInfo_DoubleClick(object sender, EventArgs e)
        {
            Person newPersonInfo = new Person();
            Baptismal newBaptismalInfo = new Baptismal();
            String strAddress = null;
            String strPresentAdd = null;
            String strBaptismalID = null;

            iPersonID = Convert.ToInt16(lstPersonInfo.SelectedItems[0].Text);

            strBaptismalID = newBaptismalInfo.GetBaptismalIDByPersonID(iPersonID);
            newBaptismalInfo.SetBaptismalInfo(strBaptismalID);
            newPersonInfo.SetPersonInfo(iPersonID);

            txtFirstname.Text = lstPersonInfo.SelectedItems[0].SubItems[1].Text;
            txtMiddlename.Text = lstPersonInfo.Items[0].SubItems[2].Text;
            txtLastname.Text = lstPersonInfo.Items[0].SubItems[3].Text;

            dtBirthdate.Text = newPersonInfo.Birthdate;
            cboGender.Text = newPersonInfo.Gender;
            cboCivil.Text = newPersonInfo.Status;
            dtBaptismalDate.Text = newBaptismalInfo.DateofBaptism;
            txtBaptismalPlace.Text = newBaptismalInfo.PlaceofBaptism;

            String strFather = newPerson.GetPersonNameByID(newParent.GetPersonIDByParentsID(newBaptismalInfo.ParentsNoForFather));
            if (!String.IsNullOrEmpty(strFather))
            {
                lblFatherID.Text = Convert.ToString(newBaptismalInfo.ParentsNoForFather);
                txtFather.Text = strFather;
                txtFather.ReadOnly = true;
                lnkAddFather.Enabled = false;
            }

            String strMother = newPerson.GetPersonNameByID(newParent.GetPersonIDByParentsID(newBaptismalInfo.ParentsNoForMother));
            if (!String.IsNullOrEmpty(strMother))
            {
                lblMotherID.Text = Convert.ToString(newBaptismalInfo.ParentsNoForMother);
                txtMother.Text = strMother;
                txtMother.ReadOnly = true;
                lnkAddMother.Enabled = false;
            }

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

        private void DisableControl()
        {
            dtBirthdate.Enabled = false;
            cboGender.Enabled = false;
            cboCivil.Enabled = false;
            cboBirthProvince.Enabled = false;
            cboBirthTown.Enabled = false;
            txtBarangay.Enabled = false;
            dtBaptismalDate.Enabled = false;
            txtBaptismalPlace.Enabled = false;
        }

        private void EnabledControl()
        {
            dtBirthdate.Enabled = true;
            cboGender.Enabled = true;
            cboCivil.Enabled = true;
            cboBirthProvince.Enabled = true;
            cboBirthTown.Enabled = true;
            txtBarangay.Enabled = true;
            dtBaptismalDate.Enabled = true;
            txtBaptismalPlace.Enabled = true;
        }

        private void PopulateConfirmationComboBox()
        {
            String strQuery = "SELECT * FROM tblProvince ORDER BY ProvinceName ASC";
            String strTownQuery = "SELECT * FROM tblTown ORDER BY TownName ASC";

            Procedure.PopulateComboBox(cboProvince, strQuery, "tblProvince", "ProvinceName", "ProvinceID");
            Procedure.PopulateComboBox(cboTown, strTownQuery, "tblTown", "TownName", "TownID");
            Procedure.PopulateComboBox(cboBirthProvince, strQuery, "tblProvince", "ProvinceName", "ProvinceID");
            Procedure.PopulateComboBox(cboBirthTown, strTownQuery, "tblTown", "TownName", "TownID");
        }

        private void frmConfirmationEntry_Load(object sender, EventArgs e)
        {
            this.PopulateConfirmationComboBox();
            this.iBookID = newBook.GetBookIDByNo(newBook.GetActiveBook(strCategoryFlag));
            txtConfirmationNo.Text = newBook.GetActiveBook(strCategoryFlag) + "-" + newSeriesNumber.GetActiveYear() + "-" + newSeriesNumber.GetSeriesNumberByYear(newSeriesNumber.GetActiveYear(), "ConfirmationSeries");
        }

        private void SetDataToConfirmation()
        {
            newConfirmation.ConfirmationID = txtConfirmationNo.Text;
            newConfirmation.PersonID = this.iPersonID;
            newConfirmation.ParentsIDForFather = Convert.ToInt16(lblFatherID.Text);
            newConfirmation.ParentsIDForMother = Convert.ToInt16(lblMotherID.Text);
            newConfirmation.DateofConfirmation = dtDateofConfirmation.Text;
            newConfirmation.MinisterID = Convert.ToInt16(lblMinisterID.Text);
            newConfirmation.BookID = this.iBookID;
            newConfirmation.DateofBaptism = dtBaptismalDate.Text;
            newConfirmation.PlaceofBaptism = txtBaptismalPlace.Text;
            if (String.IsNullOrEmpty(txtPresentBarangay.Text))
            {
                newConfirmation.Address = cboTown.Text + ", " + cboProvince.Text;
            }
            else
            {
                newConfirmation.Address = txtPresentBarangay.Text + ", " + cboTown.Text + ", " + cboProvince.Text;
            }
            newConfirmation.PlaceofConfirmation = txtPlaceofConfirmation.Text;
        }

        private void lstMinister_DoubleClick(object sender, EventArgs e)
        {
            lblMinisterID.Text = lstMinister.SelectedItems[0].Text;
            txtMinister.Text = lstMinister.SelectedItems[0].SubItems[1].Text;
            lstMinister.Visible = false;
            this.strParentState = null;
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

        private void cmdAddSponsor_Click(object sender, EventArgs e)
        {
            frmListofSponsors newForm = new frmListofSponsors();
            newForm.SetSponsorType("Confirmation");
            this.SendToBack();
            newForm.ShowDialog();
        }

        public void LoadSponsorToList()
        {
            ListViewItem lstItem = null;
            lstSponsors.Items.Clear();

            if (Convert.ToInt16(SystemVariable.arrSponsorPersonID.Length) != 0)
            {
                for (int x = 0; x < SystemVariable.arrSponsorPersonID.Length; x++)
                {
                    lstItem = lstSponsors.Items.Add(SystemVariable.arrSponsorPersonID[x].ToString());
                    lstItem.SubItems.Add(SystemVariable.arrSponsorFirstname[x].ToString());
                    lstItem.SubItems.Add(SystemVariable.arrSponsorMiddlename[x].ToString());
                    lstItem.SubItems.Add(SystemVariable.arrSponsorLastname[x].ToString());
                    lstItem.SubItems.Add(SystemVariable.arrSponsorAddress[x].ToString());
                }
            }
        }

        private void frmConfirmationEntry_Activated(object sender, EventArgs e)
        {
            this.LoadSponsorToList();
        }

        private void SetDataToSeriesNumber()
        {
            String strActiveYear = currSeriesNumber.GetActiveYear();
            currSeriesNumber.ConfirmationSeries = Convert.ToInt16(currSeriesNumber.GetSeriesNumberByYear(strActiveYear, "ConfirmationSeries"));
            currSeriesNumber.Year = strActiveYear;
        }

        private void SetDataToSponsor(int counter)
        {
            newSponsor.PersonID = Convert.ToInt16(lstSponsors.Items[counter].Text);
            newSponsor.EventNo = txtConfirmationNo.Text;
            newSponsor.Event = "Confirmation";
        }


        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.SetDataToConfirmation();
            newConfirmation.AddNew(newConfirmation);

            for (int count = 0; count < lstSponsors.Items.Count; count++)
            {
                this.SetDataToSponsor(count);
                newSponsor.AddNew(newSponsor);
            }

            this.SetDataToSeriesNumber();
            currSeriesNumber.Update(currSeriesNumber, "ConfirmationSeries", currSeriesNumber.ConfirmationSeries);

            MessageBox.Show("New record successfully saved.", SystemVariable.ProjectName);
        }
    }
}
