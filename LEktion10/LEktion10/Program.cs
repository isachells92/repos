using System;
using static System.Console;

namespace LEktion10
{
    class Program
    {
        static void Main(string[] args)
        {
            Fact f = new Fact(300, "Micke Engeström", 150, "OOPS programmering");
            WriteLine($"{f.Pages} pages, written by {f.Author} about {f.Subject}, and the price is {f.Price}");

        }
    }
}
