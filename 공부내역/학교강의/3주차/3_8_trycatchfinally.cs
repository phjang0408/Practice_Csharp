
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 4, 7 };
            try // 예외 발생 코드 생성
            {
                for (int i = 0; i < a.Length; i++)
                    if (a[i] % 2 == 0)
                        Console.WriteLine("정상입니다.");
                    else
                    {
                        // throw : 예외 발생 키워드
                        throw new Exception("짝수가 아니므로 오류입니다.");
                        return;
                    }
            }
            // catch : 예외 발생 시, 처리 코드 생성
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            // finally : 무조건 항상 실행되는 코드 생성
            finally
            {
                Console.WriteLine("프로그램 종료");

            }
            return;
        }
    }
}