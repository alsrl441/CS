// 1. 다음 코드에서 Square() 메소드를 구현해 프로그램을 완성. Square() 함수는 매개변수를 제곱하여 반환. 프로그램의 실행 예는 다음과 같음.
/*
수를 입력하세요. : 3
결과 : 9

수를 입력하세요. : 34.2
결과 : 1169.64
*/
using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    static double Square(double arg)
    {
        return arg * arg;
    }
    static void Main(string[] args)
    {
        Write("수를 입력하세요. : ");
        if (double.TryParse(ReadLine(), out double input))
            WriteLine($"결과 : {Square(input)}");
    }
}