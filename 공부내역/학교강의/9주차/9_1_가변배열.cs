namespace mySpace
{
    class myClass
    {
        static void PrintElement(int[][] tmpJagged)
        {
            // 1. 배열로 접근
            foreach (int[] arr in tmpJagged)
            {
                Console.WriteLine($"Length : {arr.Length}");
                foreach(int ele in arr)
                {
                    Console.WriteLine($"{ele} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // [용량][] -> 용량끼리는 같을 필요 없음
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 }; // 0번 요소에는 5인 배열
            jagged[1] = new int[] { 10, 20, 30 };     // 1번요소에는길이가3인배열
            jagged[2] = new int[] { 100, 200 };

            PrintElement(jagged);
        }
    }
}