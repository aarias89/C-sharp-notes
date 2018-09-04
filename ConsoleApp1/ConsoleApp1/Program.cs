using System;
using System.Collections.Generic;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            //creating 
            var timeSpan = new TimeSpan(1,2,3);//1 hr 2min 3 secs

            var timeSpan1 = new TimeSpan(1, 0, 0);

            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " +  timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " +  timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

            //subtract 
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //Conversion to and from string

            Console.WriteLine("ToString: " +  timeSpan.ToString());

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));


        }
    }
}

