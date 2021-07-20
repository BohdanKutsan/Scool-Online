using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class LessonDto
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int Number { get; set; }
        public int ClassId { get; set; }
        public int TeacherId { get; set; }
        public int Day { get; set; }
    }
}
