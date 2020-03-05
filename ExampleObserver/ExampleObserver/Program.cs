using System;

namespace ExampleObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            ObservableNumber numberManager = new ObservableNumber();

            numberManager.setVal(10);

            ObserverAddFive ob1 = new ObserverAddFive();
            ObserverAddFive ob2 = new ObserverAddFive();
            ObserverAddTwo ob3 = new ObserverAddTwo();

            numberManager.registerObserver(ob1);
            numberManager.registerObserver(ob2);
            numberManager.registerObserver(ob3);

            numberManager.setVal(30);

            numberManager.removeObserver(ob3);

            numberManager.setVal(50);

            Console.WriteLine("END");

            Console.ReadLine();

        }
    }
}
