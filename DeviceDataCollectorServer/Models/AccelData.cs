using System;
using System.Collections.Generic;

namespace DeviceDataCollectorServer.Models
{
    public partial class AccelData
    {
        public DateTime Time { get; set; }
        public decimal Acceleration { get; set; }
    }
}
