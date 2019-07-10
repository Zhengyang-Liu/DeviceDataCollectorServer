using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceDataCollectorServer.Models;
using System;

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

            if (context.AccelData.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                context.AccelData.Add(new AccelData { Time = DateTime.Now, Acceleration = 0.04M });
                context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccelData>>> GetExperimentItems()
        {
            return await this.context.AccelData.ToListAsync();
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<AccelData>> GetExperimentItem(string name)
        {
            var experimentItem = await context.AccelData.FindAsync(name);

            if (experimentItem == null)
            {
                return NotFound();
            }

            return experimentItem;
        }
    }
}