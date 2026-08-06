// 다음 코드에서 b는 얼마?
/*
int a = 10;
string b = a == 0 ? "가나다" : "ABC";
*/
using static System.Console;

class MainApp
{
    static void Main(string[] args)
    {
        int a = 10;
        string b = a == 0 ? "가나다" : "ABC";
        /*
            연산자는 =, ==, ?: 이렇게 세 가지가 있는데
            우선순위는 == > ?: > = 이므로 순서대로 풀어주면

            b = a == 0 ? "가나다" : "ABC";
            b = False ? "가나다" : "ABC";
            b = "ABC";

            따라서 b는 "ABC"가 된다
        */

        WriteLine($"b : {b}");
    }
}

/* 실행결과
b : ABC
*/