partial class MyClass
{
    public void Method1() { }
    public void Method2() { }
}
partial class MyClass
{
    public void Method3() { }
    public void Method4() { }
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.Method1();
        obj.Method2();
        obj.Method3();
        obj.Method4();
    }
}