// 3. 1번과 2번을 for문 대신 while 문과 do-while 문으로 바꿔서 각각 작성.

using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    static void Main(string[] args)
    {
        // 1번 => while
        int i = 1, j = 1;

        while(i <= 5)
        {
            while(j <= i)
            {
                Write("*");
                j++;
            }
            WriteLine();
            j = 1;
            i++;
        }

        WriteLine();

        // 2번 => do-while
        int k = 1, l = 5;
        do
        {
            do
            {
                Write("*");
                l--;
            } while(l >= 1);
            WriteLine();
            k++;
            l = 6 - k;
        } while(k <= 5);
    }
}