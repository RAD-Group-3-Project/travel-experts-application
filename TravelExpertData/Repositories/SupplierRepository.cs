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
        public static List<Supplier> getAllSuppliers()
        {
            using TravelExpertContext conn = new TravelExpertContext();
            {
                var supplier = conn.Suppliers;
                return supplier.ToList();
            }
        }
        public static List<Supplier> GetSortedSuppliers()
        {
            using TravelExpertContext conn = new TravelExpertContext();
            {
                var supplier = conn.Suppliers;
                return supplier
                    .OrderBy(s => s.SupName)
                    .ToList();
            }
        }

        public static void addSupplier(Supplier newSupplier)
        {   
            using(TravelExpertContext conn = new TravelExpertContext())
            {
                conn.Suppliers.Add(newSupplier);
                conn.SaveChanges();
            }
        }

        public static void updateSupplier(Supplier editedSupplier)
        {
            using(TravelExpertContext conn = new TravelExpertContext())
            {
                conn.Suppliers.Update(editedSupplier);
                conn.SaveChanges();
            }
        }

        public static void deleteSupplier(int supplierId) 
        {   
            using(TravelExpertContext conn = new TravelExpertContext())
            {
                Supplier supplier = conn.Suppliers.Find(supplierId);
                supplier.is_active = false;
                conn.Suppliers.Update(supplier);
                conn.SaveChanges();

            }
            
        }

        public static Supplier getSupplierByID(int id)
        {
            using (TravelExpertContext conn = new TravelExpertContext())
            {
                // Returns the suppliers object via function
                return conn.Suppliers.Find(id);
            }
        }
    }
}
