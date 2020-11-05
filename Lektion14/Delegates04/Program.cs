using System;

namespace Delegates04
{
    class Program
    {
        static void Main(string[] args)
        {
            
             SomeMethod("Här är en sträng",UpperOrLowerCase);
            
                     // den här metoden tar en (string,Func<bool>)
        }
        static bool UpperOrLowerCase()
        {
            Console.Write("vill du skriva ut med [S]tora bokstäver, annars små?: ");
            string input = Console.ReadLine();
            return input.ToLower() == "s";      // Här är en bool method, den är true om S är inmatat. (stort eller litet)
        }
        static void SomeMethod(string s, Func<bool>b)
        {
            if (b())
                Console.WriteLine(s.ToUpper());
            else 
                Console.WriteLine(s.ToLower());
        }
    }
}
