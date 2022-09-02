using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo3
    {
        public static void Main3()
        {
            int a;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine(a + " is a positive number");

            }
            else
            {
                Console.WriteLine(a + " is a negative number");

            }
            Console.ReadKey();
        }
    }
}
