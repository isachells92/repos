using System;

namespace ToP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] grid = new string[10,3];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                Console.Write("_");
                Console.WriteLine("");
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write("");

                }
                
            }
            Console.ReadLine();
        }
    }
}
