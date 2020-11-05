using System;
using System.Collections.Generic;
using System.Text;

namespace TjuvoPolisTest
{
    class Person
    {
        static Random r = new Random();
        public int SpawnCoordinateX  { get; set; }
        public int SpawnCoordinateY { get; set; }
        public List<string> Inventory { get; set; }

        public Person(int spawncoordinateX, int spawncoordinateY)
        {
            SpawnCoordinateX = spawncoordinateX;
            SpawnCoordinateY = spawncoordinateY;
        }
        public static void SpawnAndMoveInRandomDirection()
        {
            
            int dx = 0;
            int dy = 0;
            int px = 5;
            int py = 5;
            int randomDirection = r.Next(1, 8);

            switch (randomDirection)
            {
                case 1:
                    dx = 1;
                    dy = 0;
                    break;
                case 2:
                    dx = 1;
                    dy = 1;
                    break;
                case 3:
                    dx = 1;
                    dy = 0;
                    break;
                case 4:
                    dx = -1;
                    dy = 0;
                    break;
                case 5:
                    dx = 0;
                    dy = -1;
                    break;
                case 6:
                    dx = -1;
                    dy = -1;
                    break;
                case 7:
                    dx = 1;
                    dy = -1;
                    break;
                case 8:
                    dx = -1;
                    dy = 1;
                    break;
                default:
                    break;
            }

            px += dx;
            py += dy;

        }
    }
}
