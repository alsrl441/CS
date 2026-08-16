// 7. 다음 코드에서 switch 식을 제거하고 switch 문으로 동일한 기능을 작성
/* 
private static double GetDiscountRate(object client)
{
    return client switch
    {
        ("학생", int n) when n < 18 => 0.2, // 학생 & 18세 미만
        ("학생", _) => 0.1,                 // 학생 & 18세 이상
        ("일반", int n) when n < 18 => 0.1, // 일반 & 18세 미만
        ("일반", _) => 0.05,                // 일반 & 18세 이상
        _ => 0,
    };
}
*/

using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    private static double GetDiscountRate(object client)
    {
        double discountRate;

        switch (client)
        {
            case ("학생", int n) when n < 18 :
                discountRate = 0.2;
                break;
            case ("학생", _) :
                discountRate = 0.1;
                break;
            case ("일반", int n) when n < 18 :
                discountRate = 0.1;
                break;
            case ("일반", _) :
                discountRate = 0.05;
                break;
            default :
                discountRate = 0;
                break;
        }

        return discountRate;
    }

    static void Main(string[] args)
    {
        WriteLine(GetDiscountRate(("학생", 16)));
        WriteLine(GetDiscountRate(("학생", 19)));
        WriteLine(GetDiscountRate(("일반", 4)));
        WriteLine(GetDiscountRate(("일반", 25)));
        WriteLine(GetDiscountRate(("기타", 20)));
    }
}