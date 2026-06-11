namespace MySpace
{
    class MainClass
    {
        delegate void ThereIsAFire(string location);
        static void Call119(string location)
        {
            Console.WriteLine("소방서죠? 불났어요! 주소는{0}", location);
        }
        static void ShotOut(string location)
        {
            Console.WriteLine("피하세요! {0}에불이났어요!", location);
        }
        static void Escape(string location)
        {
            Console.WriteLine("{0}에서나갑시다!", location);
        }
        static void Main(string[] args)
        {
            ThereIsAFire Fire = new ThereIsAFire(Call119);
            Fire += new ThereIsAFire(ShotOut);
            //Fire += new ThereIsAFire(Escape);
            Fire += Escape;

            Fire("우리집"); // 순서대로 Call119, ShotOut, Escape 메소드가 호출됨

            /* ThereIsAFire Fire = new ThereIsAFire(Call119)
                + new ThereIsAFire(ShotOut)
                + new ThereIsAFire(Escape);
                와
                ThereIsAFire Fire = (ThereIsAFire)Delegate.Combine(
                new ThereIsAFire(Call119),
                new ThereIsAFire(ShotOut),
                new ThereIsAFire(Escape));
                도 같음
                */
        }
    }
}