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

namespace TravelExpertGUI;
public partial class ucManageSuppliers : UserControl
{
    public ucManageSuppliers()
    {
        InitializeComponent();
    }
    string function;

    private void ucManageSuppliers_Load(object sender, EventArgs e)
    {
        populateSuppliers();

    }

    private void populateSuppliers()
    {
        txtSupID.ReadOnly = true;
        txtSupName.ReadOnly = true;
        btnAdd.Enabled = true;
        btnDelete.Enabled = true;
        btnEdit.Enabled = true;
        btnDisc.Enabled = false;
        btnSave.Enabled = false;

        dgvSuppliers.Columns.Clear();
        dgvSuppliers.DataSource = SupplierRepository.getSupplier();
        // format the column header
        dgvSuppliers.EnableHeadersVisualStyles = false;
        dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        dgvSuppliers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
        dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvSuppliers.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        // Hides the row selection columns
        dgvSuppliers.RowHeadersVisible = false;
        // Hides additional columns we dont need to see 
        dgvSuppliers.Columns[2].Visible = false;
        dgvSuppliers.Columns[3].Visible = false;
        dgvSuppliers.Columns[4].Visible = false;
        dgvSuppliers.Columns[1].Width = 350;

    }

    private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvSuppliers.SelectedRows != null)
        {
            txtSupID.Text = dgvSuppliers.CurrentRow.Cells["SupplierId"].Value.ToString();
            txtSupName.Text = dgvSuppliers.CurrentRow.Cells["SupName"].Value.ToString();
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        txtSupID.Clear();
        txtSupName.Clear();
        txtSupID.ReadOnly = true;
        txtSupName.ReadOnly = false;
        txtSupName.Focus();
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDisc.Enabled = true;
        int lastRowColumnValue = lastID_PlusOne();
        txtSupID.Text = lastRowColumnValue.ToString();
        function = "ADD";


    }

    private static int lastID_PlusOne()
    {
        List<Supplier> supplierData = SupplierRepository.getAllSuppliers();
        int lastRowColumnValue = supplierData.Last().SupplierId;
        lastRowColumnValue++;
        return lastRowColumnValue;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        txtSupID.ReadOnly = true;
        txtSupName.ReadOnly = false;
        txtSupName.Focus();
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDisc.Enabled = true;
        function = "EDIT";

    }

    private void btnDisc_Click(object sender, EventArgs e)
    {
        populateSuppliers();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        switch (function)
        {
            case "ADD":

                Supplier addedSupplier = new Supplier();
                int lastRowColumnValue = lastID_PlusOne();
                addedSupplier.SupplierId = lastRowColumnValue;
                addedSupplier.SupName = txtSupName.Text;
                addedSupplier.is_active = true;
                SupplierRepository.addSupplier(addedSupplier);
                populateSuppliers();

                break;

            case "EDIT":

                Supplier editedSupplier = new Supplier();

                editedSupplier.SupplierId = Convert.ToInt32(txtSupID.Text);
                editedSupplier.SupName = txtSupName.Text;
                editedSupplier.is_active = true;
                SupplierRepository.updateSupplier(editedSupplier);
                populateSuppliers();

                break;

        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        DataGridViewRow selectedRow = dgvSuppliers.CurrentRow;
        int selectedSupplier = Convert.ToInt32(selectedRow.Cells[0].Value);
        DialogResult result =
            MessageBox.Show($"Are you sure you want to delete Supplier {selectedRow.Cells[1].Value} ",
            "Delete Supplier",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        if (result == DialogResult.Yes) 
        {
            SupplierRepository.deleteSupplier(selectedSupplier);
            populateSuppliers() ;
        }
    }
}

