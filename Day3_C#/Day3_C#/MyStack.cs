using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_
{
    public class MyStack<T>
    {
        private List<T> _items = new List<T>();

        public int Count()
        {
            return _items.Count;
        }

        public void Push(T item)
        {
            _items.Add(item);
        }

        public T Pop()
        {

            var lastIndex = _items.Count - 1;
            T item = _items[lastIndex];
            _items.RemoveAt(lastIndex);
            return item;
        }
    }
}
