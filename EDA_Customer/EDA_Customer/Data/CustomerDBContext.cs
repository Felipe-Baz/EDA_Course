using Microsoft.EntityFrameworkCore;

namespace EDA_Customer.Data
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext()
        {
            
        }

        public CustomerDBContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
           
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
