using System;
using System.Collections.Generic;

namespace AppPostgreSQL
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
