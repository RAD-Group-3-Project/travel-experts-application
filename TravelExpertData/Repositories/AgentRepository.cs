// Agent Repository - C Ferguson

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertData.Data;
using TravelExpertData.Models;

namespace TravelExpertData.Repositories;
public class AgentRepository
{   
    // Our create agent Function 
    public static void CreateAgent(Agent agent)
    {   // Tries our add function
        try
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {   
                // Actual Add Function
                ctx.Agents.Add(agent);
                // Saves db changes 
                ctx.SaveChanges();
            }
        }   
        // Catches any of our errors 
        catch (DbUpdateException dbEx)
        {   
            // Log error
            Console.WriteLine($"Database update error: {dbEx.Message}");
            // Throws error down the line 
            throw new Exception("An error occurred while creating an agent in the database.", dbEx);
        }
        // Catches any errors on the way
        catch (Exception ex)
        {   
            // Logs and throws them
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw new Exception("An unexpected error occurred while creating a agent.", ex);
        }
    }
    // Get agent by id function
    public static Agent GetAgentById(int id)
    {   // tries to get it 
        try
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {
                return ctx.Agents.Find(id);
            }
        }   
        // Error thrown if not found 
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");

            throw new Exception("Error finding by ID");
        }
    }
    // Gets all of our agents via a list 
    public static List<Agent> GetAgents()
    {   
        // Grabs a list of all of our agents 
        using (TravelExpertContext ctx = new TravelExpertContext())
        {   
            // linq code to find active agents only
            var agents = ctx.Agents.Where(agent => agent.is_active == true);
            // adds found user to list 
            return agents.ToList();
        }
    }
    // Update function
    public static void UpdateAgent(Agent agent)
    {   
        // Tries update
        try
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {
                ctx.Agents.Update(agent);
                ctx.SaveChanges();
            }
        }
        // catches any exceptions 
        catch (DbUpdateException dbEx)
        {   
            // logs and throws 
            Console.WriteLine($"Database update error: {dbEx.Message}");
            throw new Exception("An error occurred while updating the agent in the database.", dbEx);
        }
        
    }
    // "Delete" function 
    public static void DeleteAgentById(int id)
    {   
        // Tries to get agent 
        try
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {   
                // Finds Id and changes is_active to false 
                Agent agent = ctx.Agents.Find(id);
                agent.is_active = false;
                // If no agent is found 
                if (agent == null)
                {   
                    // Throws an error when looking 
                    throw new Exception("Agent not found.");
                }
                // if not, updates or "Deletes" the agent
                ctx.Agents.Update(agent);   
                // Saves db
                ctx.SaveChanges();
            }
        } 
        // Catch error if all fails 
        catch (DbUpdateException dbEx)
        {   
            // Log and throw 
            Console.WriteLine($"Database update error: {dbEx.Message}");
            throw new Exception("An error occurred while deleting the agent from the database.", dbEx);
        }
    }
}
// CF