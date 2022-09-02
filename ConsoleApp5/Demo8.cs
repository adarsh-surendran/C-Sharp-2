using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo8
    {
        public static void Main8()
        {
            int a,b,c;
            Console.WriteLine("Enter three numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine("The 1st number is the largest among three");
            }
            else if (b > c)
            {
                Console.WriteLine("The 2nd number is the largest among three");
            }
            else
            {
                Console.WriteLine("The 3rd number is the largest among three");
            }
         
            Console.ReadKey();
        }
    }
}
