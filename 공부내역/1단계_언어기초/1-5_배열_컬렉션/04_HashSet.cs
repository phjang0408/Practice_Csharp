using System;
using System.Collections.Generic;
namespace HashSetStudy
{
    class Program
    {
        static void Main()
        {
            // ── HashSet<T> 선언 ──────────────────────────────────────
            // 중복을 허용하지 않는 집합. 순서 보장 없음
            HashSet<int> set = new HashSet<int>();

            // ── 추가: Add ────────────────────────────────────────────
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(2);   // 중복 → 무시됨
            set.Add(1);   // 중복 → 무시됨
            Console.WriteLine("Count: " + set.Count);           // 3
            Console.WriteLine("요소: " + string.Join(", ", set));

            // ── 검색: Contains ───────────────────────────────────────
            Console.WriteLine($"Contains(2): {set.Contains(2)}");
            Console.WriteLine($"Contains(9): {set.Contains(9)}");

            // ── 삭제: Remove ─────────────────────────────────────────
            set.Remove(2);
            Console.WriteLine("Remove(2) 후: " + string.Join(", ", set));

            // ── 집합 연산 ────────────────────────────────────────────
            HashSet<int> a = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> b = new HashSet<int> { 3, 4, 5, 6 };

            // 합집합 (a ∪ b)
            HashSet<int> union = new HashSet<int>(a);
            union.UnionWith(b);
            Console.WriteLine("\n합집합 (a∪b): " + string.Join(", ", union));

            // 교집합 (a ∩ b)
            HashSet<int> intersect = new HashSet<int>(a);
            intersect.IntersectWith(b);
            Console.WriteLine("교집합 (a∩b): " + string.Join(", ", intersect));

            // 차집합 (a - b)
            HashSet<int> except = new HashSet<int>(a);
            except.ExceptWith(b);
            Console.WriteLine("차집합 (a-b): " + string.Join(", ", except));

            // ── List에서 중복 제거 활용 ──────────────────────────────
            // HashSet은 중복 제거가 필요할 때 자주 사용됨
            int[] nums = { 1, 2, 2, 3, 3, 3, 4 };
            HashSet<int> unique = new HashSet<int>(nums);
            Console.WriteLine("\n중복 제거: " + string.Join(", ", unique));
        }
    }
}
