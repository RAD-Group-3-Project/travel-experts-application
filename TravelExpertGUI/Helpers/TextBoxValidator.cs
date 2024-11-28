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
            Helper.ShowWarningMessageBox($"Please enter a value for {textBox.Tag}.", "Input Required");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }

        return true;
    }

    public static bool IsDouble(TextBox textBox)
    {
        if (!Double.TryParse(textBox.Text, out double output))
        {
            Helper.ShowWarningMessageBox($"{textBox.Tag} field contains non-numeric characters", "Error");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }

        return true;
    }

    public static bool IsNonNegativeDouble(TextBox textBox)
    {
        if (!Double.TryParse(textBox.Text, out double output))
        {
            Helper.ShowWarningMessageBox($"{textBox.Tag} field contains non-numeric characters", "Error");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }
        if (output < 0)
        {
            Helper.ShowWarningMessageBox($"{textBox.Tag} can't be negative value", "Error");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }

        return true;
    }

    public static bool IsDoubleInRange(TextBox textBox, double min, double max)
    {
        if (!Double.TryParse(textBox.Text, out double output))
        {
            Helper.ShowWarningMessageBox($"{textBox.Tag} field contains non-numeric characters", "Error");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }
        if (output < min || output > max)
        {
            Helper.ShowWarningMessageBox($"{textBox.Tag} field should be within the range of {min} and {max}", "Error");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }

        return true;
    }

    public static bool IsDecimal(TextBox textBox)
    {
        if (!Double.TryParse(textBox.Text, out double output))
        {
            Helper.ShowWarningMessageBox($"{textBox.Tag} field contains non-numeric characters", "Error");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }

        return true;
    }

    public static bool IsInteger(TextBox textBox)
    {
        if (!Int32.TryParse(textBox.Text, out Int32 output))
        {
            Helper.ShowWarningMessageBox($"{textBox.Tag} field contains non-numeric characters", "Error");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }

        return true;
    }

    public static bool IsNonNegativeInteger(TextBox textBox)
    {
        if (!Int32.TryParse(textBox.Text, out Int32 output))
        {
            Helper.ShowWarningMessageBox($"{textBox.Tag} field contains non-numeric characters", "Error");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }
        if (output < 0)
        {
            Helper.ShowWarningMessageBox($"{textBox.Tag} can't be negative value", "Error");
            textBox.SelectAll();
            textBox.Focus();
            return false;
        }

        return true;
    }

    public static bool IsValidDate(TextBox textBox)
    {
        if (!DateTime.TryParse(textBox.Text, out var dateTime))
        {
            Helper.ShowWarningMessageBox($"Invalid data format in {textBox.Tag}. Please enter a valid date.", "Input Format Error");
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
            Helper.ShowWarningMessageBox("Please enter valid numbers for Base Price and Agency Commission.", "Input Error");
            return false;
        }

        if (agencyCommission > basePrice)
        {
            Helper.ShowWarningMessageBox("Agency Commission cannot be greater than Base Price.", "Validation Error");
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
            Helper.ShowWarningMessageBox("Please enter valid numbers for Base Price and Agency Commission.", "Input Error");
            return false;
        }

        if (PackageEndDate.CompareTo(packageStartDate) < 0) // earlier
        {
            Helper.ShowWarningMessageBox("The Package End Date must be later than Package Start Date", "Validation Error");
            txtPackageEndDate.SelectAll();
            txtPackageEndDate.Focus();
            return false;
        }

        return true;
    }


}
