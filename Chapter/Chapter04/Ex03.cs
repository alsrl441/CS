// 다음 코드에서 a와 b는 각각 얼마?
/*
int a = 8 >> 1;
int b = a >> 2;
*/
using static System.Console;

class MainApp
{
    static void Main(string[] args)
    {
        int a = 8 >> 1; // 8을 2진수로 나타내면 0000_1000 이므로 1을 오른쪽으로 1번 옮기면 0000_0100이 되어 4가 된다.
        int b = a >> 2; // 4(a의 값)를 2진수로 나타내면 0000_0100 이므로 1을 오른쪽으로 2번 옮기면 0000_0001이 되어 1이 된다.

        WriteLine($"a : {a}(0b{Convert.ToString(a, 2).PadLeft(8, '0')})");
        WriteLine($"b : {b}(0b{Convert.ToString(b, 2).PadLeft(8, '0')})");
    }
}

/* 실행결과
a : 4(0b00000100)
b : 1(0b00000001)
*/