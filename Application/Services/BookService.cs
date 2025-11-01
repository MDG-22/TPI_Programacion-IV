using Application.Interfaces;
using Application.Models;
using Application.Models.Requests;
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

        public IEnumerable<BookDto> GetAllBooks()
        {
            var books = _bookRepository.GetAll();

            return books.Select(BookDto.ToDto);
        }

        public BookDto GetBookbyId(int id)
        {
            var book = _bookRepository.GetbyId(id);

            return BookDto.ToDto(book);
        }

        public BookDto CreateBook(CreateBookRequest book)
        {
            var newBook = new Book
            {
                Title = book.Title,
                Author = book.Author,
                Pages = book.Pages,
                Summary = book.Summary,
                CoverUrl = book.CoverUrl
            };

            return BookDto.ToDto(newBook);
        }

        public BookDto UpdateBook(BookDto book)
        {
            var updatedBook = _bookRepository.GetbyId(book.Id);

            updatedBook.Title = book.Title;
            updatedBook.Author = book.Author;
            updatedBook.Pages = book.Pages;
            updatedBook.Summary = book.Summary;
            updatedBook.CoverUrl = book.CoverUrl;

            return BookDto.ToDto(updatedBook);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.Delete(id);
        }

        public IEnumerable<BookDto> SearchByTitle(string titleForSearch)
        {
            var books = _bookRepository.SearchByTitle(titleForSearch);

            return books.Select(BookDto.ToDto);
        }
    }
}
