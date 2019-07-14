﻿using System;
using System.Collections.Generic;

namespace Demo.EntityFramework.MySql.Models
{
    public partial class OrdersStatus
    {
        public OrdersStatus()
        {
            Orders = new HashSet<Orders>();
        }

        public sbyte Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
