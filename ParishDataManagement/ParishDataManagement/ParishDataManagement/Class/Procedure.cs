using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ParishDataManagement
{
    class Procedure
    {
        public static MySqlConnection conn = new MySqlConnection(MyConnection.connectionString);
        public static MySqlConnection connSystem = new MySqlConnection(MyConnection.connectionStringforSystem);
        public static MySqlCommand comm = new MySqlCommand();
        public static MySqlDataReader reader = null;

        public static void ClearTextbox(Control frm)
        {
            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;
                }
            }
        }

        public static void SetHeaderData(ListView lst, String[] arrHeaderData, int[] headerWidth)
        {
            try
            {
                lst.Columns.Clear();
                for (int i = 0; i <= arrHeaderData.Length - 1; i++) 
                {
                    lst.Columns.Add(new ColumnHeader());
                    lst.Columns[i].Text = arrHeaderData[i];
                    lst.Columns[i].Width = headerWidth[i];
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void PopulateListView(ListView lst, String strQuery)
        { 
            ListViewItem lstItem = null;
            int x;

            lst.Items.Clear();

            conn.Open();
            comm.Connection = conn;
            comm.CommandText = strQuery;
            reader = comm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lstItem = lst.Items.Add(reader.GetValue(0).ToString());
                    for (x = 1; x < reader.FieldCount; x++)
                    {
                        lstItem.SubItems.Add(reader.GetValue(x).ToString());
                    }
                }
            }
            conn.Close();
        }

        public static void PopulateListViewForSystem(ListView lst, String strQuery)
        {
            ListViewItem lstItem = null;
            int x;

            lst.Items.Clear();

            connSystem.Open();
            comm.Connection = connSystem;
            comm.CommandText = strQuery;
            reader = comm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lstItem = lst.Items.Add(reader.GetValue(0).ToString());
                    for (x = 1; x < reader.FieldCount; x++)
                    {
                        lstItem.SubItems.Add(reader.GetValue(x).ToString());
                    }
                }
            }
            connSystem.Close();
        }

        public static void PopulateComboBox(ComboBox cbo, String strQuery, String strTableName, String strDisplayMember, String strValue)
        {
            MySqlDataAdapter adapter = null;
            DataSet dataset = new DataSet();
            cbo.DataSource = null;

            adapter = new MySqlDataAdapter(strQuery, conn);
            
            cbo.Items.Clear();

            adapter.Fill(dataset, strTableName);
            cbo.DataSource = dataset.Tables[strTableName];
            cbo.DisplayMember = strDisplayMember;
            cbo.ValueMember = strValue;
        }
    }
}
