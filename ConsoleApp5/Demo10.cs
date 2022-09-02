using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Demo10
    {
        public static void Main10()
        {
            int math, phy, chem, eng, bio;
            Console.WriteLine("Enter Maths mark");
            math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Physics mark");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Chemistry mark");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter English mark");
            eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Biology mark");
            bio = Convert.ToInt32(Console.ReadLine());
            if((math>64 && phy>54 && chem > 49) && ((math + phy + chem) > 179))
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else if ((math + eng + bio) > 139)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission");
            }
            Console.ReadKey();
        }
    }
}
