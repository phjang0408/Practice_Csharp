namespace mySpace
{
    class myClass
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };
            // System.Range 형식, ".." 연산자로 왼쪽과 오른쪽 index 표시
            // 출력결과 3에 해당하는 index는 포함X -> 마지막 숫자 - 1에 해당하는 index까지
            // 
            System.Range r1 = 0..3;
            Range r2 = ..3;
            int[] slice = scores[r1];
            int[] slice2 = scores[0..3];

            int[] s3 = scores[..3]; // 시작 생략 : 처음부터
            int[] s4 = scores[0..]; // 마지막 생략 : 마지막까지 전부
            int[] s5 = scores[..];  // 전부 생략 : 배열 전체

            Array.ForEach<int>(s4, new Action<int>((item) => Console.WriteLine(item)));

            System.Index idx = ^1;
            Index idx2 = ^2;
            int[] sliced6 = scores[..idx];
            int[] sliced7 = scores[..^1];   // 마지막에 있는 1개를 빼고 
            Array.ForEach<int>(sliced7, new Action<int>((item) => Console.WriteLine(item)));

        }
    }
}