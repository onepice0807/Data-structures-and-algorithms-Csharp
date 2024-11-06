# Data-structures-and-algorithms-Csharp
C#언어를 통한 자료구조 및 알고리즘 공부내용 정리

---

## LinkedList (단일 연결 리스트) - C# 구현

1. **노드 생성 및 리스트 끝에 추가**  
   - `Node` 클래스는 데이터를 저장하고 `NextNode`로 다음 노드를 참조
   - `CreateNode(int data)`로 새로운 노드를 생성
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
   - `CreateNode(int data)`로 새로운 노드를 생성
   - `AppendNode(Node newNode)`로 리스트의 끝에 노드를 추가

2. **리스트 특정 위치에 노드 삽입**  
   - `InsertAfter(Node current, Node newNode)`로 지정된 노드 뒤에 새로운 노드를 삽입하여 양방향 연결 유지

3. **특정 노드 제거**  
   - `RemoveNode(Node remove)`로 리스트에서 지정된 노드를 삭제하며, 리스트의 첫 노드, 중간, 끝 노드에 맞게 처리

4. **노드 개수 세기**  
   - `GetNodeCount()`로 리스트의 모든 노드를 카운트하여 반환

5. **리스트 초기화**  
   - `Main()`에서 `RemoveNode()`를 반복 호출하여 모든 노드를 삭제하고 초기화
	
---

## CircularDoublyLinkedList (순환 이중 연결 리스트) - C# 구현

1. 노드 생성 및 리스트에 추가

- `Node` 클래스는 데이터를 저장하고 `PrevNode`와 `NextNode`로 양방향 연결을 유지
- `CreateNode(int data)`로 새로운 노드를 생성합니다.
- `AppendNode(Node newNode)`로 리스트의 끝에 노드를 추가하며 순환 연결 구조를 유지
  - **리스트가 비어 있을 경우**: 새 노드를 `Head`로 지정하고 `PrevNode`와 `NextNode`를 자신으로 설정하여 단일 노드의 순환 구조를 형성
  - **리스트가 비어 있지 않을 경우**: 마지막 노드(`tail`)를 찾아 새 노드를 연결하고, `Head`와의 순환 연결을 유지

2. 리스트 특정 위치에 노드 삽입

- `InsertAfter(Node current, Node newNode)`로 지정된 노드 뒤에 새로운 노드를 삽입하여 순환 연결 구조를 유지
  - 새로운 노드의 `PrevNode`를 `current`로, `NextNode`를 `current.NextNode`로 설정
  - 기존 다음 노드의 `PrevNode`를 새로운 노드로 업데이트하고, `current.NextNode`를 새로운 노드로 설정

3. 특정 노드 제거

- `RemoveNode(Node remove)`로 리스트에서 지정된 노드를 삭제하며 순환 연결 구조를 유지
  - **제거하려는 노드가 `Head`인 경우**:
    - `Head.PrevNode.NextNode`를 `remove.NextNode`로 설정하여 이전 노드와 다음 노드를 연결
    - `Head.NextNode.PrevNode`를 `remove.PrevNode`로 설정하여 다음 노드의 이전 참조를 업데이트
    - `Head`를 `Head.NextNode`로 이동하여 리스트의 시작점을 업데이트합니다.
  - **제거하려는 노드가 `Head`가 아닌 경우**:
    - 제거할 노드의 이전 노드(`remove.PrevNode`)의 `NextNode`를 제거할 노드의 다음 노드로 설정
    - 제거할 노드의 다음 노드(`remove.NextNode`)의 `PrevNode`를 제거할 노드의 이전 노드로 설정
  - 제거된 노드의 `PrevNode`와 `NextNode`를 `null`로 설정하여 참조를 해제

4. 특정 위치의 노드 가져오기

- `GetNodeAt(int location)`으로 지정된 위치의 노드를 반환
  - `Head`부터 시작하여 `location`만큼 `NextNode`를 따라 이동
  - 순환 리스트이므로 리스트의 길이를 초과하는 위치를 지정하면 순환하여 노드를 반환할 수 있다

5. 노드 개수 세기

- `GetNodeCount()`로 리스트의 모든 노드를 카운트하여 반환
  - 리스트가 비어 있으면 `0`을 반환
  - `Head`부터 시작하여 `NextNode`를 따라 `Head`에 다시 도달할 때까지 순회하며 개수를 카운트

6. 노드 정보 출력

- `PrintNode(Node node)`로 지정된 노드의 이전 노드, 현재 노드, 다음 노드의 데이터를 출력
  - 이전 또는 다음 노드가 없을 경우 `"NULL"`로 표시

7. 리스트 초기화

- `Main()`에서 `RemoveNode()`를 반복 호출하여 모든 노드를 삭제하고 초기화
  - 리스트의 노드 개수를 구한 후, `GetNodeAt(0)`을 통해 항상 첫 번째 노드를 가져와 제거
  - 모든 노드가 제거되면 `Head`는 `null`이 되며, 리스트가 초기화
  	
---

## ArrayStack (배열 기반 스택) - C# 구현

1. 스택 생성 및 데이터 추가

- `ArrayStack` 클래스는 `Capacity`, `Top` 변수와 `Nodes` 배열을 사용하여 최대 용량을 지정하고, 스택 데이터를 저장
- 생성자 `ArrayStack(int capacity)`: 주어진 용량으로 스택을 초기화
- `Push(int data)`: 스택의 상단에 새로운 데이터를 추가합니다. 스택이 가득 차면 예외처리
 
2. 스택 상단 데이터 제거 및 확인

- `Pop()`: 스택의 상단에서 데이터를 제거하고 반환합니다. 스택이 비어 있으면 예외처리
- `Peek()`: 스택의 상단 데이터를 제거하지 않고 반환합니다. 스택이 비어 있으면 예외처리
  - 기존 다음 노드의 `PrevNode`를 새로운 노드로 업데이트하고, `current.NextNode`를 새로운 노드로 설정

3. 스택의 크기 및 상태 확인

- `GetSize()`: 스택에 저장된 데이터의 개수를 반환
- `IsEmpty()`: 스택이 비어있는지 확인하여 true 또는 false를 반환

---

## LinkedListStack (연결 리스트 스택) - C# 구현

1. 스택 생성 및 초기화

- `LinkedListStack` 클래스는 `Count`, `List`, `Top` 속성을 통해 스택을 정의
- `new LinkedListStack()` 생성자로 스택을 초기화하여 빈 상태의 스택을 생성
- `Push(int data)`: 스택의 상단에 새로운 데이터를 추가합니다. 스택이 가득 차면 예외처리
 
2. 스택 데이터 추가 및 제거

- `Push(Node newNode)`: 새로운 노드를 스택의 상단에 추가
- 스택이 비어있다면 첫 번째 노드로 설정하고, 그렇지 않으면 기존 최상단 노드 뒤에 연결하여 최상단 노드를 갱신
- `Pop()`: 최상단 노드를 제거하고 반환합니다. 스택이 비어있으면 null을 반환
- 최상단 노드를 제거한 후 새로운 최상단 노드를 갱신

3. 스택 상단 데이터 확인 및 상태 체크

- `Peek()`: 스택의 최상단 노드를 확인하여 반환합니다. 스택의 데이터를 확인만 하고 제거X
- `GetSize()`: 현재 스택 내 노드의 개수를 반환
- `IsEmpty()`: 스택이 비어있는지 여부를 확인하여 반환 (비어있다면 `true`, 그렇지 않다면 `false`)
- C#은 가비지 컬렉터를 통해 메모리를 자동 관리하므로, 스택의 메모리 해제를 위한 별도의 함수가 필요X