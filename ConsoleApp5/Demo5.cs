using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo5
    {
        public static void Main5()
        {
            int a;
            Console.WriteLine("Enter your age");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");

            }
            else
            {
                Console.WriteLine("Sorry! You are not eligible for casting your vote.");

            }
            Console.ReadKey();
        }
    }
}
