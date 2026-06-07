using System.Runtime.Serialization.Formatters.Binary;
namespace MySpace
{
    class NameCard
    {
        public string Name;
        [NonSerialized]
        public string Phone;
        public int Age;
    }
    class MyClass
    {
        static void Main(string[] args)
        {
            using (Stream ws = new FileStream("a.dat", FileMode.Create))
            {
                BinaryFormatter serializer = new BinaryFormatter();

                NameCard nc = new NameCard();
                nc.Name = "홍길동";
                nc.Phone = "010-1234-5678";
                nc.Age = 33;

                serializer.Serialize(ws, nc);
            }

            using Stream rs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            NameCard nc2;
            nc2 = (NameCard)deserializer.Deserialize(rs);
            Console.WriteLine($"Name:  {nc2.Name}");
            Console.WriteLine($"Phone:  {nc2.Phone}");
            Console.WriteLine($"Age:  {nc2.Age}");
        /* [출력결과]
        Name: 홍길동
        Phone:
        Age: 33
        */
        }
    }
}
