namespace DrawPaper
{
    // 콜백 : 자기 자신을 넘겨, 받는사람이 자신의 메서드를 호출하도록
    // 인터페이스의 역할 : 보증수표역할
    interface ISource { int GetResult(); }
    // GetResult()를 호출할 수 있다는 보장
    class Source : ISource  // 값을 가지고 있는 사람
    {
        public int GetResult() { return 10; }

        public void Test()
        {
            Target target = new Target();
            target.Do(this); // 내 자신을 넘겨서, 내 함수를 호출해도 돼라는 뜻
        }
        static void Main(string[] args)
        {
            Source src = new Source();
            src.Test(); 
        }
    }
    class Target // 값을 물어보는 사람
    {
        public void Do(ISource obj) // 파라미터 : 인터페이스를 가지는 지 확인
        {
            Console.WriteLine(obj.GetResult()); // Source의, GetResult를 요청한다.
        }
    }
}
/* 
 * Source = 값을 가진 사람 (10을 알고 있음)
 * Target = 값이 필요한 사람 (Source한테 물어봐야 함)
 * ISource = "나한테 GetResult() 물어봐도 돼" 라는 보증수표
 */
