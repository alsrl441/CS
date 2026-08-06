// 4. 다음과 같이 사용자로부터 입력받은 횟수만큼 별을 반복 출력하는 프로그램을 작성.
// 단, 입력받은 수가 0보다 작거나 같을 경우 "0보다 작거나 같은 수는 사용할 수 없습니다."라는 메시지를 띄우고 프로그램을 종료.
/*
반복 횟수를 입력하세요. : -10
0보다 작거나 같은 수는 사용할 수 없습니다.

반복 횟수를 입력하세요. : 5
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
        void printStars(int loopCount)
        {
            for (int i = 1; i <= loopCount; i++)
                WriteLine(new string('*', i));
        }

        while(true)
        {

            Write("반복 횟수를 입력하세요. : ");

            if (int.TryParse(ReadLine(), out int loopCount))
            {
                if (loopCount > 0)
                    printStars(loopCount);
                else
                {
                    WriteLine("0보다 작거나 같은 수는 사용할 수 없습니다.\n");
                    break;
                }
            }
        }
    }
}