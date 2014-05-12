namespace APM_AC
{
    partial class ACMaster
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbACType = new System.Windows.Forms.ComboBox();
            this.aCTypeMastersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aPM_ACMaintanceDataSet = new APM_AC.APM_ACMaintanceDataSet();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.locationMastersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblHideTon = new System.Windows.Forms.Label();
            this.lblHideID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTypeMasterID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aCTypeMastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoctionMasterID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.locationMastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastServiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCMastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCMastersTableAdapter = new APM_AC.APM_ACMaintanceDataSetTableAdapters.ACMastersTableAdapter();
            this.aCTypeMastersTableAdapter = new APM_AC.APM_ACMaintanceDataSetTableAdapters.ACTypeMastersTableAdapter();
            this.locationMastersTableAdapter = new APM_AC.APM_ACMaintanceDataSetTableAdapters.LocationMastersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCTypeMastersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPM_ACMaintanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationMastersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTypeMastersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationMastersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCMastersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpPurchaseDate);
            this.panel1.Controls.Add(this.dtpServiceDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbACType);
            this.panel1.Controls.Add(this.cmbLocation);
            this.panel1.Controls.Add(this.lblHideTon);
            this.panel1.Controls.Add(this.lblHideID);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 185);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(1062, 22);
            this.txtName.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Note";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Location = new System.Drawing.Point(931, 76);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(257, 22);
            this.dtpPurchaseDate.TabIndex = 22;
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Location = new System.Drawing.Point(931, 46);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(257, 22);
            this.dtpServiceDate.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(776, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Next Service Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(776, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Last Service Date";
            // 
            // cmbACType
            // 
            this.cmbACType.DataSource = this.aCTypeMastersBindingSource1;
            this.cmbACType.DisplayMember = "ACName";
            this.cmbACType.FormattingEnabled = true;
            this.cmbACType.Location = new System.Drawing.Point(124, 76);
            this.cmbACType.Name = "cmbACType";
            this.cmbACType.Size = new System.Drawing.Size(523, 24);
            this.cmbACType.TabIndex = 18;
            this.cmbACType.ValueMember = "Id";
            // 
            // aCTypeMastersBindingSource1
            // 
            this.aCTypeMastersBindingSource1.DataMember = "ACTypeMasters";
            this.aCTypeMastersBindingSource1.DataSource = this.aPM_ACMaintanceDataSet;
            // 
            // aPM_ACMaintanceDataSet
            // 
            this.aPM_ACMaintanceDataSet.DataSetName = "APM_ACMaintanceDataSet";
            this.aPM_ACMaintanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbLocation
            // 
            this.cmbLocation.DataSource = this.locationMastersBindingSource1;
            this.cmbLocation.DisplayMember = "AddLine1";
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(124, 41);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(523, 24);
            this.cmbLocation.TabIndex = 17;
            this.cmbLocation.ValueMember = "Id";
            // 
            // locationMastersBindingSource1
            // 
            this.locationMastersBindingSource1.DataMember = "LocationMasters";
            this.locationMastersBindingSource1.DataSource = this.aPM_ACMaintanceDataSet;
            // 
            // lblHideTon
            // 
            this.lblHideTon.AutoSize = true;
            this.lblHideTon.Location = new System.Drawing.Point(308, 122);
            this.lblHideTon.Name = "lblHideTon";
            this.lblHideTon.Size = new System.Drawing.Size(0, 17);
            this.lblHideTon.TabIndex = 16;
            this.lblHideTon.Visible = false;
            // 
            // lblHideID
            // 
            this.lblHideID.AutoSize = true;
            this.lblHideID.Location = new System.Drawing.Point(354, 138);
            this.lblHideID.Name = "lblHideID";
            this.lblHideID.Size = new System.Drawing.Size(0, 17);
            this.lblHideID.TabIndex = 15;
            this.lblHideID.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::APM_AC.Properties.Resources.Cancel;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(1002, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 33);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::APM_AC.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(242, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 33);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::APM_AC.Properties.Resources.Save__2_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(126, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "AC Type";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(124, 107);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(1064, 22);
            this.txtNote.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ShortName,
            this.ACTypeMasterID,
            this.LoctionMasterID,
            this.lastServiceDateDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aCMastersBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 295);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // ShortName
            // 
            this.ShortName.DataPropertyName = "ShortName";
            this.ShortName.HeaderText = "ShortName";
            this.ShortName.Name = "ShortName";
            this.ShortName.ReadOnly = true;
            // 
            // ACTypeMasterID
            // 
            this.ACTypeMasterID.DataPropertyName = "ACTypeMasterId";
            this.ACTypeMasterID.DataSource = this.aCTypeMastersBindingSource;
            this.ACTypeMasterID.DisplayMember = "ACName";
            this.ACTypeMasterID.HeaderText = "ACTypeMasterId";
            this.ACTypeMasterID.Name = "ACTypeMasterID";
            this.ACTypeMasterID.ReadOnly = true;
            this.ACTypeMasterID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACTypeMasterID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ACTypeMasterID.ValueMember = "Id";
            this.ACTypeMasterID.Width = 200;
            // 
            // aCTypeMastersBindingSource
            // 
            this.aCTypeMastersBindingSource.DataMember = "ACTypeMasters";
            this.aCTypeMastersBindingSource.DataSource = this.aPM_ACMaintanceDataSet;
            // 
            // LoctionMasterID
            // 
            this.LoctionMasterID.DataPropertyName = "LocationMasterId";
            this.LoctionMasterID.DataSource = this.locationMastersBindingSource;
            this.LoctionMasterID.DisplayMember = "AddLine1";
            this.LoctionMasterID.HeaderText = "LocationMasterId";
            this.LoctionMasterID.Name = "LoctionMasterID";
            this.LoctionMasterID.ReadOnly = true;
            this.LoctionMasterID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoctionMasterID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LoctionMasterID.ValueMember = "Id";
            this.LoctionMasterID.Width = 200;
            // 
            // locationMastersBindingSource
            // 
            this.locationMastersBindingSource.DataMember = "LocationMasters";
            this.locationMastersBindingSource.DataSource = this.aPM_ACMaintanceDataSet;
            // 
            // lastServiceDateDataGridViewTextBoxColumn
            // 
            this.lastServiceDateDataGridViewTextBoxColumn.DataPropertyName = "LastServiceDate";
            this.lastServiceDateDataGridViewTextBoxColumn.HeaderText = "LastServiceDate";
            this.lastServiceDateDataGridViewTextBoxColumn.Name = "lastServiceDateDataGridViewTextBoxColumn";
            this.lastServiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastServiceDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchaseDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 300;
            // 
            // aCMastersBindingSource
            // 
            this.aCMastersBindingSource.DataMember = "ACMasters";
            this.aCMastersBindingSource.DataSource = this.aPM_ACMaintanceDataSet;
            // 
            // aCMastersTableAdapter
            // 
            this.aCMastersTableAdapter.ClearBeforeFill = true;
            // 
            // aCTypeMastersTableAdapter
            // 
            this.aCTypeMastersTableAdapter.ClearBeforeFill = true;
            // 
            // locationMastersTableAdapter
            // 
            this.locationMastersTableAdapter.ClearBeforeFill = true;
            // 
            // ACMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ACMaster";
            this.Text = "ACMaster";
            this.Load += new System.EventHandler(this.ACMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCTypeMastersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPM_ACMaintanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationMastersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTypeMastersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationMastersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCMastersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHideTon;
        private System.Windows.Forms.Label lblHideID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label1;
        private APM_ACMaintanceDataSet aPM_ACMaintanceDataSet;
        private System.Windows.Forms.BindingSource aCMastersBindingSource;
        private APM_ACMaintanceDataSetTableAdapters.ACMastersTableAdapter aCMastersTableAdapter;
        private System.Windows.Forms.BindingSource aCTypeMastersBindingSource;
        private APM_ACMaintanceDataSetTableAdapters.ACTypeMastersTableAdapter aCTypeMastersTableAdapter;
        private System.Windows.Forms.BindingSource locationMastersBindingSource;
        private APM_ACMaintanceDataSetTableAdapters.LocationMastersTableAdapter locationMastersTableAdapter;
        private System.Windows.Forms.ComboBox cmbACType;
        private System.Windows.Forms.BindingSource aCTypeMastersBindingSource1;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.BindingSource locationMastersBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ACTypeMasterID;
        private System.Windows.Forms.DataGridViewComboBoxColumn LoctionMasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastServiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}