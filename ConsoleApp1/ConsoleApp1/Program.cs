using System;
using System.Collections.Generic;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,12,2,3,4 };
            numbers.Add(9);
            numbers.AddRange(new int[3] { 11,12,13 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //IndexOf

            Console.WriteLine("index of 12 : " + numbers.IndexOf(12)); 
            Console.WriteLine("last index of 12 : " + numbers.LastIndexOf(12));


            Console.WriteLine("Count: " + numbers.Count);


            //Remove

            numbers.Remove(12);
            Console.WriteLine("Effecs of Remove()");
            foreach (var number in numbers)
            {
                //it only removes the first instance of the paramater passed to the Remove method.
                Console.WriteLine(number);
            }
        //to remove all instances...use for loop...foreach loops will throw error
           for (var i =0; i < numbers.Count; i ++)
            {
                if (numbers[i] == 12)
                    numbers.Remove(numbers[i]);
            }

            //Clear()
            numbers.Clear();
           Console.WriteLine(numbers.Count);


        }
    }
}

