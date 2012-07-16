using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Province : Place
    {
        protected int iProvinceID;

        public int ProvinceID
        {
            get { return this.iProvinceID; }

            set { this.iProvinceID = value; }
        }

        public void AddNew(Province newProvince)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblProvince(ProvinceName) VALUES ('" + this.PlaceName + "')";

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

        public void Update(Province currProvince)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "UPDATE tblProvince SET ProvinceName='" + this.PlaceName + "' WHERE ProvinceID= " + this.ProvinceID;
                
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
