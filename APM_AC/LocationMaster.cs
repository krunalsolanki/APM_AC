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
    public partial class LocationMaster : Form
    {
        public LocationMaster()
        {
            InitializeComponent();
        }

        private void LocationMaster_Load(object sender, EventArgs e)
        {
            BindGrid();           

        }
        private void BindGrid()
        {
            this.locationMastersTableAdapter.Fill(this.aPM_ACMaintanceDataSet.LocationMasters);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblHideID.Text))
            {
                locationMastersTableAdapter.Insert(txtLocation.Text.Trim(),txtAdd1.Text.Trim(), txtAdd2.Text.Trim());
            }
            else
            {
                locationMastersTableAdapter.Update(txtLocation.Text.Trim(),txtAdd1.Text.Trim(), txtAdd2.Text.Trim(),
                    int.Parse(lblHideID.Text));
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
            txtLocation.Text = string.Empty;
            txtAdd1.Text = string.Empty;
            txtAdd2.Text = string.Empty;
            lblHideID.Text = string.Empty;
            btnDelete.Visible = false;
            btnSave.Text = "Save";
            btnSave.Image = APM_AC.Properties.Resources.Save__2_;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.locationMastersTableAdapter.Delete(int.Parse(lblHideID.Text));
            ClearValues();
            BindGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex != 0)
                {
                    if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString()))
                    {
                        txtLocation.Text = dataGridView1.Rows[e.RowIndex].Cells["Location"].Value.ToString();
                        txtAdd1.Text = dataGridView1.Rows[e.RowIndex].Cells["AddLine2"].Value.ToString();
                        txtAdd2.Text = dataGridView1.Rows[e.RowIndex].Cells["AddLine3"].Value.ToString();
                        lblHideID.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
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
    }
}
