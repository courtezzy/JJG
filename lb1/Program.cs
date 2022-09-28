using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sec = 0;
            Console.WriteLine("sec: ");
            sec = Int32.Parse(Console.ReadLine());
            int minutes = sec / 60;
            int newSec = sec - minutes * 60;
            int hour = minutes / 60;
            int newMinnutes = minutes - hour * 60;
            TimeSpan time = new TimeSpan(hour, newMinnutes, newSec);
            Console.WriteLine("{0} its {1}", sec, time);
            Console.ReadLine();

        }

    } 

}
