using System;

namespace MySpace
{
    class Profile
    {
        static void Main(string[] args)
        {
            var students = new[] {
                new { Name = "강하늘", GPA = 3.5, Dept = "컴공" },
                new { Name = "이사랑", GPA = 4.2, Dept = "전자" },
                new { Name = "박구름", GPA = 2.8, Dept = "컴공" },
                new { Name = "최바다", GPA = 3.9, Dept = "민디" },
                new { Name = "김햇살", GPA = 4.5, Dept = "전자" },
                new { Name = "윤들판", GPA = 3.1, Dept = "컴공" }
            };

            var studentStast = from s in students
                               group s by s.Dept into g // 같은 Dept값끼리 그룹화
                               orderby g.Average(s => s.GPA) descending // 평균 성적순 정렬
                               select new
                               {
                                   Department = g.Key,
                                   StudentCount = g.Count(),
                                   MaxGPA = g.Max(s => s.GPA),
                                   MinGPA = g.Min(s => s.GPA),
                                   AverageGPA = g.Average(s => s.GPA)
                               };

            foreach (var s in studentStast)
            {
                Console.WriteLine(
                    $"{s.Department}-인원: {s.StudentCount}, " +
                    $"최고: {s.MaxGPA}, 최저: {s.MinGPA}, " +
                    $"평균: {s.AverageGPA:F2}"); // F2 = 소수점 둘째자리
            }
        }
    }
}
