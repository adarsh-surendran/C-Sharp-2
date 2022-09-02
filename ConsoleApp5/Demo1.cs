using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo1
    {
        public static void Main1()
        {
            Console.WriteLine("Enter two numbers");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine(a + " and " + b + " are equal");
            }
            else
            {
                Console.WriteLine(a + " and " + b + " are not equal");
            }
            Console.ReadKey();
        }
    }
}
