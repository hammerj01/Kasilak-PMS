using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Sponsor : Person
    {
        protected int iSponsorID;
        protected String strEventNo;
        protected String strEvent;

        public int SponsorID
        {
            get { return this.iSponsorID; }

            set { this.iSponsorID = value; }
        }

        public String EventNo
        {
            get { return this.strEventNo; }

            set { this.strEventNo = value; }
        }

        public String Event
        {
            get { return this.strEvent; }

            set { this.strEvent = value; }
        }

        public void AddNew(Sponsor newSponsor)
        {
            MySqlCommand comm = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblSponsor(PersonID,EventNo,Event) VALUES ('" + this.PersonID + "','" + this.EventNo + "','" + this.Event + "')";

                comm.Connection = conn;
                comm.CommandText = strQuery;
                comm.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
