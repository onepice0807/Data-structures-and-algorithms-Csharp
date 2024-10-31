using System;

public class Node
{
    public int Data; // 노드에 저장된 데이터 값
    public Node PrevNode; // 이전 노드를 가리키는 참조 변수
    public Node NextNode; // 다음 노드를 가리키는 참조 변수

    // 생성자 : 노드를 생성하면서 데이터 값을 초기화

    public Node(int data)
    {
        Data = data;
        PrevNode = null;
        NextNode = null;
    }
}

public class CircularDoublyLinkedList
{
    public Node Head = null; // 리스트의 첫 노드(Head)

    // 노드를 생성하는 함수
    public Node CreateNode(int newData)
    {
        return new Node(newData);
    }

    // 새로운 노드를 리스트에 추가하는 함수 끝부분에 추가
    public void AppendNode(Node newNode)
    {
        // 리스트에 노드가 없을 경우 새로운 노드를 Head로 지정해서 순환 연결 설정
        if (Head == null)
        {
            Head = newNode;
            Head.NextNode = Head;
            Head.PrevNode = Head;
        }
        else
        {
            // 마지막 노드를 찾아 새로운 노드를 연결
            Node tail = Head.PrevNode;

            tail.NextNode = newNode;
            newNode.PrevNode = tail;

            newNode.NextNode = Head;
            Head.PrevNode = newNode;
        }
    }

    // 특정 노드 뒤에 새로운 노드를 삽입하는 함수
    public void InsertAfter(Node current, Node newNode)
    {
        // 새로운 노드의 다음 노드를 현재 노드의 다음 노드로 설정
        newNode.NextNode = current.NextNode;
        newNode.PrevNode = current; // 새로운 노드의 이전 노드를 현재 노드로 설정

        if (current.NextNode != null) // 현재 노드의 다음 노드가 존재하는 경우
        {
            current.NextNode.PrevNode = newNode; // 다음 노드의 이전 참조를 새로운 노드로 연결
            current.NextNode = newNode; // 현재 노드의 다음 노드를 새로운 노드로 설정
        }
    }

    // 특정 노드를 리스트에서 제거하는 함수
    public void RemoveNode(Node remove)
    {
        if (Head == remove) // 제거하려는 노드가 Head인 경우
        {
            // Head의 이전 노드의 다음 노드를 현재의 Head의 다음 노드로 설정
            Head.PrevNode.NextNode = remove.NextNode;

            // 제거된 노드의 이전, 다음 참조를 제거한다
            remove.PrevNode = null;
            remove.NextNode = null;
        }
        else // 제거하려는 노드가 Head가 아닌 다른 노드인 경우
        {
            // 제거할 노드의 이전 노드의 다음 노드를 제거할 노드의 다음 노드로 설정
            remove.PrevNode.NextNode = remove.NextNode;
            // 제거할 노드의 다음 노드의 이전 노드를 제거할 노드의 이전 노드로 설정
            remove.NextNode.PrevNode = remove.PrevNode;
            // 제거된 노드의 이전, 다음 참조를 제거
            remove.PrevNode = null;
            remove.NextNode = null;
        }
    }

    // 특정 위치에 있는 노드를 가져오는 함수
    public Node GetNodeAt(int location)
    {
        Node current = Head;

        while (current != null && (--location) >= 0) // location값만큼 순회하며 해당 위치의 노드를 반환
        {
            current = current.NextNode;
        }
        return current; // 순환하며 찾은 노드를 반환 (없을경우 null)
    }

    public int GetNodeCount()
    {
        int count = 0;
        Node current = Head;

        if (current == null) return count; // 리스트가 비어있으면 0을 반환

        // Head부터 순회하며 개수를 카운트하고, 순환 리스트 구조에 맞게 한 번 더 Head에 도달하면 종료
        do
        {
            count++;
            current = current.NextNode;
        }
        while (current != Head);

        return count;
    }

    // 특정 노드의 정보를 출력하는 함수 (이전, 현재, 다음 노드의 데이터를 출력)
    public void PrintNode(Node node)
    {
        string prevData = node.PrevNode == null ? "NULL" : node.PrevNode.Data.ToString();
        string nextData = node.NextNode == null ? "NULL" : node.NextNode.Data.ToString();

        Console.WriteLine($"Prev : {prevData}, Next : {nextData}");
    }
}