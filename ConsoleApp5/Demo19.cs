using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo19
    {
        public static void Main19()
        {
            int count = 1;
            int space = 3;
            for (int j = 0; j < 4; j++)
            {
                for(int k=0;k<space;k++)
                {
                    Console.Write(" ");
                }
                space--;
                for (int i = 0; i <= j; i++)
                {
                    Console.Write(count + " ");
                    count = count + 1;
                }
                Console.WriteLine(" ");

            }

            Console.ReadKey();

        }
    }
}
