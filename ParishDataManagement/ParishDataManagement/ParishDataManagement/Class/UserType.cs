using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class UserType
    {
        protected int iUserTypeID;
        protected String strUserType;

        public int UserTypeID
        {
            get { return this.iUserTypeID; }

            set { this.iUserTypeID = value; }
        }

        public String _UserType
        {
            get { return this.strUserType; }

            set { this.strUserType = value; }
        }

        public void AddNew(UserType newUserType)
        {
            MyConnection newConnection = new MyConnection();
            MySqlCommand comm = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(newConnection.ConnectionString);

            try
            {
                conn.Open();

                String strQuery = "INSERT INTO tblUserType(UserType) VALUES ('" + newUserType._UserType + "')";

                comm.Connection = conn;
                comm.CommandText = strQuery;
                comm.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PMIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

    }
}
