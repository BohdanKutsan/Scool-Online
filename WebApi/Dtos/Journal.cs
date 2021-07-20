using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Dtos
{
    public class Journal
    {
        public int NumberClass { get; set; }

        public List<Student> Students { get; set; }

        public List <Mark> Marks { get; set; } 
    }
}
