using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCommand
{
    interface Command
    {
        public void execute();
    }

    class CommandSave : Command
    {

        private FakeUI dest;
        private string argument;

        public CommandSave(FakeUI dest, string argument)
        {
            this.dest = dest;
            this.argument = argument;
        }
        public void execute() {
            Console.WriteLine("Im the save command, should be a receiver");
            Console.WriteLine(this.dest.GetHashCode());
        }

    }

    class CommandSaveShortcut : Command {

        private FakeUI dest;
        private string argument;


        public CommandSaveShortcut(FakeUI dest, string argument)
        {
            this.dest = dest;
            this.argument = argument;
        }
        public void execute() {
            Console.WriteLine("Im the save command too, should be a receiver, but called from a shortcut");
            Console.WriteLine(this.dest.GetHashCode());
        }

    }


    class CommandDelete : Command {


        public void execute() {
        
        }

    }
}
