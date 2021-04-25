using System;

namespace ExampleTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminUserCreator a1 = new AdminUserCreator();
            StandardUserCreator s1 = new StandardUserCreator();


            Console.WriteLine(a1.createUser("Test Admin User 1"));
            Console.WriteLine(s1.createUser("Test Standard User 1"));
            Console.WriteLine(s1.createUser("Test Standard User 2"));
            
            
        }
    }
}
