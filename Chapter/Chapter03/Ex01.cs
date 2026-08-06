using static System.Console;

namespace RectArea;

class MainApp
{
    static void Main()
    {
        Write("사각형의 너비를 입력하세요. : "); // 너비 입력 안내문 출력
        string width = ReadLine(); // 문자열 변수 width에 입력값 저장

        Write("사각형의 높이를 입력하세요. : "); // 높이 입력 안내문 출력
        string height = ReadLine(); // 문자열 변수 height에 입력갑 저장

        int area = int.Parse(width) * int.Parse(height); // width와 height를 정수로 파싱하여 넓이 계산(넓이 = 너비 * 높이)
        WriteLine($"사각형의 넓이 : {area}"); // 넓이 출력
    }
}

/* 실행결과
사각형의 너비를 입력하세요. : 12
사각형의 높이를 입력하세요. : 34
사각형의 넓이 : 408
*/