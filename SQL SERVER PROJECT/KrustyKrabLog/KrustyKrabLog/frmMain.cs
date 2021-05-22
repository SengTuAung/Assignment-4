
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
        ///4-27-2021 Saung NEW 5L: Constructor
        /// </summary>
        public frmMain(){
            InitializeComponent();
        }
        /// <summary>
        ///4-27-2021 Saung NEW 5L: Add information button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddInformation_Click(object sender, EventArgs e)
        {
            frmAddInformation frmAddInformation = new frmAddInformation();
            frmAddInformation.ShowDialog();
        }
        /// <summary>
        ///4-27-2021 Saung NEW 5L: Edit information button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditInformation_Click(object sender, EventArgs e)
        {
            frmModifyInformation frmModifyInformation = new frmModifyInformation();
            frmModifyInformation.ShowDialog();
        }
        /// <summary>
        ///4-27-2021 Saung NEW 5L: Reports button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReporting frmReporting = new frmReporting();
            frmReporting.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
