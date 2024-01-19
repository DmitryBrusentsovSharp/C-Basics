using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpProject
{
    public class Admin : Users
    {
        private string role;

        public Admin(string name, string email, string password, sbyte age, string _role) 
            : base(name, email, password, age)
        {
            this.role = _role;
        }

        public void getRole() 
        {
            Console.WriteLine(role);
        }

        public override void printAll()
        {
            Console.WriteLine(name + " " + email + " " + pass + " " + Age + " " + role);
        }
    }
}
