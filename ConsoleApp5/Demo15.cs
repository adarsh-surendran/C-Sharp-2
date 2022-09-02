using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo15
    {
        public static void Main15()
        {
            for(int j = 0; j < 5; j++)
            {
                for (int i = 0; i <= j; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");

            }
            
            Console.ReadKey();

        }
    }
}
