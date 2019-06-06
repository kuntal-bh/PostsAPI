using Newtonsoft.Json;
using PostsAPIM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PostsAPIM.Repository
{
    public class Repository : IRepository
    {
        public async Task<IEnumerable<Agents>> GetAgents(string url)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept
               .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var data = await responseMessage.Content.ReadAsStringAsync();

                var agents = JsonConvert.DeserializeObject<Agents[]>(data);

                return agents;
            }

            return null;

        }
    }
}
