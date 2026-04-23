namespace DrawPaper
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown"; // 초기화 안 해도 댐
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

    public class Player
    {
        public int Hp { get; set; } = 100;  // 1. 프로퍼티의 실행

        public Player(int hp)
        {
            Hp = hp;  // 2. 생성자의 set
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 프로퍼티와 생성자
            BirthdayInfo birth = new BirthdayInfo() // 생성자로 시작
            {
                Name = "장지욱",   // 각 필드 초기화, 콤마(,)로 구분
                // Birthday = ...  -> 초기화 하고싶은것만 하면 됨
                BornCity = "포항"

            };  // 마지막은 세미콜론

            Console.WriteLine(birth.BornCity);

            // 프로퍼티 초기값, 생성자, 객체 이니셜의 순서
            Player p = new Player(200)
            {
                Hp = 300
            };
            Console.WriteLine(p.Hp);
            /*1. 프로퍼티 초기값 = 100
              2. 생성자 실행    = 200
              3. 객체 이니셜라이저 = 300  ← 마지막에 덮어씀
              */
        }
    }
}
