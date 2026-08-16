// 4. 구조체에 대한 다음 설명 중 틀린 것을 모두 찾기
/* 
1. struct 키워드를 이용하여 선언한다.
2. 복사할 때 얕은 복사가 이루어진다.
3. 참조 형식이다.
4. 메소드를 가질 수 있다.

답안 : 2, 3
2 : 구조체는 값 형식이기 때문에 깊은 복사가 이루어짐.
3 : 구조체는 값 형식으로, 스택에 할당됨.
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
2번, 3번.

1번 (O): C#에서 구조체는 struct 키워드로 선언함.
2번 (X): 구조체(Struct)는 값 형식(Value Type)이므로, 변수에 할당하거나 전달할 때 메모리 데이터 전체가 복사되는 깊은 복사(Deep Copy)가 일어남.
3번 (X): 구조체는 값 형식(Value Type)이며, 스택(Stack) 메모리에 할당됨. (참조 형식은 class임)
4번 (O): C#의 구조체는 클래스처럼 필드뿐만 아니라 메서드, 생성자, 프로퍼티 등을 모두 가질 수 있음.
*/