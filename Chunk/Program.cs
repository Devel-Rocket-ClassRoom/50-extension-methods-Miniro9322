using System;
using System.Collections.Generic;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 컬렉션 청킹 테스트 ===\n");
Console.WriteLine("[숫자를 3개씩 그룹화]");
List<int> numChunk = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach(var num in numChunk.SplitChunk(3))
{
    Console.WriteLine($"[{string.Join(", ", num)}]");
}
Console.WriteLine();
Console.WriteLine("[학생들을 2명씩 팀 구성]");
List<string> studentChunk = new List<string> { "김철수", "이영희", "박민수", "최지연", "정우진" };
int teamCount = 1;
foreach (var student in studentChunk.SplitChunk(2))
{
    Console.WriteLine($"팀 {teamCount}: {string.Join(", ", student)}");
    teamCount++;
}
Console.WriteLine();
Console.WriteLine("[페이지별로 5개씩 나누기]");
List<int> pageChunk = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
int pageCount = 1;
foreach (var page in pageChunk.SplitChunk(5))
{
    Console.WriteLine($"팀 {pageCount}: {string.Join(", ", page)}");
    pageCount++;
}
Console.WriteLine();