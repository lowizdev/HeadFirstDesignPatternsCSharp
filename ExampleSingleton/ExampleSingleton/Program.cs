using System;

namespace ExampleSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var randomSingleton = SingleRandomSingleton.getSingleRandomSingleton();

            Console.WriteLine(randomSingleton.number);

            var anotherRandomSingleton  = SingleRandomSingleton.getSingleRandomSingleton();

            Console.WriteLine(anotherRandomSingleton.number);
        }
    }
}
