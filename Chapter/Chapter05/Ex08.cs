// 8. 2차원 좌표 (int x, int y) 튜플을 받아 해당 좌표가 어디에 위치해 있는지 문자열로 반환하는 GetQuadrant 메소드를 작성하세요.
/* 
switch 식과 튜플 위치 패턴((x, y) switch)을 사용할 것.
(0, 0)일 경우 "원점"
x가 0이고 y가 0이 아닌 경우 "Y축 위"
y가 0이고 x가 0이 아닌 경우 "X축 위"
그 외 양수/음수 조합에 따라 "1사분면", "2사분면", "3사분면", "4사분면" 반환

```C#
// 뼈대 코드
public static string GetQuadrant((int x, int y) point) => point switch
{
    // 작성 위치
};
```
*/
using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    public static string GetQuadrant((int x, int y) point) => point switch
    {
        (0, 0) => "원점",
        (0, not 0) => "y축 위",
        (not 0, 0) => "x축 위",
        (> 0, > 0) => "1사분면",
        (< 0, > 0) => "2사분면",
        (< 0, < 0) => "3사분면",
        (> 0, < 0) => "4사분면"
    };
    static void Main(string[] args)
    {
        Write("x 좌표 : ");
        if (!int.TryParse(ReadLine(), out int x))
        {
            WriteLine("정수를 입력하세요.");
            return;
        }

        Write("y 좌표 : ");
        if (!int.TryParse(ReadLine(), out int y))
        {
            WriteLine("정수를 입력하세요.");
            return;
        }

        WriteLine($"해당 좌표는 {GetQuadrant((x, y))}에 있습니다.");
    }
}