using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TravelExpertData.Models;
using TravelExpertData.Repositories;
using TravelExpertGUI.Helpers;

namespace TravelExpertGUI;
public partial class ucManageProducts : UserControl
{
    private List<Product> products = null;
    private bool suppressSelectionChanged;
    string function;

    public ucManageProducts()
    {
        InitializeComponent();
    }

    private void ucManageProducts_Load(object sender, EventArgs e)
    {
        populateProducts();
    }

    private void populateProducts()
    {
        // Sets the textboxes and buttons to the appropriate status
        lblSearchIcon.Visible = false;
        txtSupID.ReadOnly = true;
        txtSupName.ReadOnly = true;
        btnAdd.Enabled = true;
        btnDelete.Enabled = true;
        btnEdit.Enabled = true;
        btnDisc.Enabled = false;
        btnSave.Enabled = false;

        // Clears the list
        dgvSuppliers.Columns.Clear();
        dgvSuppliers.ReadOnly = true;
        products = ProductRepository.GetProduct();
        dgvSuppliers.DataSource = products;

        // Formating the column header
        dgvSuppliers.EnableHeadersVisualStyles = false;
        dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        dgvSuppliers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
        dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvSuppliers.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        // Manually change the column width, alignment, and header text
        dgvSuppliers.Columns[0].HeaderText = "ID";
        dgvSuppliers.Columns[1].HeaderText = "Product Name";

        // Hide header column
        dgvSuppliers.RowHeadersVisible = false;

        // Hide additional columns
        dgvSuppliers.Columns[2].Visible = false;
        dgvSuppliers.Columns[3].Visible = false;
        dgvSuppliers.Columns[4].Visible = false;
        dgvSuppliers.Columns[1].Width = 350;

        // Unlocks database grid view to be able to click
        dgvSuppliers.Enabled = true;
    }

    private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
    {
        if (suppressSelectionChanged)
        {
            return;
        }

        if (dgvSuppliers.SelectedRows != null)
        {
            txtSupID.Text = dgvSuppliers.CurrentRow.Cells["ProductId"].Value.ToString();
            txtSupName.Text = dgvSuppliers.CurrentRow.Cells["ProdName"].Value.ToString();
        }
    }

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

        // Find the last product id and adds one to populate and box
        int lastRowColumnValue = lastID_PlusOne();
        txtSupID.Text = lastRowColumnValue.ToString();

        // Edit the save button to "add"
        function = "ADD";

        // Locks the dgv so it cannot be clicked
        dgvSuppliers.Enabled = false;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        // Enables form manipulation/editting
        txtSupID.ReadOnly = true;
        txtSupName.ReadOnly = false;
        txtSupName.Focus();
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDisc.Enabled = true;
        function = "EDIT";

        // Locks the database grid view
        dgvSuppliers.Enabled = false;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        // Finds the selected row and product
        DataGridViewRow selectedRow = dgvSuppliers.CurrentRow;
        int selectedProduct = Convert.ToInt32(selectedRow.Cells[0].Value);

        // Pops out message box to ensure deletion
        DialogResult result = MessageBox.Show($"Are you sure you want to delete Product {selectedRow.Cells[1].Value}", "Delete Product",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        // If the user clicks yes
        if (result == DialogResult.Yes)
        {
            // Try-catch delete
            try
            {
                ProductRepository.DeleteProductByID(selectedProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Product Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh list
            populateProducts();
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        lblSearchIcon.Visible = true;

        EnableEditableFields();

        txtSupID.ReadOnly = false;

        btnSave.Enabled = false;
        btnAdd.Enabled = false;
        btnDelete.Enabled = false;
        btnEdit.Enabled = false;
        btnDisc.Enabled = true;
    }

    private void btnDisc_Click(object sender, EventArgs e)
    {
        populateProducts();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        switch (function)
        {
            // Checks function
            case "ADD":
                // Validates the text box for ID and name
                if (TextBoxValidator.IsPresent(txtSupName) && TextBoxValidator.IsInteger(txtSupID))
                {
                    // Makes new product and apply the attributes
                    Product addedProduct = new Product();

                    // Finds the last ID again in case it changes
                    int lastRowColumnValue = lastID_PlusOne();
                    addedProduct.ProductId = lastRowColumnValue;
                    addedProduct.ProdName = txtSupName.Text;
                    //addedProduct.IsActive = true;

                    try
                    {
                        ProductRepository.CreateProduct(addedProduct);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Product Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Reload list
                    populateProducts();

                    break;
                }
                else
                {
                    MessageBox.Show("Please input a Product name");
                    break;
                }

            case "EDIT":
                // Validate text boxes
                if (TextBoxValidator.IsPresent(txtSupName) && TextBoxValidator.IsInteger(txtSupID))
                {
                    // Creates a new product and sets attributes
                    Product editedProduct = new Product();
                    editedProduct.ProductId = Convert.ToInt32(txtSupID.Text);
                    editedProduct.ProdName = txtSupName.Text;

                    // Try-catch the edit function
                    try
                    {
                        ProductRepository.UpdateProduct(editedProduct);
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Product Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Refresh list
                    populateProducts();

                    break;
                }
                else
                {
                    MessageBox.Show("Please input a Product Name");
                    break;
                }
        }
    }

    private void lblSearchIcon_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtSupID.Text) && !TextBoxValidator.IsInteger(txtSupID))
        {
            return;
        }

        var filteredList = products.Where(product => (string.IsNullOrWhiteSpace(txtSupID.Text) ||
        product.ProductId == Convert.ToInt32(txtSupID.Text)) && (string.IsNullOrWhiteSpace(txtSupName.Text) ||
        product.ProdName.ToLower().Contains(txtSupName.Text.ToLower()))).ToList();

        if (filteredList.Count == 0)
        {
            suppressSelectionChanged = true;
        }

        dgvSuppliers.DataSource = filteredList;
    }

    private void lblSearchIcon_MouseHover(object sender, MouseEventArgs e)
    {
        lblSearchIcon.Cursor = Cursors.Hand;
    }

    private void lblSearchIcon_MouseLeave(object sender, EventArgs e)
    {
        lblSearchIcon.Cursor = Cursors.Default;
    }

    private void lblClearIcon_Click(object sender, EventArgs e)
    {
        ClearAllInputFields();
    }

    private void lblClearIcon_MouseHover(object sender, EventArgs e)
    {
        lblClearIcon.Cursor = Cursors.Hand;
    }

    private void lblClearIcon_MouseLeave(Object sender, EventArgs e)
    {
        lblClearIcon.Cursor = Cursors.Default;
    }

    private static int lastID_PlusOne()
    {
        // Obtains a list of all products including the non-active ones
        List<Product> productData = ProductRepository.GetProduct();

        // Gets the last ID, adds one and returns it
        int lastRowColumnValue = productData.Last().ProductId;
        lastRowColumnValue++;
        return lastRowColumnValue;

    }

    private void EnableEditableFields()
    {
        ClearAllInputFields();

        txtSupName.ReadOnly = false;
    }

    private void ClearAllInputFields()
    {
        txtSupID.Clear();
        txtSupName.Clear();
    }
}
