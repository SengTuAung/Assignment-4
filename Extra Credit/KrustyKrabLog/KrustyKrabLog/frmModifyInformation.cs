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
    public partial class frmModifyInformation : Form
    {
        private List<Information> allInformation =null;
        private int currentRecord = 0;
        public frmModifyInformation()
        {
            InitializeComponent();
            allInformation = KrustyKrabLogDB.getAllInformation();
            if (allInformation.Count>0)
            {
                
                displayInformation();
                btnPrevious.Enabled = false;
                if (allInformation.Count == 1)
                {
                    btnNext.Enabled = false;
                }
            }
            else
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
            }
        }
        /// <summary>
        /// display information
        /// </summary>
        private void displayInformation()
        {
            if (allInformation != null)
            {
                txtID.Text = allInformation[currentRecord].Id.ToString();
                dtpDate.Value = allInformation[currentRecord].Date;
                txtName.Text = allInformation[currentRecord].Name;
                txtSupervisor.Text = allInformation[currentRecord].Supervisor;
                txtNotes.Text = allInformation[currentRecord].Notes.ToString();
                
            }
        }
        /// <summary>
        /// Previous button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentRecord > 0)
            {
                currentRecord--;
                displayInformation();
                btnNext.Enabled = true;
                if (currentRecord == 0)
                {
                    btnPrevious.Enabled = false;
                }
            }
        }
        /// <summary>
        /// Next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentRecord < allInformation.Count)
            {
                currentRecord++;
                displayInformation();
                btnPrevious.Enabled = true;
                if (currentRecord == allInformation.Count - 1)
                {
                    btnNext.Enabled = false;
                }
            }
        }
        /// <summary>
        /// Update button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DataIsCorrect())
            {
                KrustyKrabLogDB.updateInformation(int.Parse(txtID.Text), dtpDate.Value, txtName.Text, txtSupervisor.Text, txtNotes.Text);
                MessageBox.Show("The information has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        /// <summary>
        /// Checks if input ddata is correct
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
        /// <summary>
        /// Menu button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
