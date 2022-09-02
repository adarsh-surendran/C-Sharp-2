using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo13
    {
        public static void Main13()
        {
            int a;
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            for(int j = 1; j < a + 1; j++) {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(j + " x " + i + " = " + j * i);
                }
                Console.WriteLine(" ");
            }
            
            Console.ReadKey();
        }
    }
}
