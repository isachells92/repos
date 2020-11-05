using System;

namespace DelagatesAction
{
    class Program
    {
        static void Accelerate()
        {
            Console.WriteLine("Hejdå Hejdå");
        }
        static void Deccelerate()
        {
            Console.WriteLine("Hej hej");
        }
        public static void Main(string[] args)
        {

            // Tilldela variabeln a av typen Action<string> metoden MyParameterAction.
            Action<string> a = MyParameterAction;

            // Anropa metoden som variabeln a tilldelats.
            a("ITHS Rules!");
            MyParameterAction("Hejsan alla elever");


            Action carAction = Accelerate;
            carAction = Deccelerate;
       
            carAction();
        }
        static void MyParameterAction(string s)
        {
            Console.WriteLine(s);
        }

    }
}
