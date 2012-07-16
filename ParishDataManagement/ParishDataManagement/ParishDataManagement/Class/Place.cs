using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Place
    {
        protected String strPlaceName;

        public String PlaceName
        {
            get { return this.strPlaceName; }

            set { this.strPlaceName = value; }
        }

        public bool IsExist(String strTableName, String strFieldName, Place newPlace)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            bool value = false;

            strQuery = "SELECT * FROM " + strTableName + " WHERE " + strFieldName + "='" + newPlace.PlaceName + "'";

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
