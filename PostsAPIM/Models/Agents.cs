using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostsAPIM.Models
{
    public class Agents
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public Address address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string WebSite { get; set; }
        public Company company { get; set; }
    }
}
