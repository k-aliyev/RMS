using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Role
    {

        public int Id { get; set; }
        public string Name { get; set; }
        
        // calss has-a relationship
        public List<User> Users { get; set; } // List implementats both of them 

        //public ICollection<User> Users { get; set; }

        //public IEnumerable<User> Users { get; set; }
    }
}
