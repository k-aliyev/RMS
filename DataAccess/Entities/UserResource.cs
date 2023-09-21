#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class UserResource
    {
        [Key]  // Attribute for primary key
        [Column(Order = 0)] // Order of the primary key
        public int UserId {  get; set; } // db relationship
        public User User { get; set; } // class relationship

        [Key]
        [Column(Order = 1)]
        public int ResourceId { get; set; }
        public Resource Resource  { get; set; }

    }
}
