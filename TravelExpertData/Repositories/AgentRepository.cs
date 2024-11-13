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
    public static void CreateAgent(Agent agent)
    {
        try
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {
                ctx.Agents.Add(agent);
                ctx.SaveChanges();
            }
        }
        catch (DbUpdateException dbEx)
        {
            // Log error
            Console.WriteLine($"Database update error: {dbEx.Message}");
            throw new Exception("An error occurred while creating an agent in the database.", dbEx);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw new Exception("An unexpected error occurred while creating a agent.", ex);
        }
    }

    public static Agent GetAgentById(int id)
    {
        using (TravelExpertContext ctx = new TravelExpertContext())
        {
            return ctx.Agents.Find(id);
        }
    }

    public static List<Agent> GetAgents()
    {
        using (TravelExpertContext ctx = new TravelExpertContext())
        {
            var agents = ctx.Agents.Where(agent => agent.IsActive == true);
            return agents.ToList();
        }
    }

    public static void UpdateAgent(Agent agent)
    {
        try
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {
                ctx.Agents.Update(agent);
                ctx.SaveChanges();
            }
        }
        catch (DbUpdateException dbEx)
        {
            Console.WriteLine($"Database update error: {dbEx.Message}");
            throw new Exception("An error occurred while updating the agent in the database.", dbEx);
        }
        
    }

    public static void DeleteAgentById(int id)
    {
        try
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {   
                Agent agent = ctx.Agents.Find(id);
                agent.IsActive = false;
                
                if (agent == null)
                {
                    throw new Exception("Agent not found.");
                }

                ctx.Agents.Update(agent);
                ctx.SaveChanges();
            }
        }
        catch (DbUpdateException dbEx)
        {
            Console.WriteLine($"Database update error: {dbEx.Message}");
            throw new Exception("An error occurred while deleting the agent from the database.", dbEx);
        }
    }
}
// TEST 