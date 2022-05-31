using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private  readonly Book[] _books = new[]
        {
            new Book(1, ""),
            new Book(2, ""),
            new Book(3, "")
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            return _books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }
    }
}