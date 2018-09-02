using System;


namespace ConsoleApp1
{
    public enum ShippingMethod
    {
        //best practice to set values to the enums, sometimes in databases you might have a table that represents the enum with the corresponding value. 
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }


    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method);
            Console.WriteLine((int)method);
            //assume you receive the number 3 from an outside source and you want to convert it to a shipping method.
            var methodId = 3;
            //in here you are using Explicit type conversion (casting)
            Console.WriteLine((ShippingMethod)methodId);

            //Converting the Enum's key to a string
            var method2 = ShippingMethod.Express;
            Console.WriteLine(method2.ToString());

            //Convert string into an Enum
            var methodName = "Express";
            //use parsing, conver the string into another type( use casting)
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            

        }
    }
}
