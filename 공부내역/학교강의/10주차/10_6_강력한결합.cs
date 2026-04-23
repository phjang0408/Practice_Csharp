namespace MySpace
{
    class Computer
    {
        public void TurnOn()
        {
            Console.WriteLine("Computer : Turn ON");
        }
    }
    class Switch
    {
        public void PowerOn(Computer machine)
        {  
        // 강력한 결합 : 클래스간 호출에 직접 의존
        // Computer 타입을 직접 사용 -> 다른 클래스로 변경할 때, 이것도 변경해야 함.
        // 유연성이 떨어짐
            machine.TurnOn();
        }
    }
}