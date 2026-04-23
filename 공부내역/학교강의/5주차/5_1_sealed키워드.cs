class Parent
{
    public virtual void Test() { }
}
class Child : Parent
{
    // sealed 키워드 : 오버라이딩을 막는 키워드
    public sealed override void Test() { }
}
class GrandChild : Child
{ 
    // public override void Test() { } -> 컴파일에러발생
}

// sealed 는 클래스에도 가능
sealed class FinalClass{}

// public class NormalClass : FinalClass {}
// => 컴파일 에러 발생