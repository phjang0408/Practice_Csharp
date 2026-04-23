namespace mySpace
{
    class myClass
    {
        private static void Print(int value) { Console.Write($"{value} "); }
        private static bool CheckPassed(int score) { return score >= 60; }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };
            // 1. Sort : 오름차순 정렬
            Array.Sort(scores);

            // 2. ForEach<형식>(배열, Action<형식>) : 원소들에게 Action 실행
            Array.ForEach<int>(scores, new Action<int>(Print));

            // 3. BinarySearch<형식>(배열, 찾고자하는 값)
            Console.WriteLine("81:", Array.BinarySearch<int>(scores, 81));

            // 4. IndexOf(배열, 찾고자 하는 값) : 인덱스 반환

            // 5. Rank : 배열의 차원 반환(기본 1)
            
            // 6. TrueForAll<T>(배열, Predicate<T>(조건식)) : 모든 원소가 메서드 조건 부합하는지
            Console.WriteLine(
                Array.TrueForAll<int>(scores, new Predicate<int>(CheckPassed))
                );

            // 7. FindIndex<T>(배열, Predicate<T>(조건식)) : 조건 부합하는 [첫 번째 원소] 출력
            int index =
                Array.FindIndex<int>(scores, new Predicate<int>((score) => score < 60));
            Console.WriteLine(index);

            // + 람다식 : (매개변수) => 식 또는 문장 
            // + Action과 Predicate는 제너릭대리자
            // Action : 반환값이 없음
            // Predicate : bool 반환

            // 8. Resize<T>(배열 레퍼런스, 사이즈) : 사이즈만큼 조정
            Array.Resize<int>(ref scores, 10);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            int[] sliced = new int[3];
            // 9. Copy(원본, 원본 시작 index, 복사본, 복사본 시작 index, 복사할 원소 수)
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));
        }
    }
}