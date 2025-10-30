using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book? GetBookById(int id);
        Book AddBook(Book book);
        Book? UpdateBook(Book book);
        void DeleteBook(int id);

        // by title
        IEnumerable<Book> SearchByTitle(string titleForSearch);
    }
}
