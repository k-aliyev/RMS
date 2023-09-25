using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Resource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public decimal Score { get; set; } // float (don't use it) or double can be used
        public DateTime? Date { get; set; } // you can use Nullable<DateTime> istead
        public List<UserResource> UserResource { get; set; }
    }
}
