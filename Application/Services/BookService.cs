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

            return books.Select(BookDto.ToDto);
        }

        public BookDto? GetBookbyId(int id)
        {
            var book = _bookRepository.GetBookById(id);

            return BookDto.ToDto(book);
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

            return BookDto.ToDto(newBook);
        }

        public BookDto? UpdateBook(BookDto update)
        {
            var book = _bookRepository.GetBookById(update.Id);

            book.Title = update.Title;
            book.Author = update.Author;
            book.Pages = update.Pages;
            book.Summary = update.Summary;
            book.Genres = update.Genres.Select(g => new Genre
            {
                Id = g.Id,
                GenreName = g.GenreName
            }).ToList();

            _bookRepository.UpdateBook(book);

            return BookDto.ToDto(book);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }

        public IEnumerable<BookDto> SearchByTitle(string titleForSearch)
        {
            var books = _bookRepository.SearchByTitle(titleForSearch);

            return books.Select(BookDto.ToDto);
        }
    }
}
