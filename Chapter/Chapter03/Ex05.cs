// 다음 코드를 컴파일한 후의 a와 b는 각각 어떤 데이터 형식인가?

class MainApp
{
    static void Main()
    {
        var a = 2020; // System.int32
        var b = "double"; // System.string

        System.Console.WriteLine($"a의 데이터 형식 : {a.GetType()}");
        System.Console.WriteLine($"b의 데이터 형식 : {b.GetType()}");
    }
}

/* 실행결과
a의 데이터 형식 : System.Int32
b의 데이터 형식 : System.String
*/