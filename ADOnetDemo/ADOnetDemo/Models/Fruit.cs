using System;
using System.Collections.Generic;
using System.Text;

namespace ADOnetDemo.Models
{
    class Fruit
    {

        public int ID { get; set; }
        public string FruitType { get; set; }
        public string FruitName { get; set; }
        public decimal? PricePerKg { get; set; } // här accepterar decimal nullvärden med "?"

        public override string ToString()
        {
            return $" ID: {ID} Frukttyp: {FruitType} Fruktnamn: {FruitName} Pris per Kilo: {PricePerKg}";
        }
    }
}
