using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }

        // relacion M:N con libros, lista inicializada vacia => new()
        public List<Book> Books { get; set; } = new();
    }
}
