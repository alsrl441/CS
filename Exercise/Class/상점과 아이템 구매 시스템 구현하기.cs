// 상점과 아이템 구매 시스템
/* 
게임 내에서 플레이어(Player)가
상점(Shop)에서 아이템을 구매하고,
자신의 가방(Inventory) 관리 및 골드를 차감하는 시스템을 만들어보기.

요구사항
# 1. Item 클래스 생성하기
- 필드:
    - string name (아이템 이름)
    - int price (가격)
- 생성자:
    - 이름과 가격을 받아 초기화하는 생성자

# 2. Player 클래스 생성하기
- 필드:
    - string name (플레이어 이름)
    - int gold (소지한 골드)
    - Item[] inventory (아이템을 담을 배열, 크기는 3개)
    - int itemCount (현재 가방에 들어있는 아이템 개수, 초기값 0)
- 생성자:
    - 이름과 초기 골드를 매개변수로 받아서 초기화 (inventory는 크기 3짜리 배열로 생성)
- 메서드:
    - BuyItem(Item item): 아이템을 구매하는 메서드
        조건 1: 골드가 부족하면 "골드가 부족하여 [아이템 이름]을(를) 살 수 없습니다." 출력 후 구매 실패
        조건 2: 가방이 꽉 찼으면 (itemCount >= 3) "가방이 가득 차서 더 이상 아이템을 넣을 수 없습니다." 출력 후 구매 실패
        성공 시: 골드 차감, inventory[itemCount] 위치에 아이템 저장, itemCount 1 증가, "[아이템 이름]을(를) 구매했습니다!" 출력
    - ShowStatus(): 플레이어 이름, 남은 골드, 그리고 현재 가지고 있는 아이템 목록을 콘솔에 출력하기

# 3. MainApp에서 실행해보기
- 플레이어 하나 생성 (예: 이름 "초보자", 골드 1000)
- 상점 판매용 아이템 4개 생성:
    - 포션 (200골드)
    - 검 (500골드)
    - 방어구 (400골드)
    - 반지 (300골드)
- 플레이어 상태 한번 출력해 보기
- 아이템을 순서대로 하나씩 구매하기 (골드 부족이나 가방 가득 참 로직이 실제로 발생하는지 테스트!)
- 최종 플레이어 상태(ShowStatus()) 출력해서 아이템들과 남은 골드 확인하기
*/

using System;
using static System.Console;

namespace MainApp;

class Item
{
    public string name;
    public int price;

    public Item()
    {
        name = "아이템";
        price = 0;
    }

    public Item(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
}

class Player
{
    public string name;
    public int gold;
    public Item[] inventory;
    public int itemCount = 0;
    private byte inventoryCapacity = 3;

    public Player()
    {
        name = "플레이어";
        gold = 0;
        inventory = new Item[inventoryCapacity];
    }

    public Player(string name, int initialGold)
    {
        this.name = name;
        gold = initialGold;
        inventory = new Item[inventoryCapacity];
    }

    // 아이템을 구매하는 메서드
    public void BuyItem(Item item)
    {
        if (gold < item.price) // 플레이어가 소지한 골드가 item의 가격보다 작으면
        {
            WriteLine($"골드가 부족하여 [{item.name}]을(를) 살 수 없습니다."); // 골드 부족으로 인한 구매 불가 안내 출력
            return;
        }
        else if (itemCount >= inventoryCapacity) // 플레이어의 인벤토리가 인벤토리 수용량 이상이면
        {
            WriteLine($"가방이 가득 차서 더 이상 아이템을 넣을 수 없습니다. (가방 용량 : {inventoryCapacity})"); // 가방 공간 부족으로 인한 구매 불가 안내 출력
            return;
        }
        else
        {
            gold -= item.price; // item의 가격 만큼 플레이어의 골드 차감
            inventory[itemCount] = item; // inventory[itemCount] 위치에 아이템 저장
            itemCount++; // itemCount 1 증가
            WriteLine($"[{item.name}]을(를) 구매했습니다!"); // item 구매 완료 안내 출력
            return;
        }
    }

    // 스태이터스 출력
    public void ShowStatus()
    {
        string currentInventory = "| ";
        foreach (var item in inventory) currentInventory += (item?.name ?? "비어있음") + " | ";

        WriteLine($"""

            [스태이터스]
            이름 : {name}
            골드 : {gold}
            인벤토리 : {currentInventory}

            """);
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        // 플레이어 및 상점 아이템 인스턴스 생성
        var gildong = new Player("홍길동", 1500);
        var potion = new Item("포션", 200);
        var sword = new Item("검", 600);
        var armor = new Item("방어구", 800);
        var ring = new Item("반지", 300);

        gildong.ShowStatus(); // 플레이어 상태 출력

        gildong.BuyItem(potion); // 포션 구매
        gildong.BuyItem(sword); // 검 구매
        gildong.BuyItem(armor); // 방어구 구매
        gildong.BuyItem(ring); // 반지 구매
        gildong.BuyItem(ring); // 반지 구매

        gildong.ShowStatus(); // 플레이어 최종 상태 출력
    }
}