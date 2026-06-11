namespace MySpace
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // 1. null 병합 연산자 ??
            // + 왼쪽이 null이면, 오른쪽을 사용한다.
            try
            {
                int? a = null;
                int b = a ?? throw new ArgumentNullException(); // a가 null이라 throw
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

            // 2. 조건 연산자
            try
            {
                int[] array = new[] { 1, 2, 3 };
                int index = 4;
                int value = array[index >= 0 && index < 3 // 조건이 false라, throw
                    ? index : throw new IndexOutOfRangeException()];
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}