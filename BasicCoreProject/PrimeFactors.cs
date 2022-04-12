using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PrimeFactors
    {
        public void PrimeFactor()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i <= n; i++)
            {
                if(n%i == 0)
                {
                    int Count  = 0;
                    while(n%i == 0)
                    {
                        n = n / i;
                        Count++;
                    }
                    Console.WriteLine(i +" "+"^"+Count);
                }
            }
            /*while (n % 2 == 0)
            {

                Console.WriteLine(2 + " ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n /= i;
                }
            }
            if (n > 2)
                Console.WriteLine(n);*/
        }







    }
}

















