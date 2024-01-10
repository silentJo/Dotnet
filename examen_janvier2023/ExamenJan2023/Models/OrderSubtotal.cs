using System;
using System.Collections.Generic;

namespace ExamenJan2023.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
