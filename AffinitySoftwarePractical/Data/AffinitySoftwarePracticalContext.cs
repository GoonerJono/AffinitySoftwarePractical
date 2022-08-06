using Microsoft.EntityFrameworkCore;
using AffinitySoftwarePractical.Models;

namespace AffinitySoftwarePractical.Data
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
