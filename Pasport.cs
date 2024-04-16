using System;

namespace Practice6
{
    internal class Pasport
    {
        protected string _firstName { get; set; }
        protected string _lastName { get; set; }
        protected DateTime _born { get; set; }
        protected string _sittyBorn { get; set; }
        protected int _num { get; set; }

        public Pasport(string firstName, string lastName, DateTime born, int num) 
        {
            _firstName = firstName;
            _lastName = lastName;
            _born = born;
            _num = num;
        }
        public virtual void Show()
        {
            Console.WriteLine("First name: " + _firstName);
            Console.WriteLine("Last Name: " + _lastName);
            Console.WriteLine("Born: " + _born);
            Console.WriteLine("Number of pasport: " + _num);
        }

        public void Metod()
        {
            Console.WriteLine("It is class Pasport.");
        }

    }
}
