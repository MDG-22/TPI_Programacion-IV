using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class UserLecturesDto
    {
        // pagina de lecturas personales
        public int Id { get; set; }
        public List<LectureDto> Lectures { get; set; }
    }
}
