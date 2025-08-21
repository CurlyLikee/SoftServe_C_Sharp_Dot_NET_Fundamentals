using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Fruits_Finaly
{
    [Serializable]
    [XmlInclude(typeof(Cytrus))] //для xml
    [DataContract]
    [KnownType(typeof(Cytrus))]  //для json
    public class Fruit : IComparable<Fruit>
    {
        public string path = @"...\Lecture_13(Practical)\Fruits.txt";
        private string name;
        private string color;
        [XmlElement] //для xml
        [DataMember] //для json
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [XmlElement] //для xml
        [DataMember] //для json
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Fruit()
        {
            name = "No name";
            color = "No color";
        }
        public Fruit(string n, string c)
        {
            name = n;
            color = c;
        }
        public static Fruit Input()
        {
            Console.WriteLine("Please input fruit name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please input fruit color:");
            string color = Console.ReadLine();

            Fruit fruit = new Fruit(name, color);
            return fruit;

        }
        public virtual string Output()
        {
            return $"Your fruit {name}  have {color} color.";
        }
        public virtual void InputFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public virtual void OutputFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.WriteLine("Name= {0}\tColor= {1}\t", Name, Color);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))
                return base.ToString();
            return Name;
        }
        public int CompareTo(Fruit other)
        {
            return String.Compare(this.Name, other.Name);
        }
    }

}