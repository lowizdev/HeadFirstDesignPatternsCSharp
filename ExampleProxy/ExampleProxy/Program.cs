using System;

namespace ExampleProxy
{
    class Program
    {
        static void Main(string[] args)
        {

            FakeDBAccess f1 = new FakeDBAccess();

            Console.WriteLine(f1.getSingle());
            Console.WriteLine(f1.getAll()[0] + f1.getAll()[1]);

            DBCacheProxy dbc1 = new DBCacheProxy(f1);

            Console.WriteLine(dbc1.getAll()[1]);
            Console.WriteLine("SECOND RUN FROM PROXY");
            Console.WriteLine(dbc1.getAll()[1]);

        }
    }
}
