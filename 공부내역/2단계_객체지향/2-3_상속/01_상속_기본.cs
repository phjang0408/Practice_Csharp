// 상속 (Inheritance) - 부모 클래스의 멤버를 자식 클래스가 물려받음
// C#은 단일 상속만 지원 (다중 상속 불가)
namespace DrawPaper
{
    // 부모(기반) 클래스
    class Computer
    {
        protected bool powerOn;     // protected: 자식 클래스에서 접근 가능

        public void Boot()
        {
            powerOn = true;
            Console.WriteLine("부팅 중...");
        }

        public void Shutdown()
        {
            powerOn = false;
            Console.WriteLine("종료 중...");
        }
    }

    // 자식(파생) 클래스 - 콜론(:)으로 상속
    class Notebook : Computer
    {
        public void CloseLid()
        {
            if (powerOn)    // 부모의 protected 필드 접근 가능
            {
                Shutdown(); // 부모의 메서드 호출 가능
                Console.WriteLine("노트북 덮개를 닫았습니다.");
            }
        }
    }

    class Desktop : Computer
    {
        // 부모의 모든 public/protected 멤버를 자동으로 가짐
    }

    // sealed: 상속 불가 클래스
    sealed class Monitor
    {
        public void Display() { Console.WriteLine("화면 출력"); }
    }
    // class SmartMonitor : Monitor { } // 에러! sealed 클래스는 상속 불가

    class Program
    {
        static void Main(string[] args)
        {
            Notebook note = new Notebook();
            note.Boot();        // 부모의 메서드
            note.CloseLid();    // 자식의 메서드

            // 부모/자식 간 형변환
            Computer pc = note;             // 암시적 형변환 (자식→부모)
            pc.Boot();                      // OK
            // pc.CloseLid();               // 에러! Computer에는 CloseLid 없음

            Notebook note2 = (Notebook)pc;  // 명시적 형변환 (부모→자식)
            note2.CloseLid();               // OK
        }
    }
}
