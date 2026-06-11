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
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine("정상적수행완료");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"예외 Message : {e.Message}");
                Console.WriteLine($"예외 Source : {e.Source}");
                Console.WriteLine($"예외 StackTrace : {e.StackTrace}");
                Console.WriteLine($"예외 ToString : {e.ToString()}");
            }
            Console.WriteLine("종료");
            /*
            출력결과:
                1
                2
                3
                예외 Message : Index was outside the bounds of the array.
                예외 Source : ExceptionClass
                예외 StackTrace :    at ExceptionClass.MainApp.Main(String[] 
                args) in 
                C:\Users\ongte\source\repos\KillingProgram\ExceptionClass\M
                ainApp.cs:line 15
                예외 ToString : System.IndexOutOfRangeException: Index was 
                outside the bounds of the array.
                at ExceptionClass.MainApp.Main(String[] args) in 
                C:\Users\ongte\source\repos\KillingProgram\ExceptionClass\M
                ainApp.cs:line 15
                종료
            */
        }
    }
}