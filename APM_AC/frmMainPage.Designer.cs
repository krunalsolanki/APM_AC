namespace APM_AC
{
    partial class frmMainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTypeMasterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLine3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastServiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDetailsForMainPageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPM_ACMaintanceDataSet = new APM_AC.APM_ACMaintanceDataSet();
            this.selectDetailsForMainPageTableAdapter = new APM_AC.APM_ACMaintanceDataSetTableAdapters.SelectDetailsForMainPageTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShortName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.personMastersForDropdownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPM_ACMaintanceDataSet1 = new APM_AC.APM_ACMaintanceDataSet();
            this.personMastersForDropdownTableAdapter = new APM_AC.APM_ACMaintanceDataSetTableAdapters.PersonMastersForDropdownTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.lblACName = new System.Windows.Forms.Label();
            this.dtpNextServiceDate = new System.Windows.Forms.DateTimePicker();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHideID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDetailsForMainPageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPM_ACMaintanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personMastersForDropdownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPM_ACMaintanceDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.aCTypeMasterIdDataGridViewTextBoxColumn,
            this.ShortName,
            this.ServiceDueDate,
            this.addLine1,
            this.addLine2,
            this.addLine3DataGridViewTextBoxColumn,
            this.acName,
            this.acCompanyName,
            this.tons,
            this.lastServiceDate,
            this.Name,
            this.mobileDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.personMasterId});
            this.dataGridView1.DataSource = this.selectDetailsForMainPageBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1392, 581);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // aCTypeMasterIdDataGridViewTextBoxColumn
            // 
            this.aCTypeMasterIdDataGridViewTextBoxColumn.DataPropertyName = "ACTypeMasterId";
            this.aCTypeMasterIdDataGridViewTextBoxColumn.HeaderText = "ACTypeMasterId";
            this.aCTypeMasterIdDataGridViewTextBoxColumn.Name = "aCTypeMasterIdDataGridViewTextBoxColumn";
            this.aCTypeMasterIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // ShortName
            // 
            this.ShortName.DataPropertyName = "ShortName";
            this.ShortName.HeaderText = "ShortName";
            this.ShortName.Name = "ShortName";
            this.ShortName.Width = 150;
            // 
            // ServiceDueDate
            // 
            this.ServiceDueDate.DataPropertyName = "PurchaseDate";
            this.ServiceDueDate.HeaderText = "Service Due Date";
            this.ServiceDueDate.Name = "ServiceDueDate";
            // 
            // addLine1
            // 
            this.addLine1.DataPropertyName = "AddLine1";
            this.addLine1.HeaderText = "AddLine1";
            this.addLine1.Name = "addLine1";
            this.addLine1.Width = 150;
            // 
            // addLine2
            // 
            this.addLine2.DataPropertyName = "AddLine2";
            this.addLine2.HeaderText = "AddLine2";
            this.addLine2.Name = "addLine2";
            this.addLine2.Width = 150;
            // 
            // addLine3DataGridViewTextBoxColumn
            // 
            this.addLine3DataGridViewTextBoxColumn.DataPropertyName = "AddLine3";
            this.addLine3DataGridViewTextBoxColumn.HeaderText = "AddLine3";
            this.addLine3DataGridViewTextBoxColumn.Name = "addLine3DataGridViewTextBoxColumn";
            this.addLine3DataGridViewTextBoxColumn.Visible = false;
            // 
            // acName
            // 
            this.acName.DataPropertyName = "ACName";
            this.acName.HeaderText = "ACName";
            this.acName.Name = "acName";
            // 
            // acCompanyName
            // 
            this.acCompanyName.DataPropertyName = "ACCompanyName";
            this.acCompanyName.HeaderText = "ACCompanyName";
            this.acCompanyName.Name = "acCompanyName";
            // 
            // tons
            // 
            this.tons.DataPropertyName = "Tons";
            this.tons.HeaderText = "Tons";
            this.tons.Name = "tons";
            // 
            // lastServiceDate
            // 
            this.lastServiceDate.DataPropertyName = "LastServiceDate";
            this.lastServiceDate.HeaderText = "LastServiceDate";
            this.lastServiceDate.Name = "lastServiceDate";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 200;
            // 
            // personMasterId
            // 
            this.personMasterId.DataPropertyName = "PersonMasterId";
            this.personMasterId.HeaderText = "PersonMasterId";
            this.personMasterId.Name = "personMasterId";
            this.personMasterId.Visible = false;
            // 
            // selectDetailsForMainPageBindingSource
            // 
            this.selectDetailsForMainPageBindingSource.DataMember = "SelectDetailsForMainPage";
            this.selectDetailsForMainPageBindingSource.DataSource = this.aPM_ACMaintanceDataSet;
            // 
            // aPM_ACMaintanceDataSet
            // 
            this.aPM_ACMaintanceDataSet.DataSetName = "APM_ACMaintanceDataSet";
            this.aPM_ACMaintanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectDetailsForMainPageTableAdapter
            // 
            this.selectDetailsForMainPageTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lblShortName
            // 
            this.lblShortName.AutoSize = true;
            this.lblShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortName.Location = new System.Drawing.Point(152, 27);
            this.lblShortName.Name = "lblShortName";
            this.lblShortName.Size = new System.Drawing.Size(0, 17);
            this.lblShortName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Service Person";
            // 
            // cmbPerson
            // 
            this.cmbPerson.DataSource = this.personMastersForDropdownBindingSource;
            this.cmbPerson.DisplayMember = "Name";
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(152, 74);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(267, 24);
            this.cmbPerson.TabIndex = 4;
            this.cmbPerson.ValueMember = "Id";
            // 
            // personMastersForDropdownBindingSource
            // 
            this.personMastersForDropdownBindingSource.DataMember = "PersonMastersForDropdown";
            this.personMastersForDropdownBindingSource.DataSource = this.aPM_ACMaintanceDataSet1;
            // 
            // aPM_ACMaintanceDataSet1
            // 
            this.aPM_ACMaintanceDataSet1.DataSetName = "APM_ACMaintanceDataSet";
            this.aPM_ACMaintanceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personMastersForDropdownTableAdapter
            // 
            this.personMastersForDropdownTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "AC Name";
            // 
            // lblACName
            // 
            this.lblACName.AutoSize = true;
            this.lblACName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACName.Location = new System.Drawing.Point(152, 51);
            this.lblACName.Name = "lblACName";
            this.lblACName.Size = new System.Drawing.Size(0, 17);
            this.lblACName.TabIndex = 6;
            // 
            // dtpNextServiceDate
            // 
            this.dtpNextServiceDate.Location = new System.Drawing.Point(1053, 74);
            this.dtpNextServiceDate.Name = "dtpNextServiceDate";
            this.dtpNextServiceDate.Size = new System.Drawing.Size(305, 22);
            this.dtpNextServiceDate.TabIndex = 17;
            this.dtpNextServiceDate.Value = new System.DateTime(2014, 2, 17, 0, 0, 0, 0);
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Location = new System.Drawing.Point(590, 74);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(278, 22);
            this.dtpServiceDate.TabIndex = 16;
            this.dtpServiceDate.ValueChanged += new System.EventHandler(this.dtpServiceDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(904, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Next Service Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "AC Service Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(152, 114);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(1206, 22);
            this.txtNote.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(251, 148);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 36);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(155, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 36);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHideID
            // 
            this.lblHideID.AutoSize = true;
            this.lblHideID.Location = new System.Drawing.Point(486, 158);
            this.lblHideID.Name = "lblHideID";
            this.lblHideID.Size = new System.Drawing.Size(0, 17);
            this.lblHideID.TabIndex = 22;
            this.lblHideID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblHideID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblShortName);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cmbPerson);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblACName);
            this.panel1.Controls.Add(this.dtpNextServiceDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpServiceDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 194);
            this.panel1.TabIndex = 23;
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 812);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
           
            this.Text = "AC Maintance";
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDetailsForMainPageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPM_ACMaintanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personMastersForDropdownBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPM_ACMaintanceDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private APM_ACMaintanceDataSet aPM_ACMaintanceDataSet;
        private System.Windows.Forms.BindingSource selectDetailsForMainPageBindingSource;
        private APM_ACMaintanceDataSetTableAdapters.SelectDetailsForMainPageTableAdapter selectDetailsForMainPageTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPerson;
        private APM_ACMaintanceDataSet aPM_ACMaintanceDataSet1;
        private System.Windows.Forms.BindingSource personMastersForDropdownBindingSource;
        private APM_ACMaintanceDataSetTableAdapters.PersonMastersForDropdownTableAdapter personMastersForDropdownTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblACName;
        private System.Windows.Forms.DateTimePicker dtpNextServiceDate;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHideID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTypeMasterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn addLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addLine3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acName;
        private System.Windows.Forms.DataGridViewTextBoxColumn acCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tons;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastServiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personMasterId;
        private System.Windows.Forms.Panel panel1;
    }
}