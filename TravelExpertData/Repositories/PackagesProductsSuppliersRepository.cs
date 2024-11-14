using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertData.Data;
using TravelExpertData.Models;

namespace TravelExpertData.Repositories
{
    public class PackagesProductsSuppliersRepository
    {   
        public static List<PackagesProductsSupplier> GetPPSList()
        {
            using TravelExpertContext conn = new TravelExpertContext();
            {   
                var ppslist = conn.PackagesProductsSuppliers;
                return  ppslist.ToList();
            }
        }
        public static void CreatePPS(PackagesProductsSupplier newPPS)
        {
            using TravelExpertContext conn = new TravelExpertContext();
            { 
                conn.PackagesProductsSuppliers.Add(newPPS);
                conn.SaveChanges();
            }
        }

        public static void UpdatePPS(PackagesProductsSupplier editedPPS) 
        {
            using TravelExpertContext conn = new TravelExpertContext();
            {
                conn.PackagesProductsSuppliers.Update(editedPPS);
                conn.SaveChanges();
            }
        }

        public static void DeletePPS(int deletedId)
        {
            using TravelExpertContext conn = new TravelExpertContext(); 
            {
                PackagesProductsSupplier pps = conn.PackagesProductsSuppliers.Find(deletedId);
                if (pps == null) 
                {
                    throw new Exception("Cant find PPS for deletion");
                }
                pps.IsActive = false;
                conn.PackagesProductsSuppliers.Update(pps);
                conn.SaveChanges();
            }
        }   
    }
}
