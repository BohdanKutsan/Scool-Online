using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class StudentDiaryEntryDto
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Subject { get; set; }
        public string Homework { get; set; }
        public int DiaryId { get; set; }
        public int? Mark { get; set; }
    }
}
