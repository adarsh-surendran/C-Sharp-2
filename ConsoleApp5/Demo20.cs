using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo20
    {
        public static void Main()
        {
    
            int space = 3;
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                space--;
                for (int i = 0; i <= j; i++)
                {
                    Console.Write("* ");
                 
                }
                Console.WriteLine(" ");

            }

            Console.ReadKey();

        }
    }
}
