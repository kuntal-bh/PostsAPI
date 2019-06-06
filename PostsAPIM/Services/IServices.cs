using System.Collections.Generic;
using System.Threading.Tasks;
using PostsAPIM.Models;

namespace PostsAPIM.Services
{
    public interface IServices
    {
        Task<List<Agents>> GetAgents();
    }
}