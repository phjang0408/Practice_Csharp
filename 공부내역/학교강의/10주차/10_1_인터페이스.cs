namespace DrawPaper
{
    class Computer { }
    interface IMonitor{ void TurnOn();} // 메서드 시그니처만을 포함
    interface IKeyboard { void Puts(); } // 빈 인터페이스도 가능
    class Notebook : Computer, IMonitor, IKeyboard // 다중 상속 가능(클래스는 하나)
    {
        public void TurnOn() { }    // 자식에서 인터페이스 메서드 구현 시, public 필수
        void IKeyboard.Puts() { } 
        // public 없으려면, 인터페이스명으로 구현
        // 인터페이스 멤버에 종속한다는 의미
    }
    class Program
    {
        static void Main(string[] args)
        {

            Notebook notebook = new Notebook();
            notebook.TurnOn();

            // notebook.Puts(); -> 멤버로 호출 불가능
            IKeyboard keyboard = notebook as IKeyboard;
            keyboard.Puts();
        }
    }
}
