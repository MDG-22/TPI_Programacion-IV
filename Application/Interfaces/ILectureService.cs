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
        LectureDto? GetById(int id);
        void Add(LectureDto lecture);
        void Update(LectureDto lecture);
        void Delete(LectureDto lecture);

        // por estatus
        IEnumerable<LectureDto> GetByStatus(LectureStatus status);
    }
}
