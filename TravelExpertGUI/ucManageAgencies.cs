using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertData.Data;
using TravelExpertData.Models;
using TravelExpertData.Repositories;

namespace TravelExpertGUI
{
    public partial class ucManageAgencies : UserControl
    {
        public ucManageAgencies()
        {
            InitializeComponent();
        }
        // Initialize our string for button functions
        string function;


        private void ucManageAgencies_Load(object sender, EventArgs e)
        {
            // Loads all of our agencies 
            PopulateAgencies();
        }
        // Function to clear and populate datagrid view 
        private void PopulateAgencies()
        {
            // Enables the list for clicking 
            dgvAgencies.Enabled = true;
            // Populates the list
            dgvAgencies.Columns.Clear();
            dgvAgencies.DataSource = AgencyRepository.GetAgency();


            // format the column header
            dgvAgencies.EnableHeadersVisualStyles = false;
            dgvAgencies.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvAgencies.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAgencies.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
            dgvAgencies.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            // Manually change our column width, alignment, and header text
            dgvAgencies.Columns[0].HeaderText = "ID";
            dgvAgencies.Columns[1].HeaderText = "Address";
            dgvAgencies.Columns[2].HeaderText = "City";
            dgvAgencies.Columns[3].HeaderText = "Province";
            dgvAgencies.Columns[4].HeaderText = "Postal";
            dgvAgencies.Columns[5].HeaderText = "Country";
            dgvAgencies.Columns[6].HeaderText = "Phone";
            dgvAgencies.Columns[7].HeaderText = "Fax";
            //dgvAgencies.Columns[1].Width = 250;
            dgvAgencies.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Hides the row selection columns
            dgvAgencies.RowHeadersVisible = false;
            // Hides additional columns we dont need to see 
            dgvAgencies.Columns[8].Visible = false;
            dgvAgencies.Columns[9].Visible = false;
            txtAgencyAddress.ReadOnly = true;
            // Makes our fields read only for now 
            txtCountry.ReadOnly = true;
            txtPostal.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtProv.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtFax.ReadOnly = true;
            btnSave.Enabled = false;
            btnDiscard.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

        }
        // Sets our textboxes to the selected row
        private void dgvAgencies_SelectionChanged(object sender, EventArgs e)
        {   // Changes based upon slected row by table column names 
            if (dgvAgencies.CurrentRow != null)
            {
                txtAgencyId.Text = dgvAgencies.CurrentRow.Cells["AgencyId"].Value.ToString();
                txtAgencyAddress.Text = dgvAgencies.CurrentRow.Cells["AgncyAddress"].Value.ToString();
                txtCity.Text = dgvAgencies.CurrentRow.Cells["AgncyCity"].Value.ToString();
                txtProv.Text = dgvAgencies.CurrentRow.Cells["AgncyProv"].Value.ToString();
                txtCountry.Text = dgvAgencies.CurrentRow.Cells["AgncyCountry"].Value.ToString();
                txtPostal.Text = dgvAgencies.CurrentRow.Cells["AgncyPostal"].Value.ToString();
                txtCountry.Text = dgvAgencies.CurrentRow.Cells["AgncyCountry"].Value.ToString();
                txtPhone.Text = dgvAgencies.CurrentRow.Cells["AgncyPhone"].Value.ToString();
                txtFax.Text = dgvAgencies.CurrentRow.Cells["AgncyFax"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   // Turns off the list so it cant be clicked while adding a new agency
            dgvAgencies.Enabled = false;
            // Clears all our textboxes
            txtAgencyId.Clear();
            txtAgencyAddress.Clear();
            txtCity.Clear();
            txtProv.Clear();
            txtCountry.Clear();
            txtPostal.Clear();
            txtPhone.Clear();
            txtFax.Clear();
            // Makes the boxes manipulatable 
            txtAgencyAddress.ReadOnly = false;
            txtCountry.ReadOnly = false;
            txtPostal.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtProv.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtFax.ReadOnly = false;
            btnSave.Enabled = true;
            btnDiscard.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            // Allows the save button to determine the function of its click
            function = "add";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            // determines what happens when the save button is clicked
            if (function == "add")
            {   
                // Tries 
                try
                {   
                    // Makes a new agency and populates it with info from our textboxes
                    Agency newagency = new();
                    newagency.AgncyAddress = txtAgencyAddress.Text;
                    newagency.AgncyCity = txtCity.Text;
                    newagency.AgncyProv = txtProv.Text;
                    newagency.AgncyFax = txtFax.Text;
                    newagency.AgncyPostal = txtPostal.Text;
                    newagency.AgncyPhone = txtPhone.Text;
                    newagency.AgncyCountry = txtCountry.Text;
                    // Makes the new agency active
                    newagency.IsActive = true;
                    // Calls our add fuction
                    AgencyRepository.CreateLocation(newagency);
                    //repopulates our list with the new agency present
                    PopulateAgencies();
                }  
                // Catches our errors along the way 
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}", "Agency Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // If our edit has been determined by the function string
            if (function == "edit")
            {   
                // Tries the edit
                try
                {   
                    // Makes a new agency based on our textboxes 
                    Agency updatedAgency = new Agency();
                    updatedAgency.AgencyId = Convert.ToInt32(txtAgencyId.Text);
                    updatedAgency.AgncyAddress = txtAgencyAddress.Text;
                    updatedAgency.AgncyCity = txtCity.Text;
                    updatedAgency.AgncyProv = txtProv.Text;
                    updatedAgency.AgncyCountry = txtCountry.Text;
                    updatedAgency.AgncyFax = txtFax.Text;
                    updatedAgency.AgncyPhone = txtPhone.Text;
                    updatedAgency.AgncyPostal = txtPostal.Text;
                    // Makes it active
                    updatedAgency.IsActive = true;
                    // Tries to update the selected agency with the new info
                    AgencyRepository.UpdateAgency(updatedAgency);
                    // Repopulates our list with the updated info
                    PopulateAgencies();
                }
                // Catches any errors along the way
                catch (Exception ex)
                {
                    // Shows the error
                    MessageBox.Show($"Error: {ex.Message}", "Agency Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        // Makes the textboxes manipulatable when edit is clicked 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Makes our textboxes editable
            dgvAgencies.Enabled = false;
            txtAgencyAddress.ReadOnly = false;
            txtCountry.ReadOnly = false;
            txtPostal.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtProv.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtFax.ReadOnly = false;
            btnSave.Enabled = true;
            btnDiscard.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            // Chancges the save function to edit
            function = "edit";


        }
        // Function for delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {   
            // Finds the currently selected row 
            DataGridViewRow selectedRow = dgvAgencies.CurrentRow;
            // Stores the id as an int
            int selectedAgency = Convert.ToInt32(selectedRow.Cells[0].Value);
            // Names the result of our messagebox
            DialogResult result =
            // Makes the result whatever we click on the box we pop up 
            MessageBox.Show($"Delete location number {selectedAgency}?",
                "Confirm Delete", MessageBoxButtons.YesNo, // gives us some yes/ no values 
                MessageBoxIcon.Question); // Includes an icon in the message box 
            // if the button presses is yes (as stored in result)
            if (result == DialogResult.Yes)
            {   
                //tries to delete  
                try
                {   
                    // Deleted based on id
                    AgencyRepository.DeleteAgencyByID(selectedAgency);
                    // repopulates the list 
                    PopulateAgencies();
                }   
                // Catches and displays any errors 
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}", "Agency Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
        // Resets back to default when discard is pushed 
        private void btnDiscard_Click(object sender, EventArgs e)
        {   
            PopulateAgencies();
        }
    }
}
