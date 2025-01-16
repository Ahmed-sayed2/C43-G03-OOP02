using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Book
    {
        public Book(string Title ,string Author,int ISBN)
        { 
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
    }
    internal class EBook:Book {
        public EBook(decimal size, string Title, string Author, int ISBN) :base(Title,Author,ISBN)
        {
            this.FileSize = size;
        }
        public decimal FileSize { get; set; }
    }
    internal  class PrintedBook:Book  {
        public PrintedBook(int PageCount, string Title, string Author, int ISBN) : base(Title, Author, ISBN)
        {
           this.PageCount= PageCount;
        }
        public int PageCount { get; set; }
    }
}
