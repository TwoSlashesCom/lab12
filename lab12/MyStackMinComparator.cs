using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class MyStackMinComparator<T, U> : Stack<T> where U : IComparer<T>
    {
        private T[] mins;
        private U comparer;
        public MyStackMinComparator(U c) : base()
        {
            this.mins = new T[n];
            comparer = c;
        }
        public override void Push(T item)
        {
            base.Push(item);
            if (count < 2)
                mins[count - 1] = item;
            else
                mins[count - 1] = (comparer.Compare(item, mins[count - 2]) > 0 ? item : mins[count - 2]);
        }
        public T GetMin
        {
            get
            {
                if (IsEmpty) throw new InvalidOperationException();
                return mins[count - 1];
            }
        }
    }
}
