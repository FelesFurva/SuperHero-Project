using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Project
{
    public static class Arrayhelper
    {
        public static T[] Append<T>(this T[] array, T item)
        {
            List<T> list = new List<T>(array);
            list.Add(item);

            return list.ToArray();
        }


        public static T[] Remove<T>(this T[] array, int position)
        {
            List<T> list = new List<T>(array);
            list.RemoveAt(position);

            return list.ToArray();
        }

        public static T[,] Append<T>(this T[,] array, T[] item)
        {
            T[,] newArray = new T[array.GetLength(0) + 1, array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[i, j] = array[i, j];
                }
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                newArray[array.GetLength(0), i] = item[i];
            }
            return newArray;
        }

        public static T[,] Remove<T>(this T[,] array, int position)
        {
            T[,] newArray = new T[array.GetLength(0) - 1, array.GetLength(1)];

            int skipper = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == position)
                {
                    skipper = 1;
                    continue;
                }

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[i + skipper, j] = array[i, j];
                }
            }

            return newArray;
        }
    }
}
