using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    class Sailor:Human
    {
        public string _company {  get; set; }
        public int _salary { get; set; }

        public Sailor(string _name, string _lastName, int _age,string _phone ):base(_name, _lastName, _age, _phone)
        {
        }

        public Sailor(string _name, string _lastName, int _age, string _phone, string company, int salary) : base(_name, _lastName, _age, _phone)
        {
            _company = company;
            _salary = salary;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Company: {_company}");
            Console.WriteLine($"Salary: {_salary}");
        }
    }
}
