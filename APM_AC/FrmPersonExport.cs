using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APM_AC
{
    public partial class FrmPersonExport : Form
    {
        public FrmPersonExport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|xlsx files (*.xls)|*.xls";
            openFileDialog1.Filter = "xls files (*.xls)|*.xls";

            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {



                    OleDbConnection oconn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +  openFileDialog1.FileName + "; Extended Properties=Excel 8.0");//OledbConnection and 
                    // connectionstring to connect to the Excel Sheet
                    try
                    {
                        //After connecting to the Excel sheet here we are selecting the data 
                        //using select statement from the Excel sheet
                        OleDbCommand ocmd = new OleDbCommand("select * from [Sheet1$]", oconn);
                        oconn.Open();  //Here [Sheet1$] is the name of the sheet 
                        //in the Excel file where the data is present
                        OleDbDataReader odr = ocmd.ExecuteReader();
                        string fname = "";
                        string lname = "";
                        string mobnum = "";
                        string city = "";
                        string state = "";
                        string zip = "";
                        List<string> lstUsers = new List<string>();
                        while (odr.Read())
                        {
                            fname = Convert.ToString( odr[0]);
                            if (!string.IsNullOrWhiteSpace(fname))
                                lstUsers.Add(fname);
                            //     fname = valid(odr, 0);//Here we are calling the valid method
                            //     lname = valid(odr, 1);
                            //     mobnum = valid(odr, 2);
                            //     city = valid(odr, 3);
                            //     state = valid(odr, 4);
                            //     zip = valid(odr, 5);
                            //     //Here using this method we are inserting the data into the database
                            //insertdataintosql(fname, lname, mobnum, city, state, zip);
                        }
                        oconn.Close();
                        lstUsers = lstUsers.Distinct().ToList();
                        SaveToDB(lstUsers);
                    }
                    catch (DataException ee)
                    {
                        //lblmsg.Text = ee.Message;
                        //lblmsg.ForeColor = System.Drawing.Color.Red;
                    }
                    finally
                    {
                        //lblmsg.Text = "Data Inserted Sucessfully";
                        //lblmsg.ForeColor = System.Drawing.Color.Green;
                    }

                    //if ((myStream = openFileDialog1.OpenFile()) != null)
                    //{
                    //    using (myStream)
                    //    {
                    //        // Insert code to read the stream here.
                    //    }
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void SaveToDB(List<string> lstUsers)
        {
            APM_ACMaintanceDataSet.PersonMastersDataTable dt = personMastersTableAdapter.GetData();
            lstUsers.ForEach(p => InsertToDB(dt,p));
        }

        private bool InsertToDB(APM_ACMaintanceDataSet.PersonMastersDataTable dt, string p)
        {
            if(!dt.Where(r=>r.Name==p).Any())
            {
                personMastersTableAdapter.Insert(p, string.Empty, string.Empty, null, null);
            }
            return true;
        }
    }

}
