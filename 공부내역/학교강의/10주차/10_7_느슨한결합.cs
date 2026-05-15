namespace MySpace
{
    interface IPower
    {
        void TurnOn();
    }
    class Monitor : IPower
    {
        public void TurnOn()
        {
            Console.WriteLine("Monitor: TurnOn");
        }
    }
    class Computer : IPower
    {
        public void TurnOn()
        {
            Console.WriteLine("Computer: TurnOn");
        }
    }
    class Switch
    {
        static void PowerOn(IPower machine) // 느슨한 결합 : 둘 다 상속하는 인터페이스를, 매개변수 타입으로 활용
        {
            machine.TurnOn();
        }
        static void Main(string[] args)
        {
            Monitor m = new Monitor();
            Computer c = new Computer();

            PowerOn(m);
            PowerOn(c);
        }

    }

}