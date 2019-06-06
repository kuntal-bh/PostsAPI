using Microsoft.Extensions.Configuration;
using PostsAPIM.Models;
using PostsAPIM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostsAPIM.Services
{
    public class Services : IServices
    {
        private readonly IRepository _repository;
        private readonly IConfiguration _configuration;

        public Services(IRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        public async Task<List<Agents>> GetAgents()
        {

            string baseUrl = _configuration.GetSection("AgentsAPI:baseUrl").Value;         
            
            var agents = await _repository.GetAgents(baseUrl);

            if (agents != null)
                return agents.ToList();

            throw new Exception(" Agents not found");
        }
    }
}
