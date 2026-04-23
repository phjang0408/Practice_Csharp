
using System.Collections;   // IComparer가 정의된 곳
namespace MySpace
{
    class IntegerCompare : IComparer
    {// IComparer 인터페이스의 Compare 메서드를 구현
     // 이 메서드는 Array.Sort 메서드 내에서 콜백으로 호출됨
        public int Compare(object x, object y)
        {
            int xValue = (int)x;
            int yValue = (int)y;

            // return y-x 로도 가능

            if (xValue > yValue) return -1; // 기존과 반대, x가 크면 음수
            else if (xValue == yValue) return 0;
            return 1;   // y가 크면 양수
        }
    }
    class MYClass
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            Array.Sort(intArray, new IntegerCompare());
            foreach(int item in intArray)
            {
                Console.WriteLine(item + ", ");
            }
        }
    }
}