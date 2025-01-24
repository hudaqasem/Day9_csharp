using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9.Classes
{
    internal class GStack<T>
    {
        private T[] items;
        private int top;

        public GStack(int sz)
        {
            items = new T[sz];
            top = -1;
        }

        public void Push(T ele)
        {
            items[++top] = ele;
        }

        public T Peek()
        {
            return items[top] ;
        }

        public T Pop()
        {
            return items[top--];
        }

    }
}
