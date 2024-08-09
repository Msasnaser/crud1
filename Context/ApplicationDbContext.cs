using crud.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Context
{
    internal class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Crud;Trusted_Connection=True;TrustServerCertificate=True");

        }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }


    }
}
