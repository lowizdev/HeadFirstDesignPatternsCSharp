using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleFactoryMethod
{
    abstract class Soldier
    {
        public String weapon { get; set; }
        public int age { get; set; }

        public double salary { get; set; }

        public void signUp() {

            Console.WriteLine("Signing up!");

        }

        public abstract void equip();


    }

    class SimpleSoldier : Soldier {

        public SimpleSoldier() {

            this.salary = this.salary * 0.95;

        }

        public override void equip()
        {
            Console.WriteLine("Simple equipment!");
        }

    }

    class EliteSoldier : Soldier {

        public EliteSoldier() {

            this.salary = this.salary * 1.05;

        }

        public override void equip() {

            Console.WriteLine("With Elite equipment!");
        }

    }

    abstract class Barracks {

        public Soldier trainSoldier(String soldierLevel) {

            Soldier s1 = this.createSoldier(soldierLevel);

            s1.signUp();
            s1.equip();

            return s1;
        
        }

        public abstract Soldier createSoldier(String level);
    
    }

    class GuardBarracks: Barracks {

        public override Soldier createSoldier(String level) {
            Soldier soldier = null;

            if (level == "Elite")
            {
                soldier = new EliteSoldier();
            }
            else if (level == "Simple")
            {

               soldier = new SimpleSoldier();
            }

            soldier.weapon = "Pike";
            soldier.age = 30;
            soldier.salary = 10;

            return soldier;

        }

    }

    class StrategyBarracks : Barracks
    {

        public override Soldier createSoldier(String level)
        {

            Soldier soldier = null;

            if (level == "Elite")
            {
                soldier = new EliteSoldier();
            }
            else if (level == "Simple")
            {

                soldier = new SimpleSoldier();
            }

            soldier.weapon = "Dagger";
            soldier.age = 40;
            soldier.salary = 20;

            return soldier;

        }

    }
}
