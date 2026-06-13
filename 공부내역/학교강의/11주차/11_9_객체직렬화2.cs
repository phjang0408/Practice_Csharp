namespace MySpace
{
    [Serializable]
    class MyClass
    {
        public int Field1;
        public int Field2;

        [NonSerialized]   // 직렬화에서 제외할 '필드'임을 명시하는 특성(Attribute)
        public int Field3;  // 1. 특성 바로 아래필드만 적용
        public int Field4;  

        [NonSerialized]     // 2. [NonSerialized]는 필드에만, 클래스 자체에는 불가능
        public IDontWantSerialize Field5;  // 직렬화에서 제외할 클래스 타입 필드
    }   // Field 1,2,4만 직렬화!
    /* 특히 Nonserialized 태그가 붙은 필드는, 역질려화 해보면 null로 저장되어있음.
        
        또한, 2번의 예시를 들면,
            // 1. [Serializable]이 없어서 직렬화가 불가능한 클래스 Monster
            class Monster 
            {
                public int hp;
            }

            [Serializable]
            class MyClass
            {
                public int Field1;
                
                // 2. 직렬화 대상인데 속을 파보니 직렬화 안 되는 Monster가 들어있음
                // ! -> 에러 발생!!
                public Monster Field5; 
            }
    */
}
