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
                Books = new List<Book>
                {
                    new Book("1111111111111", "Jopa"),
                    new Book("1111111111222", "Dak"),
                    new Book("1111111111333", "Jok")
                }
            };

            var q = new Author("zzz", "qqq");
            var m = new Author("www", "eee");
            var e = new Author("rrr", "ooo");

            w.Books[0].Authors = new List<Author> { q };
            w.Books[1].Authors = new List<Author> { q, m };
            w.Books[2].Authors = new List<Author> { e };

            w.Books[0].DatePublish = new DateTime(1900, 12, 20);
            w.Books[1].DatePublish = new DateTime(1000, 3, 3);
            w.Books[2].DatePublish = new DateTime(2000, 3, 3);
            return w;

        }

        public static Catalog Cat(out Author author)
        {
            var w = new Catalog
            {
                Books = new List<Book>
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

            w.Books[0].Authors = new List<Author> { q };
            w.Books[1].Authors = new List<Author> { q, m };
            w.Books[2].Authors = new List<Author> { e };

            w.Books[0].DatePublish = new DateTime(1900, 12, 20);
            w.Books[1].DatePublish = new DateTime(1000, 3, 3);
            w.Books[2].DatePublish = new DateTime(2000, 3, 3);
            return w;

        }
    }

    
}
