using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealers.DataManager.Context
{
    public class CarDealersDbContext : DbContext
    {
        public CarDealersDbContext(DbContextOptions<CarDealersDbContext> options) :base(options)
        {
            Database.EnsureCreated();
        }




        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    string sqlConnectionString = "Server=DESKTOP-7UFK8SA\\SQL2016; Database=CarDealersDb; Trusted_Connection=True";
        //    string sqlConnectionString = "Server=DESKTOP-7UFK8SA\\SQL2016; Database=CarDealersDb;Integrated Security=SSPI; User ID = sa ;Password=welcome@123;
        //    builder.UseSqlServer(sqlConnectionString);
        //    base.OnConfiguring(builder);
        //}
    }
}
    