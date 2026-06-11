namespace MySpace
{
    class MainClass
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
                Console.WriteLine("arg : {0}", arg);
            else
                throw new Exception("arg가 10보다 큽니다.");
        }
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("예외를 던집니다.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try { DoSomething(13); }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}