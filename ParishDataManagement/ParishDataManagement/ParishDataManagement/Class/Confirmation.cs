﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Confirmation
    {
        protected String strConfirmationID;
        protected int iPersonID;
        protected int iParentsIDForMother;
        protected int iParentsIDForFather;
        protected int iBookID;
        protected int iMinisterNo;
        protected String strDateofConfirmation;
        protected String strPlaceofConfirmation;
        protected String strDateofBaptism;
        protected String strPlaceofBaptism;
        protected String strAddress;
        protected String strAnnotation;

        public String ConfirmationID
        {
            get { return this.strConfirmationID; }

            set { this.strConfirmationID = value; }
        }

        public int PersonID
        {
            get { return this.iPersonID; }

            set { this.iPersonID = value; }
        }

        public int ParentsIDForMother
        {
            get { return this.iParentsIDForMother; }

            set { this.iParentsIDForMother = value; }
        }

        public int ParentsIDForFather
        {
            get { return this.iParentsIDForFather; }

            set { this.iParentsIDForFather = value; }
        }

        public int BookID
        {
            get { return this.iBookID; }

            set { this.iBookID = value; }
        }

        public int MinisterID
        {
            get { return this.iMinisterNo; }

            set { this.iMinisterNo = value; }
        }

        public String DateofConfirmation
        {
            get { return this.strDateofConfirmation; }

            set { this.strDateofConfirmation = value; }
        }

        public String PlaceofConfirmation
        {
            get { return this.strPlaceofConfirmation; }

            set { this.strPlaceofConfirmation = value; }
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

        public String Address
        {
            get { return this.strAddress; }

            set { this.strAddress = value; }
        }

        public String Annotation
        {
            get { return this.strAnnotation; }

            set { this.strAnnotation = value; }
        }

        public void AddNew(Confirmation newConfirmation)
        {
            MySqlCommand comm = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblConfirmation(ConfirmationID,PersonID,ParentsIDForFather,ParentsIDForMother,DateofConfirmation," +
                           "MinisterID,BookID,DateofBaptism,PlaceofBaptism,Resident,PlaceofConfirmation,Annotation) VALUES" +
                           " ('" + this.ConfirmationID + "','" + this.PersonID + "','" + this.ParentsIDForFather + "','" + this.ParentsIDForMother + "','" + this.DateofConfirmation + "'," +
                           "'" + this.MinisterID + "','" + this.BookID + "','" + this.DateofBaptism + "','" + this.PlaceofBaptism + "','" + this.Address + "'," +
                           "'" + this.PlaceofConfirmation + "','" + this.Annotation + "')";

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
