using System;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var alice = (job: "학생", Age: 18);
            var discountRate = GetDiscountRate(alice);
            Console.WriteLine(discountRate);
        }
        private static double GetDiscountRate(object client)
        {
            // 튜블은 switch문 또는 식에서, 분기 조건으로 활용 가능하다.
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2,
                ("학생", _) => 0.1,
                ("일반", int n) when n < 18 => 0.1,
                ("일반", _) => 0.05,
                _ => 0,
            };
        }
    }
}