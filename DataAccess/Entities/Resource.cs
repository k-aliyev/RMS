using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class Resource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public decimal Score { get; set; } //floatm (don't use it) or decimal can be used
        public DateTime Date { get; set; }
    }
}
