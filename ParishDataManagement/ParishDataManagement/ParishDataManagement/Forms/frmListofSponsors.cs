using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    public partial class frmListofSponsors : Form
    {
        Person newPerson = new Person();
        String strSearchByStatus = null;
        String strSponsorType = null;
        String[] arrSponsor = new String[0];
        int ctr = 0;

        public frmListofSponsors()
        {
            InitializeComponent();
        }

        private void frmListofSponsors_Load(object sender, EventArgs e)
        {
            String strQuery = "SELECT Firstname,Middlename,Lastname,BirthPlace,PersonID FROM tblPerson";

            switch (this.strSponsorType)
            { 
                case "Baptismal":
                    arrSponsor = new String[5];
                    SystemVariable.arrSponsorPersonID = new String[5];
                    SystemVariable.arrSponsorFirstname = new String[5];
                    SystemVariable.arrSponsorMiddlename = new String[5];
                    SystemVariable.arrSponsorLastname = new String[5];
                    SystemVariable.arrSponsorAddress = new String[5];
                    break;

                case "Marriage":
                    arrSponsor = new String[20];
                    SystemVariable.arrSponsorPersonID = new String[5];
                    SystemVariable.arrSponsorFirstname = new String[5];
                    SystemVariable.arrSponsorMiddlename = new String[5];
                    SystemVariable.arrSponsorLastname = new String[5];
                    SystemVariable.arrSponsorAddress = new String[5];
                    break;

                case "Confirmation":
                    arrSponsor = new String[5];
                    SystemVariable.arrSponsorPersonID = new String[5];
                    SystemVariable.arrSponsorFirstname = new String[5];
                    SystemVariable.arrSponsorMiddlename = new String[5];
                    SystemVariable.arrSponsorLastname = new String[5];
                    SystemVariable.arrSponsorAddress = new String[5];
                    break;
            }

            Procedure.PopulateListView(lstSponsor, strQuery);
            cboSearchBy.SelectedIndex = 0;
        }

        private void cboSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            strSearchByStatus = cboSearchBy.Text;
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            String strQuery = null;

            if(String.IsNullOrEmpty(txtKeyword.Text))
            {
                strQuery = "SELECT t.Firstname,t.Middlename,t.Lastname,t.BirthPlace,t.PersonID,Sponsor.PersonID AS Sponsor FROM tblPerson t" +
                                   " LEFT JOIN tblPerson as Sponsor ON t.PersonID = Sponsor.PersonID WHERE t.PersonID IN ('" + arrSponsor[0] + "','" + arrSponsor[1] + "','" + arrSponsor[2] + "','" + arrSponsor[3] + "','" + arrSponsor[4] + "')" +
                " UNION SELECT t1.Firstname,t1.Middlename,t1.Lastname,t1.BirthPlace,t1.PersonID,t1.PersonID FROM dbparish.tblperson t1"; 
                //" WHERE t1.Firstname LIKE '%" + txtKeyword.Text + "%' OR Middlename LIKE '%" + txtKeyword.Text + "%' OR Lastname LIKE '%" + txtKeyword.Text + "%'";
            }
            else
            {
                switch (strSearchByStatus)
                { 
                    case "All":
                        strQuery = "SELECT t.Firstname,t.Middlename,t.Lastname,t.BirthPlace,t.PersonID,Sponsor.PersonID AS Sponsor FROM tblPerson t" +
                                   " LEFT JOIN tblPerson as Sponsor ON t.PersonID = Sponsor.PersonID WHERE t.PersonID IN ('" + arrSponsor[0] + "','" + arrSponsor[1] + "','" + arrSponsor[2] + "','" + arrSponsor[3] + "','" + arrSponsor[4] + "')" +
                                   " UNION SELECT t1.Firstname,t1.Middlename,t1.Lastname,t1.BirthPlace,t1.PersonID,t1.PersonID FROM dbparish.tblperson t1" +
                                   " WHERE t1.Firstname LIKE '%" + txtKeyword.Text + "%' OR Middlename LIKE '%" + txtKeyword.Text + "%' OR Lastname LIKE '%" + txtKeyword.Text + "%'";
                        break;

                    case "Firstname":
                        strQuery = "SELECT t.Firstname,t.Middlename,t.Lastname,t.BirthPlace,t.PersonID,Sponsor.PersonID AS Sponsor FROM tblPerson t" +
                                   " LEFT JOIN tblPerson as Sponsor ON t.PersonID = Sponsor.PersonID WHERE t.PersonID IN ('" + arrSponsor[0] + "','" + arrSponsor[1] + "','" + arrSponsor[2] + "','" + arrSponsor[3] + "','" + arrSponsor[4] + "')" +
                                   " UNION SELECT t1.Firstname,t1.Middlename,t1.Lastname,t1.BirthPlace,t1.PersonID,t1.PersonID FROM dbparish.tblperson t1" +
                                   " WHERE t1.Firstname LIKE '%" + txtKeyword.Text + "%'";
                        break;

                    case "Middlename":
                        strQuery = "SELECT t.Firstname,t.Middlename,t.Lastname,t.BirthPlace,t.PersonID,Sponsor.PersonID AS Sponsor FROM tblPerson t" +
                                   " LEFT JOIN tblPerson as Sponsor ON t.PersonID = Sponsor.PersonID WHERE t.PersonID IN ('" + arrSponsor[0] + "','" + arrSponsor[1] + "','" + arrSponsor[2] + "','" + arrSponsor[3] + "','" + arrSponsor[4] + "')" +
                                   " UNION SELECT t1.Firstname,t1.Middlename,t1.Lastname,t1.BirthPlace,t1.PersonID,t1.PersonID FROM dbparish.tblperson t1" +
                                   " WHERE Middlename LIKE '%" + txtKeyword.Text + "%'";
                        break;

                    case "Lastname":
                        strQuery = "SELECT t.Firstname,t.Middlename,t.Lastname,t.BirthPlace,t.PersonID,Sponsor.PersonID AS Sponsor FROM tblPerson t" +
                                   " LEFT JOIN tblPerson as Sponsor ON t.PersonID = Sponsor.PersonID WHERE t.PersonID IN ('" + arrSponsor[0] + "','" + arrSponsor[1] + "','" + arrSponsor[2] + "','" + arrSponsor[3] + "','" + arrSponsor[4] + "')" +
                                   " UNION SELECT t1.Firstname,t1.Middlename,t1.Lastname,t1.BirthPlace,t1.PersonID,t1.PersonID FROM dbparish.tblperson t1" +
                                   " WHERE Lastname LIKE '%" + txtKeyword.Text + "%'";
                        break;
                }  
            }
            this.PopulateSponsorList(strQuery);
        }

        private void lstSponsor_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < lstSponsor.Items.Count; x++)
            {
                if (lstSponsor.Items[x].Selected)
                {
                    if (lstSponsor.Items[x].Checked)
                    {
                        lstSponsor.Items[x].Checked = false;
                        int iSponsorID = Array.IndexOf(arrSponsor, lstSponsor.Items[x].SubItems[4].Text);
                           if (iSponsorID > -1)
                           {
                                arrSponsor[iSponsorID] = null;
                                ctr--;
                           }
                    }
                    else
                    {
                        if (ctr < (arrSponsor.Length))
                        {
                            lstSponsor.Items[x].Checked = true;
                            int SponsorID = Array.IndexOf(arrSponsor, null);
                            arrSponsor[SponsorID] = lstSponsor.Items[x].SubItems[4].Text;
                            ctr++;
                        }
                        else
                            MessageBox.Show("The sponsors the you've selected exceeds the limit.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void lnkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtKeyword.Text = "";
            lstSponsor.Refresh();
        }

        private void PopulateSponsorList(String strQuery)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;

            ListViewItem lstItem = null;
            int x;

            lstSponsor.Items.Clear();

            conn.Open();
            comm.Connection = conn;
            comm.CommandText = strQuery;
            reader = comm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lstItem = lstSponsor.Items.Add(reader.GetValue(0).ToString());
                    for (x = 1; x < reader.FieldCount; x++)
                    {
                        lstItem.SubItems.Add(reader.GetValue(x).ToString());
                        if (arrSponsor.Contains(reader.GetValue(4).ToString()))
                            lstSponsor.Items[x-1].Checked = true;
                    }
                }
            }
            conn.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int x = 0; x < lstSponsor.Items.Count; x++)
            {
                if (lstSponsor.Items[x].Checked)
                {
                    SystemVariable.arrSponsorPersonID[counter] = lstSponsor.Items[x].SubItems[4].Text;
                    SystemVariable.arrSponsorFirstname[counter] = lstSponsor.Items[x].Text;
                    SystemVariable.arrSponsorMiddlename[counter] = lstSponsor.Items[x].SubItems[1].Text;
                    SystemVariable.arrSponsorLastname[counter] = lstSponsor.Items[x].SubItems[2].Text;
                    SystemVariable.arrSponsorAddress[counter] = lstSponsor.Items[x].SubItems[3].Text;
                    counter++;
                }
            }
            this.Close();
        }

        private void lstSponsor_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //this.lstSponsor_SelectedIndexChanged(sender, e);
        }

        public void SetSponsorType(String strType)
        {
            this.strSponsorType = strType;
        }
    }
}
