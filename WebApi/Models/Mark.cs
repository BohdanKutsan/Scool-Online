using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public string SubjectName { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime Date { get; set; }
        public string TypeMark { get; set; }
    }
}
