using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Alice", "Smith", 25, "987-654-3210");


            Sailor sailor1 = new Sailor("John", "Doe", 30, "123-456-7890", "ABC Shipping", 2000);
            Sailor sailor2 = new Sailor("Alice", "Smith", 25, "987-654-3210", "XYZ Maritime", 1800);

            Console.WriteLine();
            sailor1.Show();

            Console.WriteLine();
            sailor2.Metod();

            Human obj = new Sailor("Alice", "Smith", 25, "987-654-3210", "XYZ Maritime", 1800);

            Console.WriteLine();

            if(obj is Sailor)
            {
                Console.WriteLine((obj as Sailor)._company);

            }

            sailor2.Metod();

            Console.WriteLine();





            Console.ReadLine();
        }
    }
}
