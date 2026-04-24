class Mammal
{
    public void Nurse() { }
}
class Dog : Mammal
{
    public void Bark() { }
}
class Cat : Mammal
{
    public void Meow() { }
}
class MyClass
{
    // 1. as 연산자 : 형식 변환 시도, 실패하면 null 반환
    static void Main(string[] args)
    {
        Mammal mammal = new Cat();
        Cat cat = mammal as Cat;
        // 만약 형식 변환 실패했다면 cat은 null
        if (cat != null)
        {
            cat.Meow();
        }
        // 2. is 연산자 : 형식 검사, true/false 반환
        Mammal mammal2 = new Dog();
        Dog dog;
        if (mammal2 is Dog)
        {
            dog = (Dog)mammal2;   // 형식 변환
            dog.Bark();
        }
    }

}