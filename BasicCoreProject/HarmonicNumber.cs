using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        public void HarmonicNo()
        {
            double harmonic = 0.0;

            Console.WriteLine("enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                harmonic += 1 / (double)i;
            }
            Console.WriteLine("Harmonic No Series:" + harmonic);


        }
    }
}
