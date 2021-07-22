using System;
using System.Collections.Generic;

#nullable disable

namespace testcsharp.models
{
    public partial class Product
    {
        public string Id { get; set; }
        public string Bame { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
