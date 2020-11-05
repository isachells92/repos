using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion_8
{
    class Car
    {           
        public string Model { get; set; }
        public int Year { get; set; }

        public int Age { get; set; }

        public Car()
        {

        }

        public Car(string model, int year)
        {
            Model = model;
            Year = year;
            Age = DateTime.Now.Year - year;
        }
    }
}
