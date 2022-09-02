using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo18
    {
        public static void Main18()
        {
            int count = 1;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i <=j; i++)
                {
                    Console.Write(count+" ");
                    count = count + 1;
                }
                Console.WriteLine(" ");

            }

            Console.ReadKey();

        }
    }
}
