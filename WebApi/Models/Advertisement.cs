using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }
}
