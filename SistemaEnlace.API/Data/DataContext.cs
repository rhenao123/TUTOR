using Microsoft.EntityFrameworkCore;
using SistemaEnlace.Shared.Entities;
using System.Diagnostics.Eventing.Reader;


namespace SistemaEnlace.API.Data
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {



        }

        public DbSet<Actividad> actividads { get; set; }
        public DbSet<Conversacion> conversacions { get; set; }
        public DbSet<Fundacion> fundacions { get; set; }

        public DbSet<JovenVulnerable> jovenVulnerables { get; set; }

        public DbSet<Persona> personas { get; set; }

        public DbSet<Realiza> realizas { get; set; }

        public DbSet<Supervisa> supervisas { get; set; }

        public DbSet<Supervisor> supervisors { get; set; }

        public DbSet<Tutor> tutors { get; set; }







        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}


