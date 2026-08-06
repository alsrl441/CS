// 9. 다양한 타입의 객체(object)를 인자로 받아 타입과 값에 따라 메시지를 반환하는 AnalyzeData 메소드를 작성하세요.
/*
object data를 switch 식을 사용해 분석할 것.
data가 **정수(int)**일 때:
0보다 크면 "양수 정수: [값]"
0이면 "0입니다"
0보다 작으면 "음수 정수: [값]"
data가 **문자열(string)**일 때:
비어있거나 null이면 (string.IsNullOrEmpty) "빈 문자열"
그렇지 않으면 "문자열 길이는 [길이]"
data가 null이면 "null 데이터입니다"
그 외 모든 타입은 "알 수 없는 타입" 반환

``` C#
// 뼈대 코드
public static string AnalyzeData(object data) => data switch
{
    // 작성 위치
};
```
*/