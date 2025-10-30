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
        BookDto? GetbyId(int id);
        BookDto Add(BookDto book);
        BookDto? Update(BookDto book);
        void Delete(BookDto book);

        // busqueda por titulo
        IEnumerable<BookDto> SearchByTitle(string titleForSearch);
    }
}
