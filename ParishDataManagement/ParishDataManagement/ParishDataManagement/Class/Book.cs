using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Book
    {
        protected int iID;
        protected String strBookNo;
        protected String strCategory;
        protected String strStatus;

        public int ID
        {
            get { return this.iID; }

            set { this.iID = value; }
        }

        public String BookNo
        {
            get { return this.strBookNo; }

            set { this.strBookNo = value; }
        }

        public String Status
        {
            get { return this.strStatus; }

            set { this.strStatus = value; }
        }

        public String Category
        {
            get { return this.strCategory; }

            set { this.strCategory = value; }
        }

        public void AddNew(Book newBook)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            String strQuery = null;

            try 
            {
                conn.Open();
                strQuery = "INSERT INTO tblBook(BookNo,Status,Category) VALUES ('" + newBook.BookNo + "','" + newBook.Status + "','" + newBook.Category + "')";
                comm.Connection = conn;
                comm.CommandText = strQuery;
                comm.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public bool BookNoExist(Book newBook)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            bool value = false;

            strQuery = "SELECT * FROM tblBook WHERE BookNo='" + newBook.BookNo + "' AND Category='" + newBook.Category + "'";

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
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            conn.Close();
            return value;
        }

        public String GetActiveBook(String strCategory)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;
            String strStatus = "Active";

            //default
            String value = null;

            strQuery = "SELECT BookNo FROM tblBook WHERE Status='" + strStatus + "' AND Category='" + strCategory + "'";

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
                        value = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                    return value;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = null;
            }
            conn.Close();
            return value;
        }

        public int GetBookIDByNo(String strBookNo) 
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;
            String strStatus = "Active";

            //default
            int value = 0;

            strQuery = "SELECT BookID FROM tblBook WHERE Status='" + strStatus + "' AND BookNo='" + strBookNo + "'";

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

        public bool GetActiveStatus(String strCategory)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;
            String strStatus = "Active";

            //default
            bool value = false;

            strQuery = "SELECT * FROM tblBook WHERE Status='" + strStatus + "' AND Category='" + strCategory + "'";

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
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            conn.Close();
            return value;
        }
    }
}
