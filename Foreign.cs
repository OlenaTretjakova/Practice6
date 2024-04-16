using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    class Foreign:Pasport
    {
        public int _Id { get; set; }
        public List<string> _vises { get; set; }

        public Foreign(string firstName, string lastName, DateTime born, int num, int id, List<string> vises):base ( firstName,  lastName,  born, num)
        {
            _Id = id;

            foreach (var item in vises)
            {
                _vises.Add(item);
            }
        }
        public override void Show()
        {
            base.Show();

            Console.WriteLine($"ID : {_Id}");

            foreach (var item in _vises)
            {
                Console.WriteLine($"Vises : {item}");
            }

        }
    }
}
