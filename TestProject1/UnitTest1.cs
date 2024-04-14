using NUnit.Framework;
using Biblioteca;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void AddBookToList_AddsBookToList()
        {
            // Arrange
            var form = new Form1();
            var expectedTitle = "Test Book";
            var expectedAuthor = "Test Author";

            // Act
            form.titleTextBox.Text = expectedTitle;
            form.authorTextBox.Text = expectedAuthor;
            form.issueTextBox.Text = ""; // Nu este necesar pentru c?r?i
            form.button1_Click(null, null);

            // Assert
            Assert.AreEqual(1, form.documents.Count);
            Assert.AreEqual(expectedTitle, form.documents[0].Title);
            Assert.AreEqual(expectedAuthor, (form.documents[0] as Book).Author);
        }
    }
}
