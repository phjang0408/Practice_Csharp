using System;

namespace MySpace
{ 
    class Profile{
        public string Name { get; set; }
        public int Height { get; set; }
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
            };

            var profiles = from profile in arrProfile   // from : 어떤 데이터집합에서, 집합 내 객체는 따로지정(profile로 지정)
                           where profile.Height < 175   // where : 어떤 조건으로
                           orderby profile.Height       // orderby : 어떤 정렬 조건을 적용해
                           select profile;              // select : 어떤 항목을

            foreach(var profile in profiles)
            {
                Console.WriteLine("{0}, {1}",
                    profile.Name, profile.Height);
            }
            /* 전체 LINQ 문법
            from s in students          // from - in
            where s.GPA > 3.0           // where
            orderby s.Name descending   // orderby - descending(ascending)
            group s by s.Dept into g    // group - by - into
            join d in departments       // join - in
                on s.DeptId equals d.Id //      - on - equals - (into) (into는 외부join)
            select new { }              // select
            */
        }
    }
}
