using System;


namespace ConsoleApp1
{



    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a number between 1 to 10: ");
            //var input = Console.ReadLine();
            //var number = Convert.ToInt32(input);
            //if (number >= 1 && number <= 10)
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("Invalid");

            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }

        }
    }
}
