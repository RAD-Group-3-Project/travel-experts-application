using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertGUI.Helpers;

namespace TravelExpertGUI;
public partial class ucManagePackages : UserControl
{
    public ucManagePackages()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This function is not implemented yet", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //TODO: Implement here
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

    private void btnSave_Click(object sender, EventArgs e)
    {
        // validate required fields and some business needed
        if (ValidateRequiredFieldsAndBizLogic())
        {
            return;
        }
    }

    private void btnDiscard_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This function is not implemented yet", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //TODO: Implement here
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
