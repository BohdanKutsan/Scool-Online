using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class StudentDiaryDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<StudentDiaryEntryDto> DiaryEntries { get; set; }
        public string Remark { get; set; }
        public int ClassId { get; set; }
    }
}
