using System.Runtime.Serialization.Formatters.Binary;
namespace MySpace
{
    [Serializable]
    class NameCard
    {
        public NameCard(string Name, string Phone, int Age)
        {
            this.Name = Name; this.Phone = Phone; this.Age = Age;
        }
        public string Name;
        public string Phone;
        public int Age;
    }
    class MyClass
    {
        static void Main(string[] args)
        {
            // C#의 기본 컬렉션(List, Dictionary, Stack, Queue 등)은
            // 내부적으로 [Serializable] 특성을 가지고 있어 직렬화가 가능하다.
            using (Stream ws = new FileStream("a.dat", FileMode.Create))
            {
                BinaryFormatter serializer = new BinaryFormatter();

                List<NameCard> list = new List<NameCard>();
                list.Add(new NameCard("홍길동", "010-123-4567", 33));
                list.Add(new NameCard("손오공", "010-123-1111", 22));
                list.Add(new NameCard("사오정", "010-123-2222", 26));

                serializer.Serialize(ws, list);
            }

            using Stream rs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            List<NameCard> list2;
            list2 = (List<NameCard>)deserializer.Deserialize(rs);

            foreach(NameCard nc in list2)
                Console.WriteLine($"Name:  {nc.Name}, Phone:  {nc.Phone}, Age:  {nc.Age}");
        }
    }
}
