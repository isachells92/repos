using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Car
    {
         public string RegNr;
         public string Tillverkare;  // private -  når bara i klassen.
         public int Tillverkarningsår; // public når överallt.
        public void PrintCarValues()
        {
            DoAdvancedRegulatorStuff(); // här kommer vi åt den, för att vi är i klassen. men inte i program.
            int x = 19;
            Console.WriteLine(Tillverkare);

        }
        private void DoAdvancedRegulatorStuff()
        {
            // när den är private, kommer den inte upp.
            // 
            // MAN KOMMER ÅT DEN INNUTI KLASSEN MEN INTE UTANFÖR.
        }
    }
}
