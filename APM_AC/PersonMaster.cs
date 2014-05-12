using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace APM_AC
{
    public partial class PersonMaster : Form
    {
        public PersonMaster()
        {
            InitializeComponent();
        }

        private void PersonMaster_Load(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void BindGrid()
        {
            // TODO: This line of code loads data into the 'aPM_ACMaintanceDataSet.PersonMasters' table. You can move, or remove it, as needed.
            this.personMastersTableAdapter.Fill(this.aPM_ACMaintanceDataSet.PersonMasters);
            this.dataGridView1.DataSource = this.personMastersBindingSource;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblHideID.Text))
            {
                personMastersTableAdapter.Insert(txtName.Text.Trim(), txtMobile.Text.Trim(), txtAdd.Text.Trim(), dtpDOJ.Value, dtpDOB.Value);
            }
            else
            {
                DataTable dt = personMastersTableAdapter.GetData();
                //DataRow dr = dt.Select
                //personMastersTableAdapter.Update()
             int i =   personMastersTableAdapter.Update(txtName.Text.Trim(), txtMobile.Text.Trim(), txtAdd.Text.Trim(),
                    dtpDOJ.Value, dtpDOB.Value,
                    int.Parse(lblHideID.Text), int.Parse(lblHideID.Text) // , null,null
                 //Convert.ToDateTime(lblHideDOJ.Text),
                 //Convert.ToDateTime(lblHideDOB.Text)
                 );
                    //txtName.Text.Trim(), txtMobile.Text.Trim(), txtAdd.Text.Trim(), dtpDOJ.Value, dtpDOB.Value);
            }
            ClearValues();
            BindGrid();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearValues();
        }

        private void ClearValues()
        {
            txtName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtAdd.Text = string.Empty;
            dtpDOB.Value = DateTime.Now;
            dtpDOJ.Value = DateTime.Now;
            lblHideDOB.Text = string.Empty;
            lblHideDOJ.Text = string.Empty;
            lblHideID.Text = string.Empty;
            //btnDelete.Visible = false;
            btnSave.Text = "Save";
            btnSave.Image = APM_AC.Properties.Resources.Save__2_;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.personMastersTableAdapter.Delete(int.Parse(lblHideID.Text), 
                Convert.ToDateTime(lblHideDOJ.Text), 
                Convert.ToDateTime(lblHideDOB.Text)
             );
            ClearValues();
            BindGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex != 0)
                {
                    if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString()))
                    {
                        txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                        txtMobile.Text = dataGridView1.Rows[e.RowIndex].Cells["mobileDataGridViewTextBoxColumn"].Value.ToString();
                        txtAdd.Text = dataGridView1.Rows[e.RowIndex].Cells["addressDataGridViewTextBoxColumn"].Value.ToString();
                        lblHideDOB.Text = dataGridView1.Rows[e.RowIndex].Cells["dOBDataGridViewTextBoxColumn"].Value.ToString();
                        //dtpDOB.Value = Convert.ToDateTime(lblHideDOB.Text);
                        lblHideDOJ.Text = dataGridView1.Rows[e.RowIndex].Cells["dOJDataGridViewTextBoxColumn"].Value.ToString();
                        //dtpDOJ.Value = Convert.ToDateTime(lblHideDOJ.Text);
                        lblHideID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                        btnSave.Text = "Update";
                        btnSave.Image = APM_AC.Properties.Resources.Update;
                        //btnDelete.Visible = true;
                    }
                    else
                    {
                        ClearValues();
                    }
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}