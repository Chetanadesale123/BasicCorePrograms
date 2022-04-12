using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestAmongThreeNos
    {
        public void LargestNo()

        {
            int num1, num2, num3;
            Console.WriteLine("Enter the num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write(num1 + " " + "is the largest among three.\n");
                }
                else
                {
                    Console.Write(num3 + " " + "is the largest among three.\n");
                }
            }
            else if (num2 > num3)
                Console.Write(num2 + " " + "is the largest among three.\n");
            else
                Console.Write(num3 + " " + "is the largest among three.\n");
        }
    }
}
