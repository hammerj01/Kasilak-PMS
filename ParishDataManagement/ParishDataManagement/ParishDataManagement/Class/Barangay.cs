using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Barangay : Town
    {
        protected int iBarangayID;

        public int BarangayID
        {
            get { return this.iBarangayID; }

            set { this.iBarangayID = value; }
        }

        public void AddNew(Barangay newBarangay)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblBarangay(TownID,BarangayName) VALUES ('" + newBarangay.TownID + "','" + newBarangay.PlaceName + "')";

                comm.Connection = conn;
                comm.CommandText = strQuery;
                comm.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
