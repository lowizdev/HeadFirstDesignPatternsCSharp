using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleIterator
{
    public interface IIterator<T>
    {

        public T getNext();

        public bool hasNext();

    }
}
