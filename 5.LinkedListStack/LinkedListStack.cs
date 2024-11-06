using System;
using System.Diagnostics;

// 노드 클래스 정의
public class Node
{
    public string Data; // 노드가 저장하는 문자열 데이터
    public Node NextNode; // 다음 노드를 가리키는 참조값
    public Node PrevNode; // 이전 노드를 가리키는 참조값

    // 생성자 : 새로운 노드를 생성할 때 데이터를 초기화
    public Node(string data)
    {
        Data = data;
        NextNode = null; // 다음 노드의 참조값 초기화
        PrevNode = null; // 이전 노드의 참조값 초기화
    }
}

// LinkedListStack 클래스 정의
public class LinkedListStack
{
    public int Count { get; private set; } // 스택 내 노드 개수
    public Node List; // 스택의 첫 번째 노드를 가리키는 참조값
    public Node Top; // 스택의 최상단 노드를 가리키는 참조값

    // 생성자 : LinkedListStack을 초기화
    public LinkedListStack()
    {
        List = null; // 리스트의 참조값 초기화
        Top = null; // Top의 참조값 초기화
        Count = 0; // 노드 개수를 초기화
    }

    // 새로운 노드를 생성하고 LinkedListStack에 추가
    public void Push(Node newNode)
    {
        if (List == null)
        {
            // 스택이 비어있다면 새로운 노드를 첫 번째 노드로 설정
            List = newNode;
        }
        else
        {
            // 기존의 Top 뒤에 새로운 노드를 연결
            Top.NextNode = newNode;
            newNode.PrevNode = Top;
        }
        Top = newNode; // Top을 새로운 노드로 갱신
        Count++; // 노드 개수를 증가
    }

    // 스택에서 데이터를 제거 (Pop)
    public Node Pop()
    {
        if (IsEmpty())
        {
            return null;
        }
        Node topNode = Top; // 최상위 노드를 임시로 저장

        if (List == Top)
        {
            // 스택에 노드가 하나뿐인 경우
            List = null;
            Top = null;
        }
        else
        {
            // 두 번째 노드를 새로운 Top으로 설정
            Top = Top.PrevNode;
            Top.NextNode = null;
        }
        Count--; // 노드 개수를 감소
        return topNode; // 제거된 노드를 반환
    }

    // 스택의 최상단 데이터를 확인
    public Node Peek()
    {
        return Top; // Top 노드를 반환
    }

    // 현재 스택 크기를 반환
    public int GetSize()
    {
        return Count; // 노드 개수 반환
    }

    // 스택이 비어있는지 확인
    public bool IsEmpty()
    {
        return List == null; // 리스트가 null이면 스택이 비어있다
    }
}