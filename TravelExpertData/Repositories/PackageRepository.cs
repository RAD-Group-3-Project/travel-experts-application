using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelExpertData.Data;
using TravelExpertData.Models;

namespace TravelExpertData.Repositories
{
    public class PackageRepository
    {
        public static void CreatePackage(Package package)
        {
            try
            {
                using (TravelExpertContext ctx = new TravelExpertContext())
                {
                    ctx.Packages.Add(package);
                    ctx.SaveChanges();
                }
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"Database update error: {dbEx.Message}");
                throw new Exception("An error occurred while creating a package in the database.", dbEx);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw new Exception("An unexpected error occurred while creating a package.", ex);
            }
        }

        public static Package GetPackageID(int id)
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {
                return ctx.Packages.Find(id);
            }
        }

        public static List<Package> GetPackages()
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {
                //var packages = ctx.Packages.Where(package => package.IsActive == true);
                return ctx.Packages.ToList();
            }
        }

        public static void UpdatePackage(Package package)
        {
            try
            {
                using (TravelExpertContext ctx = new TravelExpertContext())
                {
                    ctx.Packages.Update(package);
                    ctx.SaveChanges();
                }
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"Database update error: {dbEx.Message}");
                throw new Exception("An error occurred while updating the package in the database.", dbEx);
            }
        }

        public static void DeletePackageByID(int id)
        {
            try
            {
                using (TravelExpertContext ctx = new TravelExpertContext())
                {
                    Package package = ctx.Packages.Find(id);
                    //package.IsActive = false;

                    if (package == null)
                    {
                        throw new Exception("Package not found.");
                    }

                    ctx.Packages.Update(package);
                    ctx.SaveChanges();
                }
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"Database update error: {dbEx.Message}");
                throw new Exception("An error occurred while deleting the package from the database.", dbEx);
            }
        }
    }
}
