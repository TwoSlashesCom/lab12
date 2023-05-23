using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class MyStackMaxComparator<T, U> : Stack<T> where U : IComparer<T>
    {
        private T[] maxs;
        private U comparer;

        public MyStackMaxComparator(U c) : base()
        {
            this.maxs = new T[n];
            comparer = c;
        }

        public override void Push(T item)
        {
            base.Push(item);
            if (count < 2)
            {
                maxs[count-1] = item;
            }
            else
            {
                maxs[count-1] = comparer.Compare(item, maxs[count-2]) > 0 ? item : maxs[count-2];
            }
        }

        public T GetMax
        {
            get
            {
                if (IsEmpty) throw new InvalidOperationException();
                return maxs[count-1];
            }
        }
    }
}
