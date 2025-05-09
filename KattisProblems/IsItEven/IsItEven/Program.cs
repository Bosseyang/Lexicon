using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItEven
{
    class Program
    {
        static void Main(string[] args)
        {

            string nk = Console.ReadLine();
            string[] nkSplit = nk.Split(" ");
            int n = int.Parse(nkSplit[0]);
            ulong k = ulong.Parse(nkSplit[1]);
            //Terminate program if n, k doesn't follow the boundaries
            if (n < 1 || n > 100000 || k < 0 || k > 1000)
                return;

            /* Does not work for large numbers, not enough precision and accuracy
            double[] xArray = new double[n];
            double xProd = 1;
            double sq = Math.Pow(2, k);
            for (int i = 0; i < n; i++) 
            { 
                xArray[i] = ulong.Parse(Console.ReadLine());
                xProd *= xArray[i];
            }
            if ((xProd % sq) == 0)
                Console.WriteLine("1");
            else 
                Console.WriteLine("0");
            */

            //Approach with counting the base 2 instead
            ulong twos = 0;
            for (int i = 0; i < n; i++)
            {
                ulong input = ulong.Parse(Console.ReadLine());
                while (input % 2 == 0 && input>0) 
                {
                    //Iterate twos for every time we divide
                    twos++;
                    //divide with two for each iteration
                    input /= 2;
                }
            }
            //Check if it's divisible through the base of 2.
            if (twos >= k)
            {
                Console.WriteLine("1");
            }
            else 
                Console.WriteLine("0");
        }
    }
}