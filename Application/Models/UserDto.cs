using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class UserDto
    {
        // usadas en todo momento por la navBar
        public int Id { get; set; }
        public string Username { get; set; }
        public string AvatarUrl { get; set; }

        // rol para acceso a paginas
        public UserRole Role { get; set; }
    }
}
