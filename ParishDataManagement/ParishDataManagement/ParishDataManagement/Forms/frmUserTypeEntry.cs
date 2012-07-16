using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParishDataManagement
{
    public partial class frmUserTypeEntry : Form
    {
        UserType newUserType = new UserType();

        public frmUserTypeEntry()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtType.Text))
            {
                MessageBox.Show("Please specify a user type.","PMIS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtType.Focus();
                return;
            }

            newUserType._UserType = txtType.Text;
            newUserType.AddNew(newUserType);

            MessageBox.Show("New record successfully saved.","PMIS",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void frmUserTypeEntry_Load(object sender, EventArgs e)
        {
            MyConnection newConnection = new MyConnection();

            newConnection.OpenConnection(newConnection.ConnectionStringforSystem);
        }

    }
}
