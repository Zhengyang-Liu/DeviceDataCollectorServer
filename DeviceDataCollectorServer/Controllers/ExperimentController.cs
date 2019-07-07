using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceDataCollectorServer.Models;

namespace DeviceDataCollectorServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperimentController : ControllerBase
    {
        private readonly ExperimentContext context;
        private decimal accel;

        public ExperimentController(ExperimentContext context)
        {
            this.context = context;
        }
    }
}