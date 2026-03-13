using System;
using System.Collections.Generic;

static class Shuffle
{
    public static void ShuffleList<T>(this IList<T> list)
    {
        Random rnd = new Random();

        if(list == null)
        {
            throw new ArgumentNullException();
        }

        for(int i = list.Count - 1;  i > 0; i--)
        {
            int index = rnd.Next(0, i);
            var temp = list[i];
            list[i] = list[index];
            list[index] = temp;
        }
    }
}