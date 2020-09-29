using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    public static class ListExtensions<T>
    {
        public static List<T> randomize(List<T> list)
        {
            Random rand = new Random(Time.GetUnix());
            List<T> copy = new List<T>();

            for (int i = list.Count -1; i>= 0; i--)
            {
                int index = rand.Next(0, i);
                copy.Add(list[index]);
                list.RemoveAt(index);
            }

            return copy;

        }
        public static List<T> shift(List<T> list, int shift)
        {
            List<T> copy = new List<T>();

            for (int i = 0; i < list.Count; i++) 
            {
                int index = (i + shift) % list.Count;
                copy.Add(list[index]);
            }

            return copy;

        }
    }
}
