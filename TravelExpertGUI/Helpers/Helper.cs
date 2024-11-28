namespace TravelExpertGUI.Helpers;
public class Helper
{
    public static void ShowWarningMessageBox(string text, string caption)
    {
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
