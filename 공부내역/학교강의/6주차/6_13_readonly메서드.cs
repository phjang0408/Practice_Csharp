struct ACSetting
{
    public double currentInCelsius; // 현재온도
    public double target; // 희망온도
    // readonly 메서드는 구조체의 멤버를 변경할 수 없음
    // class는 그런 형태가 없음 
    public readonly double GetFahrenheit()
    {
        target = currentInCelsius * 1.8 + 32; // 컴파일에러
        return target;
    }
}