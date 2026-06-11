using System;

namespace MySpace
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}    
            };

            // group은 [group - by - into] 3가지로 구성
            var listProfile = from profile in arrProfile
                                // group (범위변수) by (그룹 조건식) into (그룹 변수 별칭)   
                              group profile by profile.Height < 175 into g  // profile.Height < 175 의 결과는 true / false로 두 그룹
                              // 그룹화 결과를 g라는 변수로 받음. g는 그룹
                              select new
                              {
                                  GroupKey = g.Key, // 그룹을 나눈 기준값
                                  Profiles = g      // 해당 그룹에 속한 profile 목록
                              };

            foreach (var group in listProfile)
            {
                Console.WriteLine($"175 미만 여부: {group.GroupKey}");
                foreach (var profile in group.Profiles)
                    Console.WriteLine($"  {profile.Name}, {profile.Height}");
            }
            /* 출력
               175 미만 여부: False
                  정우성, 186
                  이문세, 178
               175 미만 여부: True
                  김태희, 158
                  고현정, 172
                  하하, 171
            */
        }
    }
}
