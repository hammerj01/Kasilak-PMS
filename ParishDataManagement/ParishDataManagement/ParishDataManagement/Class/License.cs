using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class License
    {
        protected String strLicenseNo;
        protected String strDate;
        protected String strAddress;
        protected String strObsDate;
        protected String strObsPlace;
        protected String strObservation;

        public String LicenseNo
        {
            get { return this.strLicenseNo; }

            set { this.strLicenseNo = value; }
        }

        public String Date
        {
            get { return this.strDate; }

            set { this.strDate = value; }
        }

        public String Address
        {
            get { return this.strAddress; }

            set { this.strAddress = value; }
        }

        public String ObsDate
        {
            get { return this.strObsDate; }

            set { this.strObsDate = value; }
        }

        public String ObsPlace
        {
            get { return this.strObsPlace; }

            set { this.strObsPlace = value; }
        }

        public String Observation
        {
            get { return this.strObservation; }

            set { this.strObservation = value; }
        }

        public void AddNew(License newLicense)
        {
            MySqlCommand comm = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblLicense(LicenseNo,Date,Place,Observation,ObservationDate,ObservationPlace) VALUES" +
                           " ('" + this.LicenseNo + "','" + this.Date + "','" + this.Address + "','" + this.Observation + "','" + this.ObsDate + "','" + this.ObsPlace + "')";

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

    }
}
