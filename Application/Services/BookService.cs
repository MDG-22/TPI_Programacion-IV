using Application.Interfaces;
using Application.Models;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService (IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;

        }


        // hay que transformar los datos
        // ej: var newBook = new Book(dto.datos)
        public IEnumerable<BookDto> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public BookDto? GetbyId(int id)
        {
            return _bookRepository.GetbyId(id);
        }

        public BookDto Add(BookDto book)
        {
            _bookRepository.Add(book);
        }

        public BookDto? Update(BookDto book)
        {

        }

        public void Delete(BookDto book)
        {

        }

        // busqueda por titulo
        public IEnumerable<BookDto> SearchByTitle(string titleForSearch)
        {

        }

    }
}
