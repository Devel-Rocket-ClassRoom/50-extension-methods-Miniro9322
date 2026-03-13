using System;
using System.Text.RegularExpressions;

static class Palindrome
{
    public static bool IsPalindrome(this string text)
    {
        if (text == null || text == string.Empty)
        {
            return false;
        }
        text = text.Trim().ToLower();
        text = Regex.Replace(text, @"[^a-zA-Z0-9]", "");
        string[] temp = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string reverse = string.Join("", temp);
        char[] reverseTemp = reverse.ToCharArray();
        for (int i = 0; i < reverseTemp.Length / 2; i++)
        {
            char tempc = reverseTemp[i];
            reverseTemp[i] = reverseTemp[reverseTemp.Length - 1 - i];
            reverseTemp[reverseTemp.Length - 1 - i] = tempc;
        }
        reverse = string.Join("", reverseTemp);

        return text == reverse;
    }
}