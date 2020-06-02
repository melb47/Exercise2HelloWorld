using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of miles driven:");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter gallons of gas consumed:");
            int gallons = int.Parse(Console.ReadLine());
            int mpg = miles / gallons;
            Console.WriteLine("Your vehicle's gas efficiency is " + mpg + " miles per gallon");
        }
    }
}
