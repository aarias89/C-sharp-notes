﻿using System;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName );
        }
    }
}
