using NUnit.Framework;
using Biblioteca; // Asigură-te că adaugi referința la proiectul Biblioteca

namespace Biblioteca_Tests
{
    [TestFixture]
    public class DocumentTests
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
