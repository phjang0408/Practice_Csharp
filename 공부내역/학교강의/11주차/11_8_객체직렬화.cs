using System.Runtime.Serialization.Formatters.Binary;
namespace MySpace
{
    /* 
        BinaryWriter, BinaryReader가 데이터를 알아서 바이트로 바꿔줬지만,
        Write와 Read의 순서를 꼭 지켜주어야 했다.

        이를 해결하기 위해, 객체 자체를 통채로 저장하는 방법이 바로 [직렬화]이다.
        덕분에, 필드값을 일일히 Write할 필요도, 순서를 기억할 필요도 없다.

        1. [Serialized], [NonSerialized] 특성
        2. BinaryFormatter 클래스 : 객체 단위로 직렬화, 역직렬화하는 클래스
           - Serialize(Stream, Object) : 객체를 직렬화하여 저장하는 메서드
           - Deserialize(Stream) : 직렬화된 데이터를 역직렬화하여 객체로 반환하는 메서드
        => BinaryFormatter와 BinaryReader, BinaryWriter를 헷갈리지 말자!
    */
    [Serializable]   // 직렬화 가능한 클래스임을 명시하는 특성(Attribute)
    class MyClass
    {
        // 1. 직렬화하여 저장
        Stream ws = new FileStream("a.dat",FileMode.Create);
        BinaryFormatter serializer = new BinaryFormatter(); // 객체 상태 포장해주는 BinaryFormatter

        MyClass obj = new MyClass();    // obj라는 객체를 직렬화할거임.
        serializer.Serialize(ws,obj);  // 직렬화

        ws.Close();

        // 2. 역직렬화하여 읽기
        Stream rs = new FileStream("a.dat", FileMode.Open);
        BinaryFormatter deserializer = new BinaryFormatter();

        MyClass obj2 = (MyClass)deserializer.Deserialize(rs);  // 역직렬화,
        // Deserialize는 Object 타입으로 반환하기 때문에, MyClass로 형변환 필요

        rs.Close();
    }
}
