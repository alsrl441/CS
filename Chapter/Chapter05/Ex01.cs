// 1. 다음과 같은 겨과를 출력하는 프로그램을 for문을 이용하여 작성. 규칙 : 첫 번째 줄에 1별 1개, 두 번째 줄에 별 2개, 세 번째 줄에 별 3개 ... 이런 식으로 별 5개가 찍힐 때까지 반복
/*
*
**
***
****
*****
*/
using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Write("*");
            }
            WriteLine();
        }
    }
}