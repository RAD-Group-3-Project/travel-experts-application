using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertGUI.Helpers;
public static class TextBoxValidator
{
    /// <summary>
    /// Validates whether the specified TextBox control contains a value.
    /// </summary>
    /// <param name="textBox">The TextBox control to validate.</param>
    /// <returns>
    /// <c>true</c> if the TextBox contains a non-whitespace value; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsPresent(TextBox textBox)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            MessageBox.Show($"Please enter a value for {textBox.Tag}.", "Input Required");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }

        return true;
    }

    public static bool ValidateAgencyCommission(TextBox txtAgencyCommission, TextBox txtBasePrice)
    {
        if (!decimal.TryParse(txtBasePrice.Text, out decimal basePrice) ||
            !decimal.TryParse(txtAgencyCommission.Text, out decimal agencyCommission))
        {
            ShowWarningMessageBox("Please enter valid numbers for Base Price and Agency Commission.", "Input Error");
            return false;
        }

        if (agencyCommission > basePrice)
        {
            ShowWarningMessageBox("Agency Commission cannot be greater than Base Price.", "Validation Error");
            txtAgencyCommission.SelectAll();
            txtAgencyCommission.Focus();
            return false;
        }

        return true;
    }

    public static bool ValidatePackageEndDate(TextBox txtPackageStartDate, TextBox txtPackageEndDate)
    {
        if (!DateTime.TryParse(txtPackageStartDate.Text, out DateTime packageStartDate) ||
            !DateTime.TryParse(txtPackageEndDate.Text, out DateTime PackageEndDate))
        {
            ShowWarningMessageBox("Please enter valid numbers for Base Price and Agency Commission.", "Input Error");
            return false;
        }

        if (PackageEndDate.CompareTo(packageStartDate) < 0) // earlier
        {
            ShowWarningMessageBox("The Package End Date must be later than Package Start Date", "Validation Error");
            txtPackageEndDate.SelectAll();
            txtPackageEndDate.Focus();
            return false;
        }

        return true;
    }

    private static void ShowWarningMessageBox(string text, string caption)
    {
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
