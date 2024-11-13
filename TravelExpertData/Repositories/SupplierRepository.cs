using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertData.Data;
using TravelExpertData.Models;

namespace TravelExpertData.Repositories
{
    public class SupplierRepository
    {   
        public static List<Supplier> getSupplier()
        {
            using TravelExpertContext conn = new TravelExpertContext();
            {
                var supplier = conn.Suppliers.Where(supplier => supplier.is_active == true);
                    return supplier.ToList();
            }
        }
    }
}
