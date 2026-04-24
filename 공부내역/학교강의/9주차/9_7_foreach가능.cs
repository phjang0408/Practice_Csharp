namespace mySpace
{
    class MyList
    {
        // IEnumerator = 반복자, "현재 어디까지 순회했는지 기억하는 객체"
        // IEnumerable = GetEnumerator()가 정의됨
        // GetEnumerator = IEnumerable에서, IEnumerator를 반환하는 함수
        int[] numbers= { 1, 2, 3, 4 };
        
        // GetEnumerator가 IEnumerator를 만든다.
        // 이 메서드는 foreach가 자동으로 호출한다.

        // yield 키워드는, return 앞에 붙어, 함수를 종료하지 않고, IEnumerator객체를 보내는 키워드다.
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];    // IEnumerator.Current = numbers[0] 로 저장
            yield return numbers[0];    // 이걸 foreach가 Current를 읽어감
            yield return numbers[1];
            yield return numbers[2];

            yield break;             // GetEnumerator() 종료
            yield return numbers[3]; // 실행되지않음
        }
        static void Main(string[] args)
        {
            var list = new MyList();
            // foreach는 반복자를 활용한다.
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}