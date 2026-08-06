// 5. 다음 Fibonacci 클래스의 GetNumber() 메소드에서 switch 문을 switch 식으로 변경.
/*
class Fibonacci
{
    public static long GetNumber (long index)
    {
        long result = 0;
        switch (index)
        {
            case 0:
                result = 0;
                break;
            case 1:
                result = 1;
                break;
            default:
                result = GetNumber(index - 1) + GetNumber(index - 2);
                break;
        }

        return result;
    }
}
*/
using System;
using static System.Console;

namespace MainApp;

class Fibonacci
{
    public static long GetNumber (long index) => index switch
    {
        0 => 0,
        1 => 1,
        _ => GetNumber(index - 1) + GetNumber(index - 2)
    };
}

class MainApp
{
    static void Main(string[] args)
    {
        
    }
}