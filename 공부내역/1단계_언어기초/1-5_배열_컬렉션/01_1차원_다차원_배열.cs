using System;
namespace ArrayStudy
{
    class Program
    {
        static void Main()
        {
            // ── 1차원 배열 ────────
            int[] arr1 = new int[5];          // 크기 5, 기본값 0으로 초기화
            arr1[0] = 10;
            arr1[1] = 20;

            int[] arr2 = { 1, 2, 3, 4, 5 };  // 선언과 동시에 초기화

            Console.WriteLine("=== 1차원 배열 ===");
            Console.WriteLine($"arr1[0] = {arr1[0]}");
            Console.WriteLine($"arr2.Length = {arr2.Length}");

            // 배열 순회
            foreach (int n in arr2)
                Console.Write(n + " ");
            Console.WriteLine();

            // 유용한 배열 메서드
            int[] nums = { 5, 3, 1, 4, 2 };
            Array.Sort(nums);                 // 오름차순 정렬
            Console.WriteLine("Sort:    " + string.Join(", ", nums));

            Array.Reverse(nums);              // 역순
            Console.WriteLine("Reverse: " + string.Join(", ", nums));

            // ── 다차원 배열 (2D) ────────────────────────────────────
            Console.WriteLine("\n=== 2차원 배열 ===");
            int[,] exmpl = new int[2,3];
            int[,] ex2 = new int[,];
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine($"행: {matrix.GetLength(0)}, 열: {matrix.GetLength(1)}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    Console.Write($"{matrix[row, col]} ");
                Console.WriteLine();
            }

            // ── 가변 배열 (Jagged Array) ────────────────────────────
            Console.WriteLine("\n=== 가변 배열 (Jagged) ===");
            int[][] jagged = new int[3][];    // 행마다 크기가 다를 수 있음
            jagged[0] = new int[] { 1, 2 };   // 각각을 초기화 해야 함
            jagged[1] = new int[] { 3, 4, 5 };
            jagged[2] = new int[] { 6 };

            foreach (int[] row in jagged)
            {
                foreach (int val in row)
                    Console.Write(val + " ");
                Console.WriteLine();
            }

            // ── 다차원 vs 가변 차이 ─────────────────────────────────
            // int[,]  : 직사각형, 메모리 연속 → 수학 행렬에 적합
            // int[][] : 각 행의 길이가 자유로움 → Unity 타일맵 등에 유용
        }
    }
}
