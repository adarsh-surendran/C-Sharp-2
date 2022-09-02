using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo16
    {
        public static void Main16()
        {
            for (int j = 1; j < 6; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine(" ");

            }

            Console.ReadKey();

        }
    }
}
