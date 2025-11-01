﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Summary { get; set; }
        public string? CoverUrl { get; set; }

        // relacion M:N con genre inicializada como lista vacia => new()
        //public List<Genre> Genres { get; set; } = new List<Genre>();

        // relacion con lecturas inicializada como lista vacia => new()
        //public List<Lecture> Lectures { get; set; } = new List<Lecture>();
    }
}
