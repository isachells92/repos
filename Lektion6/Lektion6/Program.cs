using System;
using System.Collections.Generic;

namespace Lektion6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> djur = new List<string>();
            djur.Add("Katt");
            djur.Add("Hund");
            djur.Add("Kanariefågel");

            djur.RemoveAt(1);

            djur.Sort();

            djur.

            for (int i = 0; i < djur.Count; i++)
            {
                Console.WriteLine(djur[i]);
            }

            Console.WriteLine("--------------");

            foreach (string anAnimal in djur)
            {
                Console.WriteLine(anAnimal);
            }
           
        }
    }
}
