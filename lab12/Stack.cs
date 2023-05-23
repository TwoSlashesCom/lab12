using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    public class Stack <T>
    {
        private T[] items;
        public int count;
        public const int n = 10;

        public Stack()
        {
            items = new T[n];
        }
        public Stack(int length)
        {
            items = new T[length];
        }
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public int Count
        {
            get { return count; }
        }

        public virtual void Push(T item) 
        {
            if (count == items.Length)
            {
                Resize(items.Length + 10);
            }
            items[count++] = item;
        }

        public T Pop() 
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            T item = items[--count];
            return item;
        }

        public T Peek() 
        {
            return items[count - 1];
        }
        public virtual void Resize(int max)
        {
            T[] tempItems = new T[max];
            for (int i = 0; i < count; i++)
                tempItems[i] = items[i];
            items = tempItems;
        }

        public override string? ToString()
        {
            return string.Join(", ", items.Take(count - 1));
        }
    }
}
