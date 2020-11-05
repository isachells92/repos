using System;

namespace TjuvOchPolis
{
    class Program
    {
        static void Main(string[] args)
        {
            int storlek = 3;
            
            for (int i = 0; i < storlek; i++)
            {

                // varje rad
                Console.Write("Tak: ");
                for (int j = 0; j < storlek*4+1; j++)
                {
                    Console.Write("-");

                }
                Console.WriteLine();

                for (int k = 0; k <= 3; k++)
                {
                    Console.Write("rad: ");      

                    for (int l = 0; l < storlek*3+1; l++)
                    {
                        Console.Write("|");
                        for (int m = 0; m <=3; m++) // vägg i rutan
                        {
                            for (int n = 0; n <= 3; n++) // varje tecken i varje ruta
                            {
                                if (true)
                                {



                                }
                            }
                        }
                    }
                }
                Console.WriteLine("");

                

                
            }

        }
    }
}
