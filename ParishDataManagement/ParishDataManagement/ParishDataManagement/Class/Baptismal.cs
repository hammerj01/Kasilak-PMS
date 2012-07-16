using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Baptismal : Person
    {
        protected String strBaptismalID;
        protected String strResident;
        protected String strDateofBaptism;
        protected String strNotes;
        protected String strPlaceofBaptism;
        protected String strBookID;
        protected int iParentsNoForFather;
        protected int iParentsNoForMother;
        protected int iMinisterNo;
        protected int iSponsorNo;


        public String BaptismalID
        {
            get { return this.strBaptismalID; }

            set { this.strBaptismalID = value; }
        }

        public String Resident
        {
            get { return this.strResident; }

            set { this.strResident = value; }
        }

        public String DateofBaptism
        {
            get { return this.strDateofBaptism; }

            set { this.strDateofBaptism = value; }
        }

        public String Notes
        {
            get { return this.strNotes; }

            set { this.strNotes = value; }
        }

        public String BookID
        {
            get { return this.strBookID; }

            set { this.strBookID = value; }
        }

        public String PlaceofBaptism
        {
            get { return this.strPlaceofBaptism; }

            set { this.strPlaceofBaptism = value; }
        }

        public int ParentsNoForFather
        {
            get { return this.iParentsNoForFather; }

            set { this.iParentsNoForFather = value; }
        }

        public int ParentsNoForMother
        {
            get { return this.iParentsNoForMother; }

            set { this.iParentsNoForMother = value; }
        }

        public int MinisterNo
        {
            get { return this.iMinisterNo; }

            set { this.iMinisterNo = value; }
        }

        public int SponsorNo
        {
            get { return this.iSponsorNo; }

            set { this.iSponsorNo = value; }
        }

        public void AddNew(Baptismal newBaptismal)
        {
            MySqlCommand comm = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblBaptismal(BaptismalID,PersonID,BookID,MinisterNo,ParentsIDForFather,ParentsIDForMother,DateofBaptism,Resident,Annotation,PlaceofBaptism) VALUES" +
                           " ('" + this.BaptismalID + "','" + this.PersonID + "','" + this.BookID + "','" + this.MinisterNo + "','" + this.ParentsNoForFather + "','" + this.ParentsNoForMother + "'," +
                           "'" + this.DateofBaptism + "','" + this.Resident + "','" + this.Notes + "','" + this.PlaceofBaptism + "')";

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

        public String GetBaptismalIDByPersonID(int iPersonID)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            String value = null;

            strQuery = "SELECT BaptismalID FROM tblBaptismal WHERE PersonID ='" + iPersonID + "'";

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

        public String GetBaptismalDateByBaptismalID(String strBaptismalID)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            String value = null;

            strQuery = "SELECT DateofBaptism FROM tblBaptismal WHERE BaptismalID ='" + strBaptismalID + "'";

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

        public String GetPlaceofBaptismByBaptismalID(String strBaptismalID)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            String value = null;

            strQuery = "SELECT PlaceofBaptism FROM tblBaptismal WHERE BaptismalID ='" + strBaptismalID + "'";

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

        public int GetParentsIDByBaptismalID(String strBaptismalID, String strField) 
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            int value = 0;

            strQuery = "SELECT " + strField + " FROM tblBaptismal WHERE BaptismalID ='" + strBaptismalID + "'";

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

        public void SetBaptismalInfo(String strBaptismalID)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            strQuery = "SELECT * FROM tblBaptismal WHERE BaptismalID ='" + strBaptismalID + "'";

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
                        this.BaptismalID = reader.GetValue(0).ToString();
                        this.PersonID = Convert.ToInt16(reader.GetValue(1).ToString());
                        this.BookID = reader.GetValue(2).ToString();
                        this.MinisterNo = Convert.ToInt16(reader.GetValue(3).ToString());
                        this.ParentsNoForFather = Convert.ToInt16(reader.GetValue(4).ToString());
                        this.ParentsNoForMother = Convert.ToInt16(reader.GetValue(5).ToString());
                        this.DateofBaptism = reader.GetValue(6).ToString();
                        this.Resident = reader.GetValue(7).ToString();
                        this.PlaceofBaptism = reader.GetValue(9).ToString();
                    }
                    reader.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
