using System;
using System.Collections.Generic;

#nullable disable

namespace testcsharp.models
{
    public partial class Chartdatum
    {
        public int ChartDataId { get; set; }
        public DateTime ChartTimeStamp { get; set; }
        public double ChartValue { get; set; }
    }
}
