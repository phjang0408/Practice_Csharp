namespace DrawPaper
{
    class Program
    {
        public int a;            // 어디서든
        private int b;           // 클래스 내부 -> 외부 호출X
        protected int c;         // 클래스 내부 + 자식 클래스 -> 외부 호출X
        internal int d;          // 같은 어셈블리(프로젝트)

        protected internal int e; // 같은 어셈블리(프로젝트) or 자식 클래스
        private protected int f;  // 같은 어셈블리(프로젝트) and 자식 클래스만

        // [IF] 다른 어셈블리 and 자식클래스 라면?
        // protected internal -> 가능!(자식을 or로 만족)
        // private protected -> 불가능!(다른 어셈블리를 and로 불만족)

        static void Main(string[] args)
        {
            /*
             어셈블리 = 빌드 결과물 하나 (EXE or DLL) = 프로젝트 하나
             exe = 실행파일, dll = 라이브러리

             어셈블리 (EXE/DLL)
            ├── 모듈 1 (file1.netmodule)
            ├── 모듈 2 (file2.netmodule)
            └── 모듈 3 (file3.netmodule) 

            모듈 : 어셈블리를 구성하는 파일, .cs를 여러개 빌드하면 [모듈]이 된다.

            => 단일 프로젝트에서는, internal, protected internal, private protected
               모두 같은 'public'의 의미로 사용 가능하다.
            => EXE와 DLL은 서로 다른 어셈블리이므로 internal은 접근 X.
         */
        }
    }
}
