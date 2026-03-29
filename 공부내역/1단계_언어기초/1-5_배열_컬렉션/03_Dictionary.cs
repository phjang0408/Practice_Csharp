using System;
using System.Collections.Generic;
namespace DictionaryStudy
{
    class Program
    {
        static void Main()
        {
            // ── Dictionary<K, V> 선언 ────────────────────────────────
            // 키(Key)와 값(Value)을 쌍으로 저장, 키는 중복 불가
            Dictionary<string, int> scores = new Dictionary<string, int>();

            // ── 추가: Add ────────────────────────────────────────────
            scores.Add("Alice", 95);
            scores.Add("Bob",   80);
            scores.Add("Charlie", 70);

            // ── 인덱서로 값 접근/추가 ────────────────────────────────
            scores["Dave"] = 88;           // 없으면 추가, 있으면 덮어쓰기
            Console.WriteLine($"Dave: {scores["Dave"]}");

            // ── 키 존재 확인: ContainsKey ────────────────────────────
            if (scores.ContainsKey("Alice"))
                Console.WriteLine($"Alice의 점수: {scores["Alice"]}");

            // ── 안전한 읽기: TryGetValue ─────────────────────────────
            // ContainsKey + 인덱서 접근을 한 번에 처리 (키 없을 때 예외 방지)
            if (scores.TryGetValue("Eve", out int eveScore))
                Console.WriteLine($"Eve: {eveScore}");
            else
                Console.WriteLine("Eve는 없음");

            // ── 삭제: Remove ─────────────────────────────────────────
            scores.Remove("Charlie");
            Console.WriteLine($"Remove 후 Count: {scores.Count}");

            // ── Keys / Values 프로퍼티 ───────────────────────────────
            Console.WriteLine("\n키 목록: " + string.Join(", ", scores.Keys));
            Console.WriteLine("값 목록: " + string.Join(", ", scores.Values));
        }
    }
}
