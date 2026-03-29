using System;
using System.Collections.Generic;
namespace CollectionIterationStudy
{
    class Program
    {
        static void Main()
        {
            // ── 배열 순회 ────────────────────────────────────────────
            int[] arr = { 10, 20, 30, 40, 50 };

            // for: 인덱스가 필요할 때
            Console.WriteLine("=== 배열 for ===");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"arr[{i}] = {arr[i]}");

            // foreach: 값만 필요할 때 (더 간결)
            Console.WriteLine("\n=== 배열 foreach ===");
            foreach (int n in arr)
                Console.Write(n + " ");
            Console.WriteLine();

            // ── List<T> 순회 ─────────────────────────────────────────
            List<string> fruits = new List<string> { "사과", "바나나", "포도" };

            Console.WriteLine("\n=== List foreach ===");
            foreach (string fruit in fruits)
                Console.WriteLine(fruit);

            // ── Dictionary 순회 ──────────────────────────────────────
            // foreach → KeyValuePair<K, V> 로 분해됨
            Dictionary<string, int> scores = new Dictionary<string, int>
            {
                { "Alice", 95 },
                { "Bob",   80 },
                { "Charlie", 70 }
            };

            Console.WriteLine("\n=== Dictionary foreach ===");
            foreach (KeyValuePair<string, int> kv in scores)
                Console.WriteLine($"{kv.Key}: {kv.Value}");

            // var로 간결하게 쓰는 방식
            Console.WriteLine("\n=== Dictionary foreach (var) ===");
            foreach (var kv in scores)
                Console.WriteLine($"{kv.Key}: {kv.Value}");

            // ── Queue 순회 (꺼내지 않고 읽기만) ────────────────────
            Queue<string> queue = new Queue<string>(new[] { "A", "B", "C" });

            Console.WriteLine("\n=== Queue foreach ===");
            foreach (string item in queue)     // 순서: 들어온 순서 (FIFO)
                Console.Write(item + " ");
            Console.WriteLine();

            // ── Stack 순회 (꺼내지 않고 읽기만) ────────────────────
            Stack<string> stack = new Stack<string>(new[] { "A", "B", "C" });

            Console.WriteLine("\n=== Stack foreach ===");
            foreach (string item in stack)     // 순서: 나중에 들어온 것부터 (LIFO)
                Console.Write(item + " ");
            Console.WriteLine();

            // ── for vs foreach 선택 기준 ─────────────────────────────
            // for     : 인덱스 필요, 역순 순회, 특정 범위만 순회할 때
            // foreach : 단순 읽기, 코드가 더 간결할 때
        }
    }
}
