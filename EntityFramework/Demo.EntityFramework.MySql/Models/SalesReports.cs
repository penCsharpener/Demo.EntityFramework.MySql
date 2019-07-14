using System;
using System.Collections.Generic;

namespace Demo.EntityFramework.MySql.Models
{
    public partial class SalesReports
    {
        public string GroupBy { get; set; }
        public string Display { get; set; }
        public string Title { get; set; }
        public string FilterRowSource { get; set; }
        public sbyte Default { get; set; }
    }
}
