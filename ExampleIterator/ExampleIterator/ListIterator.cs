using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleIterator
{
    public class ListIterator<T> : IIterator<T>
    {
        private List<T> _collection = null;
        private int _current = 0;

        public ListIterator(List<T> collection)
        {
            this._collection = collection;
            this._current = 0;
        }

        public T getNext()
        {
            T item = this._collection[this._current];

            this._current += 1;

            return item;
        }

        public bool hasNext()
        {
            return this._current < this._collection.Count;
        }
    }
}
