using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DeviceDataCollectorServer.Models
{
    public partial class ExperimentContext : DbContext
    {
        public ExperimentContext()
        {
        }

        public ExperimentContext(DbContextOptions<ExperimentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccelData> AccelData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=zhengyl-db.database.windows.net;Database=zhengyl-db;User ID=liuzhengyang183;Password=COOL_man183;Trusted_Connection=True;Trusted_Connection=False;Encrypt=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AccelData>(entity =>
            {
                entity.HasKey(e => e.Time);

                entity.ToTable("accelData");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.Acceleration)
                    .HasColumnName("acceleration")
                    .HasColumnType("decimal(18, 8)");
            });
        }
    }
}
