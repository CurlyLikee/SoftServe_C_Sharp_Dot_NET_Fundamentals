using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Fruits_Finaly
{
    [Serializable]
    [DataContract]
    public class Cytrus : Fruit
    {
        double count_vytamin_C;
        [XmlElement] //для xml
        [DataMember] //для json
        public double Count_Vytamin_C
        {
            get { return count_vytamin_C; }
            set { count_vytamin_C = value; }
        }
        public Cytrus() { }
        public Cytrus(string name, string color, double count_vytamin_C) : base(name, color)
        {
            this.count_vytamin_C = count_vytamin_C;
        }
        public new static Cytrus Input()
        {
            Console.WriteLine("Enter name of cytrus: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter color of cytrus: ");
            string color = Console.ReadLine();
            Console.WriteLine("Enter count of vytamin C: ");
            double count_Vytamin_C = Convert.ToDouble(Console.ReadLine());
            Cytrus cytrus = new Cytrus(name, color, count_Vytamin_C);
            return cytrus;

        }
        public override string Output()
        {
            return $"Name= {Name}\tColor= {Color}\tCount of vytamin C= {count_vytamin_C}";
        }
        public override void InputFile()
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
        public override void OutputFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine("Name= {0}\tColor= {1}\tCount of vytamin C= {2}", Name, Color, Count_Vytamin_C);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}