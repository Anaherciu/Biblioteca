using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Book : Document
    {
        public string Author { get; set; }
        public Book(string title, string author) : base(title)
        {
            Author = author;
        }
    }
}
