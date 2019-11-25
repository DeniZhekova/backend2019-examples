using Lesson09.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson09.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API mappings (if needed)
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Author>().ToTable("Author");
            
            //Configure Book Column
            modelBuilder.Entity<Book>()
                        .Property(b => b.PublishedOn)
                        .HasColumnType("datetime2");
        }
    }
}
