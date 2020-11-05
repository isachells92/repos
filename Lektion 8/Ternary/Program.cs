using System;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ternary
            string s = Console.ReadKey(true).Key == ConsoleKey.S ? "Sant" : "Falskt";

            Console.WriteLine(s);

        //    if (Console.ReadKey(true).Key == ConsoleKey.S)
        //    {
        //        s = "Sant";

        //        else
        //           s = "falskt";
        //    }
        //}
    }
}
