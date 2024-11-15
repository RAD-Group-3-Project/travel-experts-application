using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertData.Models
{
    public class PackagesProductsSupplierView
    {
        public int PackageProductSupplierId { get; set; }
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public int ProductSupplierId { get; set; }
        public string SupName { get; set; }
    }
}
