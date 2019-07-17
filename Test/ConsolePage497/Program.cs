using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsolePage497 {
    class Program {
        static void Main(string[] args) {
            Card ThreeOfClubs = new Card(Suits.Clubs, Values.Three);
            Card SixOfHearts = new Card(Suits.Hearts, Values.Six);

            using (Stream output = File.Create("three-c.dat")) {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, ThreeOfClubs);
            }
            using (Stream output = File.Create("six-h.dat")) {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, SixOfHearts);
            }
            byte[] firstFile = File.ReadAllBytes("three-c.dat");
            byte[] secondFile = File.ReadAllBytes("six-h.dat");
            for (int i = 0; i < firstFile.Length; i++) {
                if (firstFile[i] != secondFile[i])
                    Console.WriteLine("Byte #{0}: {1} versus {2}", i, firstFile[i], secondFile[i]);
            }
            firstFile[267] = (byte)Suits.Spades;
            firstFile[316] = (byte)Values.King;
            File.Delete("king-s.dat");
            File.WriteAllBytes("king-s.dat", firstFile);

            Card KingOfSpades;
            using(Stream input = File.OpenRead("king-s.dat")) {
                BinaryFormatter bf = new BinaryFormatter();
                KingOfSpades = (Card)bf.Deserialize(input);
            }
            Console.WriteLine(KingOfSpades.Name);

            Console.ReadKey();
        }
    }
}
