// 다음 코드에서 a는 얼마?
/*
int a = 0xF0 | 0x0F;
*/
using static System.Console;

class MainApp
{
    static void Main(string[] args)
    {
        int a = 0xF0 | 0x0F;
        /*
            0xF0는 10진수로 240이므로 2진수로 나타내면 0b1111_0000
            0x0F는 10진수로 15이므로 2진수로 나타내면 0b0000_1111 

            0b1111_0000과 0b0000_1111 사이의 논리합(|)은 0b1111_1111,
            10진수로 나타내면 255, 16진수로 나타내면 0xFF이다.
        */
        
        WriteLine($"a : {a}(0b{Convert.ToString(a, 2).PadLeft(8, '0')}, {a:X})");
    }
}

/* 실행결과
a : 255(0b11111111, FF)
*/