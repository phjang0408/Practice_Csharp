class OuterClass
{
    private int OuterMember;
    // 중첩클래스는 외부 클래스의 private 멤버에도 접근 가능
    class NestedClass
    {
        public void DoSomething()
        {
            OuterClass outer = new OuterClass();
            outer.OuterMember = 10; // OuterClass 의private 멤버에접근가능
        }
    }
}