namespace MySpace
{
    class MainClass
    {
        static void CopyArray<T>(T[] source, T[] target) where T : struct //T는 값형식으로 제약
        {
            for(int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            foreach (int element in target)
                Console.WriteLine(element);

            
            string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
            string[] target2 = new string[source2.Length];

            // string은 참조형식으로 에러 발생!
            CopyArray<string>(source2, target2);
        }
    }
    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }
        public void CopyArray<T>(T[] Source) where T : U // T는 상위형식 매개변수 U를 상속받도록 강제
        {
            Source.CopyTo(Array, 0); // 원본배열.CopyTo(대상배열, 복사시작인덱스)
        }
    }
}
