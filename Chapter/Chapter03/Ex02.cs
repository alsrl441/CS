// 다음 코드에서 잘못된 부분 찾기

class MainApp
{
    static void Main()
    {
        int a = 7.3; // int형 변수를 선언하는데 부동 소수점 리터럴을 대입하여 컴파일 에러 발생
        float b = 3.14; // float형 변수를 선언하는데 리터럴 뒤에 float형 리터럴이라는 의미의 'f'가 누락되어 컴파일 에러 발생
        double c = a * b; // 문제 없음
        char d = "abc"; // char형 변수를 선언하는데 문자열 리터럴을 대입하여 컴파일 에러 발생
        string e = '한'; // string형 변수를 선언하는데 문자 리터럴을 대입하여 컴파일 에러 발생
    }
}