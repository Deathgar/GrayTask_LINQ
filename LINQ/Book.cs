using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LINQ
{
    public class Book
    {
        private const string firstType = @"\d{3}-\d{1}-\d{2}-\d{6}-\d{1}";
        private const string secondType = @"\d{13}";
        private const int maxLengthName = 1000;

        private string isbn;
        private string name;
        public DateTime DatePublish { get; set; }
        public List<Author> Authors { get; set; }

        public Book(string isbn, string name)
        {
            ISBN = isbn;
            Name = name;
        }

        public string ISBN
        {
            get => isbn;
            set
            {

                if (!Regex.IsMatch(value, firstType, RegexOptions.Compiled) 
                    && !Regex.IsMatch(value, secondType, RegexOptions.Compiled))
                {
                    throw new Exception();
                }

                isbn = value;
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if(string.IsNullOrEmpty(value) || value.Length > maxLengthName)
                {
                    throw new IndexOutOfRangeException();
                }

                name = value;
            }
        }

        public override bool Equals(object obj)
        {
            var tempBook = (Book)obj;
            return isbn.Equals(tempBook.ISBN);
        }

    }
}
