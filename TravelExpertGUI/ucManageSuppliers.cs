using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertData.Models;
using TravelExpertData.Repositories;
using TravelExpertGUI.Helpers;

namespace TravelExpertGUI;
public partial class ucManageSuppliers : UserControl
{
    private List<Supplier> suppliers = null;

    public ucManageSuppliers()
    {
        InitializeComponent();
    }
    // Initializes our function string
    string function;

    private void ucManageSuppliers_Load(object sender, EventArgs e)
    {   
        // Loads our list into the data grid view 
        populateSuppliers();

    }
    // populates the starting point for our list
    private void populateSuppliers()
    {   
        
    {
        lblSearchIcon.Visible = false;
        // Sets textboxes and buttons to appropriate status
            txtSupID.ReadOnly = true;
        txtSupName.ReadOnly = true;
        btnAdd.Enabled = true;
        btnDelete.Enabled = true;
        btnEdit.Enabled = true;
        btnDisc.Enabled = false;
        btnSave.Enabled = false;
        // Clears The list
        dgvSuppliers.Columns.Clear();
        dgvSuppliers.ReadOnly = true;
        suppliers = SupplierRepository.getSupplier();
        dgvSuppliers.DataSource = suppliers;
        // format the column header
        dgvSuppliers.EnableHeadersVisualStyles = false;
        dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        dgvSuppliers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
        dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvSuppliers.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        // Manually change our column width, alignment, and header text
        dgvSuppliers.Columns[0].HeaderText = "ID";
        dgvSuppliers.Columns[1].HeaderText = "Supplier Name";
        // Hides header column
        dgvSuppliers.RowHeadersVisible = false;
        // Hides additional columns we dont need to see 
        dgvSuppliers.Columns[2].Visible = false;
        dgvSuppliers.Columns[3].Visible = false;
        dgvSuppliers.Columns[4].Visible = false;
        dgvSuppliers.Columns[1].Width = 350;
        // Unlocks our dgv so it can be clicked
        dgvSuppliers.Enabled = true;

    }
    // Changes our selected object id based on where we click within the dgv
    private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
    {   
        if (dgvSuppliers.SelectedRows != null)
        {   
            // Sets our textboxes to what we have selected 
            txtSupID.Text = dgvSuppliers.CurrentRow.Cells["SupplierId"].Value.ToString();
            txtSupName.Text = dgvSuppliers.CurrentRow.Cells["SupName"].Value.ToString();
        }
    }
    // Sets up our form to add a new supplier
    private void btnAdd_Click(object sender, EventArgs e)
    {
        txtSupID.ReadOnly = true;

        EnableEditableFields();

        txtSupName.Focus();
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDisc.Enabled = true;
        // Finds our last supplier id and adds one and populates the box with it 
        int lastRowColumnValue = lastID_PlusOne();
        txtSupID.Text = lastRowColumnValue.ToString();
        // Changes our function to add for our save button
        function = "ADD";
        // Locks our dgv so it cant be clicked
        dgvSuppliers.Enabled = false;


    }
    // Gets us the last id from all suppliers and adds one 
    private static int lastID_PlusOne()
    {   
        // Gets a list of all suppliers including non-active
        List<Supplier> supplierData = SupplierRepository.getAllSuppliers();
        // Gets the last id, adds one and returns it 
        int lastRowColumnValue = supplierData.Last().SupplierId;
        lastRowColumnValue++;
        return lastRowColumnValue;
    }
    // Preps our window to edit selected 
    private void btnEdit_Click(object sender, EventArgs e)
    {   
        // allows form manipulation
        txtSupID.ReadOnly = true;
        txtSupName.ReadOnly = false;
        txtSupName.Focus();
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDisc.Enabled = true;
        function = "EDIT";
        // Locks our dgv so it cant be clicked
        dgvSuppliers.Enabled = false;

    }
    // Resets our form 
    private void btnDisc_Click(object sender, EventArgs e)
    {
        populateSuppliers();
    }
    // Functions for our save changes button 
    private void btnSave_Click(object sender, EventArgs e)
    {
        switch (function)
        {   
            // Checks our function 
            case "ADD":
                // Validates the text box for id and name
                if (TextBoxValidator.IsPresent(txtSupName) && TextBoxValidator.IsInteger(txtSupID))
                {   
                    // Makes new supplier and applies attributes
                    Supplier addedSupplier = new Supplier();
                    // Finds our last id again in case it has changed 
                    int lastRowColumnValue = lastID_PlusOne();
                    addedSupplier.SupplierId = lastRowColumnValue;
                    addedSupplier.SupName = txtSupName.Text;
                    addedSupplier.IsActive = true;
                    // Tries to add
                    try
                    {
                        SupplierRepository.addSupplier(addedSupplier);
                    }   
                    // Catches and displays error 
                    catch (Exception ex )
                    {

                        MessageBox.Show($"Error: {ex.Message}", "Supplier Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Reloads our list 
                    populateSuppliers();
                    // Escapes the switch
                    break; 
                }
                // Gives error if validation has failed 
                else 
                {
                    MessageBox.Show("Please input a Supplier Name");
                    break;
                }
            // Our edit case 
            case "EDIT":
                // Validates Our Text boxes 
                if (TextBoxValidator.IsPresent(txtSupName) && TextBoxValidator.IsInteger(txtSupID))
                {   
                    // Makes a new supplier and sets attributes 
                    Supplier editedSupplier = new Supplier();
                    editedSupplier.SupplierId = Convert.ToInt32(txtSupID.Text);
                    editedSupplier.SupName = txtSupName.Text;
                    editedSupplier.IsActive = true;
                    // Tries our update function
                    try
                    {
                        SupplierRepository.updateSupplier(editedSupplier);
                    }  
                    // Catch and display Edit error
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error: {ex.Message}", "Supplier Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }   
                    // Refresh List
                    populateSuppliers();
                    // Escape switch
                    break; 
                }
                // Catches error for validation
                else
                {
                    MessageBox.Show("Please input a Supplier Name");
                    break;
                }

        }
    }
    // Delete Function 
    private void btnDelete_Click(object sender, EventArgs e)
    {   
        // Finds our selected row and supplier
        DataGridViewRow selectedRow = dgvSuppliers.CurrentRow;
        int selectedSupplier = Convert.ToInt32(selectedRow.Cells[0].Value);
        // Pops Our Message box to ensure deletion
        DialogResult result =
            MessageBox.Show($"Are you sure you want to delete Supplier {selectedRow.Cells[1].Value} ",
            "Delete Supplier",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        // If they say yes : 
        if (result == DialogResult.Yes)
        {       
        // Try delete 
            try
            {
                    SupplierRepository.deleteSupplier(selectedSupplier);
            }
            catch (Exception ex )
            {
                MessageBox.Show($"Error: {ex.Message}", "Supplier Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Refresh List
            populateSuppliers();
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        // make search icon visible
        lblSearchIcon.Visible = true;

        EnableEditableFields();

        txtSupID.ReadOnly = false; // for searching purpose

        btnSave.Enabled = false;
        btnAdd.Enabled = false;
        btnDelete.Enabled = false;
        btnEdit.Enabled = false;
        btnDisc.Enabled = true;
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
        // if SupplierId is not empty, check the textbox
        if (!string.IsNullOrWhiteSpace(txtSupID.Text) &&
            !TextBoxValidator.IsInteger(txtSupID))
        {
            return;
        }

        // If all fields are empty, no filters are applied in the Where clause,
        // mean that we're going to query all instead.
        var filteredList = suppliers.Where(supplier =>
            (string.IsNullOrWhiteSpace(txtSupID.Text) || supplier.SupplierId == Convert.ToInt32(txtSupID.Text)) &&
            (string.IsNullOrWhiteSpace(txtSupName.Text) || supplier.SupName.ToLower().Contains(txtSupName.Text.ToLower()))
        ).ToList();

        dgvSuppliers.DataSource = filteredList;
    }

    private void lblClearIcon_Click(object sender, EventArgs e)
    {
        ClearAllInputFields();
    }

    private void EnableEditableFields()
    {
        // clear all value in textboxes
        ClearAllInputFields();

        // make it editable
        txtSupName.ReadOnly = false;
    }

    private void ClearAllInputFields()
    {
        txtSupID.Clear();
        txtSupName.Clear();
    }
}

