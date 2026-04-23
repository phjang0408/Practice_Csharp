using System;

namespace InterfaceExample
{
    // 1. 인터페이스 선언: interface 키워드 사용
    interface IPhone
    {
        // 메소드, 프로퍼티만 포함 (구현부 없음, 접근 제한자 없음)
        string Model { get; set; }
        void Call(string number);
    }

    // 2. 파생 클래스: 인터페이스의 모든 멤버를 public으로 구현해야 함
    class Galaxy : IPhone
    {
        public string Model { get; set; } // 프로퍼티 구현

        public void Call(string number)   // 메소드 구현
        {
            Console.WriteLine($"{Model}가 {number}로 전화를 겁니다.");
        }

        public void SamsungPay() // 클래스만의 고유 메소드
        {
            Console.WriteLine("삼성페이를 실행합니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 3. 인터페이스는 인스턴스를 만들 수 없음 (오류 발생)
            // IPhone phone = new IPhone(); 

            // 4. 인터페이스 참조는 가능 (다형성)
            // 참조 변수에 파생 클래스 객체의 위치를 저장
            IPhone myPhone = new Galaxy(); 
            myPhone.Model = "S26";
            
            // 인터페이스에 정의된 기능 사용
            myPhone.Call("010-1234-5678");

            // 주의: 인터페이스 참조 변수로는 클래스 전용 메소드(SamsungPay)에 접근 불가
            // ((Galaxy)myPhone).SamsungPay(); // 형변환 시에는 가능
        }
    }
}