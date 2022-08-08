using Microsoft.EntityFrameworkCore;

namespace ImportLibrary
{
    public class AffinitySoftwarePracticalContext : DbContext
    {
        public AffinitySoftwarePracticalContext (DbContextOptions<AffinitySoftwarePracticalContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
