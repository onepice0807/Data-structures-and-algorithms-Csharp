using System;

public class Node
{
    public int Data { get; set; } // 노드가 저장할 데이터
    public Node NextNode { get; set; } // 다음 노드를 가리키는 포인터

    // 노드를 생성할 때 데이터 값을 초기화한다
    public Node(int newData)
    {
        Data = newData; // 전달받은 데이터 값을 저장
        NextNode = null; // 최초실행시에는 다음 노드가 없기 때문에 null로 설정
    }
}

public class LinkedList
{
    private Node head; // 리스트의 첫번째 노드를 참조

    public LinkedList()
    {
        head = null; // 처음에는 아무것도 없는 null상태로 리스트를 시작
    }

    // 새로운 노드를 생성한 뒤 반환한다
    public Node CreateNode(int data)
    {
        return new Node(data); // 주어진 데이터를 담는 노드를 생성
    }

    // 노드추가 (리스트의 끝에 노드를 추가한다)
    public void AppendNode(Node newNode)
    {
        if(head == null)
        {
            head = newNode; // 만약 리스트가 null이라면 새로운 노드가 head가 된다
        }
        else
        {
            Node tail = head; // 시작 노드부터 순차적으로 찾는다
            while(tail.NextNode != null)
            {
                tail = tail.NextNode; // 마지막 노드를 찾는다
            }

            tail.NextNode = newNode; // 마지막 노드의 다음순번에 새로은 노드를 연결
        }
    }

    // 리스트의 맨 앞에 새로운 노드 삽입
    public void InsertNewHead(Node newHead)
    {
        newHead.NextNode = head; // 새로운 노드가 기존의 head를 가르키도록 설정
        head = newHead; // 새로운 노드를 head로 설정
    }

    // 특정 노드 뒤에 새로운 노드를 삽입
    public void InsertAfter(Node current, Node newNode)
    {
        newNode.NextNode = current.NextNode; // 새로운 노드가 current의 다음 노드를 가리키도록 설정
        current.NextNode = newNode; // current의 다음노드로 새로운 노드를 설정
    }

    // 특정 위치의 노드를 찾음 (0부터 시작하는 인덱스)
    public Node GetNodeAt(int location)
    {
        Node current = head; // 첫 번째 노드부터 찾기 시작
        int count = 0; // 현재 위치를 추적하는 변수

        while (current != null && count < location)
        {
            current = current.NextNode;
            count++;
        }
        return current; // 위치에 해당하는 노드를 반환(없다면 null)
    }

    // 특정 노드를 리스트에서 제거
    public void RemoveNodeAt(Node removeNode)
    {
        if(head == removeNode)
        {
            head = removeNode.NextNode; // 삭제할 노드가 head인 경운 head를 다음노드로 설정
        }
        else
        {
            Node current = head;
            // 삭제할 노드 앞까지 이동
            while (current != null && current.NextNode != removeNode)
            {
                current = current.NextNode;
            }

            // 삭제할 노드를 연결해서 제거
            if(current != null)
            {
                current.NextNode = removeNode.NextNode;
            }
        }
    }

    // 리스트의 노드 개수를 계산
    public int GetNodeCount()
    {
        int count = 0; // 노드의 개수를 저장할 변수
        Node current = head; // 첫 번째 노드부터 탐색

        while (current != null) // 리스트가 끝날때까지 반복
        {
            count++;
            current = current.NextNode;
        }
        return count; // 총 노드 개수를 반환
    }
    
    // 리스트의 모든 노드를 출력
    public void PrintList()
    {
        Node current = head; // 첫 번째 노드부터 탐색
        int index = 0; // 각 노드의 위치 표시

        while (current != null)
        {
            Console.WriteLine($"List[{index++}] : {current.Data}"); // 현재 노드의 데이터 출력
            current = current.NextNode; // 다음 노드로 이동
        }
    }

    // 리스트의 모든 노드를 제거 (메모리에서 해제)
    public void Clear()
    {
        head = null; // head를 null로 설정해서 모든노드의 연결을 해제
        // C#의 경우 가비지 컬렉터가 메모리를 관리하기 때문에 C/C++ 추가조치가 필요없음
    }
}
