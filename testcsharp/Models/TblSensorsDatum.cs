using System;
using System.Collections.Generic;

#nullable disable

namespace testcsharp.models
{
    public partial class TblSensorsDatum
    {
        public int SensorsDataId { get; set; }
        public string SensorsTemperatureData { get; set; }
        public DateTime SensorsDataDate { get; set; }
        public TimeSpan SensorsDataTime { get; set; }
    }
}
