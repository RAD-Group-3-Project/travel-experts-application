using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertData.Models;
using TravelExpertData.Repositories;

namespace TravelExpertGUI
{
    public partial class ucManagePackageProductSupplier : UserControl
    {
        //private int selectedPackageProductSupplierID;
        //private int selectedPackageID;
        //private int selectedProductSupplierID;
        private bool isAddition;

        public ucManagePackageProductSupplier()
        {
            InitializeComponent();
        }

        private void ucManagePackageProductSupplier_Load(object sender, EventArgs e)
        {
            populatePPS();

        }

        private void populatePPS()
        {
            dgvPackageProductSupplier.Enabled = true;
            // Sets textboxes and buttons to appropriate status
            txtPackageProductSupplierId.ReadOnly = true;
            cmbPackageID.Enabled = false;
            cmbProductSupplierID.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnDisc.Enabled = false;
            btnSave.Enabled = false;
            // Clears The list
            dgvPackageProductSupplier.Columns.Clear();
            // Populates the list
            dgvPackageProductSupplier.DataSource = PackagesProductsSuppliersRepository.GetPPSList();





        }

        private void dgvPackageProductSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPackageProductSupplier.CurrentRow != null) // if row selected
            {
                loadPackageID();

                txtPackageProductSupplierId.Text = dgvPackageProductSupplier.CurrentRow.Cells["PackageProductSupplierId"].Value.ToString();

                int selectedPackageId = Convert.ToInt32(dgvPackageProductSupplier.CurrentRow.Cells["PackageId"].Value);
                int selectedSupplierId = Convert.ToInt32(dgvPackageProductSupplier.CurrentRow.Cells["ProductSupplierId"].Value);

                cmbPackageID.SelectedValue = selectedPackageId;
                cmbProductSupplierID.SelectedValue = selectedSupplierId;

            }
        }

        private void loadPackageID()
        {

            List<Package> package = PackageRepository.GetPackages();
            List<ProductsSupplier> supplier = ProductSuppliersRepository.GetProductSuppliers();

            // Set the DataSource and DisplayMember for the combo box
            cmbPackageID.DataSource = package;
            cmbPackageID.DisplayMember = "PkgName";
            cmbPackageID.ValueMember = "PackageId";
            cmbProductSupplierID.DataSource = supplier;
            cmbProductSupplierID.ValueMember = "ProductSupplierId";
            cmbProductSupplierID.DisplayMember = "ProductSupplierId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvPackageProductSupplier.Enabled = false;
            cmbPackageID.SelectedIndex = -1;
            cmbProductSupplierID.SelectedIndex = -1;
            txtPackageProductSupplierId.Clear();
            txtPackageProductSupplierId.ReadOnly = true;
            cmbPackageID.Enabled = true;
            cmbProductSupplierID.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnDisc.Enabled = true;
            btnSave.Enabled = true;
            isAddition = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAddition)
            {
                PackagesProductsSupplier addedPPS = new PackagesProductsSupplier();
                addedPPS.PackageId = Int32.Parse(cmbPackageID.SelectedValue.ToString());
                addedPPS.ProductSupplierId = Int32.Parse(cmbProductSupplierID.SelectedValue.ToString());
                addedPPS.IsActive = true;
                PackagesProductsSuppliersRepository.CreatePPS(addedPPS);
                populatePPS();

            }
            else
            {
                PackagesProductsSupplier updatedPPS = new PackagesProductsSupplier();
                updatedPPS.PackageProductSupplierId = Int32.Parse(txtPackageProductSupplierId.Text.ToString());
                updatedPPS.PackageId = Int32.Parse(cmbPackageID.SelectedValue.ToString());
                updatedPPS.ProductSupplierId = Int32.Parse(cmbProductSupplierID.SelectedValue.ToString());
                updatedPPS.IsActive = true;
                PackagesProductsSuppliersRepository.UpdatePPS(updatedPPS);
                populatePPS();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgvPackageProductSupplier.Enabled = false;
            txtPackageProductSupplierId.ReadOnly = true;
            cmbPackageID.Enabled = true;
            cmbProductSupplierID.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnDisc.Enabled = true;
            btnSave.Enabled = true;
            isAddition = false;
        }

        private void btnDisc_Click(object sender, EventArgs e)
        {
            populatePPS();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvPackageProductSupplier.CurrentRow;
            int selectedPPS = Convert.ToInt32(selectedRow.Cells[0].Value);
            DialogResult result =
           MessageBox.Show($"Are you sure you would like to delete PPS #{selectedRow.Cells[0].Value} ",
           "Confirm Agent Deletion",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    PackagesProductsSuppliersRepository.DeletePPS(selectedPPS);
                    populatePPS();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}", "PPS Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
