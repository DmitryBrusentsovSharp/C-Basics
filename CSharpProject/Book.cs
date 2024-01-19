using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public struct Book
    {
        private int pages;
        private string author, name;

        public Book(int pages, string author, string name) 
        {
            this.pages = pages;
            this.author = author;
            this.name = name;
        }

        public void printBook() 
        {
            Console.WriteLine(name + " " + author + " " + pages);
        }
    }
}
