namespace MySpace
{
    class MainClass
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return dividend / divisor;  // 여기서 예외 발생 가능
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divied() 예외 발생");
                throw e;    // 예외를 다시 위로 던짐 : Main()에서 catch함.
            }
            finally
            {
                // 정상/예외 상관없이 무조건 실행
                Console.WriteLine("Divide 끝");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("제수를 입력하세요 : ");
                string temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.Write("피제수를 입력하세요 : ");
                temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.WriteLine("{0} / {1} = {2}", 
                    dividend, divisor, Divide(dividend, divisor));
            }
            catch(FormatException e)    // abc와 같이 문자를 숫자로 변환할 때
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            catch(DivideByZeroException e)  // Divide의 catch에서, throw e로 받은 예외를 여기서 받음
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램 종료합니다.");
            }

        }
    }
}