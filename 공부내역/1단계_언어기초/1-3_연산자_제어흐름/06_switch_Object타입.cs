// Object로 switch문(데이터 형식에 따라 분기하는 switch)
// C# 7.0부터는 switch문에서 데이터 형식에 따라 분기할 수 있다.
// case 뒤에는 데이터 형식을 말해주어야 한다.
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