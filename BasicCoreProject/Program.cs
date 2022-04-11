﻿using System;
namespace BasicCorePrograms;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Basic Programs");
        bool end = true;
        Console.WriteLine("1. FlipCoin\n 2.LeapYear n 3. End the Program");
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
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }



    }
}
