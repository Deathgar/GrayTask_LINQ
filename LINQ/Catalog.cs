using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Catalog : IEnumerable<Book>
    {
        public List<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            var tempBooks = Books.OrderBy(book => book.Name).ToList();

            foreach (var book in tempBooks)
            {
                yield return book;
            }
        }

        public List<Book> GetBookForFirstNameAndLastName(string firstName, string lastName)
        {
            var w = Books.Where(b => b.Authors.Any(a => a.FirstName.Equals(firstName.FirstUpper()) && a.LastName.Equals(lastName.FirstUpper()))).ToList();
            return w;
        }

        public List<Book> GetBookOrderDecByDatePublish()
        {
            return Books.OrderByDescending(book => book.DatePublish).ToList();
        }

        public int GetCountBookFromAuthor(Author author)
        {
            var q = Books.Where(book => book.Authors.Contains(author)).ToList();
            return q.Count;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
