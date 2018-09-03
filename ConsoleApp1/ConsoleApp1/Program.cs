using System;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            //var i = 0;
            //while (i<=10)
            //{
            //    if(i % 2 == 0)
            //        Console.WriteLine(i);
            //    i++;
            //}

            string input = null;
            while (input != "quit")
            {
                Console.Write("Type your name: ");
                input = Console.ReadLine();
                Console.WriteLine("@Echo: " + input);

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("You need to type your name or type quit");
                }

            }

        }
    }
}

