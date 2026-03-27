// Object로 switch문(데이터 형식에 따라 분기하는 switch)
namespace DrawPaper
{
    public class Program
    {
        static void Main(string[] args)
        {
            object obj = 123;
            switch(obj){
                case int i:
                Console.WriteLine("정수입니다.");
                break;
                case float f:
                Console.WriteLine("실수입니다.");
                break;
                default:
                Console.WriteLine("모르겠습니다.");
                break;
            }
        }
    }

}