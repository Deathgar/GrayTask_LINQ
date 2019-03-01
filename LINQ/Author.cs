using System;

namespace LINQ
{
    public class Author
    {
        private string firstName;
        private string lastName;
        private const int maxLengthAuthorInfo = 200;

        public Author(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || firstName.Length > maxLengthAuthorInfo
                || string.IsNullOrEmpty(lastName) || lastName.Length > maxLengthAuthorInfo)
            {
                throw new IndexOutOfRangeException();
            }
            
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > maxLengthAuthorInfo)
                {
                    throw new IndexOutOfRangeException();
                }
                firstName = value;
                firstName = firstName.FirstUpper();
               
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > maxLengthAuthorInfo)
                {
                    throw new IndexOutOfRangeException();
                }
                lastName = value;
                lastName = lastName.FirstUpper();
            }
        }
    }
}
