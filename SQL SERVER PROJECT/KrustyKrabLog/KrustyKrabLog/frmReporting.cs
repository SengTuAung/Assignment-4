using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KrustyKrabLog
{
    public partial class frmReporting : Form
    {
        private List<Information> allInformation = null;
        public frmReporting()
        {
            InitializeComponent();
            allInformation = KrustyKrabLogDB.getAllInformation();
        }
        /// <summary>
        //4-27-2021 Saung NEW 5L: Search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please, enter the name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Text = "";
                txtName.Focus();
            }
            else {
                if (allInformation != null)
                {
                    List<Information> searchResult = allInformation.Where(p => p.Name == txtName.Text).ToList();
                    string informationStr = "";
                    
                    foreach (Information info in searchResult) {
                        informationStr += "ID: " + info.Id+Environment.NewLine;
                        informationStr += "Date: " + info.Date.ToShortDateString() + Environment.NewLine;
                        informationStr += "Name: " + info.Name + Environment.NewLine;
                        informationStr += "Supervisor: " + info.Supervisor + Environment.NewLine;
                        informationStr += "Notes: " + info.Notes + Environment.NewLine + Environment.NewLine;
                    }
                    txtReport.Text = informationStr;
                }
            }
        }

        private void frmReporting_Load(object sender, EventArgs e)
        {

        }
    }
}
