using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertData.Data;
using TravelExpertData.Models;
using TravelExpertData.Repositories;
using TravelExpertGUI.Helpers;

namespace TravelExpertGUI
{
    public partial class ucManageAgencies : UserControl
    {
        private List<Agency> agencies = null;
        private bool suppressSelectionChanged = false;


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
            lblSearchIcon.Visible = false;

            // Makes our fields read only for now 
            txtAgencyId.ReadOnly = true;
            txtAgencyAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtProv.ReadOnly = true;
            txtCountry.ReadOnly = true;
            txtPostal.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtFax.ReadOnly = true;

            btnSave.Enabled = false;
            btnDiscard.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            // Enables the list for clicking 
            dgvAgencies.Enabled = true;
            dgvAgencies.ReadOnly = true;
            // Populates the list
            dgvAgencies.Columns.Clear();
            agencies = AgencyRepository.GetAgency();
            dgvAgencies.DataSource = agencies;

            // format the column header
            dgvAgencies.EnableHeadersVisualStyles = false;
            dgvAgencies.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvAgencies.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAgencies.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
            dgvAgencies.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Manually change our column width, alignment, and header text
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
        }

        // Sets our textboxes to the selected row
        private void dgvAgencies_SelectionChanged(object sender, EventArgs e)
        { 
            // Suppress the event if the flag is set
            if (suppressSelectionChanged)
            {
                return;
            }

            // Changes based upon slected row by table column names 
            if (dgvAgencies.CurrentRow != null)
            {
                Debug.WriteLine($"I'm hereeee\t Rows count {dgvAgencies.RowCount}");
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

            // Makes the boxes manipulatable 
            EnableEditableFields();

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // make search icon visible
            lblSearchIcon.Visible = true;

            EnableEditableFields();

            txtAgencyId.ReadOnly = false;

            // disable all buttons except disc button
            btnSave.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnDiscard.Enabled = true;
        }

        private void lblSearchIcon_MouseHover(object sender, EventArgs e)
        {
            lblSearchIcon.Cursor = Cursors.Hand;
        }

        private void lblSearchIcon_MouseLeave(object sender, EventArgs e)
        {
            lblSearchIcon.Cursor = Cursors.Default;
        }

        private void lblClearIcon_MouseHover(object sender, EventArgs e)
        {
            lblClearIcon.Cursor = Cursors.Hand;
        }

        private void lblClearIcon_MouseLeave(object sender, EventArgs e)
        {
            lblClearIcon.Cursor = Cursors.Default;
        }

        private void lblSearchIcon_Click(object sender, EventArgs e)
        {
            // if AgencyId is not empty, check the textbox
            if (!string.IsNullOrWhiteSpace(txtAgencyId.Text) &&
                !TextBoxValidator.IsInteger(txtAgencyId))
            {
                return;
            }

            // If all fields are empty, no filters are applied in the Where clause,
            // mean that we're going to query all instead.
            var filteredList = agencies.Where(agency =>
                (string.IsNullOrWhiteSpace(txtAgencyId.Text) || agency.AgencyId == Convert.ToInt32(txtAgencyId.Text)) &&
                (string.IsNullOrWhiteSpace(txtAgencyAddress.Text) || agency.AgncyAddress.ToLower().Contains(txtAgencyAddress.Text.ToLower())) &&
                (string.IsNullOrWhiteSpace(txtCity.Text) || agency.AgncyCity.ToLower().Contains(txtCity.Text.ToLower())) &&
                (string.IsNullOrWhiteSpace(txtProv.Text) || agency.AgncyProv.ToLower().Contains(txtProv.Text.ToLower())) &&
                (string.IsNullOrWhiteSpace(txtPostal.Text) || agency.AgncyPostal.ToLower().Contains(txtPostal.Text.ToLower())) &&
                (string.IsNullOrWhiteSpace(txtCountry.Text) || agency.AgncyCountry.ToLower().Contains(txtCountry.Text.ToLower())) &&
                (string.IsNullOrWhiteSpace(txtPhone.Text) || agency.AgncyPhone.ToLower().Contains(txtPhone.Text.ToLower())) &&
                (string.IsNullOrWhiteSpace(txtFax.Text) || agency.AgncyFax.ToLower().Contains(txtFax.Text.ToLower()))
            ).ToList();

            // Check if there are no results
            if (filteredList.Count == 0)
            {
                suppressSelectionChanged = true;
            }

            dgvAgencies.DataSource = filteredList;
        }

        private void lblClearIcon_Click(object sender, EventArgs e)
        {
            ClearAllInputFields();
        }

        private void EnableEditableFields()
        {
            // Clears all our textboxes
            ClearAllInputFields();

            txtAgencyAddress.ReadOnly = false;
            txtCountry.ReadOnly = false;
            txtPostal.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtProv.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtFax.ReadOnly = false;
        }

        private void ClearAllInputFields()
        {
            txtAgencyId.Clear();
            txtAgencyAddress.Clear();
            txtCity.Clear();
            txtProv.Clear();
            txtCountry.Clear();
            txtPostal.Clear();
            txtPhone.Clear();
            txtFax.Clear();
        }

        private void dgvAgencies_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Clear selection if there are no rows or no valid data
            if (dgvAgencies.Rows.Count == 0)
            {
                Debug.WriteLine("Hereeee");
                dgvAgencies.ClearSelection();

            }

            // Deselect all rows
        }
    }
}
