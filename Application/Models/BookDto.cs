using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Summary { get; set; }
        public string CoverUrl { get; set; }
        public List<GenreDto> Genres { get; set; } = new List<GenreDto>();

        // Mapeo
        public static BookDto ToDto(Book book)
        {
            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Pages = book.Pages,
                Summary = book.Summary,
                CoverUrl = book.CoverUrl,
                Genres = book.Genres?.Select(g => new GenreDto
                {
                    Id = g.Id,
                    GenreName = g.GenreName
                }).ToList()
            };
        }

        public static Book ToEntity(BookDto dto)
        {
            return new Book
            {
                Id = dto.Id,
                Title = dto.Title,
                Author = dto.Author,
                Pages = dto.Pages,
                Summary = dto.Summary,
                CoverUrl = dto.CoverUrl,
                Genres = dto.Genres?.Select(g => new Genre
                {
                    Id = g.Id,
                    GenreName = g.GenreName
                }).ToList()
            };
        }
    }
}
