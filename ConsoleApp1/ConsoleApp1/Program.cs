using System;

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

    class Program
    {
        static void Main(string[] args)
        {
            //Person Frodo = new Person();
            var Frodo = new Person();
            Frodo.FirstName = "Frodo";
            Frodo.LastName = "Baggins";
            Frodo.Introduce();

        }
    }
}
