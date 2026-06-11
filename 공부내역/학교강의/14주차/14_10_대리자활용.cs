namespace MySpace
{
    class MyClass
    {
        // 1. 대리자 선언
        delegate int Compare(int a, int b);

        // 2. Compare 대리자가, 참조할 비교 메서드
        static int AscendCompare(int a, int b) // 오름차순
        {
            if (a > b) return 1;
            else if (a == b) return 0;
            else return -1;
        }   
        static int DescendCompare(int a, int b) // 내림차순
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }
        // 3. 정렬 메서드 작성. 매개변수로 두 정수를 입력받아 비교하는 비교메서드를, 참조하는 대리자 사용
        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0, j = 0, temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {// Comparer에 담긴 함수에 따라 반환 조건이 다름, 조건을 맞춰, 1을 반환할 때만 Swap
                    if (Comparer(DataSet[j], DataSet[j+1]) > 0) 
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // 오름차순
            int[] array = { 3, 7, 4, 2, 10 };
            Console.WriteLine("Sorting ascending...");

            BubbleSort(array, new Compare(AscendCompare));

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            // 내림차순
            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending...");

            BubbleSort(array2, new Compare(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");

            Console.WriteLine();
        }
    }
}