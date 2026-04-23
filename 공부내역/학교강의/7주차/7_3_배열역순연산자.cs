using System;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;

            System.Index last = ^1; // ^는 뒤에서 부터 계산
            scores[^2] = 90; // 배열 마지막 - 1
            scores[last] = 34; // 배열 마지막


            foreach (int score in scores)
                Console.WriteLine(score);

            int sum = 0;
            foreach (int score in scores)
                sum += score;

            int averageArray = sum / scores.Length; // Length로 평균 구하기
            Console.WriteLine($"Average score: {averageArray}");
        }
    }
}