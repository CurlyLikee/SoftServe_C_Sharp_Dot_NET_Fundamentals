using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Fruits_Finaly
{
    public static class FruitSerializer
    {
        public static void SerializeToXML(List<Fruit> fruits, string filePath)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Fruit>));
                using Stream stream = new FileStream(filePath, FileMode.Create);
                xml.Serialize(stream, fruits);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during XML serialization: {ex.Message}");
            }
        }

        public static List<Fruit> DeserializeFromXML(string filePath)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Fruit>));
                using Stream stream = new FileStream(filePath, FileMode.Open);
                return (List<Fruit>)xml.Deserialize(stream);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during XML deserialization: {ex.Message}");
                return new List<Fruit>();
            }
        }

        public static void SerializeToJSON(List<Fruit> fruits, string filePath)
        {
            try
            {
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Fruit>));
                using FileStream stream = new FileStream(filePath, FileMode.Create);
                json.WriteObject(stream, fruits);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during JSON serialization: {ex.Message}");
            }
        }

        public static List<Fruit> DeserializeFromJSON(string filePath)
        {
            try
            {
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Fruit>));
                using FileStream stream = new FileStream(filePath, FileMode.Open);
                return (List<Fruit>)json.ReadObject(stream);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during JSON deserialization: {ex.Message}");
                return new List<Fruit>();
            }
        }
    }

}