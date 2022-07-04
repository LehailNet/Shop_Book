using System;
using System.Linq;

namespace StoreBook.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new Book[]
        {
            new Book(1, "First book"),
            new Book(2, "Second book"),
            new Book(3, "Thread book")
        };
        
        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(books => book.Title.Contains(titlePart))
                .ToArray();
        }
    }
}
