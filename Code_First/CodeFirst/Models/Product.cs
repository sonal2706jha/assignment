using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Codefirst.Models
{
    public class Product
    {
        
        public Product()
        {
            Order = new HashSet<Orders>();
        }

        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
       

        public virtual ICollection<Orders> Order { get; set; }
    
    }

}

