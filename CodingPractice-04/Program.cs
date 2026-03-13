using System;

// README.md를 읽고 코드를 작성하세요.

//1
string input = "  hello world  ";

string result1 = StringExtensions.Replace(
    StringExtensions.Upper(
        StringExtensions.Trim(input)), ' ', '_');

string result2 = input
    .Trim()
    .Upper()
    .Replace(' ', '_');

Console.WriteLine($"결과1: {result1}");
Console.WriteLine($"결과2: {result2}");

//2
SecretBox box = new SecretBox();
box.ShowData();

//3
Greeter g = new Greeter();
g.SayHello();
g.SayGoodbye();

GreeterExtensions.SayHello(g);



