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
    public partial class ParishInformationManagement : Form
    {
        Form activeChild = null;

        public ParishInformationManagement()
        {
            InitializeComponent();
        }

        private void ministerTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void baptismalEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaptismalEntry newForm = new frmBaptismalEntry();
            newForm.ShowDialog();
        }

        private void addNewMinisterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void titleEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void baptismalCertificatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCertificateWizard newForm = new frmCertificateWizard();
            newForm.ShowDialog();
        }

        private void bookNoEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookNoEntry newForm = new frmBookNoEntry();
            newForm.ShowDialog();
        }

        private void seriesNumberEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeriesNumberEntry newForm = new frmSeriesNumberEntry();
            newForm.ShowDialog();
        }

        private void provinceEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvinceEntry newForm = new frmProvinceEntry();
            newForm.ShowDialog();
        }

        private void ministerEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMinisterEntry newForm = new frmMinisterEntry();
            newForm.ShowDialog();
        }

        private void municipalityTownEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTownEntry newForm = new frmTownEntry();
            newForm.ShowDialog();
        }

        private void barangayEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarangayEntry newForm = new frmBarangayEntry();
            newForm.ShowDialog();
        }

        private void chapelEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChapelEntry newForm = new frmChapelEntry();
            newForm.ShowDialog();
        }

        private void clusterEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClusterEntry newForm = new frmClusterEntry();
            newForm.ShowDialog();
        }

        private void marriageEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarriageEntry newForm = new frmMarriageEntry();
            newForm.ShowDialog();
        }

        private void listOfBaptismalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadMasterList("Baptismal");
        }

        private void listOfMarriageRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadMasterList("Marriage");
        }

        private void LoadMasterList(String strRecordType) 
        {
            frmMasterList newForm = new frmMasterList();
            this.activeChild = this.ActiveMdiChild;

            if (this.activeChild == null || this.activeChild.IsDisposed)
            {
                newForm.strRecordType = strRecordType;
                newForm.LoadDataToList();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else 
            {
                this.ActiveMdiChild.Close();
                newForm.strRecordType = strRecordType;
                newForm.LoadDataToList();
                newForm.MdiParent = this;
                newForm.Show();
            } 
        }

        private void confirmationEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfirmationEntry newForm = new frmConfirmationEntry();
            newForm.ShowDialog();
        }

        private void listOfConfirmationRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadMasterList("Confirmation");
        }

        private void deathEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeathEntry newForm = new frmDeathEntry();
            newForm.ShowDialog();
        }

        private void listOfDeathRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadMasterList("Death");
        }

    }
}
