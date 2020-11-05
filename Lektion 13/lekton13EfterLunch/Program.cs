using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace lekton13EfterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("data.txt");               // Läser fil i konsollen.
            Console.WriteLine(text);

            string text2 = File.ReadAllText("data2.txt");
            Console.WriteLine(text2);

            Hashtable dataList = new Hashtable();                     // Skapa en hashtable.

            string[] dataLines = text2.Split('\n');                 // Först Dela i Rader. med Split('\n')

            foreach (string data in dataLines)
            {
                  string[] keyValue = data.Split('=');                 // Sen Dela upp där = är. index 0 och index 1.
                  dataList.Add(keyValue[0], keyValue[1]);              // Lägger in den i en hashtable. TADA!
            }

            Console.WriteLine(dataList["age"]);

            List<int> randomNumbers = new List<int>();

            Random rnd = new Random();                                                

            for (int i = 0; i < 10; i++)
            {
                randomNumbers.Add(rnd.Next(1, 10000+1));
            }

            using (StreamWriter sw = new StreamWriter("slumptal.txt", true)) // Spara det genererade int i filen slumptal
            {                      
                int c = 0;
                foreach (int r in randomNumbers)
                {
                    sw.WriteLine("slumptal"+c+"="+r);
                    c++;
                }
            }

          //   Hashtable är en ganska enkel form av bord. Den är snabb.Dictionary är lite mer avancerad men slö.

            Hashtable demoLista = new Hashtable();
            demoLista.Add("VäderFredag", "Soligt med lite moln");
            demoLista.Add("VäderLördag", "Regn med Hagel och KörsbärsSylt");

            Console.WriteLine(demoLista["VäderLördag"]);  // Ange nyckel och få data.
            Console.WriteLine(demoLista["VäderFredag"]);  // Ange nyckel och få data.

        }
    }
}
