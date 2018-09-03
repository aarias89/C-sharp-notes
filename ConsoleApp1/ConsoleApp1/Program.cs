using System;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Length
            //Indexof 
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 is : " + index);

            //Clear
            Array.Clear(numbers, 3, 2);
            Console.WriteLine("Effects of Clear()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


            //Copy
            int[] another = new int[3];
            Array.Copy(numbers,another,3);
            Console.WriteLine("Effects of Copy() : ");
            foreach (int i in another)
            { Console.WriteLine(i); }

            //Sort 
            Array.Sort(numbers);
            Console.WriteLine("Effects of Sort()");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //Reverse
            Array.Reverse(numbers);
            Console.WriteLine("Effects of Reverse()");
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }


        }
    }
}

