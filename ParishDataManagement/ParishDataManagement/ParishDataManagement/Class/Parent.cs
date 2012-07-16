using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Parent : Person
    {
        protected int iParentID;

        public int ParentID
        {
            get { return this.iParentID; }

            set { this.iParentID = value; }
        }

        public void AddNew(Parent newParent)
        {
            MySqlCommand comm = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblParent(PersonID) VALUES ('" + this.PersonID + "')";

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

        public int GetPersonIDByParentsID(int iParentID)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            int value = 0;

            strQuery = "SELECT PersonID FROM tblParent WHERE ParentsNo ='" + iParentID + "'";

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
                        value = Convert.ToInt16(reader.GetValue(0).ToString());
                    }
                    reader.Close();
                    return value;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = 0;
            }
            conn.Close();
            return value;
        }

        public int GetParentIDByPersonID(int iPersonID)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            int value = 0;

            strQuery = "SELECT ParentsNo FROM tblParent WHERE PersonID ='" + iPersonID + "'";

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
                        value = Convert.ToInt16(reader.GetValue(0).ToString());
                    }
                    reader.Close();
                    return value;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = 0;
            }
            conn.Close();
            return value;
        }
    }
}
