using System;
using System.Linq;

namespace MySpace
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var departments = new[] {
                new { Id = 1, Name = "컴퓨터공학" },
                new { Id = 2, Name = "전자공학" },
                new { Id = 3, Name = "미디어디자인" }
            };
            var students = new[] {
                new { Name = "강하늘", DeptId = 1 },
                new { Name = "이사랑", DeptId = 2 },
                new { Name = "박구름", DeptId = 1 },
                new { Name = "최바다", DeptId = 4 } // 매칭 없음 → "미지정"
            };

            var leftJoin = from s in students
                           join d in departments on s.DeptId equals d.Id into temp // 외부 join은 into!
                           from d in temp.DefaultIfEmpty() // 매칭 실패 시 null
                           orderby s.Name
                           select new {
                               StudentName = s.Name,
                               DeptName = d?.Name ?? "미지정" // null이면 "미지정"
                           };

            foreach (var item in leftJoin)
                Console.WriteLine($"{item.StudentName}: {item.DeptName}");
        }
    }
}

// 출력:
// 강하늘: 컴퓨터공학
// 박구름: 컴퓨터공학
// 이사랑: 전자공학
// 최바다: 미지정