using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

static class Chunk
{
    public static IEnumerable<IEnumerable<T>> SplitChunk<T>(this IEnumerable<T> chunk, int size)
    {
        if(size < 1)
        {
            throw new ArgumentException();
        }

        List<T> result = new List<T>(size);

        foreach(T chunkItem in chunk)
        {
            result.Add(chunkItem);
            if(result.Count() == size)
            {
                yield return result;
                result.Clear();
            }
        }

        if(result.Count() > 0)
        {
            yield return result;
        }
    }
}