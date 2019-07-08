using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DeviceDataCollectorServer.Models
{
    public class ExperimentItem
    {
        [Key]
        public string Time { get; set; }
        public decimal Acceleration { get; set; }
    }
}
