using System;

public class Program
{ 
    // 프로그램의 시작지점
    public static void Main()
    {
        // 이중 연결 리스트 인스턴스 생성
        DoublyLinkedList list = new DoublyLinkedList();

        // 노드 5개를 추가
        // 0부터 4까지 값을 가지는 노드를 리스트에 순차적으로 추가
        for(int i =0; i < 5; i++)
        {
            // 새로운 노드를 생성
            Node newNode = list.CreateNode(i);
            // 생성한 노드를 리스트의 끝부분에 추가
            list.AppendNode(newNode);
        }

        // 현재 리스트 상태 출력
        Console.WriteLine("초기 리스트");
        list.PrintList(); // 리스트 내 모든 노드를 순서대로 출력

        // 특정 위치에 노드 삽입
        // 리스트의 세 번째 위치 (인덱스 2) 뒤에 3000인 노드를 삽입
        Console.WriteLine("\n[2] 뒤에 3000 삽입...\n");

        Node current = list.GetNodeAt(2); // 인덱스 2 위치의 노드 가져오기
        Node newNode3000 = list.CreateNode(3000); // 값이 3000인 새로운 노드 생성

        list.InsertAfter(current, newNode3000); // 인덱스 2 뒤에 새로운 노드 삽입

        // 노드를 삽입한 후 리스트 상태 출력
        Console.WriteLine("새로운 노드를 추가한 리스트");
        list.PrintList(); // 리스트 내 모든 노드를 순서대로 출력

        // 리스트의 모든 노드를 삭제 
        Console.WriteLine("\n리스트 삭제 중..");
        while(list.GetNodeCount() > 0) // 리스트에 노드가 존재하는 동안 반복
        {
            Node currentHead = list.GetNodeAt(0); // 항상 리스트의 첫 번째 노드를 가져옴

            list.RemoveNode(currentHead); // 첫 번째 노드를 삭제
        }

        Console.WriteLine("리스트 삭제 완료"); // 모든 노드를 삭제 완료하면 메시지를 출력
    }
}
