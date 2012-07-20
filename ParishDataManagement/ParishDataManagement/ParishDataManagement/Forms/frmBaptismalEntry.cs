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
    public partial class frmBaptismalEntry : Form
    {
        Person newPerson = new Person();
        Parent newParent = new Parent();
        Baptismal newBaptismal = new Baptismal();
        Sponsor newSponsor = new Sponsor();
        Book newBook = new Book();
        SeriesNumber newSeriesNumber = new SeriesNumber();
        SeriesNumber currSeriesNumber = new SeriesNumber();
        SystemVariable sv = new SystemVariable();
        Byte errmsg = 0;
        String strComboState = null;
        private static String strCategoryFlag = "Baptismal";
        String strParentsState = null;
        bool bSelected = false;

        public frmBaptismalEntry()
        {
            InitializeComponent();
        }

        private void frmBaptismal_Load(object sender, EventArgs e)
        {
            LoadProvinceDataToCombo();
            txtBaptismalNo.Text = newBook.GetActiveBook(strCategoryFlag) + "-" + newSeriesNumber.GetActiveYear() + "-" + newSeriesNumber.GetSeriesNumberByYear(newSeriesNumber.GetActiveYear(), "BaptismalSeries");
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
            }
        }

        private void SetDataToPerson()
        {
            if ((String.IsNullOrEmpty(txtFirstname.Text)) || (String.IsNullOrEmpty(txtMiddlename.Text)) || (String.IsNullOrEmpty(txtLastname.Text)))
            {
                errmsg = 1;
            }
            else
            {
                newPerson.Firstname = txtFirstname.Text;
                newPerson.Middlename = txtMiddlename.Text;
                newPerson.Lastname = txtLastname.Text;
                errmsg = 0;
            }
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

            if (String.IsNullOrEmpty(cboCluster.SelectedText))
            {
                newPerson.ClusterID = 0;
            }   
            else
            { 
                newPerson.ClusterID = Convert.ToInt16(cboCluster.SelectedValue.ToString());  
            }

            if ((String.IsNullOrEmpty(lblFatherID.Text)) || (String.IsNullOrEmpty(lblMotherID.Text)))
            {
                txtFather.BackColor = Color.Red;
                txtMother.BackColor = Color.Red;
            }
            else
            {
                newPerson.ParentIDForFather = Convert.ToInt16(lblFatherID.Text);
                newPerson.ParentIDForMother = Convert.ToInt16(lblMotherID.Text);
            }
        }

        private void SetDataToBaptismal()
        {
            newBaptismal.BaptismalID = txtBaptismalNo.Text;
            newBaptismal.PersonID = newPerson.GetPersonIDByName(newPerson);
            newBaptismal.BookID = newBook.GetActiveBook(strCategoryFlag);

            if ((String.IsNullOrEmpty(lblMinisterID.Text)) || (String.IsNullOrEmpty(lblFatherID.Text)) || (String.IsNullOrEmpty(lblMotherID.Text)))
            { 
                
            }
            else
            {
                newBaptismal.MinisterNo = Convert.ToInt16(lblMinisterID.Text);
                newBaptismal.ParentsNoForFather = Convert.ToInt16(lblFatherID.Text);
                newBaptismal.ParentsNoForMother = Convert.ToInt16(lblMotherID.Text);
            }   
            
            newBaptismal.DateofBaptism = String.Format("{0:dddd, MMMM d, yyyy}", dtDateofBaptism.Value);
            newBaptismal.Resident = cboBarangay.Text + ", " + cboTown.Text + ", " + cboProvince.Text;
            newBaptismal.Notes = null;
            newBaptismal.PlaceofBaptism = txtPlaceofBaptism.Text;
        }

        private void LoadProvinceDataToCombo()
        {
            String strQuery = "SELECT * FROM tblProvince ORDER BY ProvinceName ASC";
            Procedure.PopulateComboBox(cboProvince, strQuery, "tblProvince", "ProvinceName", "ProvinceID");
            Procedure.PopulateComboBox(cboBirthProvince, strQuery, "tblProvince", "ProvinceName", "ProvinceID");
        }

        private void LoadTownDataToCombo(String strProvinceName)
        {
            String strQuery = "SELECT TownID,TownName FROM tblTown INNER JOIN tblProvince ON tblProvince.ProvinceID = tblTown.ProvinceID" +
                              " WHERE ProvinceName='" + strProvinceName + "' ORDER BY TownName ASC";

            switch (strComboState)
            {
                case "ComboBirth":
                    Procedure.PopulateComboBox(cboBirthTown, strQuery, "tblTown", "TownName", "TownID");
                    break;

                case "TownCombo":
                    Procedure.PopulateComboBox(cboTown, strQuery, "tblTown", "TownName", "TownID");
                    break;
            }                
        }

        private void cboBirthProvince_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            strComboState = "ComboBirth";
            LoadTownDataToCombo(cboBirthProvince.Text);
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            strComboState = "TownCombo";
            LoadTownDataToCombo(cboProvince.Text);
        }

        private void cboTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            String strQuery = "SELECT BarangayID,BarangayName FROM tblBarangay INNER JOIN tblTown ON tblBarangay.TownID = tblTown.TownID" +
                              " WHERE TownName='" + cboTown.Text + "' ORDER BY BarangayName ASC";
            Procedure.PopulateComboBox(cboBarangay, strQuery, "tblBarangay", "BarangayName", "BarangayID");
        }

        private void cboBarangay_SelectedIndexChanged(object sender, EventArgs e)
        {
            String strQuery = "SELECT ChapelID,ChapelName FROM tblChapel INNER JOIN tblBarangay ON tblChapel.BarangayID = tblBarangay.BarangayID" +
                              " WHERE BarangayName='" + cboBarangay.Text + "' ORDER BY ChapelName ASC";

            Procedure.PopulateComboBox(cboChapel, strQuery, "tblChapel", "ChapelName", "ChapelID");
        }

        private void cboChapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            String strQuery = "SELECT ClusterID,ClusterName FROM tblCluster INNER JOIN tblChapel ON tblCluster.ChapelID = tblChapel.ChapelID" +
                              " WHERE ChapelName='" + cboChapel.Text + "' ORDER BY ClusterName ASC";

            Procedure.PopulateComboBox(cboCluster, strQuery, "tblCluster", "ClusterName", "ClusterID");
        }

        private void txtFather_TextChanged(object sender, EventArgs e)
        {
            int cntfather;
            strParentsState = "Father";
            cntfather = txtFather.Lines.Length;
            if (cntfather > 0)
            {
                lstParents.Top = txtFather.Top + txtFather.Height;
                lstParents.Left = txtFather.Left;
                lstParents.Visible = true;

                this.PopulateParentsList(txtFather.Text);
            }
            else
            {
                lstParents.Visible = false;
            }
        }

        private void txtMother_TextChanged(object sender, EventArgs e)
        {
            int cntmother;
            strParentsState = "Mother";
            cntmother = txtMother.Lines.Length;
            if (cntmother > 0)
            {
                lstParents.Top = txtMother.Top + txtMother.Height;
                lstParents.Left = txtMother.Left;
                lstParents.Visible = true;

                this.PopulateParentsList(txtMother.Text);
            }
            else
            { 
                 lstParents.Visible = false;

            }
        }

        private void txtFather_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblFatherID.Text = lstParents.Items[0].Text;
                txtFather.Text = lstParents.Items[0].SubItems[1].Text;
                lstParents.Visible = false;
                strParentsState = null;
            }
        }

        private void txtMother_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblMotherID.Text = lstParents.Items[0].Text;
                txtMother.Text = lstParents.Items[0].SubItems[1].Text;
                lstParents.Visible = false;
                strParentsState = null;
            }
        }

        private void PopulateParentsList(String strText)
        {
            String strQuery = null;

            switch (strParentsState)
            {
                case "Father":
                    strQuery = "SELECT tblParent.ParentsNo, CONCAT(Firstname ,' ', Middlename ,' ', Lastname) FROM tblPerson" +
                               " RIGHT JOIN tblParent ON tblPerson.PersonID = tblParent.PersonID WHERE Gender = 'Male' AND (Firstname LIKE '%" + strText + "%'" +
                               " OR Lastname LIKE '%" + strText + "%' OR Middlename LIKE '%" + strText + "%')";

                    Procedure.PopulateListView(lstParents, strQuery);
                    break;

                case "Mother":
                    strQuery = "SELECT tblParent.ParentsNo, CONCAT(Firstname ,' ', Middlename ,' ', Lastname) FROM tblPerson" +
                               " RIGHT JOIN tblParent ON tblPerson.PersonID = tblParent.PersonID WHERE Gender = 'Female' AND (Firstname LIKE '%" + strText + "%'" +
                               " OR Lastname LIKE '%" + strText + "%' OR Middlename LIKE '%" + strText + "%')";

                    Procedure.PopulateListView(lstParents, strQuery);
                    break;

                case "Minister":
                    strQuery = "SELECT tblMinister.MinisterNo, CONCAT(Firstname ,' ', Middlename ,' ', Lastname) FROM tblPerson" +
                              " RIGHT JOIN tblMinister ON tblPerson.PersonID = tblMinister.PersonID WHERE Firstname LIKE '%" + txtMinister.Text + "%'" +
                              " OR Lastname LIKE '%" + txtMinister.Text + "%' OR Middlename LIKE '%" + txtMinister.Text + "%'";

                    Procedure.PopulateListView(lstMinister, strQuery);
                    break;
            }
        }

        private void lstParents_DoubleClick(object sender, EventArgs e)
        {
            switch (strParentsState)
            { 
                case "Father":
                    lblFatherID.Text = lstParents.SelectedItems[0].Text;
                    txtFather.Text = lstParents.SelectedItems[0].SubItems[1].Text;
                    break;

                case "Mother":
                    lblMotherID.Text = lstParents.SelectedItems[0].Text;
                    txtMother.Text = lstParents.SelectedItems[0].SubItems[1].Text;
                    break;
            }

            lstParents.Visible = false;
            strParentsState = null;
        }

        private void txtMinister_TextChanged(object sender, EventArgs e)
        {
            int cntminister;
            strParentsState = "Minister";

            cntminister = txtMinister.Lines.Length;
            if (cntminister > 0)
            {
                lstMinister.Top = txtMinister.Top + txtMinister.Height;
                lstMinister.Left = txtMinister.Left;
                lstMinister.Visible = true;

                this.PopulateParentsList(txtMinister.Text);
            }
            else
            { 
                  lstMinister.Visible = false;
            }
        }

        private void lstMinister_DoubleClick(object sender, EventArgs e)
        {
            lblMinisterID.Text = lstMinister.SelectedItems[0].Text;
            txtMinister.Text = lstMinister.SelectedItems[0].SubItems[1].Text;
            lstMinister.Visible = false;
            strParentsState = null;
        }

        private void lnkAddFather_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmParentEntry newForm = new frmParentEntry();
            this.SendToBack();
            newForm.cboGender.Text = "Male";
            newForm.ShowDialog();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.SetDataToPerson();
            newPerson.AddNew(newPerson);

            for (int count = 0; count < lstSponsors.Items.Count; count++)
            {
                this.SetDataToSponsor(count);
                newSponsor.AddNew(newSponsor);
            }

            this.SetDataToBaptismal();
            newBaptismal.AddNew(newBaptismal);

            this.SetDataToSeriesNumber();
            currSeriesNumber.Update(currSeriesNumber, "BaptismalSeries", currSeriesNumber.BaptismalSeries);

            MessageBox.Show("New record successfully saved.", SystemVariable.ProjectName);
        }

        private void SetDataToSeriesNumber()
        {
            String strActiveYear = currSeriesNumber.GetActiveYear();
            currSeriesNumber.BaptismalSeries = Convert.ToInt16(currSeriesNumber.GetSeriesNumberByYear(strActiveYear, "BaptismalSeries"));
            currSeriesNumber.Year = strActiveYear;
        }

        private void SetDataToSponsor(int counter)
        { 
            newSponsor.PersonID = Convert.ToInt16(lstSponsors.Items[counter].Text);
            newSponsor.EventNo = txtBaptismalNo.Text;
            newSponsor.Event = "Baptismal";
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

        public void cmdRefresh_Click(object sender, EventArgs e)
        {
            this.LoadSponsorToList();
            lstSponsors.Refresh();
        }

        private void frmBaptismalEntry_Activated(object sender, EventArgs e)
        {
            this.LoadSponsorToList();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if (lstSponsors.Items.Count != 0)
            {
                if (bSelected)
                {
                    lstSponsors.SelectedItems[0].Remove();
                    bSelected = false;
                }
                else
                    MessageBox.Show("Please select an item on the list.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstSponsors_SelectedIndexChanged(object sender, EventArgs e)
        {
            bSelected = true;
        }

        private void lnkAddMother_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmParentEntry newForm = new frmParentEntry();
            this.SendToBack();
            newForm.cboGender.Text = "Female";
            newForm.ShowDialog();
        }

        private void txtMinister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblMinisterID.Text = lstMinister.Items[0].Text;
                txtMinister.Text = lstMinister.Items[0].SubItems[1].Text;
                lstMinister.Visible = false;
                strParentsState = null;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(tabControl1.SelectedTab == tabControl1.TabPages["tabpage2"])
            {
                //this.LoadSponsorToList();
            }
        }

        private void cmdAddSponsor_Click(object sender, EventArgs e)
        {
            frmListofSponsors newForm = new frmListofSponsors();
            newForm.SetSponsorType("Baptismal");
            this.SendToBack();
            newForm.ShowDialog();
        }
    }
}
