using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        LinkedListStack stack = new LinkedListStack();
        Stopwatch stopwatch = new Stopwatch(); // 소요시간 측정을 위한 변수
        stopwatch.Start();

        // 스택에 데이터 추가
        stack.Push(new Node("abc"));
        stack.Push(new Node("def"));
        stack.Push(new Node("efg"));
        stack.Push(new Node("hij"));

        // 10000개의 노드 추가
        for (int i = 0; i < 10000; i++)
        {
            string data = $"monster_{i}";
            stack.Push(new Node(data));
        }

        // 스택의 크기와 최상단 데이터 출력
        Console.WriteLine($"Size: {stack.GetSize()}, Top: {stack.Peek().Data}\n");

        // 스택에서 데이터를 pop하고 출력
        int count = stack.GetSize();
        for (int i = 0; i < count; i++)
        {
            if (stack.IsEmpty())
                break;

            Node popped = stack.Pop();
            Console.WriteLine($"Popped: {popped.Data}, ");
            if (!stack.IsEmpty())
            {
                Console.WriteLine($"Current Top: {stack.Peek().Data}");
            }
            else
            {
                Console.WriteLine("Stack이 비었습니다.");
            }
        }

        stopwatch.Stop();
        Console.WriteLine($"소요시간: {stopwatch.Elapsed.TotalSeconds}");
    }
}