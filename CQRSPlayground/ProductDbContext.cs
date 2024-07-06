using CQRSPlayground.Modals;
using Microsoft.EntityFrameworkCore;

namespace CQRSPlayground
{
    public class ProductDbContext(DbContextOptions<ProductDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products {  get; set; }   
    }
}
