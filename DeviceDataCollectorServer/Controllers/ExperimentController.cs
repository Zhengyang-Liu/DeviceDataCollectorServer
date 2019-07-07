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

        public ExperimentController(ExperimentContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExperimentItem>>> GetExperimentItems()
        {
            return await this.context.ExperimentItems.ToListAsync();
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<ExperimentItem>> GetExperimentItem(string name)
        {
            var experimentItem = await context.ExperimentItems.FindAsync(name);

            if (experimentItem == null)
            {
                return NotFound();
            }

            return experimentItem;
        }
    }
}