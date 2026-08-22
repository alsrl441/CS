# [C# 코딩 테스트 #01] 턴제 RPG 전투 및 속성 상성 시스템 구현

## 1. 개요
귀하는 신작 2D 턴제 RPG 게임의 핵심 전투 엔진 모듈을 개발하는 담당자입니다.
배운 C# 개념(기본 문법, 연산자, 제어문, 메서드, 클래스와 상속, 다형성, 구조체 등)을 활용하여 **캐릭터 상속 구조**, **속성 상성 연산**, **전투 루프 및 상태 출력 모듈**을 구현하세요.

---

## 2. 세부 요구사항

### A. 열거형 및 구조체 (Chapter 03, 07)
1. **`ElementType` 열거형 (enum)**
   - `None`, `Fire`, `Water`, `Grass` 4가지 속성을 정의합니다.
2. **`Stat` 구조체 (struct)**
   - `int MaxHp`, `int Attack`, `int Defense` 필드를 가집니다.
   - 생성자를 통해 초기화할 수 있어야 합니다.

---

### B. 기반 클래스: `Character` (Chapter 03, 06, 07)
모든 전투 개체의 기본이 되는 클래스입니다.

1. **필드 및 프로퍼티**
   - `string Name` (읽기 전용 프로퍼티)
   - `Stat BaseStat` (캐릭터의 기본 능력치)
   - `int CurrentHp` (현재 체력)
   - `ElementType Element` (캐릭터 속성)
   - `bool IsDead` (체력이 0 이하인지 여부를 반환하는 읽기 전용 프로퍼티)
2. **생성자**
   - 이름, `Stat`, 속성을 매개변수로 받아 초기화합니다.
   - 생성자 체이닝(`this()`) 또는 적절한 초기화 기법을 사용하세요.
3. **메서드**
   - `public virtual void TakeDamage(int damage)`
     - 데미지에서 방어력을 뺀 최종 데미지만큼 `CurrentHp`를 감소시킵니다. (최소 데미지는 1)
     - `CurrentHp`가 0 밑으로 떨어지지 않도록 처리합니다.
   - `public virtual void AttackTarget(Character target)`
     - 타겟 캐릭터에게 공격을 시도합니다. (상성 계산 포함)
   - `public virtual string GetStatusInfo()`
     - 캐릭터의 현재 이름, 체력(`CurrentHp`/`MaxHp`), 속성 정보를 문자열 서식($)으로 반환합니다.

---

### C. 파생 클래스 구현 (Chapter 07 - 상속과 다형성)

#### 1. `Hero` 클래스 (`Character` 상속)
- 추가 필드: `int Shield` (보호막 점수, 기본값 0)
- **`TakeDamage` 오버라이딩**:
  - 데미지를 입을 때, 보호막(`Shield`)이 있다면 보호막이 먼저 데미지를 차단합니다.
  - 보호막으로 막고 남은 데미지만 실제 체력(`CurrentHp`)에 반영됩니다.
- **`UseSkill` 메서드 추가 (메서드 오버로딩 및 out/ref 활용)**:
  - `public bool UseSkill(Character target, out int dealtDamage)`
  - 스킬 사용 시 기본 공격력의 1.5배(소수점 버림) 데미지를 타겟에게 입히고, 실제 들어간 데미지를 `out` 매개변수로 반환합니다. 스킬 사용 성공 여부를 `bool`로 반환합니다.

#### 2. `Monster` 클래스 (`Character` 상속)
- 추가 필드: `bool IsRaged` (광폭화 상태 여부)
- **`TakeDamage` 오버라이딩**:
  - 체력이 최대 체력의 30% 이하로 떨어지면 `IsRaged`가 `true`가 되며, 공격력이 1.5배 증가합니다.
- **`AttackTarget` 오버라이딩**:
  - 일반 공격 시 광폭화 상태라면 추가 대사 출력과 함께 강화된 공격을 수행합니다.

---

### D. 확장 메서드 및 패턴 매칭 (Chapter 04, 05, 07)

1. **`ElementTypeExtensions` static 클래스 (확장 메서드)**
   - `ElementType`에 대한 확장 메서드 `GetDamageMultiplier(this ElementType attacker, ElementType defender)`를 구현하세요.
   - **C# switch 식(switch expression)과 패턴 매칭**을 반드시 활용하세요.
   - **상성 규칙**:
     - `Fire` -> `Grass`: 2.0배 (상성 우위)
     - `Water` -> `Fire`: 2.0배
     - `Grass` -> `Water`: 2.0배
     - `Grass` -> `Fire`: 0.5배 (상성 열세)
     - `Fire` -> `Water`: 0.5배
     - `Water` -> `Grass`: 0.5배
     - 그 외(None 포함 또는 동일 속성): 1.0배

---

### E. 전투 시뮬레이션 메인 로직 (`Program.cs`) (Chapter 04, 05)

`Main` 메서드에서 다음 시나리오를 수행하는 전투 루프를 작성하세요.

1. **객체 생성**:
   - 용사(`Hero`): 이름 "아더", Stat(Hp: 100, Atk: 20, Def: 5), 속성 `Fire`, 초기 Shield: 15
   - 몬스터(`Monster`): 이름 "드래곤", Stat(Hp: 120, Atk: 18, Def: 3), 속성 `Grass`
2. **null 조건부 연산자 및 null 병합 연산자 사용**:
   - Target 선택 시 `Character? currentTarget` 변수를 두고, null 체크를 null 조건부/병합 연산자(`?.`, `??`)로 안전하게 처리하는 로직을 1회 이상 포함하세요.
3. **전투 루프 (`while` 문)**:
   - 한 쪽의 `IsDead`가 `true`가 될 때까지 턴을 교대로 진행합니다.
   - **턴 1~2**: 용사가 일반 공격(`AttackTarget`)을 진행.
   - **턴 3부터**: 용사가 스킬(`UseSkill`)을 사용하여 강력한 공격 진행.
   - 몬스터는 매 턴 용사를 공격.
   - 매 턴 종료 시 두 캐릭터의 `GetStatusInfo()` 상태를 콘솔에 출력.
4. **전투 종료**:
   - 승리한 캐릭터의 이름을 출력하며 프로그램을 종료합니다.

---

## 3. 제약 및 주의사항
- `System` 외의 외부 라이브러리는 사용하지 않습니다.
- 힌트 코드나 정답 코드는 참조하지 않고, 명세서의 요구사항에 맞춰 클래스 구조를 직접 설계하세요.
- 각 기능 구현 시 배운 문법 키워드(`virtual`, `override`, `out`, `this`, `enum`, `struct`, `switch expression` 등)가 적절히 사용되었는지 스스로 검증하세요.