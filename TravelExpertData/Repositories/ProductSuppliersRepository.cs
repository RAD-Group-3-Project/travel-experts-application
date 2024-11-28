using Microsoft.EntityFrameworkCore;
using TravelExpertData.Data;
using TravelExpertData.Models;

namespace TravelExpertData.Repositories;
public class ProductSuppliersRepository
{
    public record ProductSupplierDTO(int ProductSupplierId, int ProductId, string ProductName, int SupplierId, string SupplierName);

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

    public static List<ProductSupplierDTO> GetProductSuppliersDTO()
    {
        using (TravelExpertContext ctx = new TravelExpertContext())
        {
            return ctx.ProductsSuppliers
                .OrderBy(ps => ps.ProductSupplierId)
                .Join(ctx.Products,
                    ps => ps.ProductId,
                    p => p.ProductId,
                    (ps, p) => new { ps, p })
                .Where(psp => psp.p.IsActive == true)
                .Join(ctx.Suppliers,
                    x => x.ps.SupplierId,
                    s => s.SupplierId,
                    (pss, s) => new
                    {
                        pss.ps.ProductSupplierId,
                        pss.p.ProductId,
                        pss.p.ProdName,
                        s.SupplierId,
                        s.SupName,
                        s.IsActive
                    })
                .Where(psps => psps.IsActive == true)
                .Select(joined => new ProductSupplierDTO(joined.ProductSupplierId, joined.ProductId,
                    joined.ProdName, joined.SupplierId, joined.SupName))

                .ToList(); ;
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

                ctx.ProductsSuppliers.Remove(productSuppliers);
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
