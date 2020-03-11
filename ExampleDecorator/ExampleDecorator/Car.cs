using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleDecorator
{
    abstract class Car
    {

        protected string model = "any model";
        protected double price = 0;

        public abstract double getPrice();

        public abstract string getModel();

    }

    abstract class Decorator : Car {

        protected Car decoratedCar;

        public Decorator(Car decoratedCarInst) {

            this.decoratedCar = decoratedCarInst;
        
        }

    }

    class Tuner : Car {

        public Tuner() {

            this.model = "A Tuner car";
            this.price = 4000;
        
        }

        public override string getModel()
        {
            return this.model;
        }


        public override double getPrice() {

            return this.price;
        
        }

    }

    class Muscle : Car
    {

        public Muscle()
        {

            this.model = "A Muscle car";
            this.price = 3000;

        }

        public override string getModel()
        {
            return this.model;
        }

        public override double getPrice()
        {

            return this.price;

        }

    }

    class DecoratorWithSpoiler : Decorator {

        protected double spoilerPrice = 80;

        public DecoratorWithSpoiler(Car decoratedCarInst): base(decoratedCarInst)
        {
            
        }

        public override string getModel() {

            return base.decoratedCar.getModel() + " with spoilers ";

        }

        public override double getPrice()
        {
            return base.decoratedCar.getPrice() + this.spoilerPrice;
        }


    }

    class DecoratorWithNitrous : Decorator
    {

        protected double nitrousPrice = 500;

        public DecoratorWithNitrous(Car decoratedCarInst) : base(decoratedCarInst)
        {

        }

        public override string getModel()
        {

            return base.decoratedCar.getModel() + " with braia's nitrous ";

        }

        public override double getPrice()
        {
            return base.decoratedCar.getPrice() + this.nitrousPrice;
        }


    }



}
