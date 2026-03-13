using System;

public static class StringExtensions
{
    public static int CountWords(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return 0;
        }
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}