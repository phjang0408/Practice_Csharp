namespace MySpace
{
    class Base { }
    class Derived : Base { }

    // U는 Base 본인 또는 Base를 상속한 타입만 허용
    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BaseArray(int size) { Array = new U[size]; }

        // T는 U 본인 또는 U의 자식 타입만 허용
        // ex) U=Base면 T는 Base, Derived 모두 가능
        // ex) U=Derived면 T는 Derived만 가능 (Base는 부모이므로 불가)
        public void CopyArray<T>(T[] source) where T : U
        {
            source.CopyTo(Array, 0);
        }

        // T는 기본 생성자(new())가 있는 타입만 허용
        // U와 무관한 독립적인 제약 → 어떤 BaseArray<U>로 호출해도 동작이 동일
        // ex) BaseArray<Base>.CreateInstance<Derived>() == BaseArray<Derived>.CreateInstance<Derived>()
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            // U = Base → Array는 Base[], Base 또는 자식 타입 저장 가능
            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();                              // 업캐스팅: Derived는 Base의 자식이므로 OK
            c.Array[2] = BaseArray<Base>.CreateInstance<Base>();     // new Base() 반환

            // U = Derived → Array는 Derived[], Derived 또는 자식 타입만 저장 가능
            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived();
            d.Array[1] = BaseArray<Derived>.CreateInstance<Derived>(); // new Derived() 반환
            d.Array[2] = BaseArray<Base>.CreateInstance<Derived>();

            // e.CopyArray<Derived>: T=Derived, U=Derived → T:U 제약 만족
            // d.Array(Derived[])를 e.Array(Derived[])에 복사
            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);
        }
    }
}