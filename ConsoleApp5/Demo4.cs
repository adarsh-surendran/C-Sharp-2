using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo4
    {
        public static void Main4()
        {
            int a;
            Console.WriteLine("Enter a year");
            a = Convert.ToInt32(Console.ReadLine());
            if ((a % 4 == 0 && a%100!=0)||(a%400==0))
            {
                Console.WriteLine(a + " is a leap year");

            }
            else
            {
                Console.WriteLine(a + " is not a leap year");

            }
            Console.ReadKey();
        }
    }
}
