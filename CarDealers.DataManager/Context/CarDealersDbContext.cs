using CarDealers.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealers.DataManager.Context
{
    public class CarDealersDbContext : DbContext
    {
        //public CarDealersDbContext(DbContextOptions<CarDealersDbContext> options) :base(options)
        //{
        //    Database.EnsureCreated();
        //}

        public DbSet<Advertistment> Advertistments { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string sqlConnectionString = "Server=DESKTOP-AN6SANN; Database=CarDealersDb; Trusted_Connection=True";
        //    string sqlConnectionString = "Server=DESKTOP-7UFK8SA\\SQL2016; Database=CarDealersDb;Integrated Security=SSPI; User ID = sa ;Password=welcome@123;
            builder.UseSqlServer(sqlConnectionString);
            base.OnConfiguring(builder);
        }
    }
}
    