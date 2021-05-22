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
    public partial class frmAddInformation : Form
    {
        /// <summary>
        ///4-27-2021 Saung NEW 5L: Constructor
        /// </summary>
        public frmAddInformation()
        {
            InitializeComponent();
            //4-27-2021 Saung NEW 5L: Display ID
            txtID.Text = (KrustyKrabLogDB.getAllInformation().Count+1).ToString();
        }
        /// <summary>
        ///4-27-2021 Saung NEW 5L: Add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DataIsCorrect()) {
                KrustyKrabLogDB.insertInformation(int.Parse(txtID.Text), dtpDate.Value, txtName.Text, txtSupervisor.Text,txtNotes.Text);
                MessageBox.Show("The information has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        /// <summary>
        ///4-27-2021 Saung NEW 5L: Menu button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        ///4-27-2021 Saung NEW 5L: Checks if input ddata is correct
        /// </summary>
        /// <returns></returns>
        private bool DataIsCorrect()
        {
            
            if (txtName.Text == "")
            {
                MessageBox.Show("Please, enter the name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Text = "";
                txtName.Focus();
                return false;
            }
            if (txtSupervisor.Text == "")
            {
                MessageBox.Show("Please, enter the supervisor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSupervisor.Text = "";
                txtSupervisor.Focus();
                return false;
            }
            if (txtNotes.Text == "")
            {
                MessageBox.Show("Please, enter the notes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNotes.Text = "";
                txtNotes.Focus();
                return false;
            }
            return true;
            
        }

        private void frmAddInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
