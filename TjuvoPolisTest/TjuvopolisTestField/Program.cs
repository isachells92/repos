using System;

namespace TjuvopolisTestField
{
    class Program
    {
        static void Main(string[] args)
        {
            int dx = 0;  //Direction
            int dy = 1;

            int px = 5;  //SpawnPosition
            int py = 5;
            while (true)
            {
                Console.Clear();
                int[,] grid = new int[25, 25];
                for (int y = 0; y < grid.GetLength(0); y++)
                {

                    Console.Write(", ");
                    for (int x = 0; x < grid.GetLength(1); x++)
                    {
                        Console.Write(". ");
                        if (px == y && py == y)
                        {
                            Console.Write("X ");
                        }
                        else Console.Write(". ");
                    }
                    Console.WriteLine();
                }

            }



            //while (true)
            //{ 
            //    Random r = new Random();
            //    int randomDirection = r.Next(1, 8);
            //    Console.WriteLine(randomDirection);
            //    switch (randomDirection)
            //    {
            //        case 1:
            //            dx = 1;
            //            dy = 0;
            //            break;
            //        case 2:
            //            dx = 1;
            //            dy = 1;
            //            break;
            //        case 3:
            //            dx = 1;
            //            dy = 0;
            //            break;
            //        case 4:
            //            dx = -1;
            //            dy = 0;
            //            break;
            //        case 5:
            //            dx = 0;
            //            dy = -1;
            //            break;
            //        case 6:
            //            dx = -1;
            //            dy = -1;
            //            break;
            //        case 7:
            //            dx = 1;
            //            dy = -1;
            //            break;
            //        case 8:
            //            dx = -1;
            //            dy = 1;
            //            break;
            //        default:
            //            continue;
            //    }
            //    //if (randomDirection == 8)
            //    //{
            //    //    break;
            //    //}
            //    Console.WriteLine(dx+dy);


        }
    }
}
