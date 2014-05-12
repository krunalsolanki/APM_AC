using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace APM_AC
{
	public partial class ACMaster : Form
	{
		public ACMaster()
		{
			InitializeComponent();
		}

		private void ACMaster_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'aPM_ACMaintanceDataSet.LocationMasters' table. You can move, or remove it, as needed.
			this.locationMastersTableAdapter.Fill(this.aPM_ACMaintanceDataSet.LocationMasters);
			// TODO: This line of code loads data into the 'aPM_ACMaintanceDataSet.ACTypeMasters' table. You can move, or remove it, as needed.
			this.aCTypeMastersTableAdapter.Fill(this.aPM_ACMaintanceDataSet.ACTypeMasters);
			// TODO: This line of code loads data into the 'aPM_ACMaintanceDataSet.ACMasters' table. You can move, or remove it, as needed.

			BindGrid();
		}

		public void BindGrid()
		{
			this.aCMastersTableAdapter.Fill(this.aPM_ACMaintanceDataSet.ACMasters);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(lblHideID.Text))
			{
				aCMastersTableAdapter.Insert(int.Parse( Convert.ToString(cmbACType.SelectedValue)), dtpPurchaseDate.Value, dtpServiceDate.Value, txtNote.Text, int.Parse(Convert.ToString(cmbLocation.SelectedValue)),txtName.Text.Trim());
			}
			else
			{
				aCMastersTableAdapter.Update(int.Parse(Convert.ToString(cmbACType.SelectedValue)), dtpPurchaseDate.Value, dtpServiceDate.Value, txtNote.Text, int.Parse(Convert.ToString(cmbLocation.SelectedValue)), txtName.Text.Trim(), int.Parse(lblHideID.Text), int.Parse(lblHideID.Text));
			}
			ClearValues();
			BindGrid();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		private void ClearValues()
		{

			int nextServiceDay = 60;
			try
			{
				if (ConfigurationManager.AppSettings["NextServiceDay"] != null)
				{
					nextServiceDay = int.Parse(ConfigurationManager.AppSettings["NextServiceDay"]);
				}
			}
			catch (Exception)
			{ }

			dtpServiceDate.Value = DateTime.Now;
			dtpPurchaseDate.Value = DateTime.Now.AddDays(nextServiceDay);

			txtName.Text = "";
			cmbLocation.SelectedIndex = -1;
			cmbACType.SelectedIndex = -1;
			txtNote.Text = "";
			lblHideID.Text = "";
			lblHideID.Text = string.Empty;
			//btnDelete.Visible = false;
			btnSave.Text = "Save";
			btnSave.Image = APM_AC.Properties.Resources.Save__2_;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearValues();
		}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex != 0)
                {
                    if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString()))
                    {
                        txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["ShortName"].Value.ToString();
                        cmbLocation.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["LoctionMasterID"].Value.ToString();
                        cmbACType.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["ACTypeMasterID"].Value.ToString();
                        dtpPurchaseDate.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["purchaseDateDataGridViewTextBoxColumn"].Value.ToString());
                        dtpServiceDate.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["lastServiceDateDataGridViewTextBoxColumn"].Value.ToString());
                        txtNote.Text = dataGridView1.Rows[e.RowIndex].Cells["noteDataGridViewTextBoxColumn"].Value.ToString();
                        lblHideID.Text = dataGridView1.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString();
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
