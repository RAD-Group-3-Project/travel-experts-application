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

namespace TravelExpertGUI;
public partial class ucWelcomeMessage : UserControl
{
    public ucWelcomeMessage()
    {
        InitializeComponent();
    }
    
    public CurrentUser currentuser= new();
    private void ucWelcomeMessage_Load(object sender, EventArgs e)
    {   
        // Checks if the current user is admin or not
        if (currentuser.IS_Admin)
        {   
            // And changes the text to the first name of the user 
            lblHello.Text = $"Hello {currentuser.Username}!";
        }
        else  
        {
            lblHello.Text = $"Hello {currentuser.Username}!";
        }
    }
}
