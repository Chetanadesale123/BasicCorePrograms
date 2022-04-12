using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelOrConsonant
    {
        public void CheckVowelOrConsonant()
        {
            Console.WriteLine("Enter the Alphabet");
            char x = Convert.ToChar(Console.ReadLine());
            if (x == 'a' || x == 'e' || x == 'i' ||

                x == 'o' || x == 'u' || x == 'A' ||

                x == 'E' || x == 'I' || x == 'O' || x == 'U')

                Console.WriteLine(" Alphabet is Vowel");

            else

                Console.WriteLine(" Alphabet is Consonant");


        }

    }
}
