using System;
using System.Collections.Generic;

namespace Demo.EntityFramework.MySql.Models
{
    public partial class OrdersTaxStatus
    {
        public OrdersTaxStatus()
        {
            Orders = new HashSet<Orders>();
        }

        public sbyte Id { get; set; }
        public string TaxStatusName { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
