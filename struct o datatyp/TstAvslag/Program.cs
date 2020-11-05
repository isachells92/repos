using System;

namespace TstAvslag
{
    class Program
    {
        static void Main(string[] args)
        {
            User userOne = default;
            userOne.Name = "Musse Pigg";
            userOne.Location = "Ankeborg";
            userOne.Age = 91;

            Console.WriteLine($"{userOne.Name} bor i {userOne.Location} och är {userOne.Age} år gammal");

            // Alternitivly
            User userTwo = default;
            userTwo.Name = "Långben";
            userTwo.Location = "Ankeborg";
            userTwo.Age = 88;

            Console.WriteLine($"{userOne.Name} bor i {userOne.Location} och är {userOne.Age} år gammal");

            // Declared variable using the new Keyword, that is calling the Constructor.
            SpecialUser userThree = new SpecialUser("Stockholm", 31); 
            Console.WriteLine($"Name: {SpecialUser.Name}, Location:{userThree.Location}, Age: {userThree.Age}");



           // Declared variable Without using the new Keyword.                    ((Very nice))
            SpecialUser userFour = new SpecialUser() { Location = "Göteborg", Age = 32 };
            userFour.Location = "Göteborg";
            userFour.Age = 32;

            
            // Declared variable Without using the new Keyword.       (( USING DEFAULT )) 
            SpecialUser userFive = default;
            userFive.Location = "Edinbourgh";
            userFive.Age = 28;
            Console.WriteLine($"Name: {SpecialUser.Name}, Location:{userFive.Location}, Age: {userFive.Age}");
        }
    }
}
