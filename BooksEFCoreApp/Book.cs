namespace BooksEFCoreApp
{
    public class Book
    {
        public int BookId { get; set; }

        public string? Name { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; } = null!;
    }
}