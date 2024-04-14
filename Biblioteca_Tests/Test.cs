using Biblioteca;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Tests
{
    [TestFixture]
    internal class Test
    {
        [Test]
        public void DocumentConstructor_WithTitle_SetsTitle()
        {
            // Arrange
            string expectedTitle = "Test Document";

            // Act
            Document document = new Document(expectedTitle);

            // Assert
            Assert.That(document.Title, Is.EqualTo(expectedTitle));
        }
    }
}
