using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarWorkshop.Infrastructure.Persistence
{
    public class CarWorkshopDbContext : DbContext
    {
        public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options) : base(options)
        {

        }
        public DbSet<Domain.Entities.CarWorkshop> CarWorkshops { get; set; }     //wlasciwosc reprezentujaca tabele  //podajemy pelna nazwe namespace'a encji, gdyz nazwa pokrywa sie z poczatkiem namespace w tym pliku , omijamy tylko wspolny poczatek

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)           //polaczenie z baza danych za pomoca connection stringa
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarWorkshopDb;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)          //definiujemy, ze wlasciwosc "ContactDetails" nie jest zadna dodatkowa tabela
        {
            modelBuilder.Entity<Domain.Entities.CarWorkshop>().OwnsOne(c => c.ContactDetails);
        }
    }
}
