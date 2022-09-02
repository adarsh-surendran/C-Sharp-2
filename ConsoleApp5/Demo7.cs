using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo7
    {
        public static void Main7()
        {
            int a;
            Console.WriteLine("Enter the height in cm");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 150)
            {
                Console.WriteLine("The person is dwarf");

            }
            else
            {
                Console.WriteLine("The person is not dwarf");

            }
            Console.ReadKey();
        }
    }
}
