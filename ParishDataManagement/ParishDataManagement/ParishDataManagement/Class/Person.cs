﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParishDataManagement
{
    class Person
    {
        protected int iPersonID;
        protected String strLastname;
        protected String strMiddlename;
        protected String strFirstname;
        protected String strBirthdate;
        protected String strBirthplace;
        protected String strGender;
        protected String strStatus;
        protected int iClusterID;
        protected int iParentIDForMother;
        protected int iParentIDForFather;

        public int PersonID
        {
            get { return this.iPersonID; }

            set { this.iPersonID = value; }
        }

        public String Lastname
        {
            get { return this.strLastname; }

            set { this.strLastname = value; }
        }

        public String Middlename
        {
            get { return this.strMiddlename; }

            set { this.strMiddlename = value; }
        }

        public String Firstname
        {
            get { return this.strFirstname; }

            set { this.strFirstname = value; }
        }

        public String Birthdate
        {
            get { return this.strBirthdate; }

            set { this.strBirthdate = value; }
        }

        public String Birthplace
        {
            get { return this.strBirthplace; }

            set { this.strBirthplace = value; }
        }

        public String Gender
        {
            get { return this.strGender; }

            set { this.strGender = value; }
        }

        public String Status
        {
            get { return this.strStatus; }

            set { this.strStatus = value; }
        }

        public int ClusterID
        {
            get { return this.iClusterID; }

            set { this.iClusterID = value; }
        }

        public int ParentIDForFather
        {
            get { return this.iParentIDForFather; }

            set { this.iParentIDForFather = value; }
        }

        public int ParentIDForMother
        {
            get { return this.iParentIDForMother; }

            set { this.iParentIDForMother = value; }
        }

        public void AddNew(Person newPerson)
        {
            MySqlCommand comm = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            String strQuery = null;

            try
            {
                conn.Open();
                strQuery = "INSERT INTO tblPerson(Lastname,Middlename,Firstname,Birthdate,BirthPlace,Gender,Status,ClusterID,ParentIDForFather,ParentIDForMother) VALUES" +
                           " ('" + this.Lastname + "','" + this.Middlename + "','" + this.Firstname + "','" + this.Birthdate + "','" + this.Birthplace + "','" +
                           this.Gender + "','" + this.Status + "','" + this.ClusterID + "','" + this.ParentIDForFather + "','" + this.ParentIDForMother + "')";

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

        public bool PersonExist(Person newPerson)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            bool value = false;

            strQuery = "SELECT * FROM tblPerson WHERE Firstname='" + this.Firstname + "' AND Middlename='" + this.Middlename + "' AND Lastname='" + this.Lastname + "'";

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

        public int GetPersonIDByName(Person newPerson)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            int value = 0;

            strQuery = "SELECT PersonID FROM tblPerson WHERE Firstname='" + this.Firstname + "' OR Middlename='" + this.Middlename + "' AND Lastname='" + this.Lastname + "'";

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

        public String GetPersonNameByID(int iPersonID)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            String value = null;

            strQuery = "SELECT CONCAT(Firstname ,' ', Middlename ,' ', Lastname) as Fullname FROM tblPerson WHERE PersonID ='" + iPersonID + "'";

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

        public void SetPersonInfo(int iPersonID)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            strQuery = "SELECT * FROM tblPerson WHERE PersonID ='" + iPersonID + "'";

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
                        this.PersonID = Convert.ToInt16(reader.GetValue(0).ToString());
                        this.Lastname = reader.GetValue(1).ToString();
                        this.Middlename = reader.GetValue(2).ToString();
                        this.Firstname = reader.GetValue(3).ToString();
                        this.Birthdate = reader.GetValue(4).ToString();
                        this.Birthplace = reader.GetValue(5).ToString();
                        this.Gender = reader.GetValue(6).ToString();
                        this.Status = reader.GetValue(7).ToString();
                        this.ClusterID = Convert.ToInt16(reader.GetValue(8).ToString());
                        this.ParentIDForFather = Convert.ToInt16(reader.GetValue(9).ToString());
                        this.ParentIDForMother = Convert.ToInt16(reader.GetValue(10).ToString());
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

        public int GetParentIDByPersonID(int iPersonID, String strField)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            int value = 0;

            strQuery = "SELECT " + strField + " FROM tblPerson WHERE PersonID ='" + iPersonID + "'";

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

        public String GetPersonGenderByID(int iPersonID)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
            MySqlCommand comm = new MySqlCommand();
            MySqlDataReader reader = null;
            String strQuery = null;

            //default
            String value = null;

            strQuery = "SELECT Gender FROM tblPerson WHERE PersonID ='" + iPersonID + "'";

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
    }
}
