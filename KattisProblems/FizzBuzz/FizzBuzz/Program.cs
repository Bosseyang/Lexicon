using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Please enter X, Y and N in the following format: (X Y N) ");
            //Initialize and assign the string array with our user input
            string[] input = Console.ReadLine().Split(' ');
            
            // Parsing each string input to int and declaring for each respective variable
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int n = int.Parse(input[2]);

            //Conditioning for (1<=X<Y<=N<=100), exit the program if this condition is broken
            if (x < 1 || x >= y || y > n || n > 100)
            {
                Console.WriteLine("Error: (X Y N) must follow this condition: (1<=X<Y<=N<=100)");
                return;
            }

            Console.WriteLine(" ");
            //We want to loop from 1 to n
            for (int i = 1; i <= n; i++) 
            {
                //We are using the modulus operator to check for dividability
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    
                }
                else if (i % x == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                    Console.WriteLine(i);

            }
           
        }

    }
}