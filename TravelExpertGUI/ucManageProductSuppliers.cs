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
using TravelExpertData.Repositories;

namespace TravelExpertGUI;
public partial class ucManageProductSuppliers : UserControl
{
    private string selectedProductSupplierId;
    private int selectedProductId;
    private int selectedSupplierId;

    private bool isAddition;

    public ucManageProductSuppliers()
    {
        InitializeComponent();
    }
    
    private void ucManageProductSuppliers_Load(object sender, EventArgs e)
    {
        // init behaviour of buttons and textboxes
        InitButtonAndFields();

        // get list of product supplier
        GetProductSuppliers();
        LoadProducts();
        LoadSupplier();
    }

    private void dgvProductSupplier_SelectionChanged(object sender, EventArgs e)
    {
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
        MessageBox.Show("This function is not implemented yet", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //TODO: Implement here
    }
    private void btnDisc_Click(object sender, EventArgs e)
    {
        // set value back
        txtProductSupplierId.Text = selectedProductSupplierId;
        cboProductName.SelectedValue = selectedProductId;
        cboSupplierName.SelectedValue = selectedSupplierId;

        InitButtonAndFields();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This function is not implemented yet", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //TODO: Implement here
    }

    private void InitButtonAndFields()
    {
        // disable all textbox and combo box
        txtProductSupplierId.Enabled = false;
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
        dgvProductSupplier.DataSource = ProductSuppliersRepository.GetProductSuppliersDTO();
        dgvProductSupplier.ClearSelection();
    }

    private void LoadSupplier()
    {
        cboSupplierName.DataSource = SupplierRepository.getAllSuppliers();
        cboSupplierName.ValueMember = "SupplierId";
        cboSupplierName.DisplayMember = "SupName";
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

}
