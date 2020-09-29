using DenizKabacelik.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using DenizKabacelik.JwtProje.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Context
{
   public  class DenizJwtContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer("Server=DESKTOP-KDK0AO7;Database=JwtDb; Integrated Security=true;");
            base.OnConfiguring(optionsBuilder); 
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new AppRoleMap());
            modelBuilder.ApplyConfiguration(new AppUserRoleMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
           
        }


        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Product> Products { get; set; }


    }
    


}
