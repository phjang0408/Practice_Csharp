using System;
using System.Collections.Generic;
namespace QueueStackStudy
{
    class Program
    {
        static void Main()
        {
            // ── Queue<T> : FIFO (First In, First Out) ────────────────
            // 먼저 들어온 것이 먼저 나옴 → 줄 서기, 작업 대기열
            Queue<string> queue = new Queue<string>();

            // 추가: Enqueue
            queue.Enqueue("첫 번째");
            queue.Enqueue("두 번째");
            queue.Enqueue("세 번째");
            Console.WriteLine("=== Queue ===");
            Console.WriteLine($"Count: {queue.Count}");

            // 앞 요소 확인 (제거 없이): Peek
            Console.WriteLine($"Peek: {queue.Peek()}");

            // 꺼내기: Dequeue (앞에서부터)
            Console.WriteLine($"Dequeue: {queue.Dequeue()}");
            Console.WriteLine($"Dequeue: {queue.Dequeue()}");
            Console.WriteLine($"남은 Count: {queue.Count}");

            // ── Stack<T> : LIFO (Last In, First Out) ─────────────────
            // 나중에 들어온 것이 먼저 나옴 → Ctrl+Z(되돌리기), 함수 호출 스택
            Stack<string> stack = new Stack<string>();

            // 추가: Push
            stack.Push("바닥");
            stack.Push("중간");
            stack.Push("맨 위");
            Console.WriteLine("\n=== Stack ===");
            Console.WriteLine($"Count: {stack.Count}");

            // 맨 위 요소 확인 (제거 없이): Peek
            Console.WriteLine($"Peek: {stack.Peek()}");

            // 꺼내기: Pop (위에서부터)
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"남은 Count: {stack.Count}");

            // ── 정리 ─────────────────────────────────────────────────
            // Queue : Enqueue → [1, 2, 3] → Dequeue 순서: 1, 2, 3
            // Stack : Push    → [1, 2, 3] → Pop    순서: 3, 2, 1
        }
    }
}
