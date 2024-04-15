using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class DocumentFactory
    {
       
        public static Document CreateDocument<T>(string title, string author = null, int issueNumber = 0)
        {
          

            if (typeof(T).Name == typeof(Book).Name)
            {
                return new Book(title, author);

            }
            if (typeof(T).Name == typeof(Magazine).Name)
            {
                return new Magazine(title, issueNumber);
            }
            throw new ArgumentException("Invalid document type");
        }
    }
}
