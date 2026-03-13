public static class StringExtensions
{
    public static string First(this string text, int count)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        if (count >= text.Length)
        {
            return text;
        }

        return text.Substring(0, count);
    }
}
