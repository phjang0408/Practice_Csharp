namespace MySpace
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                for (int i = 0; i < 5; i++)
                    Console.WriteLine(arr[i]);
                Console.WriteLine("정상 수행 완료");
            }

            //catch(IndexOutOfRangeException)와 같이, e빼고, 타입 자체만 작성해도 됨
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine($"예외가 발생했습니다. : {e.Message}");
            }
            Console.WriteLine("종료");
        }
    }
}