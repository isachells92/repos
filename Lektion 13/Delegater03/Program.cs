using System;

namespace Delegater03
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> m = IsLessThan;
            m(130,144);
            Console.WriteLine(m(200, 400)); 
            Console.Write(m(100,50));
        }

        static bool IsLessThan(int i, int j)
        {
            if (i < j)
                return true;
            else
                return false;
        }
    }
}
