namespace DrawPaper
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get {return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;}
        }

        // 2. 초기화 전용 자동 구현 프로퍼티
        // 생성할 때 초기화 한 후, 중간에 변경 불가능!
        // set 대신, [init] 키워드 사용
        public string BornCity { get; init; } = "Pohang";

    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 프로퍼티와 생성자
            BirthdayInfo birth = new BirthdayInfo() // 대괄호로 시작
            {
                Name = "장지욱",   // 각 필드 초기화, 콤마(,)로 구분
                // Birthday = ...  -> 초기화 하고싶은것만 하면 됨
                BornCity = "포항"

            };  // 마지막은 세미콜론

            Console.WriteLine(birth.BornCity);
        }
    }
}
