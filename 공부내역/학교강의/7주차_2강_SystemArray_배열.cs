using System;

namespace SchoolLecture
{
    class Program
    {
        static void Print2D(int[,] values)
        {
            for (int row = 0; row < values.GetLength(0); row++)
            {
                for (int col = 0; col < values.GetLength(1); col++)
                {
                    Console.Write($"{values[row, col],4}");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 10, 30, 20, 7, 1 };
            Console.WriteLine($"Type of array: {array.GetType()}");
            Console.WriteLine($"Base type of array: {array.GetType().BaseType}");

            Array.Sort(array);
            Console.WriteLine(string.Join(", ", array));

            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Print2D(matrix);

            int[,,] cube = new int[1, 2, 2] { { { 1, 2 }, { 3, 4 } } };
            Console.WriteLine(cube.GetLength(0));
            Console.WriteLine(cube.Rank);
        }
    }
}
