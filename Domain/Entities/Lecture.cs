﻿using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Lecture
    {
        public int Id { get; set; }
        public int? Rating { get; set; }
        public int? PageCount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public LectureStatus Status { get; set; }

        // User
        public int UserId { get; set; }
        public User? User { get; set; }

        // Libro
        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}
