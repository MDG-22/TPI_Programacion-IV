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
        GenreDto? GetGenreById(int id);
        void AddGenre(GenreDto genre);
        void UpdateGenre(GenreDto genre);
        void DeleteGenre(GenreDto genre);
    }
}
