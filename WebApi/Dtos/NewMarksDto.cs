using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class NewMarksDto
    {
        public int ClassId { get; set; }
        public DateTime Firstdate { get; set; }
        public DateTime Seconddate { get; set; }
        public string SubjectName { get; set; }
    }
}
