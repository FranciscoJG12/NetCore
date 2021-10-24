using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Amigo> Amigos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amigo>().HasData(new Amigo { Id=10000,Nombre="Wirri Girl",Email="wirri@gmail.com",Ciudad="WirriLandia"},
            new Amigo { Id = 2000, Nombre = "Antoine", Email = "antoine@gmail.com", Ciudad = "AntoineLandia" },
            new Amigo { Id = 3000, Nombre = "Francisco", Email = "francisco@gmail.com", Ciudad = "FrancoLandia" },
            new Amigo { Id = 4000, Nombre = "Pierre", Email = "pierre@gmail.com", Ciudad = "PierreLandia" }

            );

        }
    }
}
