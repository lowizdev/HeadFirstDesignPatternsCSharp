using System;
using System.Collections.Generic;

namespace ExampleCommand
{

    class FakeUI
    {

        //Receiver
        public FakeUI()
        {

        }

        public void render() {

            Console.WriteLine("Im rendering");

        }
    }

    class Invoker 
    {
        public Command start = null;
        public Command finish = null;

        public List<Command> history = new List<Command>();

        public void run() 
        {

            Console.WriteLine("Started");

            if(this.start != null){
                this.start.execute();
                history.Add(this.start);
            }

            Console.WriteLine("Finished");

            if (this.finish != null)
            {
                this.finish.execute();
                history.Add(this.finish);
            }

        }

        

        
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Client call

            FakeUI f1 = new FakeUI();
            CommandSave cs1 = new CommandSave(f1, "some argument");
            CommandSaveShortcut css1 = new CommandSaveShortcut(f1, "some other argument");

            Invoker inv1 = new Invoker();

            inv1.start = cs1;

            inv1.run();

            inv1.start = css1;
            inv1.run();

            //other test
            FakeUI f2 = new FakeUI();
            Console.WriteLine(f2.GetHashCode());

        }
    }
}
