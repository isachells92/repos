using System;

namespace Lektion14
{
    class Program
    {
        public static void Main(string[] args)
        {
            I_Take_A_Delegate(HelloWorldMethod);

            /* När vi anropar metoden "I_Take_A_Delegate" tilldelar vi dess
            * Action parameter "a" metoden HelloWorldMethod. Detta är i
            * grunden samma sak som att tilldela en variabel av typen
            * Action metoden HelloWorldMethod. Exempelvis:
            *
            * Action a = HelloWorldMethod; */
        }

        static void I_Take_A_Delegate(Action a)
        {
            Console.WriteLine("Time to call the method in parameter 'a'");
            a();
        }

        static void HelloWorldMethod()
        {
            Console.WriteLine("Hello Academy!");
        }
    }
}
