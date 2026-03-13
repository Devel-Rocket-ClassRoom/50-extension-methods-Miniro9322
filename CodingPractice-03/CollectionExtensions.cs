using System;
using System.Collections.Generic;

public static class CollectionExtensions
{
    public static bool IsEmpty<T>(this ICollection<T> collection)
    {
        return collection.Count == 0;
    }

    public static bool HasItems<T>(this ICollection<T> collection)
    {
        return collection.Count > 0;
    }

    public static void ForEach<T>(this IList<T> list, Action<T> action)
    {
        foreach (var item in list)
        {
            action(item);
        }
    }
}