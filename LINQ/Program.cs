using System;
using System.Collections.Generic;

namespace LINQ
{
    public class Program
    {
        private static void Main(string[] args)
        {
        }

        public static Catalog Cat()
        {
            var w = new Catalog
            {
                books = new List<Book>
                {
                    new Book("1111111111111", "Jopa"),
                    new Book("1111111111222", "Dak"),
                    new Book("1111111111333", "Jok")
                }
            };

            var q = new Author("zzz", "qqq");
            var m = new Author("www", "eee");
            var e = new Author("rrr", "ooo");

            w.books[0].Authors = new List<Author> { q };
            w.books[1].Authors = new List<Author> { q, m };
            w.books[2].Authors = new List<Author> { e };

            w.books[0].DatePublish = new DateTime(1900, 12, 20);
            w.books[1].DatePublish = new DateTime(1000, 3, 3);
            w.books[2].DatePublish = new DateTime(2000, 3, 3);
            return w;

        }

        public static Catalog Cat(out Author author)
        {
            var w = new Catalog
            {
                books = new List<Book>
                {
                    new Book("1111111111111", "Jopa"),
                    new Book("1111111111222", "Dak"),
                    new Book("1111111111333", "Jok")
                }
            };

            var q = new Author("zzz", "qqq");
            author = q;
            var m = new Author("www", "eee");
            var e = new Author("rrr", "ooo");

            w.books[0].Authors = new List<Author> { q };
            w.books[1].Authors = new List<Author> { q, m };
            w.books[2].Authors = new List<Author> { e };

            w.books[0].DatePublish = new DateTime(1900, 12, 20);
            w.books[1].DatePublish = new DateTime(1000, 3, 3);
            w.books[2].DatePublish = new DateTime(2000, 3, 3);
            return w;

        }
    }

    
}
