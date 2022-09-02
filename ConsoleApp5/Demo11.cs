using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo11
    {
        public static void Main11()
        {
            int range;
            Console.WriteLine("Enter the number of terms");
            range = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<range+1; i++)
            {
                Console.WriteLine("Cube of " + i + " is " + i * i * i);
            }
            Console.ReadKey();
        }
    }
}
