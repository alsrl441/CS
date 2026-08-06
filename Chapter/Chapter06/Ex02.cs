// 2. 다음 코드에서 Mean() 메소드를 실행한 후의 mean은 얼마의 값을 가지는가? 0이다. mean이 0을 갖게 되는 원인은 무엇이며, 이를 바로잡으려면 다음 코드에서 어떤 부분을 고쳐야 하는가?
/*
using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    static void Main(string[] args)
    {
        double mean = 0;

        Mean(1, 2, 3, 4, 5, mean);

        WriteLine($"평균 : {mean}");
    }

    public static void Mean(double a, double b, double c, double d, double e, double mean)
    {
        mean = (a + b + c + d + e) / 5;
    }
}

# 원인 :
C#에서 double 같은 값 타입(Value Type) 매개변수는 기본적으로 값 복사(Call by Value) 방식으로 전달됨.
따라서 Mean 메소드 내부의 mean은 외부 Main 메소드의 mean 변수와 메모리 공간이 완전히 다른 별개의 복사본임.
메소드 내부에서 값을 아무리 바꿔도 외부 변수에는 영향을 주지 않기 때문에 0이 그대로 유지됨.

# 해결책 :
ref 키워드를 사용해 참조 전달(Call by Reference)로 변경하면,
복사본이 아닌 외부 변수의 메모리 주소(참조)를 직접 넘기게 되므로 내부에서 수정한 값이 외부 변수에도 그대로 반영됨.
*/

using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    static void Main(string[] args)
    {
        double mean = 0;

        Mean(1, 2, 3, 4, 5, ref mean);

        WriteLine($"평균 : {mean}");
    }

    public static void Mean(double a, double b, double c, double d, double e, ref double mean)
    {
        mean = (a + b + c + d + e) / 5;
    }
}