// 3. this 키워드와 base 키워드에 대해 설명
/* 
this : 클래스 내에서 클래스 자기 자신을 가리키는 키워드
base : 파생 클래스에서 기반 클래스를 가리키는 키워드
*/
using System;
using static System.Console;

namespace MainApp;

class MainApp
{
    static void Main(string[] args)
    {
        
    }
}

// 정답
/*
# this 키워드
- 정의: 현재 클래스에서 생성된 자기 자신의 인스턴스를 가리키는 참조 키워드.
- 주요 용도:
    매개변수와 필드(멤버 변수)의 이름이 같을 때 이를 구분할 때 사용 (this.name = name;)
    생성자 오버로딩 시 자신의 다른 생성자를 호출할 때 사용 (this())

# base 키워드
- 정의: 파생 클래스(자식) 내부에서 기반 클래스(부모)의 멤버에 접근할 때 사용하는 참조 키워드.
- 주요 용도:
    기반 클래스의 생성자를 명시적으로 호출할 때 사용 (base())
    오버라이딩된 메서드 내부에서 기반 클래스의 원본 메서드를 호출할 때 사용 (base.Method())
*/