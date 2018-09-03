using System;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            //var name = "Homer Simpson";

            //foreach ( var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            var numbers = new int[] { 1, 2, 3, 4 };

            foreach ( var i in numbers)
            {
                Console.WriteLine("I am number: " + i );
            }

        }
    }
}
