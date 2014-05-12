using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APM_AC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            FrmPersonExport frm = new FrmPersonExport();
            frm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == txtPass.Text.Trim())
            {
                if (txtLogin.Text.Trim() == "APM")
                {
                    this.Hide();
                    frmParent frm = new frmParent();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Either User Name or Password is wrong. Please Try again", "Wrong Password", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Either User Name or Password is wrong. Please Try again", "Wrong Password", MessageBoxButtons.OK);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
