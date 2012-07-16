using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Death : Person
    {
        protected String strDeathID;
        protected int iParentID;
        protected int iSpouseID;
        protected int iMinisterID;
        protected int iBookID;
        protected String strDateofDeath;
        protected String strPlaceofBurial;
        protected String strDateofBurial;
        protected String strSacraments;
        protected String strResident;

        public String DeathID
        {
            get { return this.strDeathID; }

            set { this.strDeathID = value; }
        }

        public int ParentID 
        {
            get { return this.iParentID; }

            set { this.iParentID = value; }
        }

        public int SpouseID 
        {
            get { return this.iSpouseID; }

            set { this.iSpouseID = value; }
        }

        public int MinisterID 
        {
            get { return this.iMinisterID; }

            set { this.iMinisterID = value; }
        }

        public int BookID 
        {
            get { return this.iBookID; }

            set { this.iBookID = value; }
        }

        public String DateofDeath 
        {
            get { return this.strDateofDeath; }

            set { this.strDateofDeath = value; }
        }

        public String PlaceofBurial 
        {
            get { return this.strPlaceofBurial; }

            set { this.strPlaceofBurial = value; }
        }

        public String DateofBurial 
        {
            get { return this.strDateofBurial; }

            set { this.strDateofBurial = value; }
        }

        public String Sacraments 
        {
            get { return this.strSacraments; }

            set { this.strSacraments = value; }
        }

        public String Resident 
        {
            get { return this.strResident; }

            set { this.strResident = value; }
        }

        public void AddNew(Death newDeath)
        {
            MySqlCommand comm = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblDeath(DeathID,PersonID,ParentsID,SpouseID,DateofDeath,PlaceofBurial,DateofBurial,Sacraments,Resident,MinisterNo,BookID)" +
                           " VALUES ('" + this.DeathID + "','" + this.PersonID + "','" + this.ParentID + "','" + this.SpouseID + "','" + this.DateofDeath + "'," +
                           "'" + this.PlaceofBurial + "','" + this.DateofBurial + "','" + this.Sacraments + "','" + this.Resident + "','" + this.MinisterID + "','" + this.BookID + "')";

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

    }
}
