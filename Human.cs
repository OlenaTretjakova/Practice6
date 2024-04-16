using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice6
{
    internal class Human
    {
        protected string _name { get; set; } = "no name";
        protected string _lastName { get; set; } = "no last name";
        protected int _age { get; set; } = 0;
        protected string _phone { get; set; } = "no phone";

        public Human() {}
        public Human(string name, string lastName, int age, string phone):this() 
        {
            _name = name;
            _lastName = lastName;
            _age = age;
            _phone = phone;
        }
        public virtual void  Show()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Last Name: " + _lastName);
            Console.WriteLine("Age: " + _age);
            Console.WriteLine("Phone: " + _phone);
        }

        public void Metod()
        { 
            Console.WriteLine("It is parent.");
        }

    }
}
