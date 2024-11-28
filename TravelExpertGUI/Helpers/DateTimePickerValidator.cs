namespace TravelExpertGUI.Helpers;
public class DateTimePickerValidator
{
    public static bool ValidatePackageEndDate(DateTimePicker dtpPackageStartDate, DateTimePicker dtpPackageEndDate)
    {
        if (dtpPackageEndDate.Value.CompareTo(dtpPackageStartDate.Value) < 0) // earlier
        {
            Helper.ShowWarningMessageBox("The Package End Date must be later than Package Start Date", "Validation Error");
            dtpPackageEndDate.Focus();
            return false;
        }

        return true;
    }
}
