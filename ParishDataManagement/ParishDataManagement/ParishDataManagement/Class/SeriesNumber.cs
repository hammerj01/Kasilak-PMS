using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace ParishDataManagement
{
    class SeriesNumber
    {
        protected String strYear;
        protected int iBaptismalSeries;
        protected int iConfirmationSeries;
        protected int iDeathSeries;
        protected int iMarriageSeries;
        protected String strStatus;

        public String Year
        {
            get { return this.strYear; }

            set { this.strYear = value; }
        }

        public int BaptismalSeries
        {
            get { return this.iBaptismalSeries; }

            set { this.iBaptismalSeries = value; }
        }

        public int ConfirmationSeries
        {
            get { return this.iConfirmationSeries; }

            set { this.iConfirmationSeries = value; }
        }

        public int DeathSeries
        {
            get { return this.iDeathSeries; }

            set { this.iDeathSeries = value; }
        }

        public int MarriageSeries
        {
            get { return this.iMarriageSeries; }

            set { this.iMarriageSeries = value; }
        }

        public String Status
        {
            get { return this.strStatus; }

            set { this.strStatus = value; }
        }

        public void AddNew(SeriesNumber newSeriesNumber)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionStringforSystem);
            MySqlCommand comm = new MySqlCommand();
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblSeriesNumber(Year,BaptismalSeries,ConfirmationSeries,DeathSeries,MarriageSeries,Status) VALUES" +
                           " ('" + newSeriesNumber.Year + "','" + newSeriesNumber.BaptismalSeries + "','" + newSeriesNumber.ConfirmationSeries + "','" + newSeriesNumber.DeathSeries + "','" + newSeriesNumber.MarriageSeries + "','" + newSeriesNumber.Status + "')";

                comm.Connection = conn;
                comm.CommandText = strQuery;
                comm.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public void Update(SeriesNumber currSeriesNumber, String strFieldname, int iSeriesNumber)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionStringforSystem);
            MySqlCommand comm = new MySqlCommand();
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "UPDATE tblSeriesNumber SET " + strFieldname + "='" + iSeriesNumber + "' WHERE Year=" + currSeriesNumber.Year + "";

                comm.Connection = conn;
                comm.CommandText = strQuery;
                comm.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public void UpdateStatus(SeriesNumber currSeriesNumber)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionStringforSystem);
            MySqlCommand comm = new MySqlCommand();
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "UPDATE tblSeriesNumber SET Status ='" + currSeriesNumber.Status + "' WHERE Year=" + currSeriesNumber.Year + "";

                comm.Connection = conn;
                comm.CommandText = strQuery;
                comm.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public bool YearExist(SeriesNumber newSeriesNumber)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionStringforSystem);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            bool value = false;

            strQuery = "SELECT Year FROM tblSeriesNumber WHERE Year='" + newSeriesNumber.Year + "'";

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

        public String GetActiveYear()
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionStringforSystem);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;
            String strStatus = "Active";

            //default
            String value = null;

            strQuery = "SELECT Year FROM tblSeriesNumber WHERE Status='" + strStatus + "'";

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

        public String GetSeriesNumberByYear(String strYear, String strField)
        {
             MySqlConnection conn = new MySqlConnection(MyConnection.connectionStringforSystem);
             MySqlCommand comm = new MySqlCommand();
             MySqlDataReader reader = null;
             String strQuery = null;
             String value = null;
             int counter, ctr;
        
             //default
             value = null;

             strQuery = "SELECT " + strField + " FROM tblSeriesNumber WHERE Year = '" + strYear + "'";

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
                            ctr = Convert.ToInt16(reader.GetValue(0).ToString());
                            counter = Convert.ToInt16(ctr) + 1;
                            value = Strings.StrDup(4-Strings.Len(Convert.ToString(counter)),"0") + counter;
                            
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

        public bool IsActive()
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionStringforSystem);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            bool value = false;

            strQuery = "SELECT * FROM tblSeriesNumber WHERE Status='Active'";

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