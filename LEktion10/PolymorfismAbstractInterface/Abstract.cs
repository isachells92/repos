using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{


    abstract class Animal
    {
    // Abstract Method does not have a body
    abstract public void AnimalSound();

        //Regular Method
        public void Sleep()
        {
            Console.WriteLine("ZzzzzZzzz");
        }

    }
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Grisen säger nöff: nöff");
        }
    }
}
