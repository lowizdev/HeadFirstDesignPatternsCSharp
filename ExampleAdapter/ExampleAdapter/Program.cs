using System;

namespace ExampleAdapter
{
    class Program
    {
        static void Main(string[] args)
        {

            //THE MAIN WILL BE THE CLIENT, FOR SIMPLICITY

            Console.WriteLine("Testando o banco recente");
            var db1 = new RecentDB();
            db1.create();
            db1.delete();
            db1.update();

            Console.WriteLine("Testando o banco legado adaptado");

            var db2 = new LegacyDBAdapter(new LegacyDB());
            db2.create();
            db2.delete();
            db2.update();


        }
    }
}
