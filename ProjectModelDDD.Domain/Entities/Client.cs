using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProjectDDD.Domain.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateRegistration { get; set; }
        public bool Active { get; set; }
        public virtual IEnumerable<Product> Products  { get; set; }
        public bool SpecialClient(Client client)
        {
            return client.Active && DateTime.Now.Year - client.DateRegistration.Year >= 5; 
        }
    }
}
