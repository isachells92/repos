using System;

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.Write("Ange första talet:");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("ange andra talet");
            string secondNumber = Console.ReadLine();


            int firstNumberInt = int.Parse(firstNumber);
            int secondNumberInt = int.Parse(secondNumber);

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumberInt} +{secondNumberInt}");
            
            
            Console.ReadLine();

        }
    }
}
