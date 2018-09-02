using System;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {

            var firstName = "Frodo";
            //C#
            string lastName = "Baggins";
            int j;
            //.Net Framework
            String home = "Shire";
            Int32 i;

            var fullName = firstName + " " + lastName;
            //string format
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            //string join
            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            //verbatims strings
            //var text = "Hi John\n look into the following path \n c:\\projects\\project1\\folder";
            var text = @"Hi John
look into the following path
c:\projects\project1\folder";
            Console.WriteLine(text);



        }
    }
}
