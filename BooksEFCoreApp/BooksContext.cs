using Microsoft.EntityFrameworkCore;

namespace BooksEFCoreApp
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=books.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, Name = "Author A" },
                new Author { AuthorId = 2, Name = "Author B" },
                new Author { AuthorId = 3, Name = "Author C" });

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, AuthorId = 1, Name = "Book 1" },
                new Book { BookId = 2, AuthorId = 1, Name = "Book 2" },
                new Book { BookId = 3, AuthorId = 1, Name = "Book 3" },
                new Book { BookId = 4, AuthorId = 1, Name = "Book 4" },
                new Book { BookId = 5, AuthorId = 2, Name = "Book 5" },
                new Book { BookId = 6, AuthorId = 2, Name = "Book 6" },
                new Book { BookId = 7, AuthorId = 2, Name = "Book 7" },
                new Book { BookId = 8, AuthorId = 2, Name = "Book 8" },
                new Book { BookId = 9, AuthorId = 2, Name = "Book 9" },
                new Book { BookId = 10, AuthorId = 3, Name = "Book 10" },
                new Book { BookId = 11, AuthorId = 3, Name = "Book 11" },
                new Book { BookId = 12, AuthorId = 3, Name = "Book 12" },
                new Book { BookId = 13, AuthorId = 3, Name = "Book 13" },
                new Book { BookId = 14, AuthorId = 3, Name = "Book 14" },
                new Book { BookId = 15, AuthorId = 3, Name = "Book 15" },
                new Book { BookId = 16, AuthorId = 3, Name = "Book 16" },
                new Book { BookId = 17, AuthorId = 3, Name = "Book 17" },
                new Book { BookId = 18, AuthorId = 3, Name = "Book 18" },
                new Book { BookId = 19, AuthorId = 3, Name = "Book 19" },
                new Book { BookId = 20, AuthorId = 3, Name = "Book 20" });
        }
    }
}