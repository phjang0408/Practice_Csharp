class Animal
{
    public virtual void Cry() { Console.WriteLine("소리 내어 웁니다."); }
}
class Dog : Animal
{
    public new void Cry() // 메소드 하이딩
    {
        Console.WriteLine("멍멍 짓습니다.");
    }
}
class Cat : Animal
{
    public new void Cry()  // 메소드 하이딩
    {
        base.Cry();
        Console.WriteLine("냥냥 웁니다.");
    }
    static void Main(string[] args)
    {
        Animal[] Animals = new Animal[] { new Dog(),
            new Cat(), new Dog(), new Cat() };
        foreach (var item in Animals)
        {
            item.Cry();
        }
    }
}