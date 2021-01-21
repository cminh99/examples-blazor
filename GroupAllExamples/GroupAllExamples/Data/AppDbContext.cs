using GroupAllExamples.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAllExamples.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<SlackMessage> SlackMessages { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<SlackMessage>(x => 
            {
                x.HasKey(s => s.Id);
                x.Property(s => s.Message).IsRequired();
                x.Property(s => s.PostedBy).IsRequired();
                x.Property(s => s.PostedOn).IsRequired();
                //x.Property(s => s.Like).IsRequired();
            });

            modelBuilder.Entity<CartItem>(x =>
            {
                x.HasKey(c => c.Id);
                x.Property(c => c.Name).IsRequired();
                x.Property(c => c.Quantity).IsRequired();
                x.Property(c => c.Price).IsRequired().HasColumnType("decimal(5,2)");
                x.Property(c => c.Image).IsRequired();
            });
        }
    }
}
