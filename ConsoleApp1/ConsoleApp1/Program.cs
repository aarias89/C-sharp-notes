using System;


namespace ConsoleApp1
{



    class Program
    {
        static void Main(string[] args)
        {
            //int hour = 10;

            //if (hour > 0 && hour <12)
            //{
            //    Console.WriteLine("it's morning");
            //}
            //else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("It's afternoon");
            //}
            //else
            //{
            //    Console.WriteLine("It's evening");
            //}


            //bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);


            var season = Season.Autumn;

            switch (season)
            {

                //having these 2 cases stacked like this (Autumn and Summer) will make them share the same block of code("I love this season")
                //case Season.Autumn:
                //case Season.Summer:
                //    Console.WriteLine("I love this season!");
                //    break;
                case Season.Autumn:
                    Console.WriteLine("It's Autumn and a beautiful season");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer and its a hot season");
                    break;
                case Season.Spring:
                    Console.WriteLine("It's Spring and its a season full of pollen");
                    break;
                default:
                    Console.WriteLine("This season is too cold to even mention");
                    break;
            }
      

        }
    }
}
