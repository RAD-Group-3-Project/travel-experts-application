using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertData.Repositories;

namespace TravelExpertGUI;
public partial class ucManageSuppliers : UserControl
{
    public ucManageSuppliers()
    {
        InitializeComponent();
    }

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
}

