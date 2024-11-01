using System;
class Program
{
     static void Main(string[] args)
    {
        // 용량이 50인 Stack 생성
        ArrayStack stack = new ArrayStack(50); // ArrayStack 객체를 생성하고 용량을 50으로 설정

        // while문을 사용하여 Stack에 값을 채우기
        int i = 0; // 반복문의 초기값을 설정
        while (i < 50) // Stack이 가득 찰 때까지 반복
        {
            stack.Push(i + 1); // Stack에 1부터 50까지 값을 추가
            i++;
        }

        // Stack의 현재 상태를 출력
        Console.WriteLine($"Capacity: 50, Size: {stack.GetSize()}, Top: {stack.Peek()}\n");

        // Stackdl 비어있을 때까지 값을 pop하고 출력

        while (!stack.IsEmpty()) // Stack이 비어있지 않는다면 계속 실행
        {
            Console.WriteLine($"Popped: {stack.Pop()}"); // 최상위 값을 pop하여 출력

            if (!stack.IsEmpty()) // Stack이 비어있지 않는다면 현재 Top값을 출력
            {
                Console.WriteLine($"Current Top: {stack.Peek()}");
            }
            else
            {
                Console.WriteLine("스택이 비어 있습니다."); // Stack이 비었을 때 알림
            }
        }
    }
}