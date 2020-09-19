using System;
using System.Collections.Generic;

namespace Asp_Net_Core_EF_CRUD.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
