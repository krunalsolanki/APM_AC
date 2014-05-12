namespace APM_AC
{
    partial class FrmAcMaintanaceHistory
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
            this.selectDetailsForMainPageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPM_ACMaintanceDataSet = new APM_AC.APM_ACMaintanceDataSet();
            this.selectDetailsForMainPageTableAdapter = new APM_AC.APM_ACMaintanceDataSetTableAdapters.SelectDetailsForMainPageTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTypeMasterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastServiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personMasterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLine3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDetailsForMainPageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPM_ACMaintanceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aCTypeMasterIdDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.lastServiceDateDataGridViewTextBoxColumn,
            this.shortNameDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.personMasterIdDataGridViewTextBoxColumn,
            this.addLine1DataGridViewTextBoxColumn,
            this.addLine2DataGridViewTextBoxColumn,
            this.addLine3DataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.aCNameDataGridViewTextBoxColumn,
            this.aCCompanyNameDataGridViewTextBoxColumn,
            this.tonsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.selectDetailsForMainPageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1405, 375);
            this.dataGridView1.TabIndex = 0;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTypeMasterIdDataGridViewTextBoxColumn
            // 
            this.aCTypeMasterIdDataGridViewTextBoxColumn.DataPropertyName = "ACTypeMasterId";
            this.aCTypeMasterIdDataGridViewTextBoxColumn.HeaderText = "ACTypeMasterId";
            this.aCTypeMasterIdDataGridViewTextBoxColumn.Name = "aCTypeMasterIdDataGridViewTextBoxColumn";
            this.aCTypeMasterIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "Next Service Date";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            // 
            // lastServiceDateDataGridViewTextBoxColumn
            // 
            this.lastServiceDateDataGridViewTextBoxColumn.DataPropertyName = "LastServiceDate";
            this.lastServiceDateDataGridViewTextBoxColumn.HeaderText = "LastServiceDate";
            this.lastServiceDateDataGridViewTextBoxColumn.Name = "lastServiceDateDataGridViewTextBoxColumn";
            // 
            // shortNameDataGridViewTextBoxColumn
            // 
            this.shortNameDataGridViewTextBoxColumn.DataPropertyName = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.HeaderText = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.Name = "shortNameDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // personMasterIdDataGridViewTextBoxColumn
            // 
            this.personMasterIdDataGridViewTextBoxColumn.DataPropertyName = "PersonMasterId";
            this.personMasterIdDataGridViewTextBoxColumn.HeaderText = "PersonMasterId";
            this.personMasterIdDataGridViewTextBoxColumn.Name = "personMasterIdDataGridViewTextBoxColumn";
            this.personMasterIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // addLine1DataGridViewTextBoxColumn
            // 
            this.addLine1DataGridViewTextBoxColumn.DataPropertyName = "AddLine1";
            this.addLine1DataGridViewTextBoxColumn.HeaderText = "AddLine1";
            this.addLine1DataGridViewTextBoxColumn.Name = "addLine1DataGridViewTextBoxColumn";
            // 
            // addLine2DataGridViewTextBoxColumn
            // 
            this.addLine2DataGridViewTextBoxColumn.DataPropertyName = "AddLine2";
            this.addLine2DataGridViewTextBoxColumn.HeaderText = "AddLine2";
            this.addLine2DataGridViewTextBoxColumn.Name = "addLine2DataGridViewTextBoxColumn";
            // 
            // addLine3DataGridViewTextBoxColumn
            // 
            this.addLine3DataGridViewTextBoxColumn.DataPropertyName = "AddLine3";
            this.addLine3DataGridViewTextBoxColumn.HeaderText = "AddLine3";
            this.addLine3DataGridViewTextBoxColumn.Name = "addLine3DataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // aCNameDataGridViewTextBoxColumn
            // 
            this.aCNameDataGridViewTextBoxColumn.DataPropertyName = "ACName";
            this.aCNameDataGridViewTextBoxColumn.HeaderText = "ACName";
            this.aCNameDataGridViewTextBoxColumn.Name = "aCNameDataGridViewTextBoxColumn";
            // 
            // aCCompanyNameDataGridViewTextBoxColumn
            // 
            this.aCCompanyNameDataGridViewTextBoxColumn.DataPropertyName = "ACCompanyName";
            this.aCCompanyNameDataGridViewTextBoxColumn.HeaderText = "ACCompanyName";
            this.aCCompanyNameDataGridViewTextBoxColumn.Name = "aCCompanyNameDataGridViewTextBoxColumn";
            // 
            // tonsDataGridViewTextBoxColumn
            // 
            this.tonsDataGridViewTextBoxColumn.DataPropertyName = "Tons";
            this.tonsDataGridViewTextBoxColumn.HeaderText = "Tons";
            this.tonsDataGridViewTextBoxColumn.Name = "tonsDataGridViewTextBoxColumn";
            // 
            // FrmAcMaintanaceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 503);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmAcMaintanaceHistory";
            this.Text = "FrmAcMaintanaceHistory";
            this.Load += new System.EventHandler(this.FrmAcMaintanaceHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDetailsForMainPageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPM_ACMaintanceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private APM_ACMaintanceDataSet aPM_ACMaintanceDataSet;
        private System.Windows.Forms.BindingSource selectDetailsForMainPageBindingSource;
        private APM_ACMaintanceDataSetTableAdapters.SelectDetailsForMainPageTableAdapter selectDetailsForMainPageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTypeMasterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastServiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personMasterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addLine3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonsDataGridViewTextBoxColumn;



    }
}