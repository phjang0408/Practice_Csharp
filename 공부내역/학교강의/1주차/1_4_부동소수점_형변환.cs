using System;

namespace MySpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // float <-> double
            // 2진수 -> 10진수 -> 2진수로 변환하기에, 정밀도 손상
            float c = 0.1f;
            Console.WriteLine(c);

            double d = (double)c;
            Console.WriteLine(d);

            // 부동소수점형 <-> 정수형
            // 소수점 이하는 버린다!
            float f_a = 0.9f;
            int i_a = (int)f_a;
            Console.WriteLine(i_a);

            double d_b = 0.9;
            int i_b = (int)d_b;
            Console.WriteLine(i_b);
        }
    }
}
