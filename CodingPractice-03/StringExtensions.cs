public static class StringExtensions
{
    public static bool IsCapitalized(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return false;
        }
        return char.IsUpper(text[0]);
    }

    public static string Capitalize(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }
        return char.ToUpper(text[0]) + text.Substring(1).ToLower();
    }

    public static string Reverse(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}