using System;

public static class StringHelper
{
    public static int CountWords(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return 0;
        }
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}