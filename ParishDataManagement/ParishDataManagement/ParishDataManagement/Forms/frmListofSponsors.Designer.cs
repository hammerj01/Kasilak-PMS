namespace ParishDataManagement
{
    partial class frmListofSponsors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkRefresh = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSponsor = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lnkRefresh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmdOK);
            this.panel1.Controls.Add(this.cboSearchBy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstSponsor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 520);
            this.panel1.TabIndex = 0;
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.AutoSize = true;
            this.lnkRefresh.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lnkRefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkRefresh.LinkColor = System.Drawing.Color.Green;
            this.lnkRefresh.Location = new System.Drawing.Point(623, 78);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(30, 24);
            this.lnkRefresh.TabIndex = 40;
            this.lnkRefresh.TabStop = true;
            this.lnkRefresh.Text = "q";
            this.lnkRefresh.VisitedLinkColor = System.Drawing.Color.Green;
            this.lnkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefresh_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Select atleast 5 (five) sponsors on the list.";
            // 
            // cmdOK
            // 
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.Location = new System.Drawing.Point(573, 481);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 26);
            this.cmdOK.TabIndex = 37;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "All",
            "Firstname",
            "Middlename",
            "Lastname"});
            this.cboSearchBy.Location = new System.Drawing.Point(14, 79);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(223, 21);
            this.cboSearchBy.TabIndex = 36;
            this.cboSearchBy.SelectedIndexChanged += new System.EventHandler(this.cboSearchBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Search Keyword:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(654, 481);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 26);
            this.cmdCancel.TabIndex = 34;
            this.cmdCancel.Text = "&CANCEL";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(268, 79);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(354, 21);
            this.txtKeyword.TabIndex = 32;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Search by:";
            // 
            // lstSponsor
            // 
            this.lstSponsor.CheckBoxes = true;
            this.lstSponsor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader6});
            this.lstSponsor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSponsor.FullRowSelect = true;
            this.lstSponsor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstSponsor.Location = new System.Drawing.Point(11, 116);
            this.lstSponsor.Name = "lstSponsor";
            this.lstSponsor.Size = new System.Drawing.Size(718, 359);
            this.lstSponsor.TabIndex = 25;
            this.lstSponsor.UseCompatibleStateImageBehavior = false;
            this.lstSponsor.View = System.Windows.Forms.View.Details;
            this.lstSponsor.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstSponsor_ItemChecked);
            this.lstSponsor.SelectedIndexChanged += new System.EventHandler(this.lstSponsor_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Firstname";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Middlename";
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lastname";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Address";
            this.columnHeader5.Width = 222;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Person ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sponsor ID";
            this.columnHeader6.Width = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(742, 46);
            this.label2.TabIndex = 24;
            this.label2.Text = "  List of Sponsors:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(12, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "*";
            // 
            // frmListofSponsors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 520);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListofSponsors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListofSponsors";
            this.Load += new System.EventHandler(this.frmListofSponsors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstSponsor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkRefresh;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}