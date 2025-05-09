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
            string nk = Console.ReadLine();
            string[] nkSplit = nk.Split(" ");
            ulong n = ulong.Parse(nkSplit[0]);
            ulong k = ulong.Parse(nkSplit[1]);
        }
    }
}