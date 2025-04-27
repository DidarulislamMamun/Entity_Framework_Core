using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCoreApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;
    }
}
