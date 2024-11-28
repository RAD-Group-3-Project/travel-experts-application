using System.Data;
using TravelExpertData.Models;
using TravelExpertData.Repositories;
using TravelExpertGUI.Helpers;

namespace TravelExpertGUI;
public partial class ucManageProducts : UserControl
{
    private List<Product> products = null;
    private bool suppressSelectionChanged;
    string function;
    public string TableName { get; set; } = "Products";

    public ucManageProducts()
    {
        InitializeComponent();
        lblTableName.Text = TableName;
        lblTableName.Location = Constants.UI.LABEL_TABLE_NAME_LOCATION;
    }
    private void ucManageProducts_Load_1(object sender, EventArgs e)
    {
        populateProducts();
    }

    private void populateProducts()
    {
        // Sets the textboxes and buttons to the appropriate status
        lblSearchIcon.Visible = false;
        txtProdId.ReadOnly = true;
        txtProdName.ReadOnly = true;
        btnAdd.Enabled = true;
        btnDelete.Enabled = true;
        btnEdit.Enabled = true;
        btnDisc.Enabled = false;
        btnSave.Enabled = false;

        // Clears the list
        dgvProducts.Columns.Clear();
        dgvProducts.ReadOnly = true;
        products = ProductRepository.GetProduct();
        dgvProducts.DataSource = products;

        // Formating the column header
        dgvProducts.EnableHeadersVisualStyles = false;
        dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
        dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvProducts.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        // Manually change the column width, alignment, and header text
        dgvProducts.Columns[0].HeaderText = "ID";
        dgvProducts.Columns[1].HeaderText = "Product Name";

        // Hide header column
        dgvProducts.RowHeadersVisible = false;

        // Hide additional columns
        dgvProducts.Columns[2].Visible = false;
        dgvProducts.Columns[3].Visible = false;

        // Unlocks database grid view to be able to click
        dgvProducts.Enabled = true;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        txtProdId.ReadOnly = true;

        EnableEditableFields();

        txtProdName.Focus();
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDisc.Enabled = true;

        // Find the last product id and adds one to populate and box
        int lastRowColumnValue = lastID_PlusOne();
        txtProdId.Text = lastRowColumnValue.ToString();

        // Edit the save button to "add"
        function = "ADD";

        // Locks the dgv so it cannot be clicked
        dgvProducts.Enabled = false;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        // Enables form manipulation/editting
        txtProdId.ReadOnly = true;
        txtProdName.ReadOnly = false;
        txtProdName.Focus();
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDisc.Enabled = true;
        function = "EDIT";

        // Locks the database grid view
        dgvProducts.Enabled = false;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        // Finds the selected row and product
        DataGridViewRow selectedRow = dgvProducts.CurrentRow;
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

        txtProdId.ReadOnly = false;

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
                if (TextBoxValidator.IsPresent(txtProdName) && TextBoxValidator.IsInteger(txtProdId))
                {
                    // Makes new product and apply the attributes
                    Product addedProduct = new Product();

                    addedProduct.ProdName = txtProdName.Text;
                    addedProduct.IsActive = true;

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
                if (TextBoxValidator.IsPresent(txtProdName) && TextBoxValidator.IsInteger(txtProdId))
                {
                    // Creates a new product and sets attributes
                    Product editedProduct = new Product();
                    editedProduct.ProductId = Convert.ToInt32(txtProdId.Text);
                    editedProduct.ProdName = txtProdName.Text;
                    editedProduct.IsActive = true;

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
        if (!string.IsNullOrWhiteSpace(txtProdId.Text) && !TextBoxValidator.IsInteger(txtProdId))
        {
            return;
        }

        var filteredList = products.Where(product => (string.IsNullOrWhiteSpace(txtProdId.Text) ||
        product.ProductId == Convert.ToInt32(txtProdId.Text)) && (string.IsNullOrWhiteSpace(txtProdName.Text) ||
        product.ProdName.ToLower().Contains(txtProdName.Text.ToLower()))).ToList();

        if (filteredList.Count == 0)
        {
            suppressSelectionChanged = true;
        }

        dgvProducts.DataSource = filteredList;
    }

    private void lblSearchIcon_MouseHover(object sender, EventArgs e)
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

        txtProdName.ReadOnly = false;
    }

    private void ClearAllInputFields()
    {
        txtProdId.Clear();
        txtProdName.Clear();
    }

    private void dgvProducts_SelectionChanged(object sender, EventArgs e)
    {
        if (suppressSelectionChanged)
        {
            return;
        }

        if (dgvProducts.SelectedRows != null)
        {
            txtProdId.Text = dgvProducts.CurrentRow.Cells["ProductId"].Value.ToString();
            txtProdName.Text = dgvProducts.CurrentRow.Cells["ProdName"].Value.ToString();
        }
    }

    private void txtProdName_TextChanged(object sender, EventArgs e)
    {

    }
}
