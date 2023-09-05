using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MyDictionary<T, U>
    {
        public T[] Key { get; set; }
        public U[] Value { get; set; }

        public MyDictionary()
        {
            Key = new T[0];
            Value = new U[0];
        }

        public void Add(T key, U value)
        {
            T[] tempT = Key;
            U[] tempU = Value;

            Key = new T[Key.Length + 1];
            Value = new U[Value.Length + 1];

            for (int i = 0; i < tempT.Length; i++)
            {
                Key[i] = tempT[i];
            }

            for (int i = 0; i < tempU.Length; i++)
            {
                Value[i] = tempU[i];
            }

            Key[Key.Length - 1] = key;
            Value[Value.Length - 1] = value;
        }

        public int CountKey
        {
            get { return Key.Length; }

        }

        public int CountValue { get { return Value.Length; } }

        public T[] Keys { get { return Key; } }
        public U[] Values { get { return Value; } }
    }
}