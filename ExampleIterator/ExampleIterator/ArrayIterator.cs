using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleIterator
{
    public class ArrayIterator<T> : IIterator<T>
    {
        private T[] _collection = null;

        private int _current = 0;

        public ArrayIterator(T[] collection)
        {

            this._collection = collection;
            this._current = 0;

        }
        public T getNext()
        {

            T item = _collection[this._current];
            this._current += 1;

            return item;

        }

        public bool hasNext()
        {
            return (this._current < this._collection.Length) && (this._collection[this._current + 1] != null);
        }
    }
}
