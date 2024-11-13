using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertData.Data;
using TravelExpertData.Models;

namespace TravelExpertData.Repositories;
public class ProductSuppliersRepository
{
    public static void CreateProductSupplier(ProductsSupplier productSuppliers)
    {
        try
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {
                ctx.ProductsSuppliers.Add(productSuppliers);
                ctx.SaveChanges();
            }
        }
        catch (DbUpdateException dbEx)
        {
            Console.WriteLine($"Database update error: {dbEx.Message}");
            throw new Exception("An error occurred while creating a product supplier in the database.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("An unexpected error occurred while creating a product supplier.", ex);
        }
    }

    public static ProductsSupplier GetProductSupplierById(int id)
    {
        using (TravelExpertContext ctx = new TravelExpertContext())
        {
            return ctx.ProductsSuppliers.Find(id);
        }
    }

    public static List<ProductsSupplier> GetProductSuppliers()
    {
        using (TravelExpertContext ctx = new TravelExpertContext())
        {
            return ctx.ProductsSuppliers.ToList();
        }
    }

    public static void UpdateProductSupplier(ProductsSupplier productSuppliers)
    {
        try
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {
                ctx.ProductsSuppliers.Update(productSuppliers);
                ctx.SaveChanges();
            }
        }
        catch (DbUpdateException dbEx)
        {
            Console.WriteLine($"Database update error: {dbEx.Message}");
            throw new Exception("An error occurred while updating the product supplier in the database.", dbEx);
        }

    }

    public static void DeleteProductSupplierById(int id)
    {
        try
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {
                ProductsSupplier productSuppliers = ctx.ProductsSuppliers.Find(id);
                if (productSuppliers == null)
                {
                    throw new Exception("product supplier not found.");
                }

                ctx.ProductsSuppliers.Update(productSuppliers);
                ctx.SaveChanges();
            }
        }
        catch (DbUpdateException dbEx)
        {
            Console.WriteLine($"Database update error: {dbEx.Message}");
            throw new Exception("An error occurred while deleting the product supplier from the database.", dbEx);
        }
    }
}
