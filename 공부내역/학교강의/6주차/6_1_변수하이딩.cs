class Parent
{
    public int Variable { get; set; } = 273;
    public void Method()
    {
        Console.WriteLine("부모의메소드");
    }
}
class Child : Parent
{
    // hiding을 할 때는, new 키워드 사용!
    // 이름이 같은 변수를 부모에게 숨긴다(hiding)
    public new string Variable { get; set; } = "hiding";
    public new void Method()
    {
        Console.WriteLine("자식의메소드");
    }
}
class MainApp
{
    static void Main(string[] args)
    {
        Child child = new Child();
        Console.WriteLine(child.Variable);
        // new는 실제 객체 기준이 아닌, 바라보는 기준!
        Console.WriteLine(((Parent)child).Variable);

        child.Method();
        ((Parent)child).Method();
    }
}
