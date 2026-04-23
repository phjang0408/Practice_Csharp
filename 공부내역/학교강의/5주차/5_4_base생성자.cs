class Base
{
    protected string Name;
    public Base(string Name)
    {
        this.Name = Name;
        Console.WriteLine($"{this.Name}.Base()");
    }
    ~Base()
    {
        Console.WriteLine($"{this.Name}.~Base()");
    }
    public void BaseMethod()
    {
        Console.WriteLine($"{this.Name}.BaseMethod()");
    }
}
class Derived : Base
{   
    public Derived(string Name) : base(Name) { // 매개변수를 받아 base로 연계
        Console.WriteLine($"{this.Name}.Derived()");
    }
    ~Derived() {
        Console.WriteLine($"{this.Name}.~Derived()");
    }
    public void DerivedMethod() {
        Console.WriteLine($"{this.Name}.DerivedMethod()");
    }
    public static void Test()
    {
        Base a = new Base("a");
        a.BaseMethod();
        Derived b = new Derived("b");
        b.BaseMethod();
        b.DerivedMethod();
    }
    static void Main(string[] args)
    {
        Test();
    GC.Collect(); 
        GC.WaitForPendingFinalizers(); 
    }
}
