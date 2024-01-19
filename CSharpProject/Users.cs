using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class Users
    {
        protected string name;
        protected string email;
        protected string pass;
        private sbyte age;
        private Admin admin;

        public static int count;

        public sbyte Age {
            get 
            {
                age++;
                return age;
            }
            set 
            {
                if (value < 0) this.age = 1;
                else age = value;
            }
        }
        public Users(string _name, string _email, string _pass, sbyte _age)
        {
            name = _name;
            email = _email;
            pass = _pass;
            Age = _age;
            count++;
        }
        
/*        public Users(string _name, string _email, string _pass, sbyte _age, string _role) 
        {
            name = _name;
            email = _email;
            pass = _pass;
            Age = _age;
            admin.role = _role;
            printAll();
            count++;
        }*/

        public Users()
        {
            //Console.WriteLine("inside constructor Users");
            count++;
        }

        public void setAll(string _name, string _email, string _pass, sbyte _age)
        {
            name = _name;
            email = _email;
            pass = _pass;
            Age = _age;
        }

        public virtual void printAll() 
        {
            Console.WriteLine(name + " " + email + " " + pass + " " + Age);
        }

        public static void print() 
        {
            Console.WriteLine(count);
        }
    }
}
