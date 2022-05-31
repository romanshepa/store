﻿using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private  readonly Book[] _books = new[]
        {
            new Book(1, "ISBN 12312-31231", "D.Knut","Art of Programming"),
            new Book(2,  "ISBN 12451-30231", "M. Fowler", "Refactoring"),
            new Book(3,  "ISBN 77312-31251", "B. Kernighan", "C# Programming Language")
        };

        public Book[] GetAllByTitleOrAuthor(string titlePart)
        {
            return _books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }
    }
}