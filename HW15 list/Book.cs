using System;
using System.Collections.Generic;
using System.Text;

namespace HW15_list
{
    internal class Book
    {
        public Book(string titles, string authors)
        {
            Titles = titles;
            Authors = authors;
        }

        public string Titles { get; set; }


        public string Authors { get; set; }



    }
}
