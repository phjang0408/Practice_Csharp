namespace MySpace
{
    class PrimeCallbackArg : EventArgs
    {// 이벤트에 속한 값을 담는, EventArgs를 클래스를 정의
        public int Prime;
        public PrimeCallbackArg(int prime)
        {
            this.Prime = prime;
        }
    }
    class PrimeGenerator
    {
        public event EventHandler PrimeGenerated;
        public void Run(int limit)
        {
            for(int i = 2; i<=limit; i++)
            {   // 소수의 경우, 이벤트 발생
                if (IsPrime(i) == true && PrimeGenerated != null)
                    PrimeGenerated(this, new PrimeCallbackArg(i));
            }
        }
        private bool IsPrime(int candidate)
        {// 매개변수로 입력받은 정수 candidate이 소수인지판별
            if ((candidate & 1) == 0)
                return candidate == 2;
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0) return false;
            }
            return candidate != 1;
        }
    }
    class MainApp
    {
        static void PrintPrime(object sender, EventArgs arg)
        {// 이벤트 처리 메소드 1
            Console.Write((arg as PrimeCallbackArg).Prime + ", ");
        }
        static int Sum;
        static void SumPrime(object sender, EventArgs arg)
        {// 이벤트 처리 메소드 
            Sum += (arg as PrimeCallbackArg).Prime;
        }
        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();
            gen.PrimeGenerated += PrintPrime;
            gen.PrimeGenerated += SumPrime;

            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(Sum);

            gen.PrimeGenerated -= SumPrime;
            gen.Run(15);
        }
    }
}