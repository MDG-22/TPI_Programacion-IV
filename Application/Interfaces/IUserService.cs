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
        UserDto? GetById(int id);
        void Add(UserDto user);
        void Update(UserDto user);
        void Delete(UserDto user);
    }

}
