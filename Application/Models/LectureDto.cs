using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class LectureDto
    {
        public int Id { get; set; }
        public int? Rating { get; set; }
        public int? PageCount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public LectureStatus Status { get; set; }

        // Libro
        public BookDto? Book { get; set; }

        // info util del libro (para no llamar al libro entero en cada elemento)
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookCover { get; set; }
    }
}
