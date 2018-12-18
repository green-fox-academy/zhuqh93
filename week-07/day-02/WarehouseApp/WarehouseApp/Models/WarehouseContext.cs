using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WarehouseApp.Models
{
    public partial class WarehouseContext : DbContext
    {
        public WarehouseContext()
        {
        }

        public WarehouseContext(DbContextOptions<WarehouseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BasketItem> BasketItem { get; set; }
        public virtual DbSet<Baskets> Baskets { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<OrderHistory> OrderHistory { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Warehouse;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasketItem>(entity =>
            {
                entity.HasOne(d => d.Basket)
                    .WithMany(p => p.BasketItem)
                    .HasForeignKey(d => d.BasketId);

                entity.HasOne(d => d.Good)
                    .WithMany(p => p.BasketItem)
                    .HasForeignKey(d => d.GoodId);
            });

            modelBuilder.Entity<Baskets>(entity =>
            {
                entity.HasKey(e => e.BasketId);

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            });

            modelBuilder.Entity<Goods>(entity =>
            {
                entity.HasKey(e => e.GoodId);
            });

            modelBuilder.Entity<OrderHistory>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderedAt).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasOne(d => d.Good)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.GoodId);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.OrderId);
            });
        }
    }
}
