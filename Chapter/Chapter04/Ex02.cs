// 다음 보기 중에서 그 결과가 다른 것을 찾기
/*
1. i = i + 1;
2. i++;
3. ++i;
4. i += 1;
*/
using static System.Console;

class MainApp
{
    static void Main(string[] args)
    {
        int i;

        i = 0;
        WriteLine(i = i + 1); // i에 i와 1을 더한 값을 대입하여 1을 출력

        i = 0;
        WriteLine(i++); // i를 출력한 후 i에 1을 더하여 0을 출력

        i = 0;
        WriteLine(++i); // i에 1을 더한 뒤 i의 값을 출력하여 1을 출력

        i = 0;
        WriteLine(i += 1); //  i에 기존의 i값과 1을 더한 값을 대입하여 1을 출력
    }
}

/* 실행결과
1
0
1
1
*/