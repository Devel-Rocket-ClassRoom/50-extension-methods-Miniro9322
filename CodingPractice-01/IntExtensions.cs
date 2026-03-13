using System.Linq;

public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }

    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }

    public static string Repeat(this int number, int times)
    {
        return string.Concat(Enumerable.Repeat(number.ToString(), times));
    }
}