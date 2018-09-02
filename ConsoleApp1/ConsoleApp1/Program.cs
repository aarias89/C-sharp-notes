using System;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new[3];
            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
         
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            //default initialization for int type is 0
            Console.WriteLine(numbers[2]);

            //default initialization for bool type is false
            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            //object initialization syntax
            var names = new string[3] { "Jack","John","Mary" };

        }
    }
}
