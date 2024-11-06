using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertGUI.Helpers;
public static class TextBoxValidator
{
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
}
