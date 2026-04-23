using System;
using System.Collections; // IEnumerator, IEnumerable 사용을 위해 필요

namespace mySpace
{
    // IEnumerable(열거 가능한), IEnumerator(열거자) 인터페이스 상속
    class MyList : IEnumerator, IEnumerable
    {
        private int[] array;
        int position = -1; // 현재 데이터의 위치를 가리키는 커서

        public MyList() { array = new int[3]; }

        // [인덱서] 객체를 배열처럼 list[i] 형태로 사용하게 해줌
        public int this[int index]
        {
            get { return array[index]; }
            set
            {
                // 배열 크기를 벗어날 경우 동적으로 확장
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }
                array[index] = value;
            }
        }

        // [IEnumerator] 현재 커서가 가리키는 요소 반환
        public object Current
        {
            get { return array[position]; }
        }

        // [IEnumerator] 커서를 다음으로 이동 (다음 요소가 있으면 true)
        public bool MoveNext()
        {
            if (position == array.Length - 1) // 끝에 도달하면
            {
                Reset(); // 커서 초기화
                return false;
            }
            position++;
            return (position < array.Length);
        }

        // [IEnumerator] 커서 위치를 처음(-1)으로 리셋
        public void Reset()
        {
            position = -1;
        }

        // [IEnumerable] foreach 문 실행 시 반복자(this)를 반환
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        static void Main(string[] args)
        {
            MyList list = new MyList();

            // 데이터 입력 (인덱서의 set 블록 작동)
            for (int i = 0; i < 5; i++)
                list[i] = i;

            // 데이터 출력 (foreach가 내부적으로 GetEnumerator, MoveNext, Current 호출)
            foreach (int e in list)
                Console.WriteLine(e);
        }
    }
}