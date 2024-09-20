using Microsoft.EntityFrameworkCore;
using SisCalenderVicente.Modelos;


namespace SisCalenderVicente.Data
{
    public class AppDbContext : DbContext
    {
        DbSet<Evento> Eventos {get; set;}
        //ctor
        //public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        //{
            
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=Calender.db");
        }
    }
}
