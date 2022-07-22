# A Pair Wind

게임 개요
=========
게임 정보
---------
- 게임명 : A Pair Wind
- 장르 : 2D시점 3D그래픽 핵앤슬래시
- 플레이 인원 : 1
- 조작 : 키보드
- 게임 모드 
  - 프로젝트 기간 내 웨이브 모드 구현 예정
  - 프로젝트 종료 후 개인작업시 스테이지 및 스토리모드 구현 예정
-------
플레이 정보
--------
- 1인 플레이 시 2개의 케릭터를 번갈아가며 조작한다.
- 혼자 플레이 할 경우 1개의 케릭터는 가장 가까운 적 타겟팅 후 자동공격(기본공격만 사용)
- 플레이어 스테이터스
  - 체력 : 최대치 100으로 시작, 0이하로 떨어지면 사망
  - 스테미너 : 기본 공격/스킬공격시마다 지정된 수치만큼 소모, 움직이거나 공격할때보다 가만히 있으면 빠르게 회복. 0이하로 떨어지면 5초간 스턴.
  - 공격력 / 방어력 : 클래스마다 차이 있음
- 2개의 케릭터의 클래스(기사, 궁수, 암살자, 점술사)를 선택해 던전에 입장한다.
  - 성기사 : 공격력은 낮으나 방어력이 높음. 파티원을 지켜주는 스킬과 몬스터의 주의를 끌 수 있는 스킬 보유
  - 궁수 : 다수의 적을 공격하는 범위공격 스킬, 자체 회복스킬 보유
  - 암살자  : 적을 뒤에서 공격하면 큰 데미지를 주는 스킬, 적이 케릭터를 인식하지 못하는 은신 스킬 보유
  - 점술사 : 기본 공격이 없으며, 카드를 뽑아 단일공격/범위공격 스킬을 무작위로 얻으며 힐링 스킬 보유.
- 몬스터 처치시 일정 확률로 힐링포션 드랍, 획득 즉시 사용됨
- 던전 입장시 맵 내에 있는 적을 모두 없애면 웨이브 클리어
- 몬스터는 콜라이더 내 가장 가까운 플레이어 타겟팅 후 자동공격(단, 성기사의 도발 스킬 사용중엔 성기사 우선공격)
- 카메라는 두 케릭터의 중간에 위치(케릭터끼리 멀어지면 카메라 줌아웃)
- 몬스터 종류
    - 근거리 단일공격
    - 원거리 공격
---------
프로토타입 제작 예정사항
---------
1. 성기사 클래스 우선 제작 (주말내 구현 완료시 에셋 적용방안 검토)
  - 기본공격 : 범위공격
  - 스킬 1 : 범위 내 아군의 데미지를 대신 받는 스킬
  - 스킬 2 : 범위 내 적군의 어그로를 끄는 스킬
2. 적군 스포너 및 적군 단일공격 개체 구현
3. 아군 케릭터 2개 위치에 따른 카메라 위치 이동
4. 적군 처치 시 회복아이템 드랍(추후 버프아이템 추가를 위한 설계 필요)
5. 웨이브 클리어 시 플레이어 케릭터에 대한 회복 및 보상 추가
---------
조작
---------
- 인터페이스 조작
  - 방향키 ↑ : 상단 메뉴 이동
  - 방향키 ↓ : 하당 메뉴 이동
  - Enter : 선택
  - ESC : 취소/뒤로가기
  
1인 플레이

- Player 
  - 방향키 ↑ : 점프
  - 방향키 ↓ : 방어
  - 방향키 ← : 오른쪽 이동
  - 방향키 → : 왼쪽 이동
  - A : 기본 공격
  - S : 스킬 1
  - D : 스킬 2
  - W : 케릭터 스위칭
-------
필요 미디어 자료
-----
사운드
- BGM
  - 인트로컷신용
  - 메인메뉴용
  - 스테이지용

- 효과음
  - 스킬시전 효과음
  - 기본공격 효과음
  - 피격 효과음
  - 몬스터 죽음 효과음
  - 플레이어 죽음 효과음
    
이미지
- 인트로 컷신
  - 이미지 15장 준비완료.(깃 업데이트 완료)

--------
2022.07.17 - 15:15_ Readme 최초 작성.

2022.07.22 - 02:00_ 인트로 컷신 이미지 15장 업데이트 완료.

2022.07.22 - 16:30_ 지도교수님 피드백 반영 / 프로토타입 제작 범위 결정
