# Data-structures-and-algorithms-Csharp
C#언어를 통한 자료구조 및 알고리즘 공부내용 정리

---

## LinkedList (단일 연결 리스트) - C# 구현

1. **노드 생성 및 리스트 끝에 추가**  
   - `Node` 클래스는 데이터를 저장하고 `NextNode`로 다음 노드를 참조
   - `CreateNode(int data)`로 새 노드를 생성
   - `AppendNode(Node newNode)`로 리스트의 끝에 노드를 추가

2. **리스트 시작 부분 또는 특정 위치에 노드 삽입**  
   - `InsertNewHead(Node newHead)`로 리스트 맨 앞에 노드를 삽입
   - `InsertAfter(Node current, Node newNode)`로 지정된 노드 뒤에 새 노드를 삽입

3. **특정 노드 제거**  
   - `RemoveNodeAt(Node removeNode)`로 리스트에서 지정된 노드를 삭제

4. **노드 개수 세기**  
   - `GetNodeCount()`로 리스트의 모든 노드를 카운트하여 반환

5. **리스트 초기화**  
   - `Clear()`로 리스트를 초기화하고, C#의 가비지 컬렉터가 메모리를 자동 관리

---

## DoublyLinkedList (이중 연결 리스트) - C# 구현

1. **노드 생성 및 리스트 끝에 추가**  
   - `Node` 클래스는 데이터를 저장하고 `PrevNode`와 `NextNode`로 양방향 연결을 유지
   - `CreateNode(int data)`로 새 노드를 생성
   - `AppendNode(Node newNode)`로 리스트의 끝에 노드를 추가

2. **리스트 특정 위치에 노드 삽입**  
   - `InsertAfter(Node current, Node newNode)`로 지정된 노드 뒤에 새 노드를 삽입하여 양방향 연결 유지

3. **특정 노드 제거**  
   - `RemoveNode(Node remove)`로 리스트에서 지정된 노드를 삭제하며, 리스트의 첫 노드, 중간, 끝 노드에 맞게 처리

4. **노드 개수 세기**  
   - `GetNodeCount()`로 리스트의 모든 노드를 카운트하여 반환

5. **리스트 초기화**  
   - `Main()`에서 `RemoveNode()`를 반복 호출하여 모든 노드를 삭제하고 초기화
