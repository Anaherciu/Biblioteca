using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biblioteca.Form1;

namespace Biblioteca
{
    public class SortByTitle : ISortStrategy
    {
        public void Sort(List<Document> documents)
        {
            documents.Sort((x, y) => string.Compare(x.Title, y.Title));
        }
    }
}
