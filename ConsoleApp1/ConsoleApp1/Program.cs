using System;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            //this method is used for creating random numbers
            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //    Console.WriteLine(random.Next(1,20));

            //one can also create random "passwords" or set of characters using ASCII values by casting the values to char type
            const int passwordLength = 10;
            var random = new Random();
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                //97 and 122 are ASCII values of a and z
                //Console.Write((char)random.Next(97,122));
                buffer[i] = (char)random.Next(97,122);
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}

//strings are immutable in c# so to work around this we can create an array to save the characters or letters...since arrays are mutable.
