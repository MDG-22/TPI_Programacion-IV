using Application.Interfaces;
using Application.Models;
using Domain.Entities;
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

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<BookDto> GetAll()
        {
            var books = _bookRepository.GetAll();

            return books.Select(BookDto.Create);
        }

        public BookDto? GetBookbyId(int id)
        {
            var book = _bookRepository.GetBookById(id);

            return BookDto.Create(book);
        }

        public BookDto AddBook(BookDto dto)
        {
            var newBook = new Book
            {
                Title = dto.Title,
                Author = dto.Author,
                Pages = dto.Pages,
                Summary = dto.Summary,
                CoverUrl = dto.CoverUrl
            };

            _bookRepository.AddBook(newBook);

            return BookDto.Create(newBook);
        }

        public BookDto? UpdateBook(BookDto book)
        {

        }

        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }
    }
}
