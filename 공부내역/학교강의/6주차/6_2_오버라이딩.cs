class Animal
{
    // virtual : 자식 클래스에서 재정의 가능하도록 허용
    public virtual void Cry() { Console.WriteLine("소리 내어 웁니다."); }
}
class Dog : Animal
{
    // override : 부모 클래스의 virtual 메소드를 재정의
    public override void Cry()
    {
        Console.WriteLine("멍멍 짓습니다.");
    }
}
class Cat : Animal
{
    public override void Cry()
    {
        base.Cry(); // base로 부모의 메서드도 호출 가능
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