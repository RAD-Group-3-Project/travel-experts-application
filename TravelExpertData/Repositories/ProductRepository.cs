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
    public class ProductRepository
    {
        public static void CreateProduct(Product product)
        {
            try
            {

            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"Database update error: {dbEx.Message}");
                throw new Exception("An error occurred when adding a new product to the database.", dbEx);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
                throw new Exception("An unexpected error occurred while adding a new product.", ex);
            }
        }

        public static Product GetProductByID(int id)
        {
            try
            {
                using (TravelExpertContext ctx = new TravelExpertContext())
                {
                    return ctx.Products.Find(id);
                }
            }
            catch (DbUpdateException dbEx) 
            {
                Console.WriteLine($"An error occurred looking for product ID: {id}", dbEx);
                throw new Exception("An error occurred looking for product via ID.");
            }
        }

        public static List<Product> GetProduct()
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {
                return ctx.Products.ToList();
            }
        }

        public static void UpdateProduct(Product product)
        {
            try
            {
                using (TravelExpertContext ctx = new TravelExpertContext())
                {
                    ctx.Products.Update(product);
                    ctx.SaveChanges();
                }
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"Database error while trying to update product: {product.ProductId}", dbEx);
                throw new Exception("There was an error while updating the products table.");
            }
        }

        public static void DeleteProductByID(int id)
        {
            try
            {
                using (TravelExpertContext ctx = new TravelExpertContext())
                {
                    Product product = ctx.Products.Find(id);

                    if (product == null)
                    {
                        throw new Exception($"Unable to find the product with the ID of {id}");
                    }

                    //product.IsActive = false;
                    ctx.Products.Remove(product);
                    ctx.SaveChanges();
                }
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"There was an error deleting Product {id}.", dbEx);
                throw new Exception("There was an error deleting the requested product.");
            }
        }
    }
}
