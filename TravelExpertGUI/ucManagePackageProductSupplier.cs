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
using TravelExpertGUI.Helpers;

namespace TravelExpertGUI
{
    public partial class ucManagePackageProductSupplier : UserControl
    {
        
        private bool isAddition;

        public ucManagePackageProductSupplier()
        {
            InitializeComponent();
        }
        // Populates our list with active PPS
        private void ucManagePackageProductSupplier_Load(object sender, EventArgs e)
        {
            populatePPS();

        }
        // Function to poulate our DGV
        private void populatePPS()
        {   
            // Makes it clickable
            dgvPackageProductSupplier.Enabled = true;
            // Sets textboxes and buttons to appropriate status
            txtPackageProductSupplierId.ReadOnly = true;
            cmbPackageID.Enabled = false;
            cmbProductSupplierID.Enabled = false;
            // Activates and deactivates appropriate buttons
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
        // Gets our current row and changes selected PPS
        private void dgvPackageProductSupplier_SelectionChanged(object sender, EventArgs e)
        {   // If a row is actually selected 
            if (dgvPackageProductSupplier.CurrentRow != null) // if row selected
            {
                try
                {
                    // Populates our dropdown boxes 
                    loadPackageID();
                    // Changes our cmb boxes and textboxes values to match what is selected
                    txtPackageProductSupplierId.Text = dgvPackageProductSupplier.CurrentRow.Cells["PackageProductSupplierId"].Value.ToString();
                    int selectedPackageId = Convert.ToInt32(dgvPackageProductSupplier.CurrentRow.Cells["PackageId"].Value);
                    int selectedSupplierId = Convert.ToInt32(dgvPackageProductSupplier.CurrentRow.Cells["ProductSupplierId"].Value);
                    // Selects cmb boxes 
                    cmbPackageID.SelectedValue = selectedPackageId;
                    cmbProductSupplierID.SelectedValue = selectedSupplierId;
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}", "PPS Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        // Gets 2 list and populates combo boxes with them 
        private void loadPackageID()
        {
            // gets pur lists
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
        // Start of Add Function
        private void btnAdd_Click(object sender, EventArgs e)
        {   
            // Makes our dgv inactive and allows us to enter new values 
            dgvPackageProductSupplier.Enabled = false;
            // Resets combo boxes 
            cmbPackageID.SelectedIndex = -1;
            cmbProductSupplierID.SelectedIndex = -1;
            // Clears boxes 
            txtPackageProductSupplierId.Clear();
            txtPackageProductSupplierId.ReadOnly = true;
            // Enables dropdown
            cmbPackageID.Enabled = true;
            cmbProductSupplierID.Enabled = true;
            // Sets buttons 
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnDisc.Enabled = true;
            btnSave.Enabled = true;
            // Changes function
            isAddition = true;
        }
        // Saves our changes 
        private void btnSave_Click(object sender, EventArgs e)
        {   
            // Checks function 
            if (isAddition)
            {
                try
                {
                    // Makes new PPS and gets info
                    PackagesProductsSupplier addedPPS = new PackagesProductsSupplier();
                    addedPPS.PackageId = Int32.Parse(cmbPackageID.SelectedValue.ToString());
                    addedPPS.ProductSupplierId = Int32.Parse(cmbProductSupplierID.SelectedValue.ToString());
                    addedPPS.IsActive = true;
                    PackagesProductsSuppliersRepository.CreatePPS(addedPPS);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}", "PPS Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Resets the list
                populatePPS();

            }
            // Otherwise we are updating
            else
            {
                try
                {
                    // New Pps 
                    PackagesProductsSupplier updatedPPS = new PackagesProductsSupplier();
                    // Gets our info
                    if (TextBoxValidator.IsPresent(txtPackageProductSupplierId) && TextBoxValidator.IsInteger(txtPackageProductSupplierId))
                    {
                        updatedPPS.PackageProductSupplierId = Int32.Parse(txtPackageProductSupplierId.Text.ToString());
                    }
                    updatedPPS.PackageId = Int32.Parse(cmbPackageID.SelectedValue.ToString());
                    updatedPPS.ProductSupplierId = Int32.Parse(cmbProductSupplierID.SelectedValue.ToString());
                    updatedPPS.IsActive = true;
                    // Updates 
                    PackagesProductsSuppliersRepository.UpdatePPS(updatedPPS);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}", "PPS Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Resets List
                populatePPS();
            }
        }
        // Our Edit Function
        private void btnEdit_Click(object sender, EventArgs e)
        {   
            // Makes appropriate buttons and boxes available
            dgvPackageProductSupplier.Enabled = false;
            txtPackageProductSupplierId.ReadOnly = true;
            cmbPackageID.Enabled = true;
            cmbProductSupplierID.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnDisc.Enabled = true;
            btnSave.Enabled = true;
            // Changes our function
            isAddition = false;
        }
        // Discard Button
        private void btnDisc_Click(object sender, EventArgs e)
        {   
            // Resets form
            populatePPS();
        }
        // Delete Function
        private void btnDelete_Click(object sender, EventArgs e)
        {   
            // Gets our selected row
            DataGridViewRow selectedRow = dgvPackageProductSupplier.CurrentRow;
            // Saves an int of the id 
            int selectedPPS = Convert.ToInt32(selectedRow.Cells[0].Value);
            // Popup for delete
            DialogResult result =
            MessageBox.Show($"Are you sure you would like to delete PPS #{selectedRow.Cells[0].Value} ",
            "Confirm Agent Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            // If yes delete
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
