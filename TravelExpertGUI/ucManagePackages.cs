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
using TravelExpertGUI.Helpers;

namespace TravelExpertGUI;
public partial class ucManagePackages : UserControl
{
    private List<Package> packages = null;
    private bool suppressSelectionChanged;
    string function;

    public ucManagePackages()
    {
        InitializeComponent();
    }

    private void ucManagePackages_Load(object sender, EventArgs e)
    {
        populatePackages();
    }

    private void dgvPackges_SelectionChanged(object sender, EventArgs e)
    {
        if (suppressSelectionChanged)
        {
            return;
        }

        if (dgvPackages.SelectedRows != null)
        {
            txtPkgId.Text = dgvPackages.CurrentRow.Cells["PackageID"].Value.ToString();
            txtPkgName.Text = dgvPackages.CurrentRow.Cells["PackName"].Value.ToString();
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        txtPkgId.ReadOnly = true;

        EnableEditableFields();

        txtPkgName.Focus();
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDiscard.Enabled = true;

        // Finds last package ID and populate the box
        int lastRowColumnValue = lastID_PlusOne();
        txtPkgId.Text = lastRowColumnValue.ToString();

        // Changes the save name to "ADD"
        function = "ADD";

        // Locks the database grid view
        dgvPackages.Enabled = false;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        txtPkgId.ReadOnly = true;
        txtPkgName.ReadOnly = false;
        txtPkgName.Focus();
        txtPkgStartDate.ReadOnly = false;
        txtPkgEndDate.ReadOnly = false;
        txtPkgDesc.ReadOnly = false;
        txtPkgBasePrice.ReadOnly = false;
        txtPkgAgcyCom.ReadOnly = false;
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnSave.Enabled = true;
        btnDiscard.Enabled = true;
        function = "EDIT";

        // Locks the database grid view
        dgvPackages.Enabled = false;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        // Finds the selected row and supplier
        DataGridViewRow selectedRow = dgvPackages.CurrentRow;
        int selectedPackages = Convert.ToInt32(selectedRow.Cells[0].Value);

        // Pops out message box to ensure deletion
        DialogResult result = MessageBox.Show($"Are you sure you want to delete Package {selectedRow.Cells[1].Value} ", "Delete Package",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        // If user clicks yes
        if (result == DialogResult.Yes)
        {
            // Try-catch delete
            try
            {
                PackageRepository.DeletePackageByID(selectedPackages);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Package Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh list
            populatePackages();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        switch (function)
        {
            case "ADD":
                if (ValidateRequiredFieldsAndBizLogic())
                {
                    Package addedPackage = new Package();
                    int lastRowColumnValue = lastID_PlusOne();
                    addedPackage.PackageId = lastRowColumnValue;
                    addedPackage.PkgName = txtPkgName.Text;
                    //addedPackage.PkgStartDate = DateTime.TryParse(txtPkgStartDate.Text);

                    //addedPackage.IsActive = true;

                    try
                    {
                        PackageRepository.AddPackage(addedPackage);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Package Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Refresh list
                    populatePackages();
                    break;
                }
                else
                {
                    MessageBox.Show("Please input a Package Name");
                    break;
                }

            case "EDIT":
                if (ValidateRequiredFieldsAndBizLogic())
                {
                    Package editedPackage = new Package();
                    editedPackage.PackageId = Convert.ToInt32(txtPkgId.Text);
                    editedPackage.PkgName = txtPkgName.Text;

                    try
                    {
                        PackageRepository.UpdatePackage(editedPackage);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Package Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Refresh list
                    populatePackages();

                    break;
                }
                else
                {
                    MessageBox.Show("Please input a Package Name");
                    break;
                }
        }
    }

    private void btnDiscard_Click(object sender, EventArgs e)
    {
        populatePackages();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        lblSearchIcon.Visible = true;

        EnableEditableFields();

        txtPkgId.ReadOnly = false;

        btnSave.Enabled = false;
        btnAdd.Enabled = false;
        btnDelete.Enabled = false;
        btnEdit.Enabled = false;
        btnDiscard.Enabled = true;
    }

    private void lblSearchIcon_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtPkgId.Text) && !TextBoxValidator.IsInteger(txtPkgId))
        {
            return;
        }

        var filteredList = packages.Where(package => (string.IsNullOrWhiteSpace(txtPkgId.Text) || package.PackageId == Convert.ToInt32(txtPkgId.Text) &&
        (string.IsNullOrWhiteSpace(txtPkgName.Text) || package.PkgName.ToLower().Contains(txtPkgName.Text.ToLower())))).ToList();

        if (filteredList.Count == 0)
        {
            suppressSelectionChanged = true;
        }

        dgvPackages.DataSource = filteredList;
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

    private void lblClearIcon_MouseHover(Object sender, MouseEventArgs e)
    {
        lblClearIcon.Cursor = Cursors.Hand;
    }

    private void lblClearIcon_MouseLeave(Object sender, EventArgs e)
    {
        lblClearIcon.Cursor = Cursors.Default;
    }

    private void populatePackages()
    {
        lblSearchIcon.Visible = false;
        txtPkgId.ReadOnly = true;
        txtPkgName.ReadOnly = true;
        txtPkgAgcyCom.ReadOnly = true;
        txtPkgBasePrice.ReadOnly = true;
        txtPkgDesc.ReadOnly = true;
        txtPkgStartDate.ReadOnly = true;
        txtPkgEndDate.ReadOnly = true;
        btnAdd.Enabled = true;
        btnDiscard.Enabled = false;
        btnSave.Enabled = false;

        // Clear list
        dgvPackages.Columns.Clear();
        dgvPackages.ReadOnly = true;
        packages = PackageRepository.GetPackages();
        dgvPackages.DataSource = packages;

        // Formatting the column header
        dgvPackages.EnableHeadersVisualStyles = false;
        dgvPackages.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        dgvPackages.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvPackages.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
        dgvPackages.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvPackages.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        // Manually change the column width, alignment, and header text
        dgvPackages.Columns[0].HeaderText = "ID";
        dgvPackages.Columns[1].HeaderText = "Package Name";

        // Hides header column
        dgvPackages.RowHeadersVisible = false;

        // Hides additional columns
        dgvPackages.Columns[2].Visible = false;
        dgvPackages.Columns[3].Visible = false;
        dgvPackages.Columns[4].Visible = false;
        dgvPackages.Columns[1].Width = 350;

        // Unlocks the dgv so it can be click
        dgvPackages.Enabled = true;
    }

    private void EnableEditableFields()
    {
        ClearAllInputFields();

        txtPkgName.ReadOnly = false;
        txtPkgStartDate.ReadOnly = false;
        txtPkgEndDate.ReadOnly = false;
        txtPkgDesc.ReadOnly = false;
        txtPkgBasePrice.ReadOnly = false;
        txtPkgAgcyCom.ReadOnly = false;
    }

    private void ClearAllInputFields()
    {
        txtPkgId.Clear();
        txtPkgName.Clear();
        txtPkgStartDate.Clear();
        txtPkgEndDate.Clear();
        txtPkgDesc.Clear();
        txtPkgBasePrice.Clear();
        txtPkgAgcyCom.Clear();
    }

    private static int lastID_PlusOne()
    {
        // Get list of all packages including non-active
        List<Package> packageData = PackageRepository.GetAllPackages();

        // Get the last ID, adds one and returns it
        int lastRowColumnValue = packageData.Last().PackageId;
        lastRowColumnValue++;
        return lastRowColumnValue;
    }

    private bool ValidateRequiredFieldsAndBizLogic()
    {
        return !TextBoxValidator.IsPresent(txtPkgId) ||
               !TextBoxValidator.IsPresent(txtPkgName) ||
               !TextBoxValidator.IsPresent(txtPkgDesc) ||
               !TextBoxValidator.IsPresent(txtPkgBasePrice) ||
               !TextBoxValidator.IsPresent(txtPkgStartDate) ||
               !TextBoxValidator.IsPresent(txtPkgEndDate) ||
               !TextBoxValidator.IsPresent(txtPkgAgcyCom) ||
               !TextBoxValidator.ValidatePackageEndDate(txtPkgStartDate, txtPkgEndDate) ||
               !TextBoxValidator.ValidateAgencyCommission(txtPkgAgcyCom, txtPkgBasePrice);
    }
}
