using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class SwapTwoNumbers
    {
        public void SwapNo()
        {
            int temp, num1 = 50, num2 = 60;
            Console.WriteLine("Numbers before swapping :" +"num1: " +num1 +" "+" " +"num2:" +" "+num2 );
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Numbers after swapping :"+"num1 :" +num1 +" "+"num2 :"+" "+num2);
        }
    }
}
