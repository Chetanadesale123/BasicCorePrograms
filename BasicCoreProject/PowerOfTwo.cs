using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo
    {
        int result = 1;
        public void Power()
        {
            Console.WriteLine("Enter the index");
            int index = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= index; i++)
            {
                result = result * 2;
                Console.WriteLine("2" + " " + "^" + " " + i + " " + "=" + " " + " " + " " + result);
            }
        }
    }
    }






