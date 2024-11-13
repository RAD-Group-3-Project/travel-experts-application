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
    public ucManageProductSuppliers()
    {
        InitializeComponent();
    }

    private void ucManageProductSuppliers_Load(object sender, EventArgs e)
    {

        // disable all textbox and combo box
        txtProductSupplierId.Enabled = false;
        cboProductName.Enabled = false;
        cboSupplierName.Enabled = false;

        // disable discard and save change
        btnDisc.Enabled = false;
        btnSave.Enabled = false;

        // get list of product supplier
        GetProductSuppliers();
        LoadProducts();
        LoadSupplier();
    }

    private void GetProductSuppliers()
    {
        dgvProductSupplier.DataSource = ProductSuppliersRepository.GetProductSuppliersDTO();
        dgvProductSupplier.ClearSelection();
    }

    private void LoadSupplier()
    {
        //cboSupplierName.DataSource = ProductSuppliersRepository.GetProductSuppliers();
    }

    private void LoadProducts()
    {
        cboProductName.DataSource = ProductRepository.GetProduct();
        cboProductName.ValueMember = "ProductId";
        cboProductName.DisplayMember = "ProdName";
    }

    private void btnAdd_Click(object sender, EventArgs e)
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

    private void dgvProductSupplier_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvProductSupplier.CurrentRow != null) // check not equal to column
        {
            txtProductSupplierId.Text = dgvProductSupplier.CurrentRow.Cells["ProductSupplierId"].Value.ToString();
            cboProductName.SelectedValue = int.Parse(dgvProductSupplier.CurrentRow.Cells["ProductId"].Value.ToString());
            cboSupplierName.SelectedValue = int.Parse(dgvProductSupplier.CurrentRow.Cells["SupplierId"].Value.ToString());
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This function is not implemented yet", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //TODO: Implement here
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This function is not implemented yet", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //TODO: Implement here
    }
    private void btnDisc_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This function is not implemented yet", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //TODO: Implement here
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This function is not implemented yet", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //TODO: Implement here
    }

}
