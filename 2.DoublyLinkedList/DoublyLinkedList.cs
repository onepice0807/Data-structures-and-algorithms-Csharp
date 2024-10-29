using System;
public class Node
{
    public int Data; // 노드가 저장하는 데이터
    public Node PrevNode; // 이전 노드를 가리키는 참조 (이전 노드와 연결)
    public Node NextNode; // 다음 노드를 가리키는 참조 (다음 노드와 연결)

    // 생성자: 새로운 노드를 생성할 때 데이터를 받아 초기화하고, PrevNode와 NextNode는 null로 초기화
    public Node(int data)
    {
        Data = data; // 주어진 데이터 값을 노드에 저장
        PrevNode = null; // 생성된 노드는 초기 상태에서 이전 노드가 없기으로 null로 설정
        NextNode = null; // 생성된 노드는 초기 상태에서 이전 노드가 없기으로 null로 설정
    }
}

public class DoublyLinkedList
{
    private Node Head; // 리스트의 첫 번째 노드를 참조 (리스트의 시작 지점)

    // 새 노드 생성 함수, 입력 데이터 값을 새로운 Node객체를 생성하고 반환
    public Node CreateNode(int data)
    {
        return new Node(data); // 입력 받은 데이터 값을 담는 새로운 노드를 생성하여 반환
    }
    
    // 리스트의 끝부분에 새로운 노드를 추가하는 함수
    public void AppendNode(Node newNode)
    {
        if (Head == null) // 리스트가 비어있는 경우
        {
            Head = newNode; // 새로운 노드를 Head로 설정하여 리스트의 시작 지점으로 설정
        }
        else
        {
            Node tail = Head; // 현재 Head 노드부터 시작해서 마지막 노드까지 이동

            // 끝부분의 노드를 찾기 위해 반복 (NextNode가 null인 마지막 노드를 찾음)
            while (tail.NextNode != null)
            {
                tail = tail.NextNode; // 다음 노드로 이동
            }

            // 마지막 노드의 다음 노드로 새로운 노드에 연결하고 새로운 노드의 이전 노드를 마지막 노드로 설정
            tail.NextNode = newNode;
            newNode.PrevNode = tail;
        }
    }

    // 현재 노드 뒤에 새로운 노드를 삽입하는 함수
    public void InsertAfter(Node currnet, Node newNode)
    {
        newNode.NextNode = currnet.NextNode; // 새로운 노드를 현재 노드의 다음 노드로 설정

        newNode.PrevNode = currnet; // 새로운 노드의 이전 노드를 현재 노드로 설정

        // 만약 현재 노드가 리스트의 마지막 노드가 아닐경우 현재 노드의 이전 노드를
        // 새로운 노드로 설정하고 양방향의 연결을 유지
        if(currnet.NextNode != null)
        {
            currnet.NextNode.PrevNode = newNode;
        }

        currnet.NextNode = newNode; // 현재 노드의 다음 노드를 새로운 노드로 바꾼다
    }

    // 특정 노드를 삭제하는 함수
    public void RemoveNode(Node remove)
    {
        if(Head == remove) // 삭제할 노드가 Head인 경우
        {
            Head = remove.NextNode; // 리스트의 Head를 다음 노드로 설정하여 삭제 노드를 제거

            if (Head != null) // 새로운 Head가 존재할 경우, 새로운 Head의 이전 노드를 null로 설정
            {
                Head.PrevNode = null;
            }
        }
        else
        {
            // 삭제할 노드가 리스트의 중간에 위치하는 경우
            if(remove.NextNode != null)
            {
                remove.PrevNode.NextNode = remove.NextNode; // 이전 노드의 다음을 삭제할 노드의 다음 노드로 연결

                remove.NextNode.PrevNode = remove.PrevNode; // 다음 노드의 이전을 삭제할 노드의 이전 노드로 연결
            }
            else
            {
                remove.PrevNode.NextNode = null; // 마지막 노드를 삭제하는 경우 이전 노드의 다음을 null로 설정
            }
        }
        // 삭제된 노드의 PrevNode와 NextNode를 null로 설정하여 참조를 끊음(가비지 컬렉터가 정리할 수 있도록 처리)
        remove.PrevNode = null;
        remove.NextNode = null;
    }

    // 리스트에서 특정 위치의 노드를 가져오는 함수
    public Node GetNodeAt(int location)
    {
        Node current = Head; // 첫 번째 노드부터 시작

        while(current != null && location--> 0)
        {
            current = current.NextNode; // 다음노드로 이동하면서 위치 값을 감소시킴
        }
        return current; // 지정된 위치의 노드를 반환 (해당 위치가 없으면 null 반환)
    }

    // 리스트에 있는 노드 개수를 계산하여 반환하는 함수
    public int GetNodeCount()
    {
        int count = 0; // 노드 개수 초기화
        Node current = Head; // Head 노드부터 시작

        while(current != null) // 마지막 노드까지 반복
        {
            current = current.NextNode; // 다음노드로 이동
            count++; // 노드 개수 증가
        }
        return count; // 노드 개수를 반환
    }

    // 리스트의 모든 노드를 출력하는 함수
    public void PrintList()
    {
        Node current = Head; // 첫 번째 노드부터 시작
        int index = 0; // 노드의 index

        while (current != null)  // 리스트의 끝부분까지 반복
        {
            // 각 노드의 데이터와 해당 위치를 출력
            Console.WriteLine($"List[{index}] : {current.Data}");

            current = current.NextNode; // 다음 노드로 이동

            index++; // index 증가
        }
    }


}
