using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class CircleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TeacherId { get; set; }
        public string TeacherName { get; set; }
        public List<StudentDto> StudentDtos { get; set; }
    }
}
