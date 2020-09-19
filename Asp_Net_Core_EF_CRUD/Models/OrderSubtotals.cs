using System;
using System.Collections.Generic;

namespace Asp_Net_Core_EF_CRUD.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
