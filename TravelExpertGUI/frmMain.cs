using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertGUI;
public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit(); // Ensure the entire application closes
    }
}
