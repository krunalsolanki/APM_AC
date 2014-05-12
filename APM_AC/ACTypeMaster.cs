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
    public partial class ACTypeMaster : Form
    {
        public ACTypeMaster()
        {
            InitializeComponent();
        }

        private void ACTypeMaster_Load(object sender, EventArgs e)
        {
            BindGrid();   
        }
        private void BindGrid()
        {
            this.aCTypeMastersTableAdapter.Fill(this.aPM_ACMaintanceDataSet.ACTypeMasters);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblHideID.Text))
            {
                aCTypeMastersTableAdapter.Insert(txtACName.Text.Trim(), txtCompany.Text.Trim(), decimal.Parse(txtTonn.Text.Trim()));
            }
            else
            {
                aCTypeMastersTableAdapter.Update(txtACName.Text.Trim(), txtCompany.Text.Trim(), decimal.Parse(txtTonn.Text.Trim()),
                    int.Parse(lblHideID.Text),decimal.Parse(lblHideTon.Text) );
            }
            ClearValues();
            BindGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearValues();
        }

        private void ClearValues()
        {
            txtACName.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtTonn.Text = string.Empty;
            lblHideID.Text = string.Empty;
            lblHideTon.Text = string.Empty;
            btnDelete.Visible = false;
            btnSave.Text = "Save";
            btnSave.Image = APM_AC.Properties.Resources.Save__2_;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.aCTypeMastersTableAdapter.Delete(int.Parse(lblHideID.Text), decimal.Parse(lblHideTon.Text));
            ClearValues();
            BindGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex != 0)
                {
                    if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["ACName"].Value.ToString()))
                    {
                        txtACName.Text = dataGridView1.Rows[e.RowIndex].Cells["ACName"].Value.ToString();
                        txtCompany.Text = dataGridView1.Rows[e.RowIndex].Cells["ACCompanyName"].Value.ToString();
                        lblHideTon.Text = dataGridView1.Rows[e.RowIndex].Cells["Tons"].Value.ToString();
                        txtTonn.Text = lblHideTon.Text;
                        lblHideID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                        btnSave.Text = "Update";
                        btnSave.Image= APM_AC.Properties.Resources.Update;
                        //btnDelete.Visible = true;
                    }
                    else
                    {
                        ClearValues();
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
