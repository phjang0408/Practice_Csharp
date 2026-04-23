namespace mySpace
{
    class myClass
    {
        static void Main(string[] args)
        {
            // 1. 2차원 배열
            // 초기화법
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // 요소 접근 법 : GetLength(차원)으로 접근, Rank와 달리, 0이 행, 1이 열
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}] : {arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 2. 다차원 배열
            int[,,] Multiarr = new int[4, 3, 2]
            {
                { { 1, 2 }, { 3, 4 }, { 5, 6 } },
                { { 7, 8 }, { 9, 10 }, { 11, 12 } },
                { { 13, 14 }, { 15, 16 }, { 17, 18 } },
                { { 19, 20 }, { 21, 22 }, { 23, 24 } }
            };
        }
    }
}