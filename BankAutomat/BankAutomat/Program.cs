using System;
using System.ComponentModel.Design;

namespace BankAutomat
{    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            BankomaticRun();

        }

        public static void BankomaticRun()
        {

            int balance = 0;
            Console.Write("Swedbank 1.0 vad vill du göra? ");
            string input = Console.ReadLine();
            

            Console.WriteLine("[I]nsättning \n [U]ttag \n [S]aldo \n [A]vsluta");
            Console.ReadLine();

            switch (input.ToLower())
            {
                case "i":
                    Deposit();
                    break;
                case "u":
                    Withdraw();
                    break;
                case "n":
                    Balance();
                    break;
                case "a":
                    Exit();
                    break;
                default:
                    Console.Write("Wrong input, please try again...");
                    break;
            }
        }

        private static void Exit()
        {
            Console.WriteLine("Exiting.. press any key to continue. ");
            menu = false;
        }

        private static void Balance()
        {
            Console.WriteLine($"your balance is: {balance}");
        }

        public static void Withdraw()
        {
            Console.WriteLine("Hur mycket vill du ta ut? ");
            int depositInput = int.Parse(Console.ReadLine());
            balance -= depositInput;
            
        }

        public static void Deposit()
        {
            Console.WriteLine("Hur mycket vill du sätta in? ");
            int depositInput = int.Parse(Console.ReadLine());
            balance += depositInput;
        }
    }
}
