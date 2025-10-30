using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAll();
        UserDto? GetUserById(int id);
        void AddUser(UserDto user);
        void UpdateUser(UserDto user);
        void DeleteUser(UserDto user);
    }

}
