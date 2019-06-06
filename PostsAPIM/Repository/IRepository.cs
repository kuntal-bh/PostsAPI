using PostsAPIM.Models;
using System.Collections.Generic;

namespace PostsAPIM.Repository
{
    public interface IRepository
    {
        System.Threading.Tasks.Task<IEnumerable<Agents>> GetAgents(string url);
    }
}