﻿using Application.Models;
using Application.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBookService
    {
        IEnumerable<BookDto> GetAllBooks();
        BookDto GetBookbyId(int id);
        BookDto CreateBook(CreateBookRequest book);
        BookDto UpdateBook(BookDto book);
        void DeleteBook(int id);
        IEnumerable<BookDto> SearchByTitle(string titleForSearch);
    }
}
