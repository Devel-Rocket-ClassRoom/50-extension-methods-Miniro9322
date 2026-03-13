using System;

// README.md를 읽고 코드를 작성하세요.

//1
string greeting = "안녕하세요";
Console.WriteLine(greeting.First(3));

//2
Player hero = new Player
{
Name = "용사",
Level = 5,
Experience = 150
};

Console.WriteLine(hero.GetInfo());
Console.WriteLine($"레벨업 가능? {hero.CanLevelUp()}");
hero.LevelUp();
Console.WriteLine(hero.GetInfo());