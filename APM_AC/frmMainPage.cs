using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace APM_AC
{
	public partial class frmMainPage : Form
	{
		public frmMainPage()
		{
			InitializeComponent();
		}

		private void addToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //PersonMaster form = new PersonMaster();
            //form.MdiParent = this;
            //form.Show();
		}

		private void aCTypeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void frmMainPage_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'aPM_ACMaintanceDataSet1.PersonMastersForDropdown' table. You can move, or remove it, as needed.
			this.personMastersForDropdownTableAdapter.Fill(this.aPM_ACMaintanceDataSet1.PersonMastersForDropdown);
			// TODO: This line of code loads data into the 'aPM_ACMaintanceDataSet.ACServiceHistories_Add' table. You can move, or remove it, as needed.
			//this.aCServiceHistories_AddTableAdapter.Fill(this.aPM_ACMaintanceDataSet.ACServiceHistories_Add);
			//// TODO: This line of code loads data into the 'aPM_ACMaintanceDataSet.ACServiceHistories' table. You can move, or remove it, as needed.
			//this.aCServiceHistoriesTableAdapter.Fill(this.aPM_ACMaintanceDataSet.ACServiceHistories);
			//// TODO: This line of code loads data into the 'aPM_ACMaintanceDataSet.PersonMasters' table. You can move, or remove it, as needed.
			//this.personMastersTableAdapter.Fill(this.aPM_ACMaintanceDataSet.PersonMasters);
			// TODO: This line of code loads data into the 'aPM_ACMaintanceDataSet.SelectDetailsForMainPage' table. You can move, or remove it, as needed.
			this.selectDetailsForMainPageTableAdapter.Fill(this.aPM_ACMaintanceDataSet.SelectDetailsForMainPage);
			BindGrid();

            int nextServiceDay = GetNextServiceDays();

			dtpServiceDate.Value = DateTime.Now;
			dtpServiceDate.Value = DateTime.Now.AddDays(nextServiceDay);

		}

        private static int GetNextServiceDays()
        {
            // Set default value to 2 months
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
            return nextServiceDay;
        }

		private void aCMaintainsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmAcMaintanaceHistory form = new FrmAcMaintanaceHistory();
            form.MdiParent = this;
			form.Show();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				if (e.ColumnIndex != 0)
				{
					if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString()))
					{
						lblHideID.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
						lblShortName.Text = string.Format("{0} - {1} - {2}", dataGridView1.Rows[e.RowIndex].Cells["ShortName"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["addLine1"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["addLine2"].Value.ToString());
						lblACName.Text = string.Format("{0} - {1} - Tons:- {2}", dataGridView1.Rows[e.RowIndex].Cells["acName"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["acCompanyName"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["tons"].Value.ToString());
					}
					else
					{
						lblHideID.Text = string.Empty;
						lblShortName.Text = string.Empty;
						lblACName.Text = string.Empty;
					}
				   
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(lblHideID.Text))
			{
				APM_ACMaintanceDataSetTableAdapters.ACServiceHistories_AddTableAdapter objAdp = new APM_ACMaintanceDataSetTableAdapters.ACServiceHistories_AddTableAdapter();
			   int i = objAdp.Insert(dtpServiceDate.Value, txtNote.Text.Trim(),int.Parse(cmbPerson.SelectedValue.ToString()), int.Parse(lblHideID.Text));
				APM_ACMaintanceDataSetTableAdapters.ACMastersTableAdapter objACMasterAdp = new APM_ACMaintanceDataSetTableAdapters.ACMastersTableAdapter();
				objACMasterAdp.upd_ACMasterServiceDate(dtpServiceDate.Value, dtpNextServiceDate.Value, int.Parse(lblHideID.Text), i);
			   // locationMastersTableAdapter.Insert(txtLocation.Text.Trim(), txtAdd1.Text.Trim(), txtAdd2.Text.Trim());
			}
			//else
			//{
			//    //locationMastersTableAdapter.Update(txtLocation.Text.Trim(), txtAdd1.Text.Trim(), txtNote.Text.Trim(),
			//    //    int.Parse(lblHideID.Text));
			//}
			ClearValues();
			BindGrid();
		}


		private void ClearValues()
		{
		  
			lblHideID.Text = string.Empty;
			lblACName.Text = string.Empty;
			lblShortName.Text = string.Empty;
			dtpServiceDate.Value = DateTime.Now;
			dtpNextServiceDate.Value = DateTime.Now;
			cmbPerson.SelectedIndex = -1;
			txtNote.Text = "";
		}

		private void BindGrid()
		{
			// TODO: This line of code loads data into the 'aPM_ACMaintanceDataSet.PersonMasters' table. You can move, or remove it, as needed.
			this.selectDetailsForMainPageTableAdapter.Fill(this.aPM_ACMaintanceDataSet.SelectDetailsForMainPage);
			this.dataGridView1.DataSource = this.selectDetailsForMainPageBindingSource;
			FormatRow_dataGridView1();
		}

		private void FormatRow_dataGridView1()
		{
			if (dataGridView1.DataSource != null)
			{
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					
					if (   Convert.ToDateTime(row.Cells["ServiceDueDate"].Value).Day == DateTime.Now.Day)
					{
						row.DefaultCellStyle.BackColor = Color.LightSeaGreen;
					}

					else if (Convert.ToDateTime(row.Cells["ServiceDueDate"].Value) < DateTime.Now)
					{
						row.DefaultCellStyle.BackColor = Color.LightSteelBlue;
					}

					
				}
			}
		}

        private void dtpServiceDate_ValueChanged(object sender, EventArgs e)
        {
            dtpNextServiceDate.Value = DateTime.Now.AddDays(GetNextServiceDays());
        }
	}
}
