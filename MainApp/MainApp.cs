// Unit 기반 클래스를 부모로 두는 Marine과 Medic 클래스를 정의하고, 안전한 다운캐스팅을 테스트
/*
요구사항

Unit 기반 클래스
    - public void Move() -> "유닛이 이동합니다." 출력

Marine 파생 클래스 (Unit 상속)
    - public void UseStimpack() -> "스팀팩 사용!" 출력

Medic 파생 클래스 (Unit 상속)
    - public void Heal() -> "치료 실행!" 출력

Main 메서드
    - Unit 배열(Unit[] units)에 new Marine(), new Medic() 객체를 업캐스팅하여 담는다.
    - foreach 문으로 배열을 순회하면서:
        - 모든 유닛은 공통으로 Move()를 호출한다.
        - is 연산자 또는 as 연산자를 활용해 객체가 Marine이면 UseStimpack()을, Medic이면 Heal()을 안전하게 다운캐스팅해서 호출한다.
*/

using System;
using System.Text;
using static System.Console;

namespace MainApp;

class Unit
{
    protected string Name;
    protected int Hp;

    public Unit(string name, int hp)
    {
        Name = name;
        Hp = hp;
    }

    public void Move()
    {
        WriteLine("유닛이 이동합니다.");
    }
}

class Marine : Unit
{
    public Marine(string name, int hp) : base(name, hp) {}

    public void UseStimpack()
    {
        WriteLine("스팀팩 사용!");
    }
}

class Medic : Unit
{
    public Medic(string name, int hp) : base(name, hp) {}
    
    public void Heal()
    {
        WriteLine("치료 실행!");
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        Unit[] units = { new Marine("해병", 10), new Medic("의무병", 15) };

        foreach (var unit in units)
        {
            unit.Move();

            if (unit is Marine marine) marine.UseStimpack();
            if (unit is Medic medic) medic.Heal();
        }
    }
}