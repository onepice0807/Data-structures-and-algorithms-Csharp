public class Program
{
    public static void Main()
    {
        // 새로운 CircularDoublyLinkedList 생성
        CircularDoublyLinkedList list = new CircularDoublyLinkedList();

        // 5개의 노드를 추가하고 리스트에 연결
        for (int i = 0; i < 5; i++)
        {
            // 새로운 노드를 생성 (노드의 데이터는 0 ~ 4까지의 숫자)
            Node newNode = list.CreateNode(i);
            list.AppendNode(newNode); // 새로운 노드를 리스트에 추가 (리스트 끝부분에 추가)
        }

        // 전체 리스트를 출력
        Console.WriteLine("\n전체 리스트를 출력\n");
        int count = list.GetNodeCount(); // 리스트의 노드 개수를 계산

        for (int i = 0; i < count; i++)
        {
            Node current = list.GetNodeAt(i); // 해당 index의 노드를 가져오기
            Console.WriteLine($"List[{i}] : {current.Data}"); // 가져온 노드 데이터 출력
        }

        // 리스트의 특정 위치 (2번 index) 뒤에 새 노드 (3000 데이터 값)를 삽입
        Console.WriteLine("\n특정 위치 (2번 index) 뒤에 새로운 노드 (3000 데이터 값)를 삽입\n");

        Node nodeAt2 = list.GetNodeAt(2);  // 2번 index에 해당하는 노드 가져오기
        Node newNode3000 = list.CreateNode(3000); // 데이터 값이 3000인 새로운 노드를 생성
        list.InsertAfter(nodeAt2, newNode3000); // 2번 index 위치 뒤에 새로운 노드를 삽입

        for (int i = 0; i < count; i++)
        {
            Node current = list.GetNodeAt(i); // 해당 index의 노드를 가져오기
            Console.WriteLine($"List[{i}] : {current.Data}"); // 가져온 노드 데이터 출력
        }

        // 리스트에서 특정 위치 (2번 index) 노드를 제거
        Console.WriteLine("\n리스트에서 특정 위치 (2번 index) 노드를 제거\n");

        Node nodeAtRemove = list.GetNodeAt(2); // 2번 index 위치의 노드를 가져오기
        list.RemoveNode(nodeAtRemove); // 해당하는 노드를 제거

        // 리스트의 모든 노드의 순환 구조 확인을 위해 2배로 반복 출력
        count = list.GetNodeCount(); // 노드의 개수를 다시 계산
        Node currentNode = list.Head; // 리스트의 시작 노드 (Head)

        for (int i = 0; i < count * 2; i++) // 순환 리스트 구조를 확인하기 위해 2배만큼 반복
        {
            Console.WriteLine($"List[{i}] : {currentNode.Data}"); // 현재 노드의 데이터를 출력
            currentNode = currentNode.NextNode; // 다음 노드로 이동
        }

        // 리스트의 모든 노드를 제거하여 메모리에서 정리
        Console.WriteLine("\n리스트의 모든 노드를 제거\n");

        count = list.GetNodeCount(); // 남아있는 노드의 개수 계산

        for (int i = 0; i < count; i++)
        {
            Node current = list.GetNodeAt(0); // 항상 첫 번째 노드를 가져온다

            if (current != null) // 올바른 null 확인
            {
                list.RemoveNode(current); // 해당 노드를 리스트에서 제거
            }
        }
    }
}