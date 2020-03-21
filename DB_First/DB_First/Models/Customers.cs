using System;
using System.Collections.Generic;

namespace _dFirst.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCity { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
