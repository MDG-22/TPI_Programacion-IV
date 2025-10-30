using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ILectureRepository
    {
        IEnumerable<Lecture> GetAll();
        Lecture? GetById(int id);
        void Add(Lecture lecture);
        void Update(Lecture lecture);
        void Delete(Lecture lecture);

        // by status
        IEnumerable<Lecture> GetByStatus(LectureStatus status);
    }
}
