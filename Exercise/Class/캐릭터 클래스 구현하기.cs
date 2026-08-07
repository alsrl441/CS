// 게임 속에 등장하는 '캐릭터'를 클래스로 구현해 보기
/* 
요구사항
# 1. Character 클래스 생성하기
- 속성 (필드 또는 프로퍼티):
    - Name (이름, string)
    - Hp (체력, int)
    - AttackPower (공격력, int)

- 생성자 (Constructor):
    캐릭터의 이름, 체력, 공격력을 매개변수로 받아서 초기화하는 생성자를 만들기

- 메서드 (Method):
    ShowInfo(): 캐릭터의 현재 이름, 체력, 공격력을 콘솔에 출력하는 메서드
    Attack(Character target): 다른 캐릭터(target)를 공격하는 메서드
        상대방의 Hp를 내 AttackPower만큼 차감하고, "[공격자 이름]이(가) [대상 이름]을(를) 공격하여 [공격력]의 피해를 입혔습니다!" 라고 출력하기

# 2. Main 메서드에서 실행해보기
- 서로 다른 두 개의 캐릭터 객체를 생성. (예: "전사", "마법사")
- 두 캐릭터의 정보를 ShowInfo()로 각각 출력.
- 한 캐릭터가 다른 캐릭터를 Attack() 하도록 만들기.
- 공격받은 캐릭터의 ShowInfo()를 다시 호출해서 체력이 잘 깎였는지 확인.
*/

using System;
using static System.Console;

namespace MainApp;

class Character
{
    public string name;
    public int hp;
    public int attackPower;

    public Character()
    {
        name = "캐릭터";
        hp = 0;
        attackPower = 0;
    }

    public Character(string name, int hp, int attackPower)
    {
        this.name = name;
        this.hp = hp;
        this.attackPower = attackPower;
    }

    // 캐릭터의 이름, 체력, 공격력을 콘솔에 출력하는 메서드
    public void ShowInfo()
    {
        WriteLine($"""
            [캐릭터 정보]
            이름 : {name}
            체력 : {hp}
            공격력 : {attackPower}

            """);
    }

    // 다른 캐릭터(target)를 공격하는 메서드
    public void Attack(Character target)
    {
        target.hp -= attackPower; // 타겟의 hp를 attackPower 만큼 감소
        WriteLine($"[{name}]이(가) [{target.name}]을(를) 공격하여 [{attackPower}]의 피해를 입혔습니다!\n"); // 로그 출력
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        // 전사, 마법사 인스턴스 생성
        var warrior = new Character("전사", 15, 2);
        var wizard = new Character("마법사", 10, 3);

        // 캐릭터 상태 출력
        warrior.ShowInfo();
        wizard.ShowInfo();

        // 전사가 마법사를 공격
        warrior.Attack(wizard);

        // 마법사의 체력이 깎였는지 확인
        wizard.ShowInfo();
    }
}