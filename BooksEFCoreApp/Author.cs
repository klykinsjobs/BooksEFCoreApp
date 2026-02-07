using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BooksEFCoreApp
{
    public class Author
    {
        public int AuthorId { get; set; }
        
        public string? Name { get; set; }
        
        public virtual ObservableCollectionListSource<Book> Books { get; } = [];
    }
}