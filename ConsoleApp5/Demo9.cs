using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo9
    {
        public static void Main9()
        {
            Console.WriteLine("Enter the x-coordinate");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y-coordinate");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0)
            {
                Console.WriteLine("The coordinate point ("+a+","+b+") lies in the first quadrant");
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine("The coordinate point (" + a + "," + b + ") lies in the second quadrant");
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine("The coordinate point (" + a + "," + b + ") lies in the fourth quadrant");
            }
            else
            {
                Console.WriteLine("The coordinate point (" + a + "," + b + ") lies in the third quadrant");
            }
            Console.ReadKey();
        }
    }
}
