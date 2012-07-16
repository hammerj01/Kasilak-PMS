using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParishDataManagement;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class User : UserType
    {
        protected int iUserID;
        protected String strUsername;
        protected String strPassword;
        MySqlConnection conn = new MySqlConnection(MyConnection.connectionStringforSystem);

        public int UserID
        {
            get { return this.iUserID; }

            set { this.iUserID = value; }
        }

        public String Username
        {
            get { return this.strUsername; }

            set { this.strUsername = value; }
        }

        public String Password
        {
            get { return this.strPassword; }

            set { this.strPassword = value; }
        }

        public void AddNew(User newUser)
        {
            MyConnection newConnection = new MyConnection();
            MySqlCommand comm = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(newConnection.ConnectionString);

            try
            {
                conn.Open();

                String strQuery = "INSERT INTO tblUser(UserTypeID, Username, Password) VALUES" +
                                  " ('" + newUser.UserTypeID + "','" + newUser.strUsername + "','" + newUser.strPassword + "')";
                
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

        public bool UsernameExist(String strUsername)
        {
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;
            
            //default
            bool value = false;

            strQuery = "SELECT * FROM tblUser WHERE Username='" + strUsername + "'";

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = strQuery;
                reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        value = true;
                    }
                    reader.Close();
                    value = true;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "PMIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            conn.Close();
            return value;
        }

        public bool PasswordExist(String strPassword)
        {
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            bool value = false;

            strQuery = "SELECT * FROM tblUser WHERE Password='" + strPassword + "'";

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = strQuery;
                reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        value = true;
                    }
                    reader.Close();
                    value = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PMIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            conn.Close();
            return value;
        }
    }
}
