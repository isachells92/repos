using System;

namespace Delegater02
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, bool> m = PrintIt;
            m("Hejsan alla cpbarn",true);  // NajsLa
        }
        static void PrintIt(string s, bool b)
        {
            if (b == true)
            {
                Console.WriteLine(s.ToUpper());
            }
            else
            {
                Console.WriteLine(s);
            }
        }
    }
    
}
