using System;

namespace ExampleDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Car c1 = new Tuner();
            Car c2 = new Muscle();

            Console.WriteLine(c1.getModel());
            Console.WriteLine(c1.getPrice());

            Console.WriteLine(c2.getModel());
            Console.WriteLine(c2.getPrice());

            Decorator d1 = new DecoratorWithSpoiler(c1);
            Decorator d2 = new DecoratorWithSpoiler(c2);

            Decorator d3 = new DecoratorWithNitrous(d1);


            Console.WriteLine(d3.getModel());
            Console.WriteLine(d3.getPrice());

            Console.WriteLine(d2.getModel());
            Console.WriteLine(d2.getPrice());

            Console.ReadLine();
        }
    }
}
