using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();// you can specify a starting string
            //Append
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            //Replace
            builder.Replace('-', '+');

            //Remove
            builder.Remove(0, 10);// start at index 0 and remove 10 chars

            //Insert
            builder.Insert(0, new string('-', 10));


            Console.WriteLine(builder);

        }
    }
}

