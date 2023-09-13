using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Models
{
    public class LibraryContext : DbContext
    {

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }
        public LibraryContext() {  }

        // Kitapları temsil eden DbSet
        public DbSet<Books> Book { get; set; }
    }
}
