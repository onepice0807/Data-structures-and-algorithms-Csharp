using System;

class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList(); // 새로운 리스트 생성

        // 리스트에서 0부터 4까지의 숫자를 가진 노드 추가
        for (int i = 0; i < 5; i++)
        {
            Node newNode = list.CreateNode(i); // 노드를 생성
            list.AppendNode(newNode); // 노드를 리스트 끝에 추가
        }

        // -1과 -2의 값을 가진 노드를 리스트 맨 앞에 추가
        Node newHeadNode = list.CreateNode(-1);
        list.InsertNewHead(newHeadNode);

        newHeadNode = list.CreateNode(-2);
        list.InsertNewHead(newHeadNode);

        // 초기 리스트 출력
        Console.WriteLine("초기 리스트");
        list.PrintList();

        // 인덱스 2의 노드 뒤에 3000의 값을 가진 새로운 노드 삽입
        Console.WriteLine("인덱스 2의 노드 뒤에 3000 값을 가진 새 노드 삽입");
        Node nodeAt2 = list.GetNodeAt(2); // 인덱스 2에 위치한 노드 찾기
        if(nodeAt2 != null)
        {
            Node newNode = list.CreateNode(3000); // 새 노드 생성
            list.InsertAfter(nodeAt2, newNode); // 특정 위치 뒤에 삽입
        }

        // 리스트 출력
        Console.WriteLine("리스트 출력");
        list.PrintList();

        // 리스트의 모든 노드를 제거
        Console.WriteLine("리스트의 모든 노드를 제거");
        list.Clear(); // 리스트 초기화 
        list.PrintList(); // 리스트가 비어있기 때문에 아무것도 출력되지 않음
    }
}