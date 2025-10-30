using Application.Models;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ILectureService
    {
        IEnumerable<LectureDto> GetAll();
        LectureDto? GetLectureById(int id);
        void AddLecture(LectureDto lecture);
        void UpdateLecture(LectureDto lecture);
        void DeleteLecture(LectureDto lecture);

        // por estatus
        IEnumerable<LectureDto> GetLectureByStatus(LectureStatus status);
    }
}
