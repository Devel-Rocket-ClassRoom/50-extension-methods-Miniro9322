using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

static class Chunk
{
    public static IEnumerable<IEnumerable<T>> SplitChunk<T>(this IEnumerable<T> chunk, int size)
    {
        if(chunk.Count() < 1)
        {
            throw new ArgumentException();
        }

        IEnumerable<IEnumerable<T>> result = null;

        chunk.Chunk(size);

        yield return chunk;
    }
}