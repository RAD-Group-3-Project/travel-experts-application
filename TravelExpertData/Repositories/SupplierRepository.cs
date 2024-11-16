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
    {   // Returns a list of all suppliers that are active 
        public static List<Supplier> getSupplier()
        {   
            // Opens the connection
            using TravelExpertContext conn = new TravelExpertContext();
            {   
                // Tries to grab the list 
                try
                {   
                    // Stores a list from the databse where they are still active
                    var supplier = conn.Suppliers.Where(supplier => supplier.IsActive == true);
                    // returns the list
                    return supplier.ToList();
                }   
                // Catches our exceptions 
                catch (Exception ex)
                {
                    // throws exception
                    throw new Exception("Unable to load suppliers");
                }
            }
        }
        // We need a function to get all suppliers including inactive ones. This lets us determine the next id number 
        public static List<Supplier> getAllSuppliers()
        {   
            // opens our connection
            using TravelExpertContext conn = new TravelExpertContext();
            {   
                // Returns ALL suppliers 
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
            // Opens connection and tries 
            using(TravelExpertContext conn = new TravelExpertContext())
            {
                try
                {
                    conn.Suppliers.Add(newSupplier);
                    conn.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error Adding Supplier to database");
                }
            }
        }

        public static void updateSupplier(Supplier editedSupplier)
        {
            using(TravelExpertContext conn = new TravelExpertContext())
            {
                try
                {
                    conn.Suppliers.Update(editedSupplier);
                    conn.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error updating selected supplier");
                }
            }
        }

        public static void deleteSupplier(int supplierId) 
        {   
            using(TravelExpertContext conn = new TravelExpertContext())
            {

                try
                {
                    Supplier supplier = conn.Suppliers.Find(supplierId);
                    if (supplier == null)
                    {
                        throw new Exception("Cant find Supplier for Deletion");
                    }
                    supplier.IsActive = false;
                    conn.Suppliers.Update(supplier);
                    conn.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error deleting the supplier");
                }

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
