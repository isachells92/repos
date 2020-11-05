using System;
using System.ComponentModel;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ange ett decimal tal!");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ange ett annat  decimal tal!");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("ange ett tredje decimal tal!");
            double num3 = double.Parse(Console.ReadLine());

            double sum = (num1 + num2 + num3) / 3;
            double roundSUm = Math.Round(sum);

            Console.WriteLine($"Medeltalet är  {sum} ") ;
            Console.WriteLine($"avrundat med en decimal är {roundSUm}");


        }
    }
}
