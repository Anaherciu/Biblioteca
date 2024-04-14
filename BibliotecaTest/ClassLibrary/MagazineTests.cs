using Biblioteca;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTest.ClassLibrary
{
    internal class MagazineTests
    {
        [Test]
        public void MagazineConstructor_SetsTitleAndIssueNumber()
        {
            string expectedTitle = "Test Magazine";
            int expectedIssueNumber = 1;

            Magazine magazine = new Magazine(expectedTitle, expectedIssueNumber);

            Assert.AreEqual(expectedTitle, magazine.Title);
            Assert.AreEqual(expectedIssueNumber, magazine.IssueNumber);
        }
    }
}
