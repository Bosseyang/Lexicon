using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            int[] sequenceMatch = new int[n];
            int[] output = new int[n];
            if (n < 1 && n > 100)
                return;
            

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
                if (number[i] < 1 && number[i] > 200)
                    return;
                sequenceMatch[i] = number[0] + 1;
                if (sequenceMatch[i] != number[i])
                    output[i] = number[i];
                else
                    Console.WriteLine("good job");
                

            }
            
        }
    }
}