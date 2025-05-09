
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASecondOpinion

{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Convert seconds into this format hour : min : sec");
            //Console.WriteLine("Please enter a number between 0 and 1 000 000");
            int seconds = int.Parse(Console.ReadLine());
            int hour = 3600;
            int minute = 60;

            //Since C# is rounding down we can write this and get hours
            int h = seconds / hour;
            //remaining seconds from rounding down hours
            int restS = seconds % hour;
            //Converting the remaining seconds into minutes (from dividing the hours)
            int m = restS / minute;
            //rest of the seconds
            int s = restS % minute;

            Console.WriteLine(h + " : " + m + " : " + s);

        }
    }
}