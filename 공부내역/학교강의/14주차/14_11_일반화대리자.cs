using System;

namespace MySpace
{
    class MyClass
    {
        delegate int Compare<T>(T a, T b);

        // 일반화로 구성된 메서드
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        // 일반화 대리자를 매개변수로 사용하는 버블정렬 메서드 정의.
        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i = 0;
            int j = 0;
            T temp;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
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
            // 1. 오름차순 정렬 (int)
            int[] array = { 3, 7, 4, 2, 10 };
            Console.WriteLine("Sorting ascending...");
            BubbleSort<int>(array, new Compare<int>(AscendCompare));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            } // 기존 코드에서 잘못 닫혔던 괄호 위치 수정

            // 2. 내림차순 정렬 (string) - Main 메서드 안으로 이동
            string[] array2 = { "abc", "mno", "ghi", "jkl", "def" }; // 정렬 확인을 위해 데이터 순서 임의 변경

            Console.WriteLine("\nSorting descending...");
            BubbleSort<string>(array2, new Compare<string>(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }
            Console.WriteLine();
        }
    }
}