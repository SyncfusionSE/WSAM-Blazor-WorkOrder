using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WorkOrderApp.Shared.Models
{
    public partial class OrderDataContext : DbContext
    {
        public OrderDataContext()
        {
        }

        public OrderDataContext(DbContextOptions<OrderDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WorkOrder> WorkOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + "\\App_Data\\NORTHWND.mdf;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__WorkOrde__C3905BAFEBEF45D7");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(10);
            });
        }
    }
}
