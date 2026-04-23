using System.Collections;   // 컬렉션을 담는 네임스페이스
namespace mySpace
{
    // 인덱서 : 객체를 배열처럼 사용할 수 있게 하는 기능
    // 어떻게 사용할 지는, 클래스 내부에서 정의
    // 인덱서 형식은 반환값의 형식임
    /* [인덱서 문법]
     class 클래스이름
        {
        --> 한정자 "인덱서형식" this[형식 index] --> 인덱서 형식은 반환값
            {
                get { // index 를 이용하여 내부데이터 반환 }
                set { // index 를 이용하여 내부데이터 저장 }
            }
        }
    */
    class Person
    {
        private string name = "지욱";
        private int age = 20;
        private string job = "학생";

        // 컬렉션 없이 일반 필드만 있어도 인덱서 가능
        public string this[int index]   // string을 반환함
        {
            get
            {
                if (index == 0) return name;
                if (index == 1) return age.ToString();
                if (index == 2) return job;
                return null;
            }
        }
    }
    class MyList
    {
        private int[] array;
        public MyList() { array = new int[3]; }
        public int this[int index]  // 인덱서
        {
            get { return array[index]; }
            set
            {
                // 크기 부족하면 늘리는 코드
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }
                array[index] = value;   // 실제 set
            }
        }
        public int Length { get { return array.Length; } }

        static void Main(string[] args)
        {
            MyList list = new MyList();
            // list객체의 멤버를, 인덱스를 통해 입력
            // 초기값이 3이라, Resize가 4,5로 두번 됨
            for(int i = 0; i < 5; i++) { list[i] = i; }

            // 마찬가지로, 인덱스를 통해 접근
            // 인덱서 형식이 int이므로, 반환값도 int
            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
        }
    }
}