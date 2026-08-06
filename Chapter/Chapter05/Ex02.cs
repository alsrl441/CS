// 2. 다음과 같은 결과를 출력하는 프로그램을 for 문을 이용하여 작성하세요.
/*
*****
****
***
**
*
*/
using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    static void Main(string[] args)
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = i; j >= 1; j--)
            {
                Write("*");
            }
            WriteLine();
        }
    }
}