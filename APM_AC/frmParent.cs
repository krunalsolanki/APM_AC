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
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonMaster form = new PersonMaster();
            form.MdiParent = this;
            form.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LocationMaster form = new LocationMaster();
            form.MdiParent = this;
            form.Show();  
        }

        private void aCTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ACTypeMaster form = new ACTypeMaster();
            form.MdiParent = this;
            form.Show();
        }

        private void aCMastersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ACMaster form = new ACMaster();
            form.MdiParent = this;
            form.Show();
        }

        private void aCMaintanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainPage form = new frmMainPage();
            form.MdiParent = this;
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in forms)
            {
                if (thisForm.Name != "Menu") thisForm.Close();
            }
        }

        private void uploadUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonExport form= new FrmPersonExport();
            form.MdiParent = this;
            form.Show();
        }
    }
}
