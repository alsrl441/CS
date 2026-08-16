// 5. 다음 코드를 컴파일 및 실행 가능하도록 수정
/* 
using System;

namespace ReadonlyMethod
{
    struct ACSetting
    {
        public double currentInCelsius; // 현재 온도(℃)
        public double target; // 희망 온도

        public readonly double GetFahrenheit()
        {
            target = currentInCelsius * 1.8 + 32; // 화씨(℉) 계산 결과를 targert에 저장
            return target; // target 반환
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}
*/
using System;
using static System.Console;

namespace MainApp;

struct ACSetting
{
    public double currentInCelsius; // 현재 온도(℃)
    public double target; // 희망 온도

    public readonly double GetFahrenheit() // ※ 읽기 전용 메서드 안에서는 변수를 수정할 수 없음
    {
        return currentInCelsius * 1.8 + 32; // 화씨(℉) 계산 결과를 반환
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        ACSetting acs;
        acs.currentInCelsius = 25;
        acs.target = 25;

        Console.WriteLine($"{acs.GetFahrenheit()}℉");
        Console.WriteLine($"{acs.target}℃");
    }
}