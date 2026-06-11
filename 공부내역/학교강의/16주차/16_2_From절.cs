using System;

namespace MySpace
{ 
    class Profile{
        static void Main(string[] args)
        {
            // 1. 기본
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = from n in numbers  // numbers에서
                         where n % 2 == 0   // 짝수만
                         orderby n          // 오름차순으로
                         select n;          // 꺼내라
            foreach (int n in result)
                Console.WriteLine("짝수 : {0}", n);

            // 중첩 from절
            var arrClass = new[]
            {
                new {Name="연두반", Score=new[]{99, 80, 70, 24}},
                new {Name="분홍반", Score=new[]{60, 45, 87, 72}},
                new {Name="파랑반", Score=new[]{92, 30, 85, 94}},
                new {Name="노랑반", Score=new[]{90, 88, 0, 17}}
            };
            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s // 기본은 오름차순
                          select new { c.Name, Lowest = s };

            foreach(var cla in classes)
                Console.WriteLine($"낙제 : {cla.Name} {cla.Lowest}");
        }
    }
}
