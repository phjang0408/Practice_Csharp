using MyExtens; // 확장 메서드가 정의된 네임스페이스를 가져와야 사용 가능함

namespace MyExtens
{
    // 1. 반드시 static 클래스여야 함 (도구함 역할)
    public static class IntegerExtension
    {
        // 2. static 메서드로 정의
        // 'this int myInt' -> 마침표(.) 앞의 숫자가 'myInt' 파라미터로 자동으로 들어옴
        // this는 그래서 반드시 하나!
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        // 'this int myInt' -> 호출 주체 (예: 3.Power(4)에서 3)
        // 'int exponennt' -> 사용자가 괄호 안에 입력할 값 (예: 3.Power(4)에서 4)
        public static int Power(this int myInt, int exponennt)
        {
            int result = myInt;
            for (int i = 1; i < exponennt; i++)
            {
                result *= myInt;
            }
            return result;
        }
    }
}

namespace MySpace
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // [호출 원리] 
            // 3.Square()를 호출하면 컴파일러는 내부적으로 
            // IntegerExtension.Square(3)으로 바꿔서 실행함.
            Console.WriteLine($"3^2 : {3.Square()}");

            // [파라미터 매핑]
            // . 앞의 '3'은 'this int myInt'로 전달되고
            // ( ) 안의 '4'는 'int exponennt'로 전달됨
            Console.WriteLine($"3^4 : {3.Power(4)}");

            // 리터럴뿐만 아니라 변수에서도 당연히 작동함
            int baseNum = 2;
            Console.WriteLine($"2^10 : {baseNum.Power(10)}");
        }
    }
}