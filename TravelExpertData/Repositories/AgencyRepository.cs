// Agency Repository - C Ferguson 

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
                throw new Exception("An unexpected error occured while adding a new agency location");

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
                Console.WriteLine($"An error occured looking for agency id :{id}");
                throw new Exception("An Error Occured looking for Agencies via ID)");
            }
        }
        // Gets a list of all agencies 
        public static List<Agency> GetAgency()
        {
            using TravelExpertContext conn = new TravelExpertContext();
            {

                var agency = conn.Agencies.Where(agency => agency.is_active == true);
                return agency.ToList();
                
            }
        }

        // Creating our update Agency function passing in object Agency and the data as agency
        public static void UpdateAgency(Agency agency)
        {
            // Starting a try for an update
            try
            {
                // Opens up our connection 
                using (TravelExpertContext conn = new TravelExpertContext())
                {
                    // Tries the add ad saves the database 
                    conn.Agencies.Update(agency);
                    conn.SaveChanges();
                }
            }
            // Catches specific update error 
            catch (DbUpdateException dbex)
            {   // Once again Writes the line and throws exception down the line
                Console.WriteLine($"Database Error while trying to update agency : {agency.AgencyId}");
                throw new Exception("There was an error while updating the agencies table");
            }   

        }
        // Final Crud operation to delete 
        public static void DeleteAgencyByID(int id)     
        {
            // Starts our try
            try
            {   
                // Opening Connection
                using (TravelExpertContext conn = new TravelExpertContext())
                {   
                    // Declares our agency object based on the input ID number 
                    Agency agency = conn.Agencies.Find(id);
                    // If there is no such agency throw an error
                    if (agency == null)
                    {
                        // Bam. Error
                        throw new Exception($"Couldnt find an agency with the ID of {id}");
                    }
                    agency.is_active = false;
                    // Otherwise procedes with the deletion (to be changed to flip valid bit in sql)
                    conn.Agencies.Remove(agency);
                    conn.SaveChanges();
                }
            }
            catch (DbUpdateException dbex) 
            {
                Console.WriteLine($"There was an error deleting Agency {id}");
                throw new Exception("There was an error deleting the requested agent");
            }

        }
    }
}
