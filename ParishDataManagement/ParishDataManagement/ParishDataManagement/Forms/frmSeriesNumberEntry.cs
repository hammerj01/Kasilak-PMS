﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParishDataManagement
{
    public partial class frmSeriesNumberEntry : Form
    {
        SeriesNumber newSeriesNumber = new SeriesNumber();
        SeriesNumber currSeriesNumber = new SeriesNumber();
        private String strQuery = "SELECT * FROM tblSeriesNumber";
        private String strButtonState = null;

        public frmSeriesNumberEntry()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            switch (strButtonState)
            {
                case "AddMode":
                    this.ValidateData();

                    if (newSeriesNumber.IsActive() && cboStatus.Text == "Active")
                    {
                        MessageBox.Show("There is a year that is currently 'active'." + Environment.NewLine +
                                        "Would you like to set this year as 'inactive' anyway?", SystemVariable.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        currSeriesNumber.Year = currSeriesNumber.GetActiveYear();
                        currSeriesNumber.Status = "Inactive";
                        newSeriesNumber.UpdateStatus(currSeriesNumber);
                    }
                    else SetDataToSeriesNumber();

                    newSeriesNumber.AddNew(newSeriesNumber);

                    MessageBox.Show("New record successfully saved.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "EditMode":
                    this.ValidateData();

                    if (newSeriesNumber.IsActive()) 
                    {
                    
                    }
                    currSeriesNumber.Year = txtYear.Text;
                    currSeriesNumber.Status = cboStatus.Text;
                    currSeriesNumber.UpdateStatus(currSeriesNumber);

                    MessageBox.Show("Record successfully updated.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            Procedure.PopulateListViewForSystem(lstSeriesNumber, strQuery);
        }

        private void SetDataToSeriesNumber()
        {
            newSeriesNumber.Year = txtYear.Text;
            newSeriesNumber.BaptismalSeries = 0;
            newSeriesNumber.ConfirmationSeries = 0;
            newSeriesNumber.DeathSeries = 0;
            newSeriesNumber.MarriageSeries = 0;
            newSeriesNumber.Status = cboStatus.Text;
        }

        private void frmSeriesNumberEntry_Load(object sender, EventArgs e)
        {
            Procedure.PopulateListViewForSystem(lstSeriesNumber, strQuery);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            String strYearSeries = null;

            if (lstSeriesNumber.SelectedItems[0].Selected) 
            {
                strYearSeries = lstSeriesNumber.SelectedItems[0].Text;
                cboStatus.Text = lstSeriesNumber.SelectedItems[0].SubItems[5].Text;
                txtYear.Text = strYearSeries;
                txtYear.ReadOnly = true;
            }
            this.strButtonState = "EditMode";
        }

        private void ValidateData()
        {
            if (String.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("Please specify a year.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtYear.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cboStatus.Text))
            {
                MessageBox.Show("Please select a status.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboStatus.Focus();
                return;
            }

            if (newSeriesNumber.YearExist(newSeriesNumber))
            {
                MessageBox.Show("The information you entered already exist.", SystemVariable.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtYear.Focus();
                return;
            }
        }
    }
}
