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
    public partial class frmBookNoEntry : Form
    {
        Book newBook = new Book();
        private String strQuery = "SELECT ID,BookNo,Category,Status FROM tblBook";

        public frmBookNoEntry()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            int ans;

            ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to cancel this operation?", SystemVariable.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (ans == 6)
            {
                this.Close();
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboCategory.Text))
            {
                MessageBox.Show("Please select a book category.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboStatus.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtBookNo.Text))
            {
                MessageBox.Show("Please specify a book number.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookNo.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cboStatus.Text))
            {
                MessageBox.Show("Please select a status.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboStatus.Focus();
                return;
            }

            SetDataToBook();
            if (newBook.BookNoExist(newBook))
            {
                MessageBox.Show("The information you entered already exist.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookNo.Focus();
                return;
            }
            else
            {
                if (cboStatus.Text == "Active")
                {
                    if (newBook.GetActiveStatus(cboCategory.Text))
                    {
                        MessageBox.Show("Only one book should be active per category.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newBook.BookNo = txtBookNo.Text;
                        newBook.Category = cboCategory.Text;
                        newBook.Status = "Inactive";
                    }
                }
                else
                {
                    if (!newBook.GetActiveStatus(cboCategory.Text))
                    {
                        MessageBox.Show("It should have atleast one book is set to be active.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newBook.BookNo = txtBookNo.Text;
                        newBook.Category = cboCategory.Text;
                        newBook.Status = "Active";
                    }
                }
            }

            newBook.AddNew(newBook);
            MessageBox.Show("New record successfully saved.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Procedure.PopulateListView(lstBook, strQuery);
        }

        private void frmBookNoEntry_Load(object sender, EventArgs e)
        {
            Procedure.PopulateListView(lstBook, strQuery);
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            txtBookNo.Text = lstBook.SelectedItems[0].SubItems[1].Text;
            cboStatus.Text = lstBook.SelectedItems[0].SubItems[2].Text;
            cmdSave.Text = "&UPDATE";
           
        }

        private void SetDataToBook()
        {
            newBook.BookNo = txtBookNo.Text;
            newBook.Category = cboCategory.Text;
            newBook.Status = cboStatus.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String strQuery = "SELECT ID,BookNo,Category,Status FROM tblBook WHERE Category='" + cboCategory.Text + "'";

            Procedure.PopulateListView(lstBook, strQuery);
        }
    }
}
