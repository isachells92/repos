using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    interface Ianimal
    {
        void AnimalSound();
    }
    class Pig : Ianimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The pig says: oink ink.");
        }
    }
}
