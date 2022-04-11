using System;
namespace BasicCorePrograms;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Basic Programs");
        bool end = true;
        Console.WriteLine("1. FlipCoin\n 2.LeapYear \n 3.PowerOfTwo  \n 4.Harmonic number \n 5. Prime factors \n 6. Quotient and Remainder \n 7.swap no \n 8. Even or odd \n 9. End the Program");
        while (end == true)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Flip();
                    flipCoin.percentage();
                    break;
                case 2:
                    LeapYear lip = new LeapYear();
                    lip.Year();
                    break;
                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.Power();
                    break;
                case 4:
                    HarmonicNumber harmonic = new HarmonicNumber();
                    harmonic.HarmonicNo();
                    break;
                case 5:
                    PrimeFactors factors = new PrimeFactors();
                    factors.PrimeFactor();
                    break;
                case 6:
                    QuotientAndRemainder quorem = new QuotientAndRemainder();
                    quorem.QuotientRemainder();
                    break;
                case 7:
                    SwapTwoNumbers swap = new SwapTwoNumbers();
                    swap.SwapNo();
                    break;
                case 8:
                    EvenOrOdd no = new EvenOrOdd();
                    no.CheckEvenOrOdd();
                    break;
                case 9:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}
