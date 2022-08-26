using Microsoft.EntityFrameworkCore;

namespace WorkOrderApp.Shared.Models
{
    public class OrderDataContext : DbContext
    {
        public OrderDataContext()
        { }
        
        public OrderDataContext(DbContextOptions<OrderDataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=database.db");

        public DbSet<WorkOrder> WorkOrder { get; set; }
    }
}
