using EMS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Menu>()
        //        .HasOne<AppUser>(m =>m.AppUser )
        //        .WithMany(a => a.Menus)
        //        .HasForeignKey(m => m.AppUserId)
        //        .OnDelete(DeleteBehavior.Cascade);
        //}


        public DbSet<AppUser> Users{ get; set; }
        public DbSet<Menu> menu { get; set; }
        public DbSet<Website> website { get; set; }
        
    }
}
