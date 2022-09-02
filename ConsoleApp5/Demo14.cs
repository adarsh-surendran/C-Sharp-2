using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo14
    {
        public static void Main14()
        {
            int range,sum=0;
            Console.WriteLine("Enter the number of terms");
            range = Convert.ToInt32(Console.ReadLine());
            Console.Write("Odd numbers : ");
            for (int i = 1; i < range*2; i=i+2)
            {
                
                Console.Write(i+" ");
                sum =sum+ i;
                
            }
            Console.WriteLine(" ");
            Console.WriteLine("Sum of these odd numbers : "+sum);
            Console.ReadKey();
        }
    }
    

}
