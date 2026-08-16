// 2. 다음 코드에서 오류를 찾고, 오류의 원인을 설명
/* 
class A
{

}

class B : A
{

}

class C
{
    public static void Main()
    {
        A a = new A();
        B b = new B();
        A c = new B();
        D b = new A();
    }
}
*/
using System;
using static System.Console;

namespace MainApp;

class A
{

}

class B : A
{

}

class C
{
    public static void Main()
    {
        A a = new A();
        B b = new B();
        A c = new B();
        B d = new A(); // 오류 발생. 기반 클래스의 인스턴스를 파생 클래스의 인스턴스로 형변환할 수 없음.
    }
}

// 정답
/*
오류가 발생하는 코드: B d = new A();
오류 원인: 기반 클래스 타입의 객체를 파생 클래스 타입의 참조 변수에 암시적으로 형변환할 수 없기 때문.
*/