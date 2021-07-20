using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class ScheduleOfLessonsDto
    {
        public int Id { get; set; }
        public int Classid { get; set; }
        public string Day { get; set; }
        public List<SubjectDto>  SubjectDtos { get; set; }
    }
}
