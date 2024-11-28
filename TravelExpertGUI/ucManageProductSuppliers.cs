using System.Data;
using TravelExpertData.Models;
using TravelExpertData.Repositories;
using TravelExpertGUI.Helpers;
using static TravelExpertData.Repositories.ProductSuppliersRepository;

namespace TravelExpertGUI;
public partial class ucManageProductSuppliers : UserControl
{
    private string selectedProductSupplierId;
    private int selectedProductId;
    private int selectedSupplierId;
    private bool suppressSelectionChanged;

    private bool isAddition;

    private List<ProductSupplierDTO> productsSupplierList = null;
    public string TableName { get; set; } = "Product Supplier";

    public ucManageProductSuppliers()
    {
        InitializeComponent();
        lblTableName.Text = TableName;
    }

    private void ucManageProductSuppliers_Load(object sender, EventArgs e)
    {
        // init behaviour of buttons and textboxes
        InitButtonAndFields();

        lblSearchIcon.Visible = false;
        dgvProductSupplier.ReadOnly = true;

        // get list of product supplier
        GetProductSuppliers();
        LoadProducts();
        LoadSupplier();

        // Styling
        dgvProductSupplier.EnableHeadersVisualStyles = false;
        dgvProductSupplier.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        dgvProductSupplier.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvProductSupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
        dgvProductSupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvProductSupplier.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    }

    private void dgvProductSupplier_SelectionChanged(object sender, EventArgs e)
    {
        if (suppressSelectionChanged)
        {
            return;
        }

        if (dgvProductSupplier.CurrentRow != null) // check not equal to column
        {
            selectedProductSupplierId = dgvProductSupplier.CurrentRow.Cells["ProductSupplierId"].Value.ToString();
            selectedProductId = Convert.ToInt32(dgvProductSupplier.CurrentRow.Cells["ProductId"].Value.ToString());
            selectedSupplierId = Convert.ToInt32(dgvProductSupplier.CurrentRow.Cells["SupplierId"].Value.ToString());

            txtProductSupplierId.Text = selectedProductSupplierId;
            cboProductName.SelectedValue = selectedProductId;
            cboSupplierName.SelectedValue = selectedSupplierId;
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        // set isAddition to true
        isAddition = true;

        EnableEditableFields();

        // reset textbox and combo boxes to empty value
        // set product id to +1
        txtProductSupplierId.Text =
            (Convert.ToInt32(dgvProductSupplier.Rows[dgvProductSupplier.Rows.Count - 1].Cells["ProductSupplierId"].Value.ToString()) + 1).ToString();
        // clear all combo boxes
        cboProductName.SelectedIndex = -1;
        cboSupplierName.SelectedIndex = -1;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        // set isAddition to false
        isAddition = false;

        EnableEditableFields();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        int currentId = Convert.ToInt32(dgvProductSupplier.CurrentRow.Cells[0].Value);
        DialogResult result =
            MessageBox.Show($"Are you sure you would like to delete Product Supplier id {currentId}",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            try
            {
                ProductSuppliersRepository.DeleteProductSupplierById(currentId);
                InitButtonAndFields();
                GetProductSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't delete product supplier id {currentId}\n{ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    private void btnDisc_Click(object sender, EventArgs e)
    {
        // set value back
        // Nov 17, 2024 - (James) Might not need this anymore
        //txtProductSupplierId.Text = selectedProductSupplierId;
        //cboProductName.SelectedValue = selectedProductId;
        //cboSupplierName.SelectedValue = selectedSupplierId;

        InitButtonAndFields();

        // set datasource back
        dgvProductSupplier.DataSource = productsSupplierList;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {


        if (isAddition)
        {
            try
            {
                ProductsSupplier newProductsSupplier = new ProductsSupplier
                {
                    ProductId = Convert.ToInt32(cboProductName.SelectedValue),
                    SupplierId = Convert.ToInt32(cboSupplierName.SelectedValue)
                };
                ProductSuppliersRepository.CreateProductSupplier(newProductsSupplier);
                InitButtonAndFields();
                GetProductSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't add product supplier\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            try
            {
                ProductsSupplier newProductsSupplier = new ProductsSupplier
                {
                    ProductSupplierId = Convert.ToInt32(txtProductSupplierId.Text),
                    ProductId = Convert.ToInt32(cboProductName.SelectedValue),
                    SupplierId = Convert.ToInt32(cboSupplierName.SelectedValue)
                };
                ProductSuppliersRepository.UpdateProductSupplier(newProductsSupplier);
                InitButtonAndFields();
                GetProductSuppliers();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Can't update product supplier\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void InitButtonAndFields()
    {
        // disable all textbox and combo box
        txtProductSupplierId.ReadOnly = true;
        cboProductName.Enabled = false;
        cboSupplierName.Enabled = false;

        // disable discard and save change
        btnDisc.Enabled = false;
        btnSave.Enabled = false;

        // enable add, edit and delete
        btnAdd.Enabled = true;
        btnEdit.Enabled = true;
        btnDelete.Enabled = true;
    }

    private void GetProductSuppliers()
    {
        productsSupplierList = ProductSuppliersRepository.GetProductSuppliersDTO();
        dgvProductSupplier.DataSource = productsSupplierList;
        dgvProductSupplier.ClearSelection();
    }

    private void LoadSupplier()
    {
        cboSupplierName.DataSource = SupplierRepository.GetSortedSuppliers();
        cboSupplierName.ValueMember = "SupplierId";
        cboSupplierName.DisplayMember = "SupName";
        // Hides the row selection columns
        dgvProductSupplier.RowHeadersVisible = false;
    }

    private void LoadProducts()
    {
        cboProductName.DataSource = ProductRepository.GetProduct();
        cboProductName.ValueMember = "ProductId";
        cboProductName.DisplayMember = "ProdName";
    }

    private void EnableEditableFields()
    {
        // disable add, edit and delete
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;

        // enable discard and save change
        btnDisc.Enabled = true;
        btnSave.Enabled = true;

        // enable combo boxes
        cboProductName.Enabled = true;
        cboSupplierName.Enabled = true;
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        // make search icon visible
        lblSearchIcon.Visible = true;

        EnableEditableFields();
        txtProductSupplierId.ReadOnly = false; // allow to search by key

        // clear all input fields
        ClearAllInputFields();


        btnSave.Enabled = false;
        btnAdd.Enabled = false;
        btnDelete.Enabled = false;
        btnEdit.Enabled = false;
        btnDisc.Enabled = true;
    }

    private void ClearAllInputFields()
    {
        txtProductSupplierId.Clear();
        cboProductName.SelectedIndex = -1;
        cboSupplierName.SelectedIndex = -1;
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
        // if ProductSupplierId is not empty, check the textbox
        if (!string.IsNullOrWhiteSpace(txtProductSupplierId.Text) &&
            !TextBoxValidator.IsInteger(txtProductSupplierId))
        {
            return;
        }

        // If all fields are empty, no filters are applied in the Where clause,
        // mean that we're going to query all instead.
        var filteredList = productsSupplierList.Where(productsSupplier =>
            (string.IsNullOrWhiteSpace(txtProductSupplierId.Text) || productsSupplier.ProductSupplierId == Convert.ToInt32(txtProductSupplierId.Text)) &&
            (cboProductName.SelectedValue == null || productsSupplier.ProductId == Convert.ToInt32(cboProductName.SelectedValue)) &&
            (cboSupplierName.SelectedValue == null || productsSupplier.SupplierId == Convert.ToInt32(cboSupplierName.SelectedValue))
        ).ToList();

        if (filteredList.Count == 0)
        {
            suppressSelectionChanged = true;
        }

        dgvProductSupplier.DataSource = filteredList;
    }

    private void lblClearIcon_Click(object sender, EventArgs e)
    {
        ClearAllInputFields();
    }

}
