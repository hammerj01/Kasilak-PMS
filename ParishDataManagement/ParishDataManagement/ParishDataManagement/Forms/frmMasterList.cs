using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ParishDataManagement
{
    public partial class frmMasterList : Form
    {
        public String strRecordType = "";

        public frmMasterList()
        {
            InitializeComponent();
        }

        private void frmMasterList_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            //set the position of the record list
            lstRecords.Left = 0;
            lstRecords.Top = lblCaption.Top + lblCaption.Height;
            lstRecords.Width = this.ClientSize.Width - splitContainer1.Panel1.Width;
            lstRecords.Height = this.ClientSize.Height + 20 - lblCaption.Height;

            //set the position of record count label
            lblRecordCount.Left = 0;
            lblRecordCount.Top = lstRecords.Height + lblCaption.Height + 2;
            lblCounter.Left = lblRecordCount.Width + 5;
            lblCounter.Top = lstRecords.Height + lblCaption.Height + 2;
            lblCaption.Text = "List of " + strRecordType + " Record";

            this.LoadDataToList();
            lblCounter.Text = Convert.ToString(lstRecords.Items.Count) + " record(s) found";
        }

        public void LoadDataToList()
        {
            String strQuery = "";

            switch (strRecordType)
            {
                case "Baptismal":
                    String[] strBaptismalField = { "Baptismal ID", "Firstname", "Middlename", "Lastname", "Address" };
                    int[] iBaptismalHeaderWidth = {180, 200, 200, 200, 300};
                    Procedure.SetHeaderData(lstRecords, strBaptismalField, iBaptismalHeaderWidth);

                    strQuery = "SELECT tblBaptismal.BaptismalID,Firstname,Middlename,Lastname,BirthPlace FROM tblPerson" +
                               " RIGHT JOIN tblBaptismal ON tblPerson.PersonID = tblBaptismal.PersonID";
                    Procedure.PopulateListView(lstRecords, strQuery);
                    break;

                case "Marriage":
                    String[] strMarriageField = { "Marriage ID", "Husband's Name", "Wife's Name", "Date of Marriage" };
                    int[] iMarriageHeaderWidth = { 180, 300, 300, 300 };
                    Procedure.SetHeaderData(lstRecords, strMarriageField, iMarriageHeaderWidth);

                    strQuery = "SELECT MarriageID, CONCAT(husband.Firstname,' ',husband.Middlename,' ',husband.Lastname) as Husband," +
                               " CONCAT(wife.Firstname,' ',wife.Middlename,' ',wife.Lastname) as Wife, DateofMarriage FROM" +
                               " ((tblMarriage RIGHT JOIN tblPerson husband ON tblMarriage.PersonID_Husband = husband.PersonID)" +
                               " RIGHT JOIN tblPerson wife ON tblMarriage.PersonID_Wife = wife.PersonID) WHERE tblMarriage.MarriageID <> 'NULL'";
                    Procedure.PopulateListView(lstRecords, strQuery);
                    break;

                case "Confirmation":
                    String[] strConfirmationField = { "Confirmation ID", "Firstname", "Middlename", "Lastname", "Address" };
                    int[] iConfirmationHeaderWidth = { 180, 200, 200, 200, 300 };
                    Procedure.SetHeaderData(lstRecords, strConfirmationField, iConfirmationHeaderWidth);

                    strQuery = "SELECT tblConfirmation.ConfirmationID,Firstname,Middlename,Lastname,BirthPlace FROM tblPerson" +
                               " RIGHT JOIN tblConfirmation ON tblPerson.PersonID = tblConfirmation.PersonID";
                    Procedure.PopulateListView(lstRecords, strQuery);
                    break;

                case "Death":
                    String[] strDeathField = { "Death ID", "Firstname", "Middlename", "Lastname", "Address" };
                    int[] iDeathHeaderWidth = { 180, 200, 200, 200, 300 };
                    Procedure.SetHeaderData(lstRecords, strDeathField, iDeathHeaderWidth);

                    strQuery = "SELECT tblDeath.DeathID,Firstname,Middlename,Lastname,BirthPlace FROM tblPerson" +
                               " RIGHT JOIN tblDeath ON tblPerson.PersonID = tblDeath.PersonID";
                    Procedure.PopulateListView(lstRecords, strQuery);
                    break;
            } 
        }

        private void ConfigureCrystalReports()
        {
            DataSet dsBaptismalAll = new DataSet();
		    ParishDataManagement.Dataset.BaptismalDataSetSchema dsBaptismal = new ParishDataManagement.Dataset.BaptismalDataSetSchema();
            ParishDataManagement.Dataset.SponsorDataSetSchema dsSponsor = new ParishDataManagement.Dataset.SponsorDataSetSchema();
            ParishDataManagement.Reports.rptBaptismal rptBaptismal = new ParishDataManagement.Reports.rptBaptismal();
            frmReportViewer newViewer = new frmReportViewer();
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);

            String strQuery = "SELECT tblBaptismal.BaptismalID, CONCAT(tblPerson.Firstname,' ',tblPerson.Middlename,' ',tblPerson.Lastname) as Fullname, tblPerson.Birthdate, tblPerson.BirthPlace, " +
                              "tblBaptismal.DateofBaptism, tblBaptismal.PlaceofBaptism, tblBaptismal.BookID, tblBaptismal.MinisterNo, tblBaptismal.ParentsIDForFather, tblBaptismal.ParentsIDForMother FROM dbparish.tblBaptismal " +
                              "LEFT JOIN tblPerson ON tblBaptismal.PersonID = tblPerson.PersonID WHERE tblBaptismal.BaptismalID = '" + lstRecords.SelectedItems[0].Text + "'";
            
            String strSponsorQuery = "SELECT tblSponsor.EventNo, CONCAT(tblPerson.Firstname,' ',tblPerson.Middlename,' ',tblPerson.Lastname) as Fullname FROM dbparish.tblPerson" +
                                     " LEFT JOIN tblSponsor ON tblPerson.PersonID = tblSponsor.PersonID WHERE tblSponsor.EventNo IS NOT NULL AND tblSponsor.EventNo = '" + lstRecords.SelectedItems[0].Text + "'";
            
            conn.Open();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
            MySqlDataAdapter adapterSponsor = new MySqlDataAdapter(strSponsorQuery, conn);

           // adapter.Fill(dsBaptismal, "Baptismal");
            adapterSponsor.Fill(dsSponsor, "Sponsor");

           // dsBaptismalAll = dsBaptismal.Copy();
            dsBaptismalAll.Tables[0].Merge(dsSponsor.Tables[0], true);
            
            rptBaptismal.SetDataSource(dsBaptismalAll.Tables[0]);
            //rptBapti smal.Subreports["rptSponsor"].SetDataSource(dsSponsor.Tables[0]);
            newViewer.crystalReportViewer.ReportSource = rptBaptismal;
            newViewer.crystalReportViewer.Refresh();
            newViewer.ShowDialog();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            this.ConfigureCrystalReports();
        }

        private void lstRecords_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstRecords.Columns[e.ColumnIndex].Width;
        }
    }
}
