using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertGUI
{
    public partial class ucManagePackageProductSupplier : UserControl
    {
        private int selectedPackageProductSupplierID;
        private int selectedPackageID;
        private int selectedProductSupplierID;
        private bool isAddition;

        public ucManagePackageProductSupplier()
        {
            InitializeComponent();
        }

        private void ucManagePackageProductSupplier_Load(object sender, EventArgs e)
        {
            dgvPackageProductSupplier.ReadOnly = true;
        }
    }
}
