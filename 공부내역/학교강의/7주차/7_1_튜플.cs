using System;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 항상 var 사용 : 컴파일러가 보고 직접 결정
            // 1. 명명되지 않은 튜플 : 필드의 이름을 지정하지 않음
            // -> 기본적으로 튜플이름.Item1,2,3으로 접근
            var tuple = (123, 789); 
            Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");

            // 2. 명명된 튜플 : "필드명 : "으로 선언
            var tuple2 = (Name: "지욱", Age: 17);
            Console.WriteLine($"{tuple2.Name} {tuple2.Age}");
            // 반대 형태로 분해도 가능
            // 분해는 이름 마음대로, 개수만 맞추면 됨
            var (name, _) = tuple2; // "_"는 특정 필드를 무시한다는 의미, 공간은 있지만, 빈 값으로 둠
            var (name2, age2) = ("강표", 49);

            // 3. 두 튜플 사이의 할당 : [필드수]와 [형식], [순서]만 같으면 가능 -> 이름은 달라도 됨
            var unnamed = ("슈퍼맨", 9999); // (string, int)
            var named = (Name: "홍길동", Age: 17); // (string, int)            
                                                
            named = unnamed; // 명명된튜플= 명명되지않은튜플
            Console.WriteLine($"{named.Name}, {named.Age}"); // 출력결과: 슈퍼맨, 9999
            named = ("원더우먼", 10000);
            // 명명되지않은튜플= 명명된튜플
            unnamed = named;
            Console.WriteLine($"{unnamed.Item1}, {unnamed.Item2}"); // 출력결과: 원더우먼, 10000
        }

    }
}