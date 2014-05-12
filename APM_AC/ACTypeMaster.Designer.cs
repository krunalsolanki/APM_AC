namespace APM_AC
{
    partial class ACTypeMaster
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTypeMastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPM_ACMaintanceDataSet = new APM_AC.APM_ACMaintanceDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHideTon = new System.Windows.Forms.Label();
            this.lblHideID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTonn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtACName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aCTypeMastersTableAdapter = new APM_AC.APM_ACMaintanceDataSetTableAdapters.ACTypeMastersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTypeMastersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPM_ACMaintanceDataSet)).BeginInit();
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
            this.ID,
            this.ACName,
            this.ACCompanyName,
            this.Tons});
            this.dataGridView1.DataSource = this.aCTypeMastersBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 264);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ACName
            // 
            this.ACName.DataPropertyName = "ACName";
            this.ACName.HeaderText = "ACName";
            this.ACName.Name = "ACName";
            this.ACName.ReadOnly = true;
            this.ACName.Width = 300;
            // 
            // ACCompanyName
            // 
            this.ACCompanyName.DataPropertyName = "ACCompanyName";
            this.ACCompanyName.HeaderText = "ACCompanyName";
            this.ACCompanyName.Name = "ACCompanyName";
            this.ACCompanyName.ReadOnly = true;
            this.ACCompanyName.Width = 300;
            // 
            // Tons
            // 
            this.Tons.DataPropertyName = "Tons";
            this.Tons.HeaderText = "Tons";
            this.Tons.Name = "Tons";
            this.Tons.ReadOnly = true;
            // 
            // aCTypeMastersBindingSource
            // 
            this.aCTypeMastersBindingSource.DataMember = "ACTypeMasters";
            this.aCTypeMastersBindingSource.DataSource = this.aPM_ACMaintanceDataSet;
            // 
            // aPM_ACMaintanceDataSet
            // 
            this.aPM_ACMaintanceDataSet.DataSetName = "APM_ACMaintanceDataSet";
            this.aPM_ACMaintanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblHideTon);
            this.panel1.Controls.Add(this.lblHideID);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtTonn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCompany);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtACName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 185);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnDelete.Location = new System.Drawing.Point(640, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
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
            this.btnCancel.Location = new System.Drawing.Point(257, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 33);
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
            this.btnSave.Location = new System.Drawing.Point(143, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTonn
            // 
            this.txtTonn.Location = new System.Drawing.Point(143, 92);
            this.txtTonn.Name = "txtTonn";
            this.txtTonn.Size = new System.Drawing.Size(44, 22);
            this.txtTonn.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tonn";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(143, 50);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(589, 22);
            this.txtCompany.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtACName
            // 
            this.txtACName.Location = new System.Drawing.Point(143, 11);
            this.txtACName.Name = "txtACName";
            this.txtACName.Size = new System.Drawing.Size(589, 22);
            this.txtACName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "AC Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // aCTypeMastersTableAdapter
            // 
            this.aCTypeMastersTableAdapter.ClearBeforeFill = true;
            // 
            // ACTypeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ACTypeMaster";
            this.Text = "ACTypeMaster";
            this.Load += new System.EventHandler(this.ACTypeMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTypeMastersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPM_ACMaintanceDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHideID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTonn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtACName;
        private System.Windows.Forms.Label label1;
        private APM_ACMaintanceDataSet aPM_ACMaintanceDataSet;
        private System.Windows.Forms.BindingSource aCTypeMastersBindingSource;
        private APM_ACMaintanceDataSetTableAdapters.ACTypeMastersTableAdapter aCTypeMastersTableAdapter;
        private System.Windows.Forms.Label lblHideTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tons;
    }
}