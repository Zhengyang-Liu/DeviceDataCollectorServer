﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DeviceDataCollectorServer.Models
{
    public class ExperimentContext : DbContext
    {
        public ExperimentContext(DbContextOptions<ExperimentContext> options): base(options)
        {
        }

        public DbSet<ExperimentItem> ExperimentItems { get; set; }
    }
}
