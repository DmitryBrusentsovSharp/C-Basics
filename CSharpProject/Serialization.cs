using System;
using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace CSharpProject
{
    public class Serialization
    {
        static void Main(string[] args) 
        {
            Animal cat = new Animal(2, "Tom");
            Animal dog = new Animal(5, "Charley");
            Animal[] arr = { cat, dog };

            XmlSerializer xml = new XmlSerializer(typeof(Animal[]));

/*            using (FileStream fs = new FileStream("animals.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, arr);
                Console.WriteLine("Object was serialized");
            }*/

            using (FileStream fs = new FileStream("animals.xml", FileMode.OpenOrCreate))
            {
                Animal[] newAnimals = (Animal[]) xml.Deserialize(fs);

                Console.WriteLine("Object was deserialized");

                foreach (Animal animal in newAnimals)
                {

                    Console.WriteLine($"Name: {animal.name}, Age: {animal.age}");
                }
            }

            Console.ReadKey();
        }
    }
}
