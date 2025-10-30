﻿using Domain.Entities;
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
        Book? GetbyId(int id);
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);

        // by title
        IEnumerable<Book> SearchByTitle(string titleForSearch);
    }
}
