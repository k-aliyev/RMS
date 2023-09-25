#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public Status Status { get; set; }

        // Has-a relationships (include both, mapper?): 
        // class relationship
        public Role Role {get; set;}
        // database realationship 
        public int RoleId {get; set;}
        public List<UserResource> UserResource { get; set; }
    }
}
