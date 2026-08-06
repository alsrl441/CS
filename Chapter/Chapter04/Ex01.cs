// i++와 ++i의 차이점은?
/*
i++는 후위 증가 연산자, ++i는 전위 증가 연산자로,
i++는 해당 연산이 포함된 로직이 종료된 후에 i에 1을 더하고
++i는 해당 연선이 포함된 로직이 실행되기 전에 먼저 i에 1을 더한다
*/

using static System.Console;

class MainApp
{
    static void Main(string[] args)
    {
        int i = 0;

        WriteLine(i++); // i에 1을 더하기 전 값인 0을 출력한 후 i에 1을 더한다.
        WriteLine(++i); // i의 값을 출력하기 전에 i에 1일 더하여 2를 출력한다.
    }
}
/* 실행 결과
0
2
*/