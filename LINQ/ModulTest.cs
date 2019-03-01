using NUnit.Framework;

namespace LINQ
{
    [TestFixture]
    public class ModulTest
    {
        [Test]
        public void TestConstructorAuthor()
        {
            var author = new Author("jopA", "cOX");
            Assert.AreEqual("Jopa", author.FirstName);
            Assert.AreEqual("Cox", author.LastName);
        }

        [Test]
        public void TestGettingForFirstNameAndLastName()
        {
            var catalog = Program.Cat();
            var books = catalog.GetBookForFirstNameAndLastName("zzz", "qqq");
            
            Assert.AreEqual(2, books.Count);
            Assert.AreEqual(books[0].Name, "Jopa");
            Assert.AreEqual(books[1].Name, "Dak");
        }

        [Test]
        public void TestGettingCountBookFromAuthor()
        {
            Author author;

            var catalog = Program.Cat(out author);

            Assert.That(catalog.GetCountBookFromAuthor(author), Is.EqualTo(2));
        }

        [Test]
        public void TestG()
        {
            var catalog = Program.Cat();
            var sortedCatalog = catalog.GetBookOrderDecByDatePublish();

            Assert.AreEqual(sortedCatalog[0].Name, "Jok");
            Assert.AreEqual(sortedCatalog[1].Name, "Jopa");
            Assert.AreEqual(sortedCatalog[2].Name, "Dak");

        }
    }
}
