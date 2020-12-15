using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStorage.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfRelese { get; set; }
        public int Pages { get; set; }
        public string FullNameAutor { get; set; }
        public string Genre { get; set; }
    }
}
