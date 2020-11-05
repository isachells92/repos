using System;

namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MgConverter1.0: enter a number to hellaconvert!");
            double num = double.Parse(Console.ReadLine());

            double gramToOz = num * 0.035;

            Console.WriteLine($"{num} milligrams is {gramToOz} oz (prenounced ounce)");

            Console.ReadLine();


        }
    }
}
