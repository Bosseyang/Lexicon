﻿namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a new car!";
            //Console.WriteLine(message
            else if (userValue == "2")
                message = "You won a new boat!";
            //Console.WriteLine(message);
            else if (userValue == "3")
                message = "You won a new cat!";
            //Console.WriteLine(message);
            else { 
                message = "Sorry, we didin't understand.";
                //message = message + "You lose.";
                //Console.WriteLine(message);
                message += "You lose.";
            }
            
            Console.WriteLine(message);
                Console.ReadLine();
            */



            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");
            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);
            Console.ReadLine();

        }
    }
}