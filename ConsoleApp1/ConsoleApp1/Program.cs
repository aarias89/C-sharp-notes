using System;
using System.Collections.Generic;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Bilbo Baggins ";
            //Trim
            Console.WriteLine("Trim: '{0}'",fullName.Trim());
            //ToUpper
            Console.WriteLine("ToUpper: '{0}'",fullName.Trim().ToUpper());
            //Split
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0,index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');//var in this instance is an array
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            //Replace
            Console.WriteLine(fullName.Replace("Bilbo", "Froddo"));
            Console.WriteLine(fullName.Replace("g", "G"));

            //Working with Empty Strings or Nulls--- String Validation

            if (String.IsNullOrEmpty(null))// if parameter passed is " " with a space, it will not be empty or null...need to Trim() first. Or use .IsNullOrWhiteSpace()
            {
                Console.WriteLine("It's empty...Invalid");
            }

            //Numbers to Strings and vice verse
            var str = 25;
            var age = Convert.ToByte(str)
                Console.WriteLine("Age: " + age);
            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}

