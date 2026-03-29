using System;
using System.Collections.Generic;
namespace ListStudy
{
    class Program
    {
        static void Main()
        {
            // ── List<T> 선언 ─────────────────────────────────────────
            // 배열과 달리 크기가 고정되지 않고, 요소를 자유롭게 추가/삭제할 수 있음
            List<int> list = new List<int>();

            // ── 추가: Add ────────────────────────────────────────────
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            Console.WriteLine("Add 후: " + string.Join(", ", list));

            // ── 삭제: Remove (값으로 삭제) ───────────────────────────
            list.Remove(30);                   // 값 30을 찾아서 삭제
            Console.WriteLine("Remove(30): " + string.Join(", ", list));

            // ── 삭제: RemoveAt (인덱스로 삭제) ──────────────────────
            list.RemoveAt(0);                  // 인덱스 0 (값 10) 삭제
            Console.WriteLine("RemoveAt(0): " + string.Join(", ", list));

            // ── 검색: Contains, IndexOf ──────────────────────────────
            Console.WriteLine($"Contains(40): {list.Contains(40)}");
            Console.WriteLine($"IndexOf(50): {list.IndexOf(50)}");

            // ── Count ────────────────────────────────────────────────
            Console.WriteLine($"Count: {list.Count}");

            // ── 선언과 동시에 초기화 ─────────────────────────────────
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            Console.WriteLine("\n이름 목록: " + string.Join(", ", names));

            // ── 배열 vs List 차이 ────────────────────────────────────
            // int[] arr = new int[3];   // 크기 고정, 변경 불가
            // List<int> list2 = ...;    // 크기 동적, Add/Remove 자유
        }
    }
}
