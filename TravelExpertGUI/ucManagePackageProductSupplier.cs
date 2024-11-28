using System.Data;
using TravelExpertData.Models;
using TravelExpertData.Repositories;
using TravelExpertGUI.Helpers;

namespace TravelExpertGUI
{
    public partial class ucManagePackageProductSupplier : UserControl
    {
        private List<PackagesProductsSupplierView> ppsList = null;
        private bool isAddition;
        private bool suppressSelectionChanged;
        public string TableName { get; set; } = "Package Products Suppliers";

        public ucManagePackageProductSupplier()
        {
            InitializeComponent();
            lblTableName.Text = TableName;
        }
        // Populates our list with active PPS
        private void ucManagePackageProductSupplier_Load(object sender, EventArgs e)
        {
            populatePPS();

        }
        // Function to poulate our DGV
        private void populatePPS()
        {
            // make search icon invisible
            lblSearchIcon.Visible = false;

            // Makes it clickable
            dgvPackageProductSupplier.Enabled = true;
            // Sets textboxes and buttons to appropriate status
            txtPackageProductSupplierId.ReadOnly = true;
            cmbPackageID.Enabled = false;
            cmbProductSupplierID.Enabled = false;
            // Clears The list
            dgvPackageProductSupplier.Columns.Clear();
            // Populates the list
            ppsList = PackagesProductsSuppliersRepository.GetPPSList();
            dgvPackageProductSupplier.DataSource = ppsList;
            // format the column header
            dgvPackageProductSupplier.EnableHeadersVisualStyles = false;
            dgvPackageProductSupplier.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvPackageProductSupplier.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPackageProductSupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
            dgvPackageProductSupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            // Manually change our column width, alignment, and header text
            dgvPackageProductSupplier.Columns[0].HeaderText = "Id";
            dgvPackageProductSupplier.Columns[1].HeaderText = "Package ID";
            dgvPackageProductSupplier.Columns[2].HeaderText = "Package Name";
            dgvPackageProductSupplier.Columns[3].HeaderText = "Prod Sup ID";

            dgvPackageProductSupplier.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Hides the row selection columns
            dgvPackageProductSupplier.RowHeadersVisible = false;
            // Activates and deactivates appropriate buttons
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnDisc.Enabled = false;
            btnSave.Enabled = false;

        }
        // Gets our current row and changes selected PPS
        private void dgvPackageProductSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (suppressSelectionChanged)
            {
                return;
            }
            // If a row is actually selected 
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
            dgvPackageProductSupplier.ReadOnly = true;

            EnableEditableFields();

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // make search icon visible
            lblSearchIcon.Visible = true;

            EnableEditableFields();

            txtPackageProductSupplierId.ReadOnly = false;  // for searching purpose

            // disable all buttons except disc button
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
            if (!string.IsNullOrWhiteSpace(txtPackageProductSupplierId.Text) &&
                !TextBoxValidator.IsInteger(txtPackageProductSupplierId))
            {
                return;
            }

            // If all fields are empty, no filters are applied in the Where clause,
            // mean that we're going to query all instead.
            var filteredList = ppsList.Where(pps =>
                (string.IsNullOrWhiteSpace(txtPackageProductSupplierId.Text) || pps.PackageProductSupplierId == Convert.ToInt32(txtPackageProductSupplierId.Text)) &&
                (cmbPackageID.SelectedValue == null || pps.PackageId == Convert.ToInt32(cmbPackageID.SelectedValue)) &&
                (cmbProductSupplierID.SelectedValue == null || pps.ProductSupplierId == Convert.ToInt32(cmbProductSupplierID.SelectedValue))
            ).ToList();

            if (filteredList.Count == 0)
            {
                suppressSelectionChanged = true;
            }

            dgvPackageProductSupplier.DataSource = filteredList;
        }

        private void lblClearIcon_Click(object sender, EventArgs e)
        {
            ClearAllInputFields();
        }

        private void EnableEditableFields()
        {
            ClearAllInputFields();

            // Enables dropdown
            cmbPackageID.Enabled = true;
            cmbProductSupplierID.Enabled = true;
            txtPackageProductSupplierId.ReadOnly = true;
        }

        private void ClearAllInputFields()
        {
            // Clears boxes 
            txtPackageProductSupplierId.Clear();

            // Resets combo boxes 
            cmbPackageID.SelectedIndex = -1;
            cmbProductSupplierID.SelectedIndex = -1;
        }
    }
}
