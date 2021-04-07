using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiTapLonWeb.Models
{
    public partial class WaxStoreDB : DbContext
    {
        public WaxStoreDB()
            : base("name=WaxStoreDB1")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Order_Detail> Order_Detail { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.category_id);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => e.company_id);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.customer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Order_Detail)
                .WithOptional(e => e.Order)
                .HasForeignKey(e => e.order_id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Order_Detail)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.product_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.user_id);
        }
    }
}
