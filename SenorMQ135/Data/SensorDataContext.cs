using Microsoft.EntityFrameworkCore;
using SenorMQ135.Models;

namespace SenorMQ135.Data
{
    public class SensorDataContext : DbContext
    {
        public DbSet<SensorData>? SensorData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SensorData>()
                .Property(s => s.Value)
                .HasColumnType("decimal(18, 2)"); // Adicione isso se ainda não estiver lá
        }
    }
}
