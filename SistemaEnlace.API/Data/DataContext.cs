using Microsoft.EntityFrameworkCore;
using SistemaEnlace.Shared.Entities;

namespace SistemaEnlace.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Conversacion> conversacions { get; set; }
        public DbSet<Fundacion> fundacions { get; set; }
        public DbSet<JovenVulnerable> JovenesVulnerables { get; set; }
        public DbSet<Formulario> formularios { get; set; }
        public DbSet<Supervisor> supervisors { get; set; }
        public DbSet<Tutor> Tutores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Conversacion>().HasIndex(c => c.Id).IsUnique();

        }
    }
}
