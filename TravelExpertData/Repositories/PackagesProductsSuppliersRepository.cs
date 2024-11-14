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
                try
                {
                    var ppslist = conn.PackagesProductsSuppliers;
                    return ppslist.ToList();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error Getting PPS List");
                }
            }
        }
        public static void CreatePPS(PackagesProductsSupplier newPPS)
        {
            using TravelExpertContext conn = new TravelExpertContext();
            {
                try
                {

                    conn.PackagesProductsSuppliers.Add(newPPS);
                    conn.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error Adding PPS");
                }
            }
        }

        public static void UpdatePPS(PackagesProductsSupplier editedPPS) 
        {
            using TravelExpertContext conn = new TravelExpertContext();
            {
                try
                {
                    conn.PackagesProductsSuppliers.Update(editedPPS);
                    conn.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error Updating PPS");
                }
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
                try
                {
                    pps.IsActive = false;
                    conn.PackagesProductsSuppliers.Update(pps);
                    conn.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception("Error Deleting PPS");
                }
            }
        }   
    }
}
