using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Codefirst.Models
{
    public class Customer
    {
        
       
            public Customer()
            {
            Orders = new HashSet<Orders>();
            }

        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAdderess { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

    }
}
