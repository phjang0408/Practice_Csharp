namespace DrawPaper
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        // 프로퍼티 : 필드에 대한 안전한 접근 통로
        public string ProP_Name // 필드와는 다른 이름, 함수와 달리 괄호가 없음
        {
            get { return name; }
            set { name = value; }   // value : 설정되는 값 (암묵적 매개변수)
        }

        public DateTime ProP_Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year; }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            BirthdayInfo info = new BirthdayInfo();
            info.ProP_Name = "홍길동";                         // 프로퍼티로 접근 : Set
            info.ProP_Birthday = new DateTime(1990, 5, 1);     // 프로퍼티로 접근 : DateTime 클래스

            Console.WriteLine($"{info.ProP_Name}님의 나이는 {info.Age}세입니다.");

        }
    }
}
