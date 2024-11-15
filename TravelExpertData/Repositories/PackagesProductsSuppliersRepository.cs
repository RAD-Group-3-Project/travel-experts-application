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
        public static List<PackagesProductsSupplierView> GetPPSList()
        {
            using TravelExpertContext conn = new TravelExpertContext();
            {
                try
                {
                    var query = from pps in conn.PackagesProductsSuppliers
                                join p in conn.Packages on pps.PackageId equals p.PackageId
                                join sup in conn.ProductsSuppliers on pps.PackageProductSupplierId equals sup.ProductSupplierId
                                join s in conn.Suppliers on sup.SupplierId equals s.SupplierId
                                select new PackagesProductsSupplierView
                                {
                                    PackageProductSupplierId = pps.PackageProductSupplierId,
                                    PackageId = p.PackageId,
                                    PkgName = p.PkgName,
                                    ProductSupplierId = sup.ProductSupplierId,
                                    SupName = s.SupName
                                };

                    return query.ToList();
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
