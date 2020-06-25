using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleSingleton
{
    class SingleRandomSingleton
    {

        static SingleRandomSingleton singleton = null;

        public int number { get; set; }

        private SingleRandomSingleton() {
            var rdm = new Random();
            this.number = rdm.Next(1000);
        }

        public static SingleRandomSingleton getSingleRandomSingleton() {

            if (singleton == null) {

                singleton = new SingleRandomSingleton();

            }

            return singleton;

        }

        

    }
}
