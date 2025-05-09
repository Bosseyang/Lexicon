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
            int[] checkDigit = {4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };
            string cpr = Console.ReadLine();
            int[] cprInt = new int[checkDigit.Length];
            //check if the cpr is in the right format
            if (cpr[6].ToString() != "-")
                return;
            //Removing the "-" to later parse into int
            cpr = cpr.Remove(6,1);
            
            int[] validateCpr = new int[checkDigit.Length];

            for (int i = 0; i < checkDigit.Length; i++)
            {
                //Parsing the string values of array cpr into int
                cprInt[i] = int.Parse(cpr[i].ToString());
                validateCpr[i] = checkDigit[i] * cprInt[i];
            }
            
            
            if(validateCpr.Sum() % 11 == 0)
                Console.WriteLine("1");
            else 
                Console.WriteLine("0");
            
        }
    }
}