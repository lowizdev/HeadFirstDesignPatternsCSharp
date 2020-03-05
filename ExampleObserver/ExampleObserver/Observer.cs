using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleObserver
{

    public interface IObserver {

        public void update(int val);
    
    }
    class ObserverAddFive : IObserver
    {

        public void update(int val) {

            Console.WriteLine("From addfive: " + this.addFive(val));

        }

        public int addFive(int num) {

            return num + 5;

        }

    }

    class ObserverAddTwo : IObserver
    {

        public void update(int val)
        {

            Console.WriteLine("From addtwo: " + this.addTwo(val));

        }

        public int addTwo(int num)
        {

            return num + 2;

        }

    }
}
