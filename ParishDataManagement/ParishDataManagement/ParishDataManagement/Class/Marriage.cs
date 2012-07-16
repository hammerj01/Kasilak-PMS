using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Marriage : Person
    {
        protected String strMarriageID;
        protected int iPersonIDHusband;
        protected int iPersonIDWife;
        protected int iParentsIDForMotherHusband;
        protected int iParentsIDForFatherHusband;
        protected int iParentsIDForMotherWife;
        protected int iParentsIDForFatherWife;
        protected int iBookID;
        protected int iMinisterNo;
        protected String strLicenseNo;
        protected String strDateofMarriage;
        protected String strPlaceofMarriage;
        protected String strDateofBaptism;
        protected String strPlaceofBaptism;
        protected String strAnnotation;

        public String MarriageID
        {
            get { return this.strMarriageID; }

            set { this.strMarriageID = value; }
        }

        public int PersonIDHusband
        {
            get { return this.iPersonIDHusband; }

            set { this.iPersonIDHusband = value; }
        }

        public int PersonIDWife
        {
            get { return this.iPersonIDWife; }

            set { this.iPersonIDWife = value; }
        }

        public int BookID
        {
            get { return this.iBookID; }

            set { this.iBookID = value; }
        }

        public int MinisterNo
        {
            get { return this.iMinisterNo; }

            set { this.iMinisterNo = value; }
        }

        public int ParentsIDForFatherWife
        {
            get { return this.iParentsIDForFatherWife; }

            set { this.iParentsIDForFatherWife = value; }
        }

        public int ParentsIDForFatherHusband
        {
            get { return this.iParentsIDForFatherHusband; }

            set { this.iParentsIDForFatherHusband = value; }
        }

        public int ParentsIDForMotherWife
        {
            get { return this.iParentsIDForMotherWife; }

            set { this.iParentsIDForMotherWife = value; }
        }

        public int ParentsIDForMotherHusband
        {
            get { return this.iParentsIDForMotherHusband; }

            set { this.iParentsIDForMotherHusband = value; }
        }

        public String LicenseNo
        {
            get { return this.strLicenseNo; }

            set { this.strLicenseNo = value; }
        }

        public String DateofMarriage
        {
            get { return this.strDateofMarriage; }

            set { this.strDateofMarriage = value; }
        }

        public String PlaceofMarriage
        {
            get { return this.strPlaceofMarriage; }

            set { this.strPlaceofMarriage = value; }
        }

        public String DateofBaptism
        {
            get { return this.strDateofBaptism; }

            set { this.strDateofBaptism = value; }
        }

        public String PlaceofBaptism
        {
            get { return this.strPlaceofBaptism; }

            set { this.strPlaceofBaptism = value; }
        }

        public String Annotation
        {
            get { return this.strAnnotation; }

            set { this.strAnnotation = value; }
        }

        public void AddNew(Marriage newMarriage)
        {
            MySqlCommand comm = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblMarriage(MarriageID,PersonID_Husband,PersonID_Wife,BookID,MinisterNo,ParentsIDForMotherHusband,ParentsIDForFatherHusband," +
                           "ParentsIDForMotherWife,ParentsIDForFatherWife,LicenseNo,DateofMarriage,DateofBaptism,PlaceofBaptism,Annotation,PlaceofMarriage) VALUES" +
                           " ('" + this.MarriageID + "','" + this.PersonIDHusband + "','" + this.PersonIDWife + "','" + this.BookID + "','" + this.MinisterNo + "','" + this.ParentsIDForMotherHusband + "'," +
                           "'" + this.ParentsIDForFatherHusband + "','" + this.ParentsIDForMotherWife + "','" + this.ParentsIDForFatherWife + "','" + this.LicenseNo + "','" + this.DateofMarriage + "'," +
                           "'" + this.DateofBaptism + "','" + this.PlaceofBaptism + "','" + this.Annotation + "','" + this.PlaceofMarriage + "')";

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

        public int GetSpouseIDByPersonID(int iPersonID, String strGender)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            int value = 0;

            if (strGender == "Male")
            {
                strQuery = "SELECT PersonID_Wife FROM tblMarriage WHERE PersonID_Husband ='" + iPersonID + "'";
            }
            else strQuery = "SELECT PersonID_Husband FROM tblMarriage WHERE PersonID_Wife ='" + iPersonID + "'";

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
    }
}
