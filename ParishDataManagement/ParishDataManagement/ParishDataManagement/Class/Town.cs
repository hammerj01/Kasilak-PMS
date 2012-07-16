using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Town : Province
    {
        protected int iTownID;
        protected int iStatus;

        public int TownID
        {
            get { return this.iTownID; }

            set { this.iTownID = value; }
        }

        public int Status
        {
            get { return this.iStatus; }

            set { this.iStatus = value; }
        }

        public void AddNew(Town newTown)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblTown(ProvinceID,TownName,Status) VALUES ('" + newTown.ProvinceID + "','" + newTown.PlaceName + "','" + newTown.Status + "')";

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

        public void Update(Town currTown)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "UPDATE tblTown SET ProvinceID='" + currTown.ProvinceID + "', TownName='" + currTown.PlaceName + "' WHERE TownID='" + currTown.TownID + "'";

                comm.Connection = conn;
                comm.CommandText = strQuery;
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
    }
}
