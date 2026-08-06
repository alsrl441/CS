// 6. 사용자의 나이(int age)와 학생 여부(bool isStudent)를 입력받아 할인율을 계산하는 GetDiscountRate 메소드를 작성하세요. (C# 9.0 이상 패턴 매칭 활용)
/*
조건:
switch 식(expression)과 패턴 매칭을 사용할 것.
나이가 7세 미만이거나 65세 이상이면 50% 할인 (0.5f)
나이가 7세 이상 18세 이하이거나, **학생(isStudent == true)**이면 20% 할인 (0.2f)
그 외 일반 성인은 할인 없음 (0.0f)
*/
using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    static void Main(string[] args)
    {
        float GetDiscountRate(int age, bool isStudent) => (age, isStudent) switch
        {
            (< 7, _) or (>= 65, _) => 0.5f,
            (<= 18, _) or (_, true) => 0.2f,
            _ => 0.0f
        };

        Write("나이를 입력하세요. : ");
        if (int.TryParse(ReadLine(), out int age))
        {
            if (age < 0)
            {
                WriteLine("0보다 큰 값을 입력하세요.");
                return;
            }
        }
        else
        {
            WriteLine("정수를 입력하세요.");
            return;
        }

        Write("학생인가요?(True / False) : ");
        if (!bool.TryParse(ReadLine(), out bool isStudent))
        {
            WriteLine("True 또는 False를 입력하세요");
            return;
        }

        WriteLine($"할인율은 {GetDiscountRate(age, isStudent) * 100}% 입니다.");
    }
}