using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    {            
    }
        // Defining dbsets, tables in the DB
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
