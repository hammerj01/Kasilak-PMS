using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Chapel : Barangay
    {
        protected int iChapelID;

        public int ChapelID
        {
            get { return this.iChapelID; }

            set { this.iChapelID = value; }
        }

        public void AddNew(Chapel newChapel)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblChapel(BarangayID,ChapelName) VALUES ('" + newChapel.BarangayID + "','" + newChapel.PlaceName + "')";

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
