using System;
using System.Collections.Generic;

namespace AppPostgreSQL
{
    public partial class Order
    {
        public int Id { get; set; }
        public int Productid { get; set; }
        public int Customerid { get; set; }
        public DateOnly Createdat { get; set; }
        public int? Productcount { get; set; }
        public decimal Price { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
