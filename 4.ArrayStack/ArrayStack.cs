using System;
public class ArrayStack
{
    // Stack의 용량과 현재 Top위치를 정의하는 변수
    private int Capacity; // Stack이 담을 수 있는 최대 요소의 개수
    private int Top; // Stack의 현재 가장 상위 요소의 index 위치
    private int[] Nodes; // Stack에 저장될때 실제 데이터의 배열

    // 생성자 : 주어진 용량으로 Stack을 초기화
    public ArrayStack(int capacity)
    {
        Capacity = capacity; // Stack의 용량을 설정
        Top = -1; // 초기에는 Stack이 비어있기 때문에 Top을 -1로 설정
        Nodes = new int[Capacity]; // Stack의 데이터를 저장할 배열을 생성
    }

    // Stack에 데이터 추가 (Push)
    // Stack의 가장 상위에 새로운 데이터를 추가
    public void Push(int data)
    {
        // Stack이 가득 찼는지 확인
        if (Top >= Capacity - 1)
        {
            throw new IndexOutOfRangeException("Stack이 가득 찼습니다"); // 오류발생에 대한 예외 처리
        }
        Nodes[++Top] = data; // Top을 증가시키고 해당 위치에 데이터를 저장
    }
    // Stack에서 데이터를 제거 (Pop)
    // Stack의 가장 상위에 있는 데이터를 제거하고 반환
    public int Pop()
    {
        // Stack이 비어있는지 확인
        if (IsEmpty())
        {
            throw new IndexOutOfRangeException("Stack이 비어 있습니다"); // 오류발생에 대한 예외 처리
        }
        return Nodes[Top--]; // 최상위 요소의 데이터를 반환
    }

    // 스택의 최상위 데이터 확인 (Peek)
    // 데이터를 제거하지 않고 현재 스택의 최상위 데이터를 반환
    public int Peek()
    {
        // 스택이 비어있는지 확인
        if (IsEmpty())
        {
            throw new InvalidOperationException("스택이 비어 있습니다."); // 오류발생에 대한 예외 처리
        }

        return Nodes[Top]; // 최상위 요소의 데이터를 반환
    }

    // 현재 Stack 크기를 반환 (GetSize)
    // 현재 Stack에 저장된 요소의 개수를 반환
    public int GetSize()
    {
        return Top + 1; // 인덱스는 0부터 시작하므로 Top + 1이 실제 크기
    }

    // Stack이 비어있는지 여부를 확인 (IsEmpty)
    // Stack에 요소가 하나도 없는지 확인하여 ture 또는 false 반환
    public bool IsEmpty()
    {
        return Top == -1; // Top이 -1이라면 Stack이 비어있는 상태
    }
}
