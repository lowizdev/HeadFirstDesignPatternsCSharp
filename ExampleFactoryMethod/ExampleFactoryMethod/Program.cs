using System;


namespace ExampleFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            GuardBarracks g1 = new GuardBarracks();
            StrategyBarracks st1 = new StrategyBarracks();

            Soldier s1 = g1.trainSoldier("Elite");
            Soldier s2 = st1.trainSoldier("Simple");

        }
    }
}
