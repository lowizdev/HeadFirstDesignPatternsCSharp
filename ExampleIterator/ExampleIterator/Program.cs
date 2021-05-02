using System;
using System.Collections.Generic;

namespace ExampleIterator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> lsStr1 = new List<string> { "test1", "test2", "test3", "test4"};

            ListIterator<String> iterator1 = new ListIterator<String>(lsStr1);

            Console.WriteLine(iterator1.getNext());
            Console.WriteLine(iterator1.getNext());
            Console.WriteLine(iterator1.getNext());
            Console.WriteLine(iterator1.hasNext());
            Console.WriteLine(iterator1.getNext());
            Console.WriteLine(iterator1.hasNext());

            String[] arrStr1 = {"test1", "test2"};

            ArrayIterator<String> iterator2 = new ArrayIterator<String>(arrStr1);

            Console.WriteLine(iterator2.getNext());
            Console.WriteLine(iterator2.getNext());
            Console.WriteLine(iterator2.hasNext());

        }
    }
}
