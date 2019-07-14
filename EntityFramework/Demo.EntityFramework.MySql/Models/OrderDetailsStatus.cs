using System;
using System.Collections.Generic;

namespace Demo.EntityFramework.MySql.Models
{
    public partial class OrderDetailsStatus
    {
        public OrderDetailsStatus()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
