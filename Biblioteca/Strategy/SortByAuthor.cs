using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biblioteca.Form1;

namespace Biblioteca
{
    public class SortByAuthor : ISortStrategy
    {
        public void Sort(List<Document> documents)
        {
            var books = documents.Where(d => d is Book).Cast<Book>().ToList();
            books.Sort((x, y) => string.Compare(x.Author, y.Author));
            documents.RemoveAll(d => d is Book);
            documents.AddRange(books);

            var magazines = documents.Where(d => d is Magazine).Cast<Magazine>().ToList();
            magazines.Sort((x, y) => string.Compare(x.Title, y.Title));
            documents.RemoveAll(d => d is Magazine);
            documents.AddRange(magazines);
        }
    }
}
