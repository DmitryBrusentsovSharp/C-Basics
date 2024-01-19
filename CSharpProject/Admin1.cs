using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class Admin1 : Users1
    {
        private string role;
        public Admin1(int age, string name, bool hasCar, Book favBook, string role)
            : base(age, name, hasCar, favBook)
        {
            this.role = role;
        }
    }
}
