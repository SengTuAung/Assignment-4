
using MySql.Data.MySqlClient;
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
    public partial class frmMain : Form
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public frmMain(){
            InitializeComponent();
        }
        /// <summary>
        /// Add information button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddInformation_Click(object sender, EventArgs e)
        {
            frmAddInformation frmAddInformation = new frmAddInformation();
            frmAddInformation.ShowDialog();
        }
        /// <summary>
        /// Edit information button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditInformation_Click(object sender, EventArgs e)
        {
            frmModifyInformation frmModifyInformation = new frmModifyInformation();
            frmModifyInformation.ShowDialog();
        }
        /// <summary>
        /// Reports button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReporting frmReporting = new frmReporting();
            frmReporting.ShowDialog();
        }
    }
}
