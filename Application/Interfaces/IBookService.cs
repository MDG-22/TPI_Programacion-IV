using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBookService
    {
        IEnumerable<BookDto> GetAll();
        BookDto? GetBookbyId(int id);
        BookDto AddBook(BookDto book);
        BookDto? UpdateBook(BookDto book);
        void DeleteBook(BookDto book);

        // busqueda por titulo
        IEnumerable<BookDto> SearchBookByTitle(string titleForSearch);
    }
}
