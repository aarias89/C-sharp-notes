using System;
using System.Collections.Generic;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2018,1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(now);
            //datetime objects are immutable 
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            //converting datime to a string

            Console.WriteLine("#####################################");

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            //with format specifiers
            Console.WriteLine(now.ToString("yy-MM-dd HH:mm"));
        }
    }
}

