namespace ParishDataManagement
{
    partial class frmChapelEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboBarangayName = new System.Windows.Forms.ComboBox();
            this.lstChapel = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtChapelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboBarangayName);
            this.panel1.Controls.Add(this.lstChapel);
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Controls.Add(this.cmdEdit);
            this.panel1.Controls.Add(this.cmdAdd);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.txtChapelName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 528);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Chapel Name :";
            // 
            // cboBarangayName
            // 
            this.cboBarangayName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarangayName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBarangayName.Location = new System.Drawing.Point(118, 74);
            this.cboBarangayName.Name = "cboBarangayName";
            this.cboBarangayName.Size = new System.Drawing.Size(333, 21);
            this.cboBarangayName.TabIndex = 61;
            // 
            // lstChapel
            // 
            this.lstChapel.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstChapel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstChapel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstChapel.FullRowSelect = true;
            this.lstChapel.Location = new System.Drawing.Point(11, 162);
            this.lstChapel.Name = "lstChapel";
            this.lstChapel.Size = new System.Drawing.Size(461, 319);
            this.lstChapel.TabIndex = 58;
            this.lstChapel.UseCompatibleStateImageBehavior = false;
            this.lstChapel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chapel ID";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Barangay ID";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Chapel Name";
            this.columnHeader6.Width = 457;
            // 
            // cmdClose
            // 
            this.cmdClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(392, 487);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(80, 30);
            this.cmdClose.TabIndex = 57;
            this.cmdClose.Text = "&CLOSE";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Location = new System.Drawing.Point(220, 487);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(80, 30);
            this.cmdEdit.TabIndex = 56;
            this.cmdEdit.Text = "&EDIT";
            this.cmdEdit.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(134, 487);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(80, 30);
            this.cmdAdd.TabIndex = 55;
            this.cmdAdd.Text = "&ADD";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(306, 487);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(80, 30);
            this.cmdSave.TabIndex = 54;
            this.cmdSave.Text = "&SAVE";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtChapelName
            // 
            this.txtChapelName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChapelName.Location = new System.Drawing.Point(118, 109);
            this.txtChapelName.Name = "txtChapelName";
            this.txtChapelName.Size = new System.Drawing.Size(333, 21);
            this.txtChapelName.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Barangay:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 46);
            this.label2.TabIndex = 51;
            this.label2.Text = "   Chapel Entry";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmChapelEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 528);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChapelEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChapel";
            this.Load += new System.EventHandler(this.frmChapelEntry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBarangayName;
        private System.Windows.Forms.ListView lstChapel;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtChapelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}