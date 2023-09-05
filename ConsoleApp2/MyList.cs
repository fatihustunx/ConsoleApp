using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MyList<T>
    {
        T[] items;

        public int Length { get { return items.Length; } }

        public T[] Items { get { return items; } }

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] temp = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                items[i] = temp[i];
            }

            items[items.Length - 1] = item;
        }
    }
}