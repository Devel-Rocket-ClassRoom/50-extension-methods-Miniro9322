using System;
using System.Collections.Generic;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 컬렉션 청킹 테스트 ===\n");
Console.WriteLine("[숫자를 3개씩 그룹화]");
int[] numchunk = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
numchunk.SplitChunk(3);
foreach(int num in numchunk)
{
    Console.WriteLine(num);
}
