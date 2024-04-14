using Biblioteca;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTest.ClassLibrary.BaseClass
{
    internal class DocumentTests
    {
        [Test]
        public void DocumentConstructor_WithTitle_SetsTitle()
        {
            string expectedTitle = "Test Document";


            Document document = new Document(expectedTitle);


            Assert.That(document.Title, Is.EqualTo(expectedTitle));
        }
    }
}
