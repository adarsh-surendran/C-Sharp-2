using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo6
    {
        public static void Main6()
        {
            int m, n;
            Console.WriteLine("Enter a number");
            m = Convert.ToInt32(Console.ReadLine());
            if (m > 0)
            {
                n = 1;
                Console.WriteLine("The value of n is : " + n);
            }
            else if (m == 0)
            {
                n = 0;
                Console.WriteLine("The value of n is : " + n);

            }
            else
            {
                n = -1;
                Console.WriteLine("The value of n is : " + n);
            }
            Console.ReadKey();
                
        }
    }
}
