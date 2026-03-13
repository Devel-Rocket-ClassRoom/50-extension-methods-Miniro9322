using System;

public static class PlayerExtensions
{
    public static string GetInfo(this Player player)
    {
        return $"[{player.Name}] 레벨: {player.Level}, 경험치: {player.Experience}";
    }

    public static bool CanLevelUp(this Player player)
    {
        return player.Experience >= 100;
    }

    public static void LevelUp(this Player player)
    {
        if (player.CanLevelUp())
        {
            player.Level++;
            player.Experience -= 100;
            Console.WriteLine($"{player.Name}이(가) 레벨업! 현재 레벨: {player.Level}");
        }
    }
}