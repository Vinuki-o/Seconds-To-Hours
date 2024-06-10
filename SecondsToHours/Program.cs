using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsToHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter the time in seconds: ");
            int seconds =Convert.ToInt32(Console.ReadLine());

            int hours = seconds / 3600;
            int minutes = (seconds % 3600)/60;
            int RemainSeconds = seconds % 60;

            Console.WriteLine(seconds + "Seconds is " + hours  + "hours, " + minutes  + "minutes, " + RemainSeconds  + "seconds.");

        }
    }
}
