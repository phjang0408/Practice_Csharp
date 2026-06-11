namespace MySpace
{
    class Wanted<T,U>
    {
        public T Value1;
        public U Value2;

        public Wanted(T _value1, U _value2)
        {
            this.Value1 = _value1;
            this.Value2 = _value2;
        }
    }
    // 일반화 클래스에는, Main 메서드를 둘 수 없다.
    class MainClass
    {
        static void Main(string[] args)
        {
            Wanted<int, string> wanted = new Wanted<int, string>(1234, "String");
            Console.WriteLine($"Value1 : {wanted.Value1}, Value2 : {wanted.Value2}");
        }
    }
}
