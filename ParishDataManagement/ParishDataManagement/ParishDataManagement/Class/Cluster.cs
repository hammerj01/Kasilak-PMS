using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Cluster : Chapel
    {
        protected int iClusterID;

        public int ClusterID
        {
            get { return this.iClusterID; }

            set { this.iClusterID = value; }
        }

        public void AddNew(Cluster newCluster)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblCluster(ChapelID,ClusterName) VALUES ('" + newCluster.ChapelID + "','" + newCluster.PlaceName + "')";

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
