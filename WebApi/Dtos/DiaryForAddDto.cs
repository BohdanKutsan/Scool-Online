using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class DiaryForAddDto
    {
        public int Id { get; set; }
        public DateTime Firstdate { get; set; }
        public DateTime Seconddate { get; set; }
        public List<DiaryEntryDto> DiaryEntries { get; set; }
        public string Remark { get; set; }
        public int ClassId { get; set; }
    }
}
