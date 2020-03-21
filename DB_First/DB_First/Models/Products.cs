﻿using System;
using System.Collections.Generic;

namespace _dFirst.Models
{
    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
