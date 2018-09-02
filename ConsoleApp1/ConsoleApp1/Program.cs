using System;


namespace ConsoleApp1
{
    public class Person
    {
        public int Age;
    }


    class Program
    {
        static void Main(string[] args)
        {
            //value types. On the stackm these two variables are completly independent from each other.
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0}, b:{1}",a,b));

            //reference types.Arrays are a class. so its a reference type
            //when we initalize the array, the object is created on the heap with a specific memory location, not the stack.
            //when we make changes to array1 or array2, the value is changed in the heap and affects the values of both arrays on the stack.
            var array1 = new int[3] { 1, 2, 3, };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]:{0}, array2[0]: {1}",array1[0],array2[0]));


            var number = 1;
            Increment(number);
            //number is declared in 2 different scopes, so it has 2 different locations in memory.
            Console.WriteLine(number);


            var person = new Person() { Age = 20 };
            //the reference from the Makeold person will be copied. So both person objects in main method and MakeOld method reference the same object on the heap.
            MakeOld(person);
            Console.WriteLine(person.Age);

        }
        //return type for both of these methods is void, which means they dont return any values.
        //methods defined as static so there they can be called without the need to create an object.
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
