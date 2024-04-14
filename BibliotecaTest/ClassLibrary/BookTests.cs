using Biblioteca;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTest.ClassLibrary
{
    internal class BookTests
    {
        [Test]
        public void BookConstructor_SetsTitleAndAuthor()
        {
            string expectedTitle = "Test Book";
            string expectedAuthor = "Test Author";

            Book book = new Book(expectedTitle, expectedAuthor);

            Assert.AreEqual(expectedTitle, book.Title);
            Assert.AreEqual(expectedAuthor, book.Author);
        }
    }
}
