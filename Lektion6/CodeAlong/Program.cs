using System;

namespace CodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] siffror = new int[5];
            siffror[0] = 11;
            siffror[1] = 785;
            siffror[2] = 4;
            siffror[3] = 130470;
            siffror[4] = 19;

            for (int i = 0; i < siffror.Length; i++)
            {
                Console.WriteLine(siffror[i] * 3);
            }

            string[] countDown = new string[6];
            countDown[0] = "Three ;";
            countDown[1] = "Two ;";
            countDown[2] = "one ;";
            countDown[3] = "Go...;";

            for (int j = 0; j < countDown.Length; j++)
            {
                Console.WriteLine(countDown[j]);
            }

             //                               0         1         2        3  
            int[,] siffror2 = new int[,] { { 1, 2 }, { 3,4 }, { 5,6 }, { 7, 8 } };
            Console.WriteLine(siffror2[2,1]); // Rad 2 - index 2
           
        }
    }
}
