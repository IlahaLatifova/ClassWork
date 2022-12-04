using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Optional<T>
    {
        T[] values = new T[0];

        public T this[int index]
        {
            get => values[index];
            set => values[index] = value;
        }

        public int Length()
        {
            return values.Length;
        }

        public void Add(T value)
        {
            Array.Resize(ref values, values.Length + 1);
            values[values.Length - 1] = value;
        }

        public bool Remove(T value)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values.Contains(value))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public int LastIndexOf(T value)
        {
            for (int i = values.Length - 1; i >= 0; i--)
            {
                if (values[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        //public void Reverse()
        //{
        //    for (int i = 0, j = values.Length - 1; i > values.Length; i++, j--)
        //    {
        //        T value = values[i];
        //        values[i] = values[j];
        //        values[j] = value;
        //    }
        //}

        public void Clear()
        {
            Array.Resize(ref values, 0);
        }



    }
}
