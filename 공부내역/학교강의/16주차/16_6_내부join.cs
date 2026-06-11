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
                new { Name = "최바다", DeptId = 4 } // 매칭 없음 → 제외
            };

            var innerJoin = from s in students
                            join d in departments on s.DeptId equals d.Id
                            orderby d.Name
                            select new {
                                StudentName = s.Name,
                                DeptName = d.Name
                            };

            foreach (var item in innerJoin)
                Console.WriteLine($"{item.StudentName}: {item.DeptName}");
        }
    }
}

// 출력:
// 이사랑: 전자공학
// 강하늘: 컴퓨터공학
// 박구름: 컴퓨터공학