namespace DrawPaper
{
    class BirthdayInfo
    {
        // 자동구현 프로퍼티
        // 프로퍼티에서, get, set이 간단하면 선언.
        // 변수도 따로 선언할 필요없음.
        // 7.0부터 초기값 설정도 가능하다. 없으면 null
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age // 얘도 필드임
        {
            get
            {   // Birthday를 프로퍼티로 접근해서 사용한다.
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
            // set이 없으면, 읽기 전용이다.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();

            // get : 프로퍼티 문법, 초기값으로 출력
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birth : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            // set : 프로퍼티 문법
            birth.Name = "장지욱";
            birth.Birthday = new DateTime(2000, 4, 8);
        }
    }
}
