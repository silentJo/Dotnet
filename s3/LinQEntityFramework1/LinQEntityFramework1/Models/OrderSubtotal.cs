﻿using System;
using System.Collections.Generic;

namespace LinQEntityFramework1.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
