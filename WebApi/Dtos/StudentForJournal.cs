using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Dtos
{
    public class StudentForJournal
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public int ClassId { get; set; }

        public List<MarkDto> MarkDtos { get; set; }
        public List<int?> parentsid { get; set; }
    }
}
