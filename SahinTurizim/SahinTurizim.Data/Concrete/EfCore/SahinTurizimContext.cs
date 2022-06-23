using System;
using Microsoft.EntityFrameworkCore;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Concrete.EfCore
{
    public class SahinTurizimContext:DbContext
    {
        public DbSet<Bus>  Buses{ get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Expedition> Expeditions { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SahinTurizimDb");
        }
    }
}
