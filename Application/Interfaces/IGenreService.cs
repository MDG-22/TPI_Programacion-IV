using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGenreService
    {
        IEnumerable<GenreDto> GetAll();
        GenreDto? GetById(int id);
        void Add(GenreDto genre);
        void Update(GenreDto genre);
        void Delete(GenreDto genre);
    }
}
