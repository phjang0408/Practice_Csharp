namespace DrawPaper
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        // 깊은 복사는 따로 구문이 없어, 직접 만들어주어야 한다.
        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();    // 독립된 힙을 위해, 새로 생성
            newCopy.MyField1 = this.MyField1;   // 자신의 멤버를 일일히 복사
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 얕은 복사 : 스택의 값(힙 메모리를 가리키는 주소값)이 동일
            // 스택에서 저장된 위치는 다르지만, 저장되어 있는 값은 동일 -> 힙은 하나를 공유
            // 객체 변경 시 -> 둘 다 영향, 공유의 목적
            MyClass source = new MyClass();
            source.MyField1 = 10;
            source.MyField2 = 20;

            Console.WriteLine("[얕은복사]");
            MyClass swallow_trg = source;    // 얕은 복사는 '='으로 사용
            swallow_trg.MyField2 = 30;

            Console.WriteLine("{0} {1}", source.MyField1, source.MyField2);
            Console.WriteLine("{0} {1}", swallow_trg.MyField1, swallow_trg.MyField2);

            // 2. 깊은 복사 : 스택의 값이 다르다.
            // 스택에서 저장된 위치, 저장된 값이 다르다 -> 각자의 힙을 가진다.
            // 독립의 목적, 서로 영향 X
            Console.WriteLine("[깊은복사]");
            MyClass deep_trg = source.DeepCopy();
            deep_trg.MyField2 = 55;
            Console.WriteLine("{0} {1}", source.MyField1, source.MyField2);
            Console.WriteLine("{0} {1}", deep_trg.MyField1, deep_trg.MyField2);
        }
    }
}
