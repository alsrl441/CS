// 7. 1부터 100까지의 정수 중에서 **3의 배수이면서 5의 배수인 수(15의 배수)**를 찾아 출력하는 프로그램을 작성하세요.
/*
for문 또는 while문을 사용할 것.
숫자가 3의 배수가 아니거나 5의 배수가 아니면 continue를 사용해 넘어가야 함.
15의 배수를 출력하다가, 출력된 횟수가 3번이 되면 break를 사용해 반복문을 즉시 종료할 것.
*/

using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    static void Main(string[] args)
    {
        int printCount = 3;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 != 0 || i % 5 != 0)
                continue;
            
            WriteLine(i);
            printCount--;

            if(printCount <= 0)
                break;
        }
    }
}