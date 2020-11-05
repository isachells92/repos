using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Standard
{
    class Animal // Base class (Parent)
    {
        public void AnimalSound()
        {
            WriteLine("Djuret låter");
        }
    }
    class Pig : Animal  // Derived class (Child)
    {
        public void AnimalSound()
        {
            WriteLine("The pig says: Oink oink!");
        }
    }
    class Dog : Animal  // Derived class (Child)
    {
        public void AnimalSound()
        {
            WriteLine("The dog says: Bark bark!");
        }
    }


}
