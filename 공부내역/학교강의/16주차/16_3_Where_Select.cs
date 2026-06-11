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

            var profiles = from profile in arrProfile   
                           orderby profile.Height ascending     // 디폴트가 ascending, 생략가능, 내림차순은 descending
                           select profile;              // select : 어떤 항목을
            /* select profile.Name으로하면, profiles형식은 IEnumerable<string>
            또한 select new { Name = profile.Name, InchHeight = profile.Height * 0.393 }; 처럼 무명형식도 가능
            */



            foreach(var profile in profiles)
            {
                Console.WriteLine("{0}, {1}",
                    profile.Name, profile.Height);
            }
        }
    }
}
