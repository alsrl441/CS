// 3. 다음 코드에서 Plus() 메소드가 double 형 매개변수를 지원하도록 오버로딩. 실행 결과는 다음과 같아야 함.
/*

using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = 4;
        int resultA = 0;

        Plus(a, b, out resultA);

        WriteLine($"{a} + {b} = {resultA}");

        double x = 2.4;
        double y = 3.1;
        double resultB = 0;

        Plus(x, y, out resultB); // 오버로드가 필요한 메소드

        WriteLine($"{x} + {y} = {resultB}");
    }

    public static void Plus(int a, int b, out int c)
    {
        c = a + b;
    }

    // 이 아래에 double 형 매개변수를 받을 수 있도록
    // 오버로딩된 Plus() 메소드를 작성.
}

``` 실행 결과
3 + 4 = 7
2.4 + 3.1 = 5.5
```
*/

using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = 4;
        int resultA = 0;

        Plus(a, b, out resultA);

        WriteLine($"{a} + {b} = {resultA}");

        double x = 2.4;
        double y = 3.1;
        double resultB = 0;

        Plus(x, y, out resultB);

        WriteLine($"{x} + {y} = {resultB}");
    }

    public static void Plus(int a, int b, out int c)
    {
        c = a + b;
    }

    public static void Plus(double a, double b, out double c)
    {
        c = a + b;
    }
}