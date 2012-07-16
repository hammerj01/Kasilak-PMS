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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void tmrAdmin_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            ParishInformationManagement newMDI = new ParishInformationManagement();

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please specify username.","User Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
            
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please specify password.", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }

            else if (!newUser.UsernameExist(txtUsername.Text))
            {
                MessageBox.Show("Username or Password does not match.", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }

            else if (!newUser.PasswordExist(txtPassword.Text))
            {
                MessageBox.Show("Username or Password does not match.", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
            MessageBox.Show("Successfully log-in");
            newMDI.Show();
            this.Hide(); 
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            int ans;

            ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to cancel this operation?","PMIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (ans == 6)
            {
                Application.Exit();
            }
        }


    }
}
