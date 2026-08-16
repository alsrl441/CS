// 접근 한정자
/* 
접근 제한 수준 (고 → 저)
private : 클래스 외부에서 절대 사용 불가능
private protected : 프로젝트 내부에서 상속받은 클래스에서 사용 가능
protected : 상속받은 클래스에서 사용 가능
internal : 프로젝트 내부에서 사용 가능
protected internal : 프로젝트 내부이거나 상속받은 클래스에서 사용 가능
public : 완전 공개
*/

using System;
using static System.Console;

namespace MainApp;

class C
{
    public int i; // 클래스의 내부/외부 모든 곳에서 접근 가능.
    protected int j; // 클래스의 외부에서는 접근 불가능하지만 파생 클래스에서는 접근 가능.
    private int k; // 클래스 내부에서만 접근 가능. 파생 클래스에서 접근 불가.
    internal int l; // 같은 어셈블리에 있는 코드에서만 public으로 접근 가능. 다른 어셈블리에 있는 코드에서는 private과 동일
    protected internal int m; // 같은 어셈블리에 있는 코드에서만 protected로 접근 가능. 다른 어셈블리에 있는 코드에서는 private과 동일
    private protected int n; // 같은 어셈블리에 있는 클래스에서 상속받은 클래스 내부에서만 접근 가능

    private int o; 
            int p; // 접근 한정자 생략 시 마지막으로 사용한 접근 한정자를 따라감
}

class MainApp
{
    static void Main(string[] args)
    {
        
    }
}