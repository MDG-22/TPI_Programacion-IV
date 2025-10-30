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
        Lecture? GetLectureById(int id);
        void AddLecture(Lecture lecture);
        void UpdateLecture(Lecture lecture);
        void DeleteLecture(Lecture lecture);

        // by status
        IEnumerable<Lecture> GetByStatus(LectureStatus status);
    }
}
