using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources09
{
    static class MyListExtentions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[5];
            int counter = 0;

            foreach (T value in list)
            {
                array[counter] = value;
                counter++;
            }

            return array;
        }

    }
}
