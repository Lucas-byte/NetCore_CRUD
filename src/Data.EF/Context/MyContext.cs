using Data.EF.Mappings;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EF.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<UserEF> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMapEF());

            modelBuilder.Entity<UserEF>().HasData(
                new UserEF()
                {
                    Id = 1,
                    Name = "Administrador",
                    Email = "administrador@email.com.br",
                    CreationDate = DateTime.Now,
                    BrithDate = DateTime.Now,
                    Password = "admin@123"
                }
                );

            modelBuilder.Entity<UserEF>().HasQueryFilter(u => !u.DeletionDate.HasValue);
        }
    }
}
