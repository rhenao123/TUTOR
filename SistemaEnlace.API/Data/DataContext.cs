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


            modelBuilder.Entity<JovenVulnerable>()
                .Property(l => l.id)
                .ValueGeneratedNever();
           
            modelBuilder.Entity<Supervisor>()
                .Property(a => a.id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Tutor>()
              .Property(m => m.id)
              .ValueGeneratedNever();

            modelBuilder.Entity<Fundacion>()
                .Property(x => x.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Conversacion>().HasIndex(c=>c.Id).IsUnique();
            
            modelBuilder.Entity<Fundacion>()
                .HasMany(f => f.JovenesVulnerables)
                .WithOne(j => j.Fundaciones)
                .HasForeignKey(j => j.FundacionId)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
