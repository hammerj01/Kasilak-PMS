using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class MyConnection
    {
        protected MySqlConnection conn;
        public static String connectionString = "Server=localhost; Database=dbParish; UID=root; PWD=root;";
        public static String connectionStringforSystem = "Server=localhost; Database=dbSystem; UID=root; PWD=root;";

        public String ConnectionString
        {
            get { return connectionString; }

            set { connectionString = value; }
        }

        public String ConnectionStringforSystem
        {
            get { return connectionStringforSystem; }

            set { connectionStringforSystem = value; }
        }

        public void OpenConnection(String strConnection)
        {
            conn = new MySqlConnection(strConnection);

            if (conn.ConnectionString != string.Empty || conn.ConnectionString != null)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Application.Exit();
                    }
                }
            } 
        }

        public void CloseConnection()
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
            }
        }

        public bool CheckConnectionState()
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open)
                {
                    return true;
                }
            }
            return false;  
        }

    }
}
