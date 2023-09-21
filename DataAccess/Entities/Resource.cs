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
        public double Score { get; set; }
        public DateTime Date { get; set; }
    }
}
