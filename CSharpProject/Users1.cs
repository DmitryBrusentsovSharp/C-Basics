using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class Users1
    {
        private int age;
        private string name;
        private bool hasCar;
        public Book favBook {  get; private set; }

        public Users1 (int age, string name, bool hasCar, Book favBook)
        {
            this.age = age;
            this.name = name;
            this.hasCar = hasCar;
            this.favBook = favBook;
        }
    }
}
