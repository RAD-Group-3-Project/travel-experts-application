using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
// Added Data and models to allow for get / set from Agency class in models
using TravelExpertData.Data;
using TravelExpertData.Models;

namespace TravelExpertData.Repositories
{
    public class AgencyRepository

    {
        // Creates a function to call Create location function
        public static void CreateLocation(Agency agency)
        {   // Starts a try to add the agency object sent via function
            try
            {   // Opens a connection via Travel Expert Context Class
                using (TravelExpertContext conn = new TravelExpertContext())
                {   // Tries the Add 
                    conn.Agencies.Add(agency);
                    // Saves to database 
                    conn.SaveChanges();

                }
            }   
            // Catch Update specific errors 
            catch (DbUpdateException dbex)
            {
                // Logs the error and throws it for specific database errors
                Console.WriteLine($"Database update Error: {dbex.Message}");
                // Tosses the error down the line
                throw new Exception("An error occured when adding a new agency location.");
            } 
            // Catches other errors 
            catch (Exception ex) 
            {   
                // Logs error to console and and then throws it down the line
                Console.WriteLine($"Database Error: {ex.Message}");
                throw new Exception("An unexpected error occured while adding a new agency location")

            }
        }
        // New function to grab agency details using the associated ID
        public static Agency GetAgencyByID(int id)
        {
            try
            {   // opens a new connection 
                using (TravelExpertContext conn = new TravelExpertContext())
                {   
                    // Returns the agencies object via function
                    return conn.Agencies.Find(id);
                }
            }
            catch (Exception dbex) 
            {
                Console.WriteLine($"An error occured looking for id :{id}");
                throw new Exception("An Error Occured looking for Agencies via ID)";
            }
        }











    }
}
