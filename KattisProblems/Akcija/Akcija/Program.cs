using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akcija

{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Collect input N, amount of books from the user
            int n = int.Parse(Console.ReadLine());
            int[] C = new int[n];

            //Collects the price for each book from the user
            for (int i = 0; i < n; i++)
                C[i] = int.Parse(Console.ReadLine());

            Console.WriteLine(MinPrice(n, C));
        }

        static int MinPrice(int n, int[] prices)
        {
            //Sorting the prices
            Array.Sort(prices);
            //Reversing the array making the prices descend in value
            Array.Reverse(prices);

            int totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                //Add the 2 most expensive books per group of 3 (It skips the 3rd)
                if (i % 3 != 2)
                {
                    totalPrice += prices[i];
                }
            }
            return totalPrice;

        }
    }
}