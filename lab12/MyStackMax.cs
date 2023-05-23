using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class MyStackMax<T> : Stack<T> where T : IComparable<T>
    {
        private T[] maxs;
        public MyStackMax() : base() 
        { 
            this.maxs = new T[n];
        }

        public MyStackMax(int lenght) : base(lenght) 
        { 
            this.maxs = new T[lenght];
        }

        public override void Resize(int lenght)
        {
            base.Resize(lenght);
            T[] newmaxs = new T[lenght];
            Array.Copy(maxs, newmaxs, count);
            maxs = newmaxs;
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
                maxs[count-1] = item.CompareTo(maxs[count-2]) > 0 ? item : maxs[count-2];
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
