using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length:");
            int length = int.Parse(Console.ReadLine());
            int area = length * width;
            Console.WriteLine("The area of your rectangle is " + area + " units squared.");
        }
    }
}
