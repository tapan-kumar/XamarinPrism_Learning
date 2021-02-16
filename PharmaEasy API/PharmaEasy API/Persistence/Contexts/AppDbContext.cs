using Microsoft.EntityFrameworkCore;

using PharmaEasy_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Persistence.Contexts
{ 

    //a class EF Core uses to map your models to database tables. 
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)      
        {
            //passing the database configuration to the base class through dependency injection. 
        }
        public DbSet<Products> ProductsSet { get; set; }  //collections of unique objects that map models to database tables.


        protected override void OnModelCreating(ModelBuilder modelBuilder)  //map the models’ properties to the respective table columns
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Products>().ToTable("Products_Table");
            modelBuilder.Entity<Products>().HasKey(p => p.Id);
            modelBuilder.Entity<Products>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Products>().Property(p=>p.Name).IsRequired().HasMaxLength(30);
            

            modelBuilder.Entity<Products>().HasData
                (
                new Products { Id=100,Name= "Volini gel", Price=51, Quantity=1, ImageUrl = "https://bit.ly/2MRISz1" },
                new Products { Id=101, Name = "Revital H", ImageUrl = "https://bit.ly/2NeOuTy", Price=98,Quantity=1}
                new Products { Id=102, Name = "Set Wet Gel", ImageUrl = "https://bit.ly/3cTQ5Jl", Price=98,Quantity=1}
                new Products { Id=103, Name = "Cipla HandRub", ImageUrl = "https://bit.ly/3a3t3Oi", Price=98,Quantity=1}
                );
        }
    }
}
