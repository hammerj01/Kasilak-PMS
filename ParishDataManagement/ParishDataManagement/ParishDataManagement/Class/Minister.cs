using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Minister : Person
    {
        protected int iMinisterNo;
        protected String strTitle;

        public int MinisterNo
        {
            get { return this.iMinisterNo; }

            set { this.iMinisterNo = value; }
        }

        public String Title
        {
            get { return this.strTitle; }

            set { this.strTitle = value; }
        }

        public void AddNew(Minister newMinister)
        {
            MySqlCommand comm = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblMinister(PersonID, Title) VALUES ('" + this.PersonID + "','" + this.Title + "')";

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
