using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange första talet:");
            string firstNumber = Console.ReadLine();

            Console.Write("ange andra talet");
            string secondNumber = Console.ReadLine();


            int firstNumberInt = int.Parse(firstNumber);
            int secondNumberInt = int.Parse(secondNumber);

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumberInt + secondNumberInt}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumberInt - secondNumberInt}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumberInt * secondNumberInt}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumberInt / secondNumberInt}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumberInt % secondNumberInt}");







            Console.ReadLine();
        }
    }
}
