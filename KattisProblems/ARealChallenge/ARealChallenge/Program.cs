using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARealChallenge

{
    class Program
    {
        static void Main(string[] args)
        {   
            //Using unsigned int since we want to be able to reach 10^18 and doesn't need negative numbers
            ulong a = ulong.Parse(Console.ReadLine());

            if (a >= 1 && a <= Math.Pow(10, 18))
            {
                double length = Math.Sqrt(a) * 4;
                Console.WriteLine(length);
            }
            else
            {
                Console.WriteLine("Error: The number a does not fall into 1<=a<=10^18");
                return;
            }

        }
    }
}