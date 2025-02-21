using Ecommerce_website.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_website.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            
        { 
           
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Registrartion> registrartions { get; set; }
    }
}
