using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 컬렉션 셔플 테스트 ===\n");

Console.WriteLine("[숫자 리스트 셔플]");
int[] numList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.Write("원본: ");
PrintList(numList);

numList.ShuffleList();
Console.Write("셔플: ");
PrintList(numList);

Console.WriteLine();

Console.WriteLine("[카드 덱 셔플]");
string[] cardDeck = { "♠A", "♥K", "◆Q", "♣J" };
Console.Write("원본: ");
PrintList(cardDeck);

cardDeck.ShuffleList();
Console.Write("셔플: ");
PrintList(cardDeck);

Console.WriteLine();

Console.WriteLine("[학생 순서 무작위 배치]");
string[] studentList = { "김철수", "이영희", "박민수", "최지연", "정우진" };
Console.Write("원본: ");
PrintList(studentList);

studentList.ShuffleList();
Console.Write("셔플: ");
PrintList(studentList);

void PrintList<T>(T[] list)
{
    for(int i = 0; i < list.Length; i++)
    {
        if(i == 0)
        {
            Console.Write(list[i]);
        }
        else
        {
            Console.Write($", {list[i]}");
        }
    }
    Console.WriteLine();
}