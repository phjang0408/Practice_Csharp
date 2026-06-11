namespace MySpace
{
    delegate void EventHandler(string message);
    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0) // number가3, 6, 9로끝나는값이
            {                              // 될때마다이벤트가발생
                SomethingHappened(String.Format($"{number} : 짝"));
            }
        }
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for(int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i);
                // 이벤트로 선언된 델리게이트는, 객체를 통해, 외부에서 호출하면 컴파일 에러
                // 외부에서는 등록,해지만 하는게 원칙
                notifier.SomethingHappened("테스트"); // 컴파일에러 발생.
            }
        }
    }
}