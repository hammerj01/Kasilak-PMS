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
    public partial class frmListofParents : Form
    {

        public frmListofParents()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            
        }


        private void cmdAdd_Click(object sender, EventArgs e)
        {
            frmParentEntry newForm = new frmParentEntry();
            newForm.ShowDialog();
        }

        private void frmListofParents_Load_1(object sender, EventArgs e)
        {
            if (SystemVariable.iTagged == 1)
            {
                String strQuery = "SELECT PersonID, Firstname, Middlename, Lastname FROM tblPerson WHERE Gender='" + SystemVariable.iTagged + "'";
                Procedure.PopulateListView(lstParents, strQuery);
            }
            else 
            {
                String strQuery = "SELECT PersonID, Firstname, Middlename, Lastname FROM tblPerson WHERE Gender='" + SystemVariable.iTagged + "'";
                Procedure.PopulateListView(lstParents, strQuery);
            }
        }

        private String GetFirstCharacter(String text)
        {
            String temp = text.Remove(1, text.Length - 1);
            return temp;
        }
    }
}
