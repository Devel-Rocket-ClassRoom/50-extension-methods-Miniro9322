public static class StringChainExtensions
{
    public static string AddPrefix(this string text, string prefix)
    {
        return prefix + text;
    }

    public static string AddSuffix(this string text, string suffix)
    {
        return text + suffix;
    }

    public static string Take(this string text, int count)
    {
        if (string.IsNullOrEmpty(text) || count >= text.Length)
        {
            return text;
        }
        return text.Substring(0, count);
    }

    public static string AddEllipsis(this string text)
    {
        return text + "...";
    }
}