namespace ParishDataManagement
{
    partial class frmDeathEntry
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstPersonInfo = new System.Windows.Forms.ListView();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.lblNote = new System.Windows.Forms.Label();
            this.chkLiveSearch = new System.Windows.Forms.CheckBox();
            this.txtDeathNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCivil = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBarangay = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboBirthTown = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cboBirthProvince = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPresentBarangay = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboTown = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSpouseID = new System.Windows.Forms.Label();
            this.cboParentName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstParents = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label16 = new System.Windows.Forms.Label();
            this.dtDateofDeath = new System.Windows.Forms.DateTimePicker();
            this.lnkAddSpouse = new System.Windows.Forms.LinkLabel();
            this.lnkAddParent = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSpouse = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblMinisterID = new System.Windows.Forms.Label();
            this.lstMinister = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.dtDateofBurial = new System.Windows.Forms.DateTimePicker();
            this.txtPlaceofBurial = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtMinister = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblMotherID = new System.Windows.Forms.Label();
            this.lblFatherID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.lblMotherID);
            this.panel1.Controls.Add(this.lblFatherID);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 583);
            this.panel1.TabIndex = 26;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 485);
            this.tabControl1.TabIndex = 80;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(865, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPersonID);
            this.panel2.Controls.Add(this.lstPersonInfo);
            this.panel2.Controls.Add(this.lblNote);
            this.panel2.Controls.Add(this.chkLiveSearch);
            this.panel2.Controls.Add(this.txtDeathNo);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cboCivil);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cboGender);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtBirthdate);
            this.panel2.Controls.Add(this.txtLastname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMiddlename);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFirstname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 453);
            this.panel2.TabIndex = 0;
            // 
            // lstPersonInfo
            // 
            this.lstPersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPersonInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lstPersonInfo.FullRowSelect = true;
            this.lstPersonInfo.GridLines = true;
            this.lstPersonInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstPersonInfo.Location = new System.Drawing.Point(467, 167);
            this.lstPersonInfo.Name = "lstPersonInfo";
            this.lstPersonInfo.Size = new System.Drawing.Size(333, 146);
            this.lstPersonInfo.TabIndex = 120;
            this.lstPersonInfo.UseCompatibleStateImageBehavior = false;
            this.lstPersonInfo.View = System.Windows.Forms.View.Details;
            this.lstPersonInfo.Visible = false;
            this.lstPersonInfo.DoubleClick += new System.EventHandler(this.lstPersonInfo_DoubleClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Person ID";
            this.columnHeader10.Width = 0;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Firstname";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Middlename";
            this.columnHeader12.Width = 0;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Lastname";
            this.columnHeader13.Width = 180;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNote.Location = new System.Drawing.Point(485, 371);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(341, 14);
            this.lblNote.TabIndex = 119;
            this.lblNote.Text = "This will enable the \'Live Search\' capability for person\'s information.";
            // 
            // chkLiveSearch
            // 
            this.chkLiveSearch.AutoSize = true;
            this.chkLiveSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLiveSearch.ForeColor = System.Drawing.Color.Black;
            this.chkLiveSearch.Location = new System.Drawing.Point(467, 351);
            this.chkLiveSearch.Name = "chkLiveSearch";
            this.chkLiveSearch.Size = new System.Drawing.Size(91, 17);
            this.chkLiveSearch.TabIndex = 118;
            this.chkLiveSearch.Text = "&Live Search";
            this.chkLiveSearch.UseVisualStyleBackColor = true;
            this.chkLiveSearch.CheckedChanged += new System.EventHandler(this.chkLiveSearch_CheckedChanged_1);
            // 
            // txtDeathNo
            // 
            this.txtDeathNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeathNo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDeathNo.Location = new System.Drawing.Point(123, 31);
            this.txtDeathNo.Name = "txtDeathNo";
            this.txtDeathNo.ReadOnly = true;
            this.txtDeathNo.Size = new System.Drawing.Size(235, 21);
            this.txtDeathNo.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 101;
            this.label9.Text = "Death No:";
            // 
            // cboCivil
            // 
            this.cboCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCivil.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCivil.FormattingEnabled = true;
            this.cboCivil.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cboCivil.Location = new System.Drawing.Point(123, 218);
            this.cboCivil.Name = "cboCivil";
            this.cboCivil.Size = new System.Drawing.Size(235, 21);
            this.cboCivil.TabIndex = 93;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Civil Status:";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(123, 188);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(235, 21);
            this.cboGender.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Birthdate:";
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthdate.Location = new System.Drawing.Point(123, 158);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(235, 21);
            this.dtBirthdate.TabIndex = 80;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(123, 122);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(298, 21);
            this.txtLastname.TabIndex = 79;
            this.txtLastname.Enter += new System.EventHandler(this.txtLastname_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Lastname:";
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddlename.Location = new System.Drawing.Point(123, 93);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(298, 21);
            this.txtMiddlename.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Middlename:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(123, 64);
            this.txtFirstname.MaximumSize = new System.Drawing.Size(298, 21);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(298, 21);
            this.txtFirstname.TabIndex = 77;
            this.txtFirstname.TextChanged += new System.EventHandler(this.txtFirstname_TextChanged);
            this.txtFirstname.Enter += new System.EventHandler(this.txtFirstname_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Firstname:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBarangay);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cboBirthTown);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cboBirthProvince);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 124);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Birthplace:";
            // 
            // txtBarangay
            // 
            this.txtBarangay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarangay.Location = new System.Drawing.Point(110, 85);
            this.txtBarangay.Name = "txtBarangay";
            this.txtBarangay.Size = new System.Drawing.Size(298, 21);
            this.txtBarangay.TabIndex = 73;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(28, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 72;
            this.label20.Text = "Barangay:";
            // 
            // cboBirthTown
            // 
            this.cboBirthTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBirthTown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBirthTown.FormattingEnabled = true;
            this.cboBirthTown.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cboBirthTown.Location = new System.Drawing.Point(110, 53);
            this.cboBirthTown.Name = "cboBirthTown";
            this.cboBirthTown.Size = new System.Drawing.Size(298, 21);
            this.cboBirthTown.TabIndex = 71;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(28, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 70;
            this.label21.Text = "Town:";
            // 
            // cboBirthProvince
            // 
            this.cboBirthProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBirthProvince.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBirthProvince.FormattingEnabled = true;
            this.cboBirthProvince.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cboBirthProvince.Location = new System.Drawing.Point(110, 24);
            this.cboBirthProvince.Name = "cboBirthProvince";
            this.cboBirthProvince.Size = new System.Drawing.Size(298, 21);
            this.cboBirthProvince.TabIndex = 69;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(28, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 68;
            this.label22.Text = "Province:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPresentBarangay);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cboTown);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboProvince);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(452, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 126);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Present Address:";
            // 
            // txtPresentBarangay
            // 
            this.txtPresentBarangay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentBarangay.Location = new System.Drawing.Point(93, 82);
            this.txtPresentBarangay.Name = "txtPresentBarangay";
            this.txtPresentBarangay.Size = new System.Drawing.Size(279, 21);
            this.txtPresentBarangay.TabIndex = 74;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 72;
            this.label19.Text = "Barangay:";
            // 
            // cboTown
            // 
            this.cboTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTown.FormattingEnabled = true;
            this.cboTown.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cboTown.Location = new System.Drawing.Point(93, 51);
            this.cboTown.Name = "cboTown";
            this.cboTown.Size = new System.Drawing.Size(279, 21);
            this.cboTown.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Town:";
            // 
            // cboProvince
            // 
            this.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvince.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cboProvince.Location = new System.Drawing.Point(93, 24);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(279, 21);
            this.cboProvince.TabIndex = 69;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 68;
            this.label18.Text = "Province:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(865, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Minister & Relatives Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSpouseID);
            this.panel4.Controls.Add(this.cboParentName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lstParents);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.dtDateofDeath);
            this.panel4.Controls.Add(this.lnkAddSpouse);
            this.panel4.Controls.Add(this.lnkAddParent);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtSpouse);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtParentName);
            this.panel4.Controls.Add(this.lblMinisterID);
            this.panel4.Controls.Add(this.lstMinister);
            this.panel4.Controls.Add(this.dtDateofBurial);
            this.panel4.Controls.Add(this.txtPlaceofBurial);
            this.panel4.Controls.Add(this.label33);
            this.panel4.Controls.Add(this.txtMinister);
            this.panel4.Controls.Add(this.label34);
            this.panel4.Controls.Add(this.label35);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(853, 447);
            this.panel4.TabIndex = 57;
            // 
            // lblSpouseID
            // 
            this.lblSpouseID.Location = new System.Drawing.Point(325, 133);
            this.lblSpouseID.Name = "lblSpouseID";
            this.lblSpouseID.Size = new System.Drawing.Size(1, 13);
            this.lblSpouseID.TabIndex = 139;
            this.lblSpouseID.Visible = false;
            // 
            // cboParentName
            // 
            this.cboParentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParentName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParentName.FormattingEnabled = true;
            this.cboParentName.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboParentName.Location = new System.Drawing.Point(125, 339);
            this.cboParentName.Name = "cboParentName";
            this.cboParentName.Size = new System.Drawing.Size(235, 21);
            this.cboParentName.TabIndex = 138;
            this.cboParentName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 137;
            this.label2.Text = "Minister\'s Information:";
            // 
            // lstParents
            // 
            this.lstParents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstParents.FullRowSelect = true;
            this.lstParents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstParents.Location = new System.Drawing.Point(487, 313);
            this.lstParents.Name = "lstParents";
            this.lstParents.Size = new System.Drawing.Size(350, 119);
            this.lstParents.TabIndex = 136;
            this.lstParents.UseCompatibleStateImageBehavior = false;
            this.lstParents.View = System.Windows.Forms.View.Details;
            this.lstParents.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Person ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Parents Name";
            this.columnHeader2.Width = 346;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 134;
            this.label16.Text = "Date of Death:";
            // 
            // dtDateofDeath
            // 
            this.dtDateofDeath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateofDeath.Location = new System.Drawing.Point(125, 55);
            this.dtDateofDeath.Name = "dtDateofDeath";
            this.dtDateofDeath.Size = new System.Drawing.Size(259, 21);
            this.dtDateofDeath.TabIndex = 133;
            // 
            // lnkAddSpouse
            // 
            this.lnkAddSpouse.ActiveLinkColor = System.Drawing.Color.Green;
            this.lnkAddSpouse.AutoSize = true;
            this.lnkAddSpouse.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddSpouse.ForeColor = System.Drawing.Color.Green;
            this.lnkAddSpouse.LinkArea = new System.Windows.Forms.LinkArea(0, 1);
            this.lnkAddSpouse.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkAddSpouse.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lnkAddSpouse.Location = new System.Drawing.Point(479, 209);
            this.lnkAddSpouse.Name = "lnkAddSpouse";
            this.lnkAddSpouse.Size = new System.Drawing.Size(20, 22);
            this.lnkAddSpouse.TabIndex = 132;
            this.lnkAddSpouse.TabStop = true;
            this.lnkAddSpouse.Text = "+";
            // 
            // lnkAddParent
            // 
            this.lnkAddParent.ActiveLinkColor = System.Drawing.Color.Green;
            this.lnkAddParent.AutoSize = true;
            this.lnkAddParent.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddParent.ForeColor = System.Drawing.Color.Green;
            this.lnkAddParent.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkAddParent.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lnkAddParent.Location = new System.Drawing.Point(479, 170);
            this.lnkAddParent.Name = "lnkAddParent";
            this.lnkAddParent.Size = new System.Drawing.Size(20, 22);
            this.lnkAddParent.TabIndex = 131;
            this.lnkAddParent.TabStop = true;
            this.lnkAddParent.Text = "+";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(12, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 130;
            this.label11.Text = "Relative\'s Information:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 129;
            this.label13.Text = "Spouse:";
            // 
            // txtSpouse
            // 
            this.txtSpouse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpouse.Location = new System.Drawing.Point(125, 210);
            this.txtSpouse.Name = "txtSpouse";
            this.txtSpouse.Size = new System.Drawing.Size(351, 21);
            this.txtSpouse.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 128;
            this.label12.Text = "Parent Name:";
            // 
            // txtParentName
            // 
            this.txtParentName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentName.Location = new System.Drawing.Point(125, 171);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(351, 21);
            this.txtParentName.TabIndex = 126;
            // 
            // lblMinisterID
            // 
            this.lblMinisterID.Location = new System.Drawing.Point(144, 124);
            this.lblMinisterID.Name = "lblMinisterID";
            this.lblMinisterID.Size = new System.Drawing.Size(10, 14);
            this.lblMinisterID.TabIndex = 104;
            this.lblMinisterID.Visible = false;
            // 
            // lstMinister
            // 
            this.lstMinister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstMinister.FullRowSelect = true;
            this.lstMinister.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstMinister.Location = new System.Drawing.Point(505, 112);
            this.lstMinister.Name = "lstMinister";
            this.lstMinister.Size = new System.Drawing.Size(333, 119);
            this.lstMinister.TabIndex = 103;
            this.lstMinister.UseCompatibleStateImageBehavior = false;
            this.lstMinister.View = System.Windows.Forms.View.Details;
            this.lstMinister.Visible = false;
            this.lstMinister.DoubleClick += new System.EventHandler(this.lstMinister_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Person ID";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Minister Name";
            this.columnHeader4.Width = 325;
            // 
            // dtDateofBurial
            // 
            this.dtDateofBurial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateofBurial.Location = new System.Drawing.Point(125, 26);
            this.dtDateofBurial.Name = "dtDateofBurial";
            this.dtDateofBurial.Size = new System.Drawing.Size(259, 21);
            this.dtDateofBurial.TabIndex = 89;
            // 
            // txtPlaceofBurial
            // 
            this.txtPlaceofBurial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceofBurial.Location = new System.Drawing.Point(125, 87);
            this.txtPlaceofBurial.Name = "txtPlaceofBurial";
            this.txtPlaceofBurial.Size = new System.Drawing.Size(314, 21);
            this.txtPlaceofBurial.TabIndex = 88;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(17, 90);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(89, 13);
            this.label33.TabIndex = 92;
            this.label33.Text = "Place of Burial:";
            // 
            // txtMinister
            // 
            this.txtMinister.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinister.Location = new System.Drawing.Point(125, 277);
            this.txtMinister.Name = "txtMinister";
            this.txtMinister.Size = new System.Drawing.Size(351, 21);
            this.txtMinister.TabIndex = 87;
            this.txtMinister.TextChanged += new System.EventHandler(this.txtMinister_TextChanged);
            this.txtMinister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinister_KeyDown);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(18, 280);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(56, 13);
            this.label34.TabIndex = 91;
            this.label34.Text = "Minister:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(17, 32);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(86, 13);
            this.label35.TabIndex = 90;
            this.label35.Text = "Date of Burial:";
            // 
            // lblMotherID
            // 
            this.lblMotherID.Location = new System.Drawing.Point(59, 558);
            this.lblMotherID.Name = "lblMotherID";
            this.lblMotherID.Size = new System.Drawing.Size(10, 23);
            this.lblMotherID.TabIndex = 63;
            this.lblMotherID.Visible = false;
            // 
            // lblFatherID
            // 
            this.lblFatherID.Location = new System.Drawing.Point(23, 558);
            this.lblFatherID.Name = "lblFatherID";
            this.lblFatherID.Size = new System.Drawing.Size(10, 23);
            this.lblFatherID.TabIndex = 62;
            this.lblFatherID.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(616, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 61;
            this.button1.Text = "&VIEW LIST";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(702, 540);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(80, 30);
            this.cmdSave.TabIndex = 15;
            this.cmdSave.Text = "&SAVE";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(788, 540);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(80, 30);
            this.cmdCancel.TabIndex = 29;
            this.cmdCancel.Text = "&CANCEL";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Gainsboro;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(881, 46);
            this.label15.TabIndex = 23;
            this.label15.Text = "  Death Entry";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPersonID
            // 
            this.lblPersonID.Location = new System.Drawing.Point(22, 408);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(1, 13);
            this.lblPersonID.TabIndex = 121;
            this.lblPersonID.Visible = false;
            // 
            // frmDeathEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 583);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeathEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeathEntry";
            this.Load += new System.EventHandler(this.frmDeathEntry_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstPersonInfo;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.CheckBox chkLiveSearch;
        public System.Windows.Forms.TextBox txtDeathNo;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cboCivil;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtBirthdate;
        public System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtBarangay;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.ComboBox cboBirthTown;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.ComboBox cboBirthProvince;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtPresentBarangay;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.ComboBox cboTown;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMinisterID;
        private System.Windows.Forms.ListView lstMinister;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.DateTimePicker dtDateofBurial;
        public System.Windows.Forms.TextBox txtPlaceofBurial;
        private System.Windows.Forms.Label label33;
        public System.Windows.Forms.TextBox txtMinister;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        public System.Windows.Forms.Label lblMotherID;
        public System.Windows.Forms.Label lblFatherID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DateTimePicker dtDateofDeath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lstParents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSpouse;
        private System.Windows.Forms.LinkLabel lnkAddSpouse;
        private System.Windows.Forms.LinkLabel lnkAddParent;
        public System.Windows.Forms.TextBox txtParentName;
        public System.Windows.Forms.ComboBox cboParentName;
        private System.Windows.Forms.Label lblSpouseID;
        private System.Windows.Forms.Label lblPersonID;
    }
}