using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class MarkDto
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public string SubjectName { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
    }
}
