using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Document
    {
        public string Title { get; set; }
        public Document(string title)
        {
            Title = title;
        }
    }
}
