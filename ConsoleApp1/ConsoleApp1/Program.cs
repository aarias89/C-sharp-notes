using ConsoleApp1.Math;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Person Frodo = new Person();
            var Frodo = new Person();
            Frodo.FirstName = "Frodo";
            Frodo.LastName = "Baggins";
            Frodo.Introduce();

            //to avoid intstantiating a class like calculator, use static keyword (public static int Add)
            Calculator calculator = new Calculator();
            var result = calculator.Add(5, 6);
            System.Console.WriteLine(result);
        }
    }
}
