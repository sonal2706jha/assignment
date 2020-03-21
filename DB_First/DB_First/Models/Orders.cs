using System;
using System.Collections.Generic;

namespace _dFirst.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int? OrderQuantity { get; set; }
        public string OrderAddress { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
    }
}
