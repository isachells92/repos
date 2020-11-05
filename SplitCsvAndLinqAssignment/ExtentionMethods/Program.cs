using System;
using System.Runtime.InteropServices;

namespace ExtentionMethods
{
    class Program
    {


        static void Main(string[] args)
        {
            if (ExtensionMethods.isOdd(9))                          // Extention methods för att utvidga c# ints.
                Console.WriteLine("uddish");
            int i = 7;

            if (i.isOdd())
                Console.WriteLine("udda tal");


            int j = ExtensionMethods.ToInt("1962"); // konverterar strängen med den vanliga metoden to Int (innan this använding.)
            Console.WriteLine(j);

            int k = "1962".ToInt();


            if (ExtensionMethods.isOdd(ExtensionMethods.ToInt(Console.ReadLine())))
                Console.WriteLine("udda tal");

            if (Console.ReadLine().ToInt().isOdd())
                Console.WriteLine("udda tal");
            

            
        }


    }

}
