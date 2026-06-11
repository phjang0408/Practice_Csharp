namespace MySpace
{
    class MainApp
    {
        delegate void DoSomething();    // 매개변수 없는경우
        delegate string Concatenate(string[] args);
        static void Main(string[] args)
        {
            // => 오른쪽에 { } 블록을 써서 여러 문장 사용 가능.
            DoSomething Doit = () =>
                {
                Console.WriteLine("출력1");
                Console.WriteLine("출력2");
                Console.WriteLine("출력3");
                };
            Doit();

            // 예제
            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (string s in arr) result += s;
                return result;
            };
            Console.WriteLine(concat(args));
            // >StatementLambda 출력을 확인 합니다.
            // 출력을확인합니다.
        }
    }
}